<template>
  <div class="container-main">
    <Navbar /> <div class="container-views">
      <RouterView />
    </div>
    <footer>
      <div class="container-footer">
        <h4>© Todo los derechos reservados, 2026</h4>
      </div>
    </footer>
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
  }
  .container-footer{
      display: flex;
      justify-content: center;
      align-items:center;
      width:100%;
      height:100px;
      background-color:brown;

  }
</style>
