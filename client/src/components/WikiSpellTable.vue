<template>
  <v-data-table density="comfortable" class="global_table" :headers="headers" :items="items" :search="search"
    items-per-page="25" :sort-by="[{ key: 'name', order: 'asc' }]" hover>
    <template v-slot:item.icon="{ item }">
      <v-img :src="item.icon" width="32"></v-img>
    </template>

    <template v-slot:item.name="{ item }">
      <span class="title">{{ item.name }}</span>
      <br />
      <span class="description">{{ item.desc }}</span>
    </template>

    <template v-slot:item.damage="{ item }">
      {{ item.damageMin }} - {{ item.damageMax }}
    </template>

    <template v-slot:item.timeToCast="{ item }">
      {{ item.timeToCast }}s
    </template>

    <template v-slot:item.timeToCooldown="{ item }">
      {{ item.timeToCooldown }}s
    </template>
  </v-data-table>
</template>

<script>
import wiki from '../assets/data/wiki.json'

export default {
  name: "WikiSpellTable",
  mounted() {
    this.items = wiki['Spells']
  },
  props: {
    search: String,
  },
  data() {
    return {
      items: [],
      headers: [
        { key: 'icon', title: '', sortable: false, width: '40px' },
        { key: 'name', title: 'Title & Description' },
        { key: 'type', title: 'Type', width: '50px' },
        { key: 'damage', title: 'Damage/Healing', width: '200px', sortable: false },
        { key: 'drainValue', title: 'Focus Cost', width: '100px' },
        { key: 'timeToCast', title: 'Cast Time', width: '100px' },
        { key: 'timeToCooldown', title: 'Cooldown', width: '100px' },
        { key: 'effectiveRange', title: 'Range', width: '100px' },
      ],
    }
  },
}
</script>

<style scoped>
.title {
  font-weight: bold;
}

.description {
  font-weight: 200;
  font-size: 0.9em;
}
</style>
