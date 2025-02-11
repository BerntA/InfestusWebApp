<template>
  <v-app>
    <!-- <v-app-bar>
    </v-app-bar> -->

    <v-main>
      <router-view />
    </v-main>

    <!-- <v-footer>
    </v-footer> -->
  </v-app>
</template>

<script setup>
import { RouterView } from 'vue-router'
</script>

<style lang="scss">
@use '@/styles/index.scss';
</style>
