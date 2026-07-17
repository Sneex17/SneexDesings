<!--<template>
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

</style>-->

<template>
  <main class="contanier-main">
    <div class="overlay"></div>
    <div class="sub-contanier-info">
      <span class="eyebrow">Estudio de diseño gráfico</span>
      <h2>SNEEX DESIGNS</h2>
      <p>
        Cada proyecto comienza con una idea y termina con una experiencia
        visual que deja huella. Fusiono creatividad, diseño y desarrollo para
        crear marcas, piezas gráficas y soluciones digitales que destacan por
        su calidad, innovación y atención al detalle.
      </p>
      <a href="#services" class="btn-cta">Ver diseños →</a>
    </div>
    <div class="sub-contanier">
      <img src="/src/assets/imgs/persona.png" alt="Diseñador SNEEX" />
    </div>
  </main>

  <div class="container-services" id="services">
    <div class="services-head">
      <span class="section-eyebrow">Qué hago</span>
      <h3>Tres formas de darle forma a tu marca</h3>
    </div>
    <div class="cards-row">
      <div class="card-services">
        <span class="card-icon">✎</span>
        <h2>Diseños de T-shirts y Logotipos</h2>
      </div>
      <div class="card-services">
        <span class="card-icon">▤</span>
        <h2>Flyer publicitarios</h2>
      </div>
      <div class="card-services">
        <span class="card-icon">▶</span>
        <h2>Edición de vídeos</h2>
      </div>
    </div>
  </div>
</template>

<script setup lang="ts"></script>

<style scoped>
  :root {
    --ink: #0b0e14;
    --ink-2: #10131c;
    --card: #0f1420;
    --violet: #7c5cfc;
    --pink: #ff5d8f;
    --cyan: #3ec6e0;
    --text: #f1f1f5;
    --muted: #a7acbd;
  }

  body,
  html {
    padding: 0;
    margin: 0;
  }

  /* ---------- HERO ---------- */
  .contanier-main {
    position: relative;
    padding: 10px;
    display: grid;
    grid-template-columns: repeat(2, 1fr);
    background-image: url('/src/assets/imgs/fondo-main.jpg');
    background-repeat: no-repeat;
    background-size: cover;
    background-position: center;
    width: 100%;
    min-height: 85vh;
    gap: 17px;
    overflow: hidden;
  }

  .overlay {
    position: absolute;
    inset: 0;
    background: linear-gradient( 100deg, rgba(11, 14, 20, 0.92) 0%, rgba(11, 14, 20, 0.55) 45%, rgba(11, 14, 20, 0.15) 100% );
    pointer-events: none;
  }

  .sub-contanier,
  .sub-contanier-info {
    position: relative;
    z-index: 1;
    width: 100%;
    height: auto;
  }

  .sub-contanier {
    display: flex;
    flex-direction: column;
    justify-content: flex-end;
    align-items: center;
  }

    .sub-contanier img {
      width: 56%;
      filter: drop-shadow(0 20px 40px rgba(0, 0, 0, 0.45));
    }

  .sub-contanier-info {
    display: flex;
    flex-direction: column;
    justify-content: center;
    padding-left: 7rem;
    padding-right: 3rem;
  }

  .eyebrow {
    display: inline-flex;
    align-items: center;
    gap: 8px;
    font-size: 0.8rem;
    letter-spacing: 1.5px;
    text-transform: uppercase;
    color: var(--cyan);
    font-weight: 600;
    margin-bottom: 16px;
    width: fit-content;
  }

    .eyebrow::before {
      content: '';
      width: 8px;
      height: 8px;
      border-radius: 50%;
      background: var(--cyan);
      box-shadow: 0 0 12px var(--cyan);
    }

  .sub-contanier-info h2 {
    font-size: 2.6rem;
    color: var(--text);
    font-weight: 800;
    letter-spacing: -1px;
    margin-bottom: 18px;
  }

  .sub-contanier-info p {
    font-size: 1.05rem;
    color: var(--muted);
    max-width: 480px;
    line-height: 1.6;
    margin-bottom: 28px;
  }

  .btn-cta {
    display: inline-flex;
    align-items: center;
    gap: 8px;
    width: fit-content;
    padding: 14px 28px;
    border-radius: 10px;
    font-weight: 600;
    font-size: 0.95rem;
    color: #fff;
    text-decoration: none;
    background: linear-gradient(90deg, var(--violet), var(--pink));
    box-shadow: 0 8px 30px -8px rgba(124, 92, 252, 0.6);
    transition: transform 0.2s ease, box-shadow 0.2s ease;
  }

    .btn-cta:hover {
      transform: translateY(-3px);
      box-shadow: 0 12px 34px -6px rgba(255, 93, 143, 0.55);
    }

  /* ---------- SERVICES ---------- */
  .container-services {
    display: flex;
    flex-direction: column;
    align-items: center;
    width: 100%;
    padding: 80px 6vw;
    background: var(--ink-2);
    gap: 48px;
  }

  .services-head {
    text-align: center;
    max-width: 520px;
  }

  .section-eyebrow {
    display: block;
    color: var(--pink);
    font-size: 0.8rem;
    letter-spacing: 1.5px;
    text-transform: uppercase;
    font-weight: 600;
    margin-bottom: 12px;
  }

  .services-head h3 {
    color: var(--text);
    font-size: 1.6rem;
    font-weight: 700;
  }

  .cards-row {
    display: flex;
    justify-content: center;
    align-items: stretch;
    flex-wrap: wrap;
    gap: 2rem;
  }

  .card-services {
    width: 220px;
    height: 260px;
    background: var(--card);
    position: relative;
    display: flex;
    flex-direction: column;
    place-content: center;
    place-items: center;
    gap: 16px;
    overflow: hidden;
    border-radius: 20px;
    padding: 24px;
    text-align: center;
    transition: transform 0.3s ease;
  }

    .card-services:hover {
      transform: translateY(-8px);
    }

  .card-icon {
    z-index: 1;
    font-size: 1.6rem;
    color: var(--cyan);
  }

  .card-services h2 {
    z-index: 1;
    color: var(--text);
    font-size: 1.15rem;
    font-weight: 700;
    line-height: 1.4;
  }

  .card-services::before {
    content: '';
    position: absolute;
    width: 140px;
    background-image: linear-gradient(180deg, var(--violet), var(--pink), var(--cyan));
    height: 160%;
    animation: rotBGimg 3.5s linear infinite;
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
    background: var(--card);
    inset: 3px;
    border-radius: 17px;
  }

  /* ---------- RESPONSIVE ---------- */
  @media (max-width: 900px) {
    .contanier-main {
      grid-template-columns: 1fr;
      min-height: auto;
      padding-top: 60px;
    }

    .sub-contanier-info {
      order: 1;
      padding: 2rem 1.5rem 0;
    }

    .sub-contanier {
      order: 2;
    }

      .sub-contanier img {
        width: 75%;
      }

    .sub-contanier-info h2 {
      font-size: 2rem;
    }
  }

  @media (max-width: 560px) {
    .cards-row {
      flex-direction: column;
      align-items: center;
    }
  }

  @media (prefers-reduced-motion: reduce) {
    .card-services::before {
      animation: none;
    }
  }
</style>
