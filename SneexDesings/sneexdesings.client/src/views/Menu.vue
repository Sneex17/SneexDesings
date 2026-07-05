<template>
  <div class="container-main">
    <Navbar /> <div class="container-views">
      <RouterView />
    </div>
  </div>
</template>

<script setup lang="ts">
  import Navbar from '../components/Navbar.vue';
  import { RouterView } from 'vue-router';
</script>

<style scoped>
  .container-main {
    display: flex;
    flex-direction: column;
    min-height: 100vh;
    width: 100%;
  }

  .container-views {
    flex-grow: 1;
    width: 100%;
    padding: 20px;
  }
</style>
