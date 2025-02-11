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
          {{ data.guild.name }}
          <v-divider></v-divider>
        </v-card-title>
        <v-card-subtitle>
          Lead by {{ data.guild.leaderName }}
        </v-card-subtitle>
        <v-card-text>
          <v-table id="guildMemberList" height="400px" density="compact" hover>
            <thead>
              <tr>
                <th class="text-left">Name</th>
                <th class="text-left">Level</th>
                <th class="text-left">Rank</th>
                <th class="text-left">Zone</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="player in data.members" :key="player.name" @click="openArmoryProfile(player.name)">
                <td>{{ player.name }}</td>
                <td>{{ player.level }}</td>
                <td>{{ ranks[player.guildRank] }}</td>
                <td>{{ zones[player.zone] }}</td>
              </tr>
            </tbody>
          </v-table>
        </v-card-text>
      </v-card>
    </v-container>
  </div>
</template>

<script>
import wiki from '../assets/data/wiki.json'

export default {
  name: "ArmoryGuildProfileView",
  props: {
    id: String,
  },
  async mounted() {
    window.scrollTo(0, 0)

    wiki['Zones'].forEach(zone => {
      this.zones[zone.id] = zone.name
    });

    await this.fetchGuildData(this.id)
  },
  data() {
    return {
      data: null,
      zones: {},
      ranks: {
        0: 'Trial',
        1: 'Member',
        2: 'Officer',
        8: 'Leader',
      },
    }
  },
  methods: {
    async fetchGuildData(id) {
      if (id == null) {
        return
      }

      await this.$http(`/api/armory/guild/${id}`)
        .then(response => {
          this.data = (response.status == 200) ? response.data : null
          if (response.status == 200) {
            document.title = `Infestus Guild - ${this.data.guild.name}`
            this.data.guild.leaderName = this.data.members[0].name
          } else {
            document.title = 'Infestus Guild - Failed to load/find guild'
          }
        })
    },
    openArmoryProfile(name) {
      window.open(`/armory/player/${name}`)
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

#guildMemberList {
  background-color: transparent !important;
}

#guildMemberList td {
  cursor: pointer;
}

.v-table.v-table--fixed-header > .v-table__wrapper > table > thead > tr > th {
  background-color: transparent !important;
}
</style>
