<template>
  <v-data-table density="comfortable" class="global_table" :headers="headers" :items="items" :search="search"
    items-per-page="25" :sort-by="[{ key: 'name', order: 'asc' }]" hover show-expand>
    <template v-slot:item.level="{ item }">
      {{ `${item.boss ? '???' : item.level}` }}
    </template>

    <template v-slot:expanded-row="{ columns, item }">
      <tr>
        <td :colspan="columns.length">
          <div v-if="item.desc">
            <p>Description</p>
            <p class="npc-info">{{ item.desc }}</p>
          </div>

          <div v-if="item.quests && item.quests.length > 0">
            <p>Quests</p>
            <p class="npc-info" v-for="quest in item.quests.filter(o => isValidQuest(item, o.questID))" v-bind:key="quest.questID">
              {{ quest.questName }}
            </p>
          </div>

          <div v-if="item.exp > 0 || item.moneyMin > 0 || item.reputation.some(o => o.ally == 'No')">
            <p>Rewards</p>
            <p class="npc-info" v-if="item.exp">{{ item.exp }} experience</p>
            <p class="npc-info" v-if="item.moneyMin">{{ item.moneyMin }} gold</p>
            <p class="npc-info" v-for="rep in item.reputation.filter(o => o.ally == 'No')" v-bind:key="rep.id">
              {{ rep.value }} rep with {{ rep.faction }}
            </p>
          </div>

          <div v-if="item.loots && item.loots.length > 0">
            <p>Loots</p>
            <p class="npc-info" v-for="inv in item.loots" v-bind:key="inv.itemID">
              {{ inv.percentage }}% chance to drop <inventory-item-tool-tip :id="inv.itemID"></inventory-item-tool-tip> x {{ inv.quantity }}
            </p>
          </div>

          <div v-if="item.inventory && item.inventory.length > 0">
            <p>Sells</p>
            <p class="npc-info" v-for="inv in item.inventory" v-bind:key="inv.itemID">
              <inventory-item-tool-tip :id="inv.itemID"></inventory-item-tool-tip> x {{ inv.quantity }},
              <span>
                {{ inv.sellPrice }}<v-img style="display: inline-block;top: 5px;" src="/images/wiki/coins.png" width="18"></v-img>
              </span>
            </p>
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
  name: "WikiNpcTable",
  components: {
    InventoryItemToolTip,
  },
  mounted() {
    const zones = wiki['Zones']
    this.items = wiki['NPCs'].map(item => {
      const zone = zones.find(o => o.id == item.zoneID)
      item.zoneName = (zone == null) ? '???' : zone.name
      return item
    })
    this.quests = wiki['Quests']
  },
  props: {
    search: String,
  },
  data() {
    return {
      items: [],
      quests: [],
      headers: [
        { key: 'name', title: 'Title' },
        { key: 'level', title: 'Level', width: '40px' },
        { key: 'health', title: 'Health', width: '100px' },
        { key: 'drainer', title: 'Focus', width: '100px' },
        { key: 'zoneName', title: 'Zone' },
        { title: '', key: 'data-table-expand' },
      ],
    }
  },
  methods: {
    isValidQuest(item, id) {
      const quest = this.quests.find(o => o.id == id)
      if (quest == null) return false
      return (quest.startsAt == item.name)
    },
  },
}
</script>

<style scoped>
.npc-info {
  font-size: 0.9em;
  font-weight: 100;
  padding-left: 8px;
  width: 80%;
}
</style>
