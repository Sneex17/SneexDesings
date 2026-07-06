<template>
  <div v-if="lista.length > 0"class="container-main">
    <div v-for="item in lista" :key="item.productdesignid" class="card-design">
      <img :src="item.img" />
      <div class="card-info">
        <h5>{{item.title}}</h5>
        <h6 :class="[item.category === 'Aventureros' ? 'cateory-a1' :
            item.category === 'Conquistadores' ? 'cateory-c1' :
            item.category === 'Guías Mayores' ? 'cateory-g1' : 'cateory-j1']">{{item.category}}</h6>
        <p>{{item.description}}</p>
        <h6 class="fecha-info">{{item.fecha}}</h6>
      </div>
    </div>
  </div>
  
</template>

<script setup lang="ts">
  import { ref, onMounted } from 'vue'
  import { type cuerpoDesign } from '../Controllers/DesignController'
  import * as DesignController  from '../Controllers/DesignController'

  const lista = ref<cuerpoDesign[]>([]);
  onMounted(async () => {
    try {
      lista.value = await DesignController.Listar();

      console.log(lista.value);
    } catch (error) {
      console.log("Error: ", error);
    }
  })

  
</script>

<style scoped>
  .container-main {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    justify-items: center;
    gap: 17px;
  }
  .card-design {
    width: 270px;
    background-color: lightslategrey;
    border-radius: 14px;
    overflow: hidden;
    box-shadow: 10px 5px 8px -1px #888888;

  }
  .card-design img{
      width: 270px;
  }
  .card-info{
      padding: 10px;
      font-size: 25px;
      color:black;
  }
  .card-info h5{
      font-weight: bold;
  }
  .cateory-a1 {
    background-color: #C5D4E8;
    border-radius: 10px;
    padding: 0 10px;
    border-style: solid;
    border-color: #003A88;
  }
  .cateory-c1 {
    background-color: #FF9688;
    border-radius: 10px;
    padding: 0 10px;
    border-style: solid;
    border-color: red;
  }
  .cateory-g1 {
    background-color: #ffd070;
    border-radius: 10px;
    padding: 0 10px;
    border-style: solid;
    border-color: #10128e;
  }

  .cateory-j1 {
    background-color: lightgrey;
    border-radius: 10px;
    padding: 0 10px;
    border-style: solid;
    border-color: #550000;
  }
    .card-info p {
      font-size: 15px;
    }

  .fecha-info {
      font-weight: 500;
  }
  .card-design:hover {
    cursor: pointer;
  }

  @media screen and (max-width: 1200px){
    .container-main {
      grid-template-columns: repeat(3, 1fr);
    }
  }
  @media screen and (max-width: 900px) {
    .container-main {
      grid-template-columns: repeat(2, 1fr);
    }
  }
  @media screen and (max-width: 600px) {
    .container-main {
      display: flex;
      flex-direction: column;
      align-items: center;
    }
  }
</style>
