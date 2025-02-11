import { createRouter, createWebHistory } from 'vue-router'

const routes = [
  { path: '/', name: 'home', component: () => import('@/views/Home.vue') },
  { path: '/index', name: 'index', component: () => import('@/views/Home.vue') },
  { path: '/armory', name: 'armory', component: () => import('@/views/Armory.vue'), meta: { title: 'Infestus Player List' } },
  { path: '/armory/player/:id', name: 'armory player profile', component: () => import('@/views/ArmoryPlayerProfile.vue'), props: route => ({ id: route.params.id }), meta: { title: 'Infestus Armory Profile' } },
  { path: '/armory/guild/:id', name: 'armory guild profile', component: () => import('@/views/ArmoryGuildProfile.vue'), props: route => ({ id: route.params.id }), meta: { title: 'Infestus Guild Profile' } },
  { path: '/playerlist', name: 'playerlist', component: () => import('@/views/Armory.vue'), meta: { title: 'Infestus Player List' } },
  { path: '/changelog', name: 'changelog', component: () => import('@/views/Changelog.vue'), meta: { title: 'Infestus Changelog' } },
  { path: '/wiki', name: 'wiki', component: () => import('@/views/Wiki.vue'), meta: { title: 'Infestus Wiki' } },
  { path: '/snapshots', name: 'snapshots', component: () => import('@/views/Snapshots.vue'), meta: { title: 'Infestus Database Snapshots' } },
  { path: '/keyauth', name: 'keyauth', component: () => import('@/views/KeyAuth.vue'), meta: { title: 'Infestus Beta Signup' } },
]

const router = createRouter({
  routes,
  history: createWebHistory(),
})

router.beforeEach((to) => {
  const { title } = to.meta;
  const defaultTitle = 'Infestus';
  document.title = title || defaultTitle
})

export default router
