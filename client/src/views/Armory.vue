<template>
  <v-container fluid style="padding: 0;">
    <div id="background">
    </div>

    <div id="nav_global">
      <v-row>
        <v-col cols="auto">
          <router-link to="/" style="text-decoration: none;"><v-icon>mdi-chevron-left</v-icon><img src="../assets/images/icon.png" width="30" height="30" class="nav_global_icon"></router-link>
        </v-col>
        <v-col style="margin:auto">
          <v-text-field
            v-model="search"
            label="Search Player"
            density="compact"
            prepend-inner-icon="mdi-magnify"
            variant="outlined"
            hide-details
            single-line
          ></v-text-field>
        </v-col>
        <v-col v-if="!isMobileView()" cols="auto" style="margin-right: 10px;">
          <span id="playerlist_chkonline" class="unselectable">
            <label><input v-model="displayOnlineOnly" type="checkbox"/>&nbsp;Only show online players</label>
          </span>
        </v-col>
        <v-col v-else cols="auto"></v-col>
      </v-row>
    </div>

    <v-data-table id="playerlist_table" :headers="headers" :items="players" :search="search" items-per-page="25" :sort-by="[{ key: 'level', order: 'desc' }]" hover @dblclick:row="openArmoryProfile">
    </v-data-table>
  </v-container>
</template>

<script>
export default {
  name: "ArmoryView",
  async mounted() {
    window.scrollTo(0, 0)
    await this.$http('/data/playerlist.json', {
      headers: {
        'Cache-Control': 'no-cache',
        'Pragma': 'no-cache',
        'Expires': '0',
      },
    })
      .then(response => {
        this.items = response.data
      })
  },
  data() {
    return {
      search: '',
      items: [],
      displayOnlineOnly: false,
      headers: [
        { key: 'name', title: 'Name' },
        { key: 'level', title: 'Level' },
        { key: 'zone', title: 'Zone' },
      ],
    }
  },
  computed: {
    players() {
      return this.displayOnlineOnly ? this.items.filter(o => o.online == 1) : this.items
    },
  },
  methods: {
    openArmoryProfile(event, obj) {
      window.open(`/armory/player/${obj.item.name}`)
    },
    isMobileView() {
      return (screen.width < 600)
    },
  },
}
</script>

<style>
.v-table .v-table__wrapper > table > tbody > tr:not(:last-child) > td {
    border-bottom: none !important;
}
</style>
