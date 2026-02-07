<template>
  <v-container fluid style="padding: 0;" ref="refTopObject">
    <div id="background">
    </div>

    <div id="mid">
        <img src="../assets/images/logo.png" id="mid_logo">
        <img src="../assets/images/foreground.jpg" id="mid_poster">
        <div id="mid_text">
            <h1><router-link class="downloadlink" to="/keyauth">DOWNLOAD NOW</router-link></h1>
            <h4 class="downloadtease">The ultimate MMORPG experience for Half-Life 2!</h4>
        </div>
    </div>

    <div id="nav" class="bar" :class="navSticky ? 'bar nav_sticky' : 'bar'">
        <ul>
            <li class="navlist"><a @click="scrollToTop">Home</a></li>
            <li class="navlist"><a @click="scrollToAbout">About</a></li>
            <li class="navlist"><a @click="scrollToMedia">Media</a></li>
            <li class="navlist"><router-link to="/keyauth">Download</router-link></li>
            <li class="navlist"><a href="http://steamcommunity.com/app/656800/discussions/" target="_blank">Forum</a></li>
            <li class="navlist"><router-link to="/changelog">Changelog</router-link></li>
            <li class="navlist"><router-link to="/armory">Players</router-link></li>
            <li class="navlist"><router-link to="/wiki">Wiki</router-link></li>
        </ul>
        <div class="medialinks">
            <a href="https://trello.com/b/WXSzasHk/infestus-roadmap" target="_blank" class="pr-2"><img src="../assets/images/trello.png"></a>
            <a href="https://discord.gg/gxDgZnc" target="_blank" class="pr-2"><img src="../assets/images/discord.png"></a>
            <a href="http://www.moddb.com/mods/infestus" target="_blank"><img src="../assets/images/moddb.png"></a>
        </div>
    </div>

    <div ref="refAboutObject"></div>
    <div id="maincontent">
        <h2>The Kingdom of Arngor</h2>
        <br/>
        <p>
            A Kingdom in chaos, enemies on all fronts, desperation and fear has infested itself upon the people of Arngor.<br/>
            A dark and powerful enemy has risen, and seeks to reveal the Kingdom for what it really is.<br/>Which side you will end up on? Who will you serve?
        </p>
        <br/>
        <p>
            Start your journey in the Capital Outskirts, you are a lone adventurer seeking new insights in the kingdom of Arngor,
            prove yourself worthy to enter Arngor, however you will have to choose your allegiances carefully.
        </p>
        <br/>
        <p>
            On your journey you will witness widespread conflict, a great rebellion has shooken the great city of Lightfall, mercenaries are scavenging the countryside,
            great houses are preparing for war.<br/>Yet, in the shadows an even greater threat is emerging, the reckoning is at hand!
        </p>
        <br/>
        <br/>
        <h2>Some of the many features</h2>
        <br/>
        <ul>
            <li>Guild System</li>
            <li>Group System - Up to 10 players</li>
            <li>Dungeon System - bring up to 10 players, unleash havoc!</li>
            <li>Singleplayer & Co-Op for those who would rather play alone or with friends only</li>
            <li>Trading & Inspecting</li>
            <li>Social System, Friends/Ignore/User Search</li>
            <li>Global, Local, Group, Guild & Private chat</li>
            <li>Vast inventory and banking system</li>
            <li>Factions / Reputation System</li>
            <li>Dynamic Quest System</li>
            <li>Simple Dedicated Server Support for Windows & Linux!</li>
            <li>Linux client with cross-platform multiplayer support!</li>
        </ul>
        <br/>

        <div id="mediahead" ref="refMediaObject">
        <h2>Media</h2>
        <br/>
        <table>
            <tbody>
                <tr>
                    <td class="mediabody">
                        <img src="../assets/images/media/image1.jpg" alt="Character Panel">
                        <p>Character Panel</p>
                    </td>
                   <td class="mediabody">
                        <img src="../assets/images/media/image2.jpg" alt="Battling the Bandits">
                        <p>Battling the Bandits</p>
                    </td>
                   <td class="mediabody">
                        <img src="../assets/images/media/image3.jpg" alt="Capital Outskirts - Town">
                        <p>Capital Outskirts - Town</p>
                    </td>
                </tr>
                <tr>
                    <td class="mediabody">
                        <img src="../assets/images/media/image4.jpg" alt="Trading">
                        <p>Trading</p>
                    </td>
                   <td class="mediabody">
                        <img src="../assets/images/media/image5.jpg" alt="Player Interaction">
                        <p>Player Interaction</p>
                    </td>
                   <td class="mediabody">
                        <img src="../assets/images/media/image6.jpg" alt="Lightfall - Human Capital">
                        <p>Lightfall - Human Capital</p>
                    </td>
                </tr>
                <tr>
                    <td class="mediabody">
                        <img src="../assets/images/media/image7.jpg" alt="Outskirts Catacombs - Fighting">
                        <p>Outskirts Catacombs - Fighting</p>
                    </td>
                   <td class="mediabody">
                        <img src="../assets/images/media/image8.jpg" alt="Outskirts Catacombs - Teaser">
                        <p>Outskirts Catacombs - Teaser</p>
                    </td>
                   <td class="mediabody">
                        <img src="../assets/images/media/image9.jpg" alt="Outskirts Catacombs - Boss Fight">
                        <p>Outskirts Catacombs - Servant of Keldroth</p>
                    </td>
                </tr>
            </tbody>
          </table>
        </div>
        <br><br>
        <div id="footercontent">
                <h4>&COPY; 2015-2026 Team Infestus</h4>
                <h5>Valve, Steam & Source are trademarks of Valve.</h5>
        </div>
    </div>
  </v-container>
</template>

<script>
export default {
  name: "HomeView",
  mounted() {
    this.checkShouldMakeNavSticky()
  },
  created() {
    window.addEventListener('scroll', this.handleScroll);
    window.addEventListener("resize", this.handleResize);
  },
  unmounted() {
    window.removeEventListener('scroll', this.handleScroll);
    window.removeEventListener("resize", this.handleResize);
  },
  data() {
    return {
      navSticky: false,
    }
  },
  methods: {
    handleScroll() {
      this.checkShouldMakeNavSticky()
    },
    handleResize() {
      this.checkShouldMakeNavSticky()
    },
    checkShouldMakeNavSticky() {
      this.navSticky = (window.scrollY > window.innerHeight)
    },
  },
}
</script>

<script setup>
import { useTemplateRef } from 'vue'

const topRef = useTemplateRef('refTopObject')
const aboutRef = useTemplateRef('refAboutObject')
const mediaRef = useTemplateRef('refMediaObject')

function scrollToTop() {
  topRef.value.$el.scrollIntoView({ behavior: "smooth" });
}

function scrollToAbout() {
  aboutRef.value.scrollIntoView({ behavior: "smooth" });
}

function scrollToMedia() {
  mediaRef.value.scrollIntoView({ behavior: "smooth" });
}
</script>
