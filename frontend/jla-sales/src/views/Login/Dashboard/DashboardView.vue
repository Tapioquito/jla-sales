<template>
  <div class="container">
    <SidebarComponent></SidebarComponent>
    <div class="container">
      <HeaderComponent></HeaderComponent>
      <div class="container"><RouterView /></div>
    </div>
  </div>
</template>
<script>
import SidebarComponent from '../../../components/__tests__/Sidebar/SidebarComponent.vue'
import HeaderComponent from '../../../components/__tests__/Header/HeaderComponent.vue'
export default {
  name: 'DashboardView',
  components: {
    SidebarComponent,
    HeaderComponent
  }
}
</script>
