<template>
  <v-data-table density="comfortable" class="global_table" :headers="headers" :items="items" :search="search"
    items-per-page="25" :sort-by="[{ key: 'name', order: 'asc' }]" hover show-expand>
    <template v-slot:item.range="{ item }">
      {{ item.levelMin }} - {{ item.levelMax }}
    </template>

    <template v-slot:expanded-row="{ columns, item }">
      <tr>
        <td :colspan="columns.length">
          <div v-if="item.chain">
            <p>Chain</p>
            <p class="quest-info">{{ item.chain }}</p>
          </div>

          <div>
            <p>Description</p>
            <p class="quest-info">{{ item.longDesc }}</p>
          </div>

          <div v-if="item.objectives && item.objectives.length > 0">
            <p>Objectives</p>
            <p class="quest-info" v-for="obj in item.objectives" v-bind:key="obj.target">
              <template v-if="obj.type == 2">
                <inventory-item-tool-tip :id="obj.target" :text="obj.objective"></inventory-item-tool-tip>
              </template>
              <template v-else>
                {{ obj.objective }}
              </template>
            </p>
          </div>

          <div>
            <p>Rewards</p>
            <p class="quest-info" v-if="item.exp">{{ item.exp }} experience</p>
            <p class="quest-info" v-if="item.money">{{ item.money }} coins</p>
            <p class="quest-info" v-for="rep in item.reputation" v-bind:key="rep.id">
              {{ rep.value }} rep with {{ rep.faction }}
            </p>
            <div v-if="item.rewards && item.rewards.length > 0">
              <p class="quest-info">Items</p>
              <p class="item-info" v-for="rewItem in item.rewards" v-bind:key="rewItem.itemID">
                <inventory-item-tool-tip :id="rewItem.itemID"></inventory-item-tool-tip> x {{ rewItem.quantity }} {{ `${rewItem.needToChoose ? '&nbsp;(choice)' : ''}` }}
              </p>
            </div>
          </div>
        </td>
      </tr>
    </template>
  </v-data-table>
</template>

<script>
import wiki from '../assets/data/wiki.json'
import InventoryItemToolTip from '@/components/InventoryItemToolTip.vue'

export default {
  name: "WikiQuestTable",
  components: {
    InventoryItemToolTip,
  },
  mounted() {
    const zones = wiki['Zones']
    this.items = wiki['Quests'].map(item => {
      const zone = zones.find(o => o.id == item.zoneID)
      item.zoneName = (zone == null) ? '???' : zone.name
      item.range = item.levelMin
      return item
    })
  },
  props: {
    search: String,
  },
  data() {
    return {
      items: [],
      headers: [
        { key: 'range', title: 'Level Range', width: '140px' },
        { key: 'name', title: 'Title' },
        { key: 'zoneName', title: 'Zone' },
        { key: 'startsAt', title: 'Starts At' },
        { key: 'endsAt', title: 'Ends At' },
        { key: 'dailyQuest', title: 'Daily Quest', width: '50px' },
        { title: '', key: 'data-table-expand' },
      ],
    }
  },
}
</script>

<style scoped>
.quest-info {
  font-size: 0.9em;
  font-weight: 100;
  padding-left: 8px;
  width: 80%;
}

.item-info {
  font-size: 0.9em;
  font-weight: 100;
  padding-left: 16px;
}
</style>
