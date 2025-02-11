<template>
  <v-data-table density="comfortable" class="global_table" :headers="headers" :items="items" :search="search"
    items-per-page="25" :sort-by="[{ key: 'name', order: 'asc' }]" hover>
    <template v-slot:item.name="{ item }">
      <span>{{ item.name }}</span>
      <br />
      <img :src="item.previewImg" :alt="item.name" width="60%">
    </template>
  </v-data-table>
</template>

<script>
import wiki from '../assets/data/wiki.json'

export default {
  name: "WikiZoneTable",
  mounted() {
    this.items = wiki['Zones']
  },
  props: {
    search: String,
  },
  data() {
    return {
      items: [],
      headers: [
        { key: 'name', title: 'Name' },
      ],
    }
  },
}
</script>
