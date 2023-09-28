<template>
  <div class="container-md grid grid-cols-5 grid-rows-5 height">
    <SidebarComponent></SidebarComponent>
    <div class="container-md">
      <HeaderComponent></HeaderComponent>
      <div class="container-sm"><RouterView /></div>
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
