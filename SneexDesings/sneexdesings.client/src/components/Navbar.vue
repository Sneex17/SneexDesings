<template>
  <div class="navbar-main">
    <div class="contanier-logo">
      <img src="../assets/Logotipo-SX.png" alt="Sneex Desings" />
    </div>

    <div class="container-menu">
      <RouterLink class="" to="/">
        <h3>Inicio</h3>
      </RouterLink>
      <RouterLink class="" to="/Design">
        <h3>Diseños</h3>
      </RouterLink>
      <a href="#services">Acerca de</a>
    </div>
    

    <div class="contanier-logo">
      <a href="https://www.instagram.com/sneex_desings17" target="_blank">
        <img src="../assets/instagram-new.png" alt="Instagram" />
      </a>

    </div>
  </div>
</template>

<script lang="ts">
  import { RouterLink } from 'vue-router'
</script>

<style scoped>
  .navbar-main {
    background-color: rgba(10, 10, 20);
    width: 100%;
    display: flex;
    gap: 20px;
    padding: 0 20px;
    box-sizing: border-box;
    border-radius: 0 0 11px 11px;
    align-items: center;
    justify-content: space-between;
        
  }

    .contanier-logo img {
      width: 70px;
      color: white;
    }

      .contanier-logo img:hover {
        cursor: pointer;
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

  .contanier-logo a {
    text-decoration: none;
  }

    .contanier-logo a img {
      width: 40px;
    }

  .container-menu {
      display:flex;
      justify-content:space-between;
      justify-items:center;
      gap:37px;
  }
  .container-menu a{
      font-size:17px;
  }
</style>
