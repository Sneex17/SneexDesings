<template>
  <div class="navbar-main">
    <div class="contanier-logo">
      <img src="../assets/Logotipo-SX.png" alt="Sneex Desings"/>
    </div>

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

<script lang="ts">
  import { RouterLink } from 'vue-router'
</script>

<style scoped>
  .navbar-main {
    background-color: rgb(4, 31, 96);
    width: 100%;
    display: flex; 
    gap: 20px; 
    padding: 0 20px; 
    box-sizing: border-box;
    border-radius: 0 0 11px 11px;
    align-items:center;
    justify-content: space-between
  }
  .contanier-logo{
      
  }
  .contanier-logo img{
      width:70px;
      color: white;
  }
    .contanier-logo img:hover {
      cursor:pointer;
    }
  .navbar-main a {
    text-decoration: none;
    color: white;
    transition: 0.3s;
  }

  .navbar-main a:hover {
    background-color: rgb(202 198 198 / 0.14);
    border-radius: 7px;
    margin: 0 2px;
  }
</style>
