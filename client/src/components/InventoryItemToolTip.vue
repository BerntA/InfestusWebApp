<template>
  <v-menu v-if="item != null" open-on-hover open-on-click :close-on-content-click="false">
    <template v-slot:activator="{ props }">
      <img v-if="icon" v-bind="props" :src="item.icon">
      <span v-else v-bind="props">{{ text ? text : item.name }}</span>
    </template>
    <v-card class="tooltip" style="min-width: 300px;">
      <v-card-title class="title">
        <template v-if="icon == false">
          <v-img style="display: inline-block;" :src="item.icon" :width="30"></v-img>&nbsp;
        </template>
        <span :class="`rarity-${item.rarity.toLowerCase()}`">{{ item.name }}</span>
      </v-card-title>
      <v-card-text>
        <table style="width: 100%;">
          <tbody>
            <tr>
              <td class="text-left">{{ item.itemInfo1 }}</td>
              <td class="text-right">{{ item.itemInfo2 }}</td>
            </tr>
            <tr v-if="item.damageMax > 0" class="stat-section">
              <td class="text-left">
                {{ item.damageMin }} - {{ item.damageMax }} Damage
              </td>
              <td class="text-right">
                Speed {{ item.attackSpeed.toFixed(2) }}
              </td>
            </tr>
            <tr v-else class="stat-section">
              <td colspan="2"></td>
            </tr>
            <template v-for="([index, [key, value]]) in Object.entries(Object.entries(baseStats))" v-bind:key="key">
              <tr v-if="item[key] != 0" :class="[{ 'stat-section': index == getLastValidIndex(baseStats) }]">
                <td class="text-left">{{ (item[key] > 0) ? '+' : '-' }} {{ Math.abs(item[key]) }} {{ value }}</td>
                <td class="text-right"></td>
              </tr>
            </template>
            <template v-for="([index, [key, value]]) in Object.entries(Object.entries(baseResistances))"
              v-bind:key="key">
              <tr v-if="item[key] != 0"
                :class="['resistance', { 'stat-section': index == getLastValidIndex(baseResistances) }]">
                <td class="text-left">{{ (item[key] > 0) ? '+' : '-' }} {{ Math.abs(item[key]) }} {{ value }}</td>
                <td class="text-right"></td>
              </tr>
            </template>
            <template v-for="([index, [key, value]]) in Object.entries(Object.entries(baseEquipStats))"
              v-bind:key="key">
              <tr v-if="item[key] != 0"
                :class="['equipstat', { 'stat-section': index == getLastValidIndex(baseEquipStats) }]">
                <td class="text-left">Equip: {{ (item[key] > 0) ? 'Increases' : 'Decreases' }} {{ value }} by {{
                  Math.abs(item[key]) }}</td>
                <td class="text-right"></td>
              </tr>
            </template>
            <tr v-if="item.level > 1" class="miscstat">
              <td class="text-left">Requires Level {{ item.level }}</td>
              <td class="text-right"></td>
            </tr>
            <tr v-if="item.sellPrice > 0" class="miscstat">
              <td class="text-left">Sells for {{ item.sellPrice }}<v-img style="display: inline-block;top: 5px;"
                  src="/images/wiki/coins.png" width="18"></v-img></td>
              <td class="text-right"></td>
            </tr>
            <tr v-if="item.canTrade == 'No'" class="dangerstat">
              <td class="text-left">Cannot be traded!</td>
              <td class="text-right"></td>
            </tr>
          </tbody>
        </table>

        <div v-if="item.desc" class="description">
          {{ item.desc }}
        </div>
      </v-card-text>
    </v-card>
  </v-menu>
</template>

<script>
import wiki from '../assets/data/wiki.json'

export default {
  name: "InventoryItemToolTip",
  props: {
    id: Number,
    text: {
      type: String,
      default: null,
    },
    icon: {
      type: Boolean,
      default: false,
    },
  },
  watch: {
    id: {
      immediate: true,
      handler(val) {
        this.item = wiki['Items'].find(o => o.id == val)
      },
    },
  },
  data() {
    return {
      item: null,
      baseStats: {
        'armor': 'Armor',
        'stamina': 'Stamina',
        'strength': 'Strength',
        'agility': 'Agility',
        'intellect': 'Intellect',
      },
      baseResistances: {
        'fireResistance': 'Fire Resistance',
        'waterResistance': 'Water Resistance',
        'shadowResistance': 'Shadow Resistance',
        'earthResistance': 'Earth Resistance',
        'windResistance': 'Wind Resistance',
      },
      baseEquipStats: {
        'meleeAttackPower': 'melee power',
        'rangedAttackPower': 'ranged power',
        'spellPower': 'spell power',
        'focusValue': 'focus',
      },
    }
  },
  methods: {
    getLastValidIndex(obj) {
      let lastIndex = 0
      for (const [index, [key,]] of Object.entries(Object.entries(obj))) {
        if (this.item[key] == 0) {
          continue
        }
        lastIndex = index
      }
      return lastIndex
    },
  },
}
</script>

<style scoped>
.tooltip {
  background-color: rgba(34, 24, 18, 1) !important;
}

.title {
  text-align: left;
}

.title span {
  top: -6px;
  position: relative;
}

.description {
  color: rgba(120, 112, 122, 1);
  padding-top: 10px;
}

.stat-section td {
  padding-bottom: 10px;
}

.resistance td {
  color: rgba(125, 125, 255, 1);
}

.equipstat td {
  color: rgba(25, 255, 25, 1);
}

.miscstat td {
  color: rgba(200, 200, 200, 1);
}

.dangerstat td {
  color: rgba(200, 25, 25, 1);
}

.rarity-junk {
  color: rgba(90, 92, 92, 1);
}

.rarity-common {
  color: rgba(14, 216, 55, 1);
}

.rarity-rare {
  color: rgba(25, 100, 230, 1);
}

.rarity-epic {
  color: rgba(149, 41, 222, 1);
}

.rarity-legendary {
  color: rgba(220, 141, 37, 1);
}
</style>
