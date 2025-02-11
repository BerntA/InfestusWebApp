<template>
  <v-data-table density="comfortable" class="global_table" :headers="headers" :items="items" :search="search"
    items-per-page="25" :sort-by="[{ key: 'name', order: 'asc' }]" hover>
    <template v-slot:item.icon="{ item }">
      <v-img :src="item.icon" width="32"></v-img>
    </template>

    <template v-slot:item.sellPrice="{ item }">
      <span>{{ item.sellPrice }} <v-img style="display: inline-block;top: 5px;" src="/images/wiki/coins.png"
          width="18"></v-img></span>
    </template>
  </v-data-table>
</template>

<script>
import wiki from '../assets/data/wiki.json'

export default {
  name: "WikiItemTable",
  mounted() {
    this.items = wiki['Items'].map(item => {
      item.itemInfo = `${item.itemInfo1} ${item.itemInfo2}`
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
        { key: 'icon', title: '', sortable: false, width: '40px' },
        { key: 'name', title: 'Title' },
        { key: 'itemInfo', title: 'Type', width: '250px' },
        { key: 'rarity', title: 'Rarity', width: '115px' },
        { key: 'level', title: 'Level', width: '50px' },
        { key: 'itemLevel', title: 'Item Level', width: '150px' },
        { key: 'sellPrice', title: 'Sell Price', width: '150px' },
        { key: 'canTrade', title: 'Tradeable' },
      ],
    }
  },
}
</script>
