import { createRouter, createWebHistory } from 'vue-router'
//import HomeView from '../views/HomeView.vue'

const Login = () => import('@/views/Login/LoginView.vue')
const Dashboard = () => import('@/views/Dashboard/DashboardView.vue')
const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'login',
      component: Login
      /* meta: {
        hasAuth: false
      }*/
      // children: [{ path: '', name: 'login', component: Login }]
    },
    {
      path: '/dashboard',
      name: 'dashboard',
      component: Dashboard,
      /*meta: {
        hasAuth: true
      },*/
      children: []
    }
  ]
})

export default router
