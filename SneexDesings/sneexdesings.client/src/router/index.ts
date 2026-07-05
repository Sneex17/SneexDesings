import { createRouter, createWebHistory } from 'vue-router'
import ViewMenu from '../views/Menu.vue'

const router = createRouter({
  history: createWebHistory(),
  routes: [
    {
      path: "/",
      name: "Menu",
      component: ViewMenu,

      children: [
        {
          path: "/",
          name: "Home",
          component: ViewMenu
        },
        {
          path: "/Design",
          name: "Design",
          component: ViewMenu
        }
      ],
    }]
});

export default router
