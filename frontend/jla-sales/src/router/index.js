import { createRouter, createWebHistory } from 'vue-router'
//import HomeView from '../views/HomeView.vue'

const Login = () => import('@/views/Login/LoginView.vue')
const Dashboard = () => import('@/views/Dashboard/DashboardView.vue')
const Sales = () => import('@/views/Sales/SalesView.vue')
const Vendors = () => import('@/views/Vendors/VendorsView.vue')
const Vehicles = () => import('@/views/Vehicles/VehiclesView.vue')
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
      component: Dashboard
      /*meta: {
        hasAuth: true
      },*/
      //   children: []
    },
    {
      path: '/sales',
      name: 'sales',
      component: Sales
      /* meta: {
        hasAuth: false
      }*/
      // children: [{ path: '', name: 'login', component: Login }]
    },
    {
      path: '/vendors',
      name: 'vendors',
      component: Vendors
      /* meta: {
        hasAuth: false
      }*/
      // children: [{ path: '', name: 'login', component: Login }]
    },
    {
      path: '/vehicles',
      name: 'vehicles',
      component: Vehicles
      /* meta: {
        hasAuth: false
      }*/
      // children: [{ path: '', name: 'login', component: Login }]
    }
  ]
})

export default router
