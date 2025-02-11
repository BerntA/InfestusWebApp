<template>
  <v-container fluid style="padding: 0;">
    <div id="background">
    </div>

    <div id="nav_global" style="border-bottom: none;position: fixed;">
      <v-row>
        <v-col cols="auto">
          <router-link to="/"><v-icon>mdi-chevron-left</v-icon><img src="../assets/images/icon.png" width="30" height="30" class="nav_global_icon"></router-link>
        </v-col>
        <v-col cols="1"></v-col>
        <v-col style="margin:auto">
          <v-text-field
            v-model="search"
            label="Search"
            density="compact"
            prepend-inner-icon="mdi-magnify"
            variant="outlined"
            hide-details
            single-line
          ></v-text-field>
        </v-col>
        <v-col cols="1"></v-col>
      </v-row>
    </div>

    <div class="wiki-dark" id="base_content">
      <v-table id="table_section" density="compact" class="table_contents unselectable" :hover="true">
        <thead>
          <tr>
            <th class="text-left">
              <v-icon size="small">mdi-clipboard-text-outline</v-icon>&nbsp;Categories
            </th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="item in categories" :key="item.name">
            <td @click="selectCategory(item.name)" :class="`${(item.name == activeCategory) ? 'wiki-active' : ''}`">{{ item.name }}</td>
          </tr>
        </tbody>
      </v-table>
    </div>

    <div v-if="activeCategory != null" id="main_content">
      <h1 id="wiki_section">{{ activeCategory }}</h1>
      <wiki-item-table v-if="activeCategory == 'Items'" :search="search"></wiki-item-table>
      <wiki-spell-table v-else-if="activeCategory == 'Spells'" :search="search"></wiki-spell-table>
      <wiki-quest-table v-else-if="activeCategory == 'Quests'" :search="search"></wiki-quest-table>
      <wiki-npc-table v-else-if="activeCategory == 'NPCs'" :search="search"></wiki-npc-table>
      <wiki-faction-table v-else-if="activeCategory == 'Factions'" :search="search"></wiki-faction-table>
      <wiki-zone-table v-else-if="activeCategory == 'Zones'" :search="search"></wiki-zone-table>
    </div>
  </v-container>
</template>

<script>
import WikiItemTable from '@/components/WikiItemTable.vue'
import WikiSpellTable from '@/components/WikiSpellTable.vue'
import WikiQuestTable from '@/components/WikiQuestTable.vue'
import WikiNpcTable from '@/components/WikiNpcTable.vue'
import WikiFactionTable from '@/components/WikiFactionTable.vue'
import WikiZoneTable from '@/components/WikiZoneTable.vue'

export default {
  name: "WikiView",
  components: {
    WikiItemTable,
    WikiSpellTable,
    WikiQuestTable,
    WikiNpcTable,
    WikiFactionTable,
    WikiZoneTable,
  },
  mounted() {
    window.scrollTo(0, 0)
  },
  data() {
    return {
      search: '',
      activeCategory: 'Items',
      categories: [
        { name: 'Items' },
        { name: 'Spells' },
        { name: 'Quests' },
        { name: 'NPCs' },
        { name: 'Factions' },
        { name: 'Zones' },
      ]
    }
  },
  methods: {
    selectCategory(name) {
      if (name == this.activeCategory) {
        return
      }

      this.activeCategory = name
      this.search = ''
    }
  },
}
</script>

<style scoped>
h1, h2, h3, h4, h5, h6, p, span {
    color: white;
}

#base_content {
    top: 60px;
    left: 0px;
    position: fixed;
    height: 100%;
    overflow: hidden;
    padding: 10px;
    z-index: 0;
    width: 200px;
}

#base_content th {
    border-top: 0px;
}

#main_content {
    top: 70px;
    left: 215px;
    position: absolute;
    padding: 0px;
    margin: 0px;
}

#search_form {
    position: fixed;
    top: 0px;
    left: 50%;
    transform: translate(-50%, 25%);
    width: 610px;
}

#search_field {
    width: 500px;
    font-weight: bolder;
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif, serif;
}

#search_btn {
    width: 100px;
}

.table_contents {
    color: white;
}

.table_contents td, th {
    cursor: pointer;
}

.table_contents th {
    transition: color 0.25s;
}

#table_data th:hover {
    color: darkred;
}

#table_section {
  background-color: transparent;
}

.wiki-dark {
    background-color: rgba(35, 30, 37, 0.5);
    box-shadow: 0px 0px 15px black;
}

.wiki-active {
    background-color: rgba(145, 55, 35, 0.2) !important;
    box-shadow: 0px 0px 10px grey;
    text-shadow: 0px 0px 10px black;
}

.unselectable, #table_data th {
    -webkit-touch-callout: none;
    -webkit-user-select: none;
    -khtml-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
}

.v-table > .v-table__wrapper > table > tbody > tr > td {
  border-bottom: 1px solid white;
}

.v-table .v-table__wrapper > table > thead > tr > th {
  border-bottom: 1px solid white;
}

</style>
