<template>
  <div class="navbar-main">
    <RouterLink class="" to="/">
      <h3>Inicio</h3>
    </RouterLink>
    <RouterLink class="" to="/Design">
      <h3>Diseños</h3>
    </RouterLink>
    <RouterLink class="" to="/">
      <h3>Acerca de</h3>
    </RouterLink>

  </div>
</template>

<script  lang="ts">
  import { RouterLink } from 'vue-router'
</script>

<style scoped>
  .navbar-main {
    background-color: aqua;
    width: 100%;
    display: flex; /* Alinea los enlaces de forma horizontal */
    gap: 20px; /* Separa los enlaces entre sí */
    padding: 15px 20px; /* Le da un grosor interno al Navbar para que no dependa solo del texto */
    box-sizing: border-box;
  }

    /* Estilo opcional para que los enlaces no se vean morados o subrayados de forma fea */
    .navbar-main a {
      text-decoration: none;
      color: #2c3e50;
    }
</style>
