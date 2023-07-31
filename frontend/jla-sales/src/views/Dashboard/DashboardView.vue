<template>
  <div class="container">
    <SidebarComponent></SidebarComponent>
    <div class="container">
      <HeaderComponent></HeaderComponent>
      <div class="container">MAIN CONTENT<RouterView /></div>
    </div>
  </div>
</template>
<script>
import SidebarComponent from '@/components/Sidebar/SidebarComponent.vue'
import HeaderComponent from '@/components/Header/HeaderComponent.vue'
export default {
  name: 'DashboardView',
  components: {
    SidebarComponent,
    HeaderComponent
  }
}
</script>
