<template>
  <v-data-table density="comfortable" class="global_table" :headers="headers" :items="items" :search="search"
    items-per-page="25" :sort-by="[{ key: 'name', order: 'asc' }]" hover>
    <template v-slot:item.name="{ item }">
      <span class="title">{{ item.name }}</span>
      <br />
      <span class="description">{{ item.desc }}</span>
    </template>
  </v-data-table>
</template>

<script>
import wiki from '../assets/data/wiki.json'

export default {
  name: "WikiFactionTable",
  mounted() {
    this.items = wiki['Factions']
  },
  props: {
    search: String,
  },
  data() {
    return {
      items: [],
      headers: [
        { key: 'name', title: 'Title & Description' },
        { key: 'obtainable', title: 'Obtainable', width: '50px' },
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
