<template>
  <div>
    <v-container fluid style="padding: 0;">
      <div id="background">
      </div>

      <div id="nav_global">
        <router-link to="/armory"><v-icon>mdi-chevron-left</v-icon><img src="../assets/images/icon.png" width="30"
            height="30" class="nav_global_icon"></router-link>
      </div>

      <div style="height: 60px;"></div>
    </v-container>
    <v-container class="mb-4 mt-4 content" v-if="data">
      <v-card id="profile" flat>
        <v-card-title>
          <a :href="`http://steamcommunity.com/profiles/${data.player.steamID}`" target="_blank">{{ data.player.name
            }}</a>, LvL {{ data.player.level }}
          <v-divider></v-divider>
        </v-card-title>
        <v-card-subtitle v-if="data.guild">
          <router-link :to="`/armory/guild/${data.guild.name}`">{{ data.guild.name }}</router-link>
        </v-card-subtitle>
        <v-card-text>
          <v-row>
            <v-col cols="auto">
              <table>
                <tbody>
                  <tr v-for="item of itemSectionLeft" v-bind:key="item.key">
                    <td>
                      <template v-if="data.player[item.key] > 0">
                        <inventory-item-tool-tip :id="data.player[item.key]" :icon="true"></inventory-item-tool-tip>
                      </template>
                      <img v-else class="inventoryItem" :src="item.icon">
                    </td>
                  </tr>
                </tbody>
              </table>
            </v-col>
            <v-col class="text-center">
              <v-container fluid>
                <v-row>
                  <v-col cols="auto">HEALTH</v-col>
                  <v-col>
                    <div class="health-bar">{{ data.player.healthMax }}</div>
                  </v-col>
                </v-row>
                <v-row>
                  <v-col cols="auto">FOCUS</v-col>
                  <v-col>
                    <div class="focus-bar">{{ data.player.drainerMax }}</div>
                  </v-col>
                </v-row>
                <v-row>
                  <v-col>
                    BASE STATS
                    <table style="width: 100%;">
                      <tbody>
                        <tr v-for="stat of baseStats" v-bind:key="stat.key">
                          <td class="text-left">{{ stat.statName }}</td>
                          <td class="text-right">{{ stat.value }}</td>
                        </tr>
                      </tbody>
                    </table>
                  </v-col>
                  <v-col>
                    RESISTANCES
                    <table style="width: 100%;">
                      <tbody>
                        <tr v-for="stat of resistanceStats" v-bind:key="stat.key">
                          <td class="text-left">{{ stat.statName }}</td>
                          <td class="text-right">{{ stat.value }}</td>
                        </tr>
                      </tbody>
                    </table>
                  </v-col>
                </v-row>
                <v-row v-if="data.reputation && data.reputation.length > 0">
                  <v-col>
                    REPUTATION
                    <table style="width: 100%;">
                      <tbody>
                        <tr v-for="rep of data.reputation" v-bind:key="rep.repID">
                          <td class="text-left">{{ rep.name }}</td>
                          <td class="text-right">{{ rep.value }}</td>
                        </tr>
                      </tbody>
                    </table>
                  </v-col>
                  <v-col></v-col>
                </v-row>
              </v-container>
            </v-col>
            <v-col cols="auto">
              <table style="margin-left: auto;">
                <tbody>
                  <tr v-for="item of itemSectionRight" v-bind:key="item.key">
                    <td>
                      <template v-if="data.player[item.key] > 0">
                        <inventory-item-tool-tip :id="data.player[item.key]" :icon="true"></inventory-item-tool-tip>
                      </template>
                      <img v-else class="inventoryItem" :src="item.icon">
                    </td>
                  </tr>
                </tbody>
              </table>
            </v-col>
          </v-row>
        </v-card-text>
      </v-card>
    </v-container>
  </div>
</template>

<script>
import wiki from '../assets/data/wiki.json'
import InventoryItemToolTip from '@/components/InventoryItemToolTip.vue'

export default {
  name: "ArmoryPlayerProfileView",
  components: {
    InventoryItemToolTip,
  },
  props: {
    id: String,
  },
  async mounted() {
    window.scrollTo(0, 0)
    this.itemWikiData = wiki['Items']
    this.factionWikiData = wiki['Factions']
    await this.fetchPlayerData(this.id)
  },
  data() {
    return {
      data: null,
      itemWikiData: null,
      factionWikiData: null,
      itemSectionLeft: [
        { icon: '/images/armory/head.png', key: 'head' },
        { icon: '/images/armory/cloak.png', key: 'cloak' },
        { icon: '/images/armory/chest.png', key: 'chest' },
        { icon: '/images/armory/gloves.png', key: 'gloves' },
        { icon: '/images/armory/legs.png', key: 'legs' },
        { icon: '/images/armory/boots.png', key: 'boots' },
      ],
      itemSectionRight: [
        { icon: '/images/armory/ring.png', key: 'ring' },
        { icon: '/images/armory/necklace.png', key: 'necklace' },
        { icon: '/images/armory/trinket.png', key: 'trinket' },
        { icon: '/images/armory/main.png', key: 'primaryWeapon' },
        { icon: '/images/armory/off.png', key: 'secondaryWeapon' },
        { icon: '/images/armory/ranged.png', key: 'miscWeapon' },
      ],
      itemKeys: [
        'head',
        'cloak',
        'chest',
        'gloves',
        'legs',
        'boots',
        'ring',
        'necklace',
        'trinket',
        'primaryWeapon',
        'secondaryWeapon',
        'miscWeapon',
      ],
      baseStats: [
        { statName: 'Armor', key: 'armor', attributeKey: null, value: 0 },
        { statName: 'Stamina', key: 'stamina', attributeKey: 'attribute1', value: 0 },
        { statName: 'Strength', key: 'strength', attributeKey: 'attribute2', value: 0 },
        { statName: 'Agility', key: 'agility', attributeKey: 'attribute3', value: 0 },
        { statName: 'Intellect', key: 'intellect', attributeKey: 'attribute4', value: 0 },
        { statName: 'Melee Power', key: 'meleeAttackPower', attributeKey: null, value: 0 },
        { statName: 'Ranged Power', key: 'rangedAttackPower', attributeKey: null, value: 0 },
        { statName: 'Spell Power', key: 'spellPower', attributeKey: null, value: 0 },
        { statName: 'Item Level', key: 'itemLevel', attributeKey: null, value: 0 },
      ],
      resistanceStats: [
        { statName: 'Fire Resistance', key: 'fireResistance', attributeKey: null, value: 0 },
        { statName: 'Water Resistance', key: 'waterResistance', attributeKey: null, value: 0 },
        { statName: 'Shadow Resistance', key: 'shadowResistance', attributeKey: null, value: 0 },
        { statName: 'Earth Resistance', key: 'earthResistance', attributeKey: null, value: 0 },
        { statName: 'Wind Resistance', key: 'windResistance', attributeKey: null, value: 0 },
      ],
    }
  },
  methods: {
    async fetchPlayerData(id) {
      if (id == null) {
        return
      }

      await this.$http(`/api/armory/player/${id}`)
        .then(response => {
          this.data = (response.status == 200) ? response.data : null
          if (response.status == 200) {
            document.title = `Infestus Armory - ${this.data.player.name}`
            this.calculatePlayerStats()
            this.enrichReputationData()
          } else {
            document.title = 'Infestus Armory - Failed to load/find character'
          }
        })
    },
    calculateStats(stats) {
      for (const stat of stats) {
        let value = 0

        if (stat.attributeKey) {
          value += this.data.player[stat.attributeKey]
        }

        for (const itemKey of this.itemKeys) {
          const itemID = this.data.player[itemKey]
          const item = this.itemWikiData.find(o => o.id == itemID)
          if (item == null) {
            continue
          }
          value += item[stat.key]
        }

        stat.value = value
      }
    },
    calculatePlayerStats() {
      this.calculateStats(this.baseStats)
      this.calculateStats(this.resistanceStats)
    },
    enrichReputationData() {
      if (this.data.reputation == null || this.data.reputation.length == 0) {
        return
      }

      this.data.reputation = this.data.reputation.map(o => {
        const faction = this.factionWikiData.find(x => x.id == o.repID)
        if (faction == null) {
          o.name = 'N/A'
          return o
        }

        o.name = faction.name
        return o
      })
    },
  },
}
</script>

<style>
.content {
  position: relative;
}

a {
  text-decoration: none;
  transition: color 0.5s;
}

a:hover {
  color: red;
  text-decoration: none;
  transition: color 0.5s;
}

#profile {
  background-color: transparent !important;
}

.inventoryItem {
  background-image: url('/images/armory/item.png');
}

.health-bar {
  background-color: rgb(90, 180, 0);
  border-radius: 5px;
  text-shadow: 0px 0px 2px black;
  box-shadow: 0px 0px 5px black;
}

.focus-bar {
  background-color: rgb(160, 125, 20);
  border-radius: 5px;
  text-shadow: 0px 0px 2px black;
  box-shadow: 0px 0px 5px black;
}
</style>
