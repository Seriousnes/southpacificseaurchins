import { createRouter, createWebHistory } from "vue-router";
import ProductView from "../views/ProductView.vue";

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: "/",
      component: ProductView,
    },
    {
      path: "/about",  
      component: () => import("../views/AboutView.vue"),
    },
    {
      path: "/products",      
      component: () => ProductView,
    },
    {
      path: "/contact",
      name: "contact",
      component: () => import("../views/ContactView.vue"),
    },
  ],
});

export default router;
