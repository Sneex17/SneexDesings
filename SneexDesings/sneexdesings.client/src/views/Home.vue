<template>
  <main class="contanier-main">
    <div class="sub-contanier-info">
      <h2>SNEEX DESINGS</h2>
      <p>Cada proyecto comienza con una idea y termina con una
      experiencia visual que deja huella. Fusiono creatividad, diseño
      y desarrollo para crear marcas, piezas gráficas y soluciones digitales que
      destacan por su calidad, innovación y atención al detalle.</p>
    </div>
    <div class="sub-contanier">
      <img src="/src/assets/imgs/persona.png"/>
    </div>
  </main>

  <div class="container-services" id="services">
    <div class="card-services">
      <h2>Diseños de T-shirts y Logotipos</h2>
    </div>
    <div class="card-services">
      <h2>Flyer publicitarios</h2>
    </div>
    <div class="card-services">
      <h2>Edición de vídeos</h2>
    </div>
  </div>
</template>

<script setup lang="ts">
  
</script>

<style scoped>
  body,html{
      padding:0;
      margin:0;
  }
  .contanier-main{
      padding:10px;
      display:grid;
      grid-template-columns: repeat(2, 1fr);
      background-image: url("/src/assets/imgs/fondo-main.jpg");
      background-repeat: no-repeat;
      background-size: 100%;
      width:100%;
      height:85vh;
      gap:17px;
  }
  .sub-contanier, .sub-contanier-info {
    width: 100%;
    height: auto;
  }
  .sub-contanier{
      display:flex;
      flex-direction:column;
      justify-content:center;
      align-items:center;
  }
  .sub-contanier img{
      width:56%;
  }
  .sub-contanier-info{
      padding-top:25rem;
      padding-left:7rem;
      padding-right:3rem;
  }
  .sub-contanier-info h2{
      font-size:2.5rem;
      color:white;
      font-weight:bold;
  }
  .sub-contanier-info p {
      font-size:1.1rem;
  }

  .container-services{
      display:flex;
      justify-content:center;
      align-items:center;
      width:100%;
      height:40vh;
      background-color:seagreen;
      gap:2rem;

  }

  .card-services {
    width: 190px;
    height: 254px;
    background: #07182E;
    position: relative;
    display: flex;
    place-content: center;
    place-items: center;
    overflow: hidden;
    border-radius: 20px;
  }

    .card-services h2 {
      z-index: 1;
      color: white;
      font-size: 1.2rem;
      align-items:center
    }

    .card-services::before {
      content: '';
      position: absolute;
      width: 100px;
      background-image: linear-gradient(180deg, rgb(0, 183, 255), rgb(255, 48, 255));
      height: 130%;
      animation: rotBGimg 3s linear infinite;
      transition: all 0.2s linear;
    }

  @keyframes rotBGimg {
    from {
      transform: rotate(0deg);
    }

    to {
      transform: rotate(360deg);
    }
  }

  .card-services::after {
    content: '';
    position: absolute;
    background: #07182E;
    ;
    inset: 5px;
    border-radius: 15px;
  }
</style>
