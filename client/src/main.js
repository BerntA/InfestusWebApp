import { createApp } from 'vue'
import axios from 'axios'
import App from '@/App.vue'
import router from '@/plugins/router'
import vuetify from '@/plugins/vuetify'
import store from '@/store/index'
import moment from 'moment-timezone'

const app = createApp(App)

app.use(router)
app.use(store)
app.use(vuetify)

app.config.globalProperties.$http = axios
app.config.globalProperties.$moment = moment

app.mount('#app')
