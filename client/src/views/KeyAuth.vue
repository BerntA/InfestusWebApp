<template>
  <v-container fluid style="padding: 0;">
    <div id="background">
    </div>

    <div id="nav_global">
      <router-link to="/"><v-icon>mdi-chevron-left</v-icon><img src="../assets/images/icon.png" width="30" height="30"
          class="nav_global_icon"></router-link>
    </div>

    <div class="main-content">
      <template v-if="steamAuthServerError || steamAuthResponse">
        <h2 v-if="steamAuthServerError || steamAuthResponse.statusCode != 200">Unable to fetch Steam Key, did you meet
          all the requirements?</h2>
        <div v-else>
          <h2>Welcome to the Realm of Arngor, traveler!</h2>
          <h3>Steam Key: {{ steamAuthResponse.result }}, <a class="downloadlink"
              href="https://support.steampowered.com/kb_article.php?ref=5414-tfbn-1352" target="_blank">Activate Key on
              Steam!</a></h3>
          <br>
        </div>
      </template>
      <template v-else>
        <h2>You are about to sign-up for Infestus Closed Beta, please sign-in through Steam!</h2>
        <h3 v-if="keysAvailable >= 0">There are {{ keysAvailable }} key(s) left!</h3>
        <div id="steam-auth">
          <form action="https://steamcommunity.com/openid/login" method="get">
            <input type="hidden" readonly name="openid.identity"
              value="http://specs.openid.net/auth/2.0/identifier_select" />
            <input type="hidden" readonly name="openid.claimed_id"
              value="http://specs.openid.net/auth/2.0/identifier_select" />
            <input type="hidden" readonly name="openid.ns" value="http://specs.openid.net/auth/2.0" />
            <input type="hidden" readonly name="openid.mode" value="checkid_setup" />
            <input type="hidden" readonly name="openid.realm" :value="hostName" />
            <input type="hidden" readonly name="openid.return_to" :value="`${hostName}/keyauth`" />
            <Button type="submit" hidden ref="steamlogin"></Button>
          </form>
          <img src="../assets/images/steam_auth.png" @click="login">
        </div>
      </template>

      <template
        v-if="steamAuthResponse == null || steamAuthServerError || (steamAuthResponse && steamAuthResponse.statusCode != 200)">
        <h4>Requirements</h4>
        <ul class="list-improved">
          <li>Must have a configured community profile.</li>
        </ul>

        <h5>Disclaimer</h5>
        <span>You may only acquire one key for Infestus per SteamID.</span>
        <br><br>
      </template>

      <h4>Community & Support</h4>
      <iframe src="https://discordapp.com/widget?id=346722326815047680&theme=dark" width="350" height="500"
        allowtransparency="true" frameborder="0"></iframe>
    </div>
  </v-container>
</template>

<script>
export default {
  name: "KeyAuth",
  async mounted() {
    window.scrollTo(0, 0)
    this.hostName = window.location.origin

    if (window.location.search && window.location.search.length > 1) {
      await this.loginCallback(window.location.search)
    } else {
      await this.$http('/api/steam-auth/keys')
        .then(response => {
          this.keysAvailable = response.data
        })
    }
  },
  data() {
    return {
      hostName: '',
      keysAvailable: -1,
      steamAuthResponse: null,
      steamAuthServerError: false,
    }
  },
  methods: {
    login() { // attempt to login via Steam OpenId 2.0
      this.$refs.steamlogin.click()
    },
    async loginCallback(query) { // fetch userdata via back-end, OpenId query will be validated on the server
      this.steamAuthServerError = false
      await this.$http(`/api/steam-auth${query}`)
        .then(response => {
          this.steamAuthResponse = response.data
        })
        .catch(() => {
          this.steamAuthServerError = true
        })
    },
  },
}
</script>

<style scoped>
#steam-auth {
  padding: 5px;
  padding-bottom: 15px;
  cursor: pointer;
}

.list-improved {
  list-style-type: square;
  color: white;
  padding-left: 30px;
  padding-bottom: 10px;
}

.main-content {
  padding-top: 80px;
  padding-left: 15px;
  position: absolute;
  z-index: 0;
}

.main-content h1,
h2 {
  padding-left: 0px;
  padding-bottom: 4px;
  margin-left: 0px;
}
</style>
