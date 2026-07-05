import { createRouter, createWebHistory } from 'vue-router'
import ViewMenu from '../views/Menu.vue'
import ViewHome from '../views/Home.vue'
import ViewDesign from '../views/Design.vue'

const router = createRouter({
  history: createWebHistory(),
  routes: [
    {
      path: '/',
      redirect: '/Menu'
    },
    {
      path: '/Menu',
      name: 'Menu',
      component: ViewMenu,
      children: [
        {
          path: '',
          name: 'Home',
          component: ViewHome
        },
        {
          path: '/Design',
          name: 'Design',
          component: ViewDesign
        }
      ],
    }
  ]
});

export default router
