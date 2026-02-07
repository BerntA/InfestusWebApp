<template>
  <v-container fluid style="padding: 0;">
    <div id="background">
    </div>

    <div id="nav_global">
      <router-link to="/" style="text-decoration: none;"><v-icon>mdi-chevron-left</v-icon><img src="../assets/images/icon.png" width="30" height="30"
          class="nav_global_icon"></router-link>
    </div>

    <div style="height: 60px;"></div>

    <div id="main_content">
      <h1>Database Snapshots</h1>
      <h4>You may apply any of these snapshots to your own database, this can be extra handy if you wish to host your
        own dedicated game server for Infestus.</h4>
      <h5>Snapshots are created every 2 weeks!</h5>
    </div>

    <v-table id="downloads" class="global_table" height="400px" density="compact" hover>
      <tbody>
        <tr v-for="file in files" :key="file">
          <td>
            <a :href="`/data/snapshots/${file}`" target="_blank" download>{{ file }}</a>
          </td>
        </tr>
      </tbody>
    </v-table>
  </v-container>
</template>

<script>
export default {
  name: "SnapshotsView",
  async mounted() {
    window.scrollTo(0, 0)
    await this.$http('/api/snapshot')
      .then(response => {
        this.files = response.data
      })
  },
  data() {
    return {
      files: [],
    }
  },
}
</script>

<style scoped>
h1,
h2,
h3,
h4,
h5,
h6,
p,
span {
  color: white;
}

a {
  color: white;
  text-decoration: none;
  transition: color 0.5s;
  font-style: oblique;
}

a:hover {
  color: red;
  text-decoration: none;
  transition: color 0.5s;
  font-style: oblique;
}

#main_content {
  top: 15px;
  left: 25px;
  position: relative;
  padding: 0px;
  margin: 0px;
  text-shadow: none;
  box-shadow: none;
}

#table_contents {
  color: white;
}

#table_contents td {
  cursor: pointer;
}

#downloads {
  position: relative;
  padding-left: 25px;
  padding-right: 25px;
  top: 25px;
  width: 100%;
}
</style>
