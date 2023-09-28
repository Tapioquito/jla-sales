<template>
  <nav
    class="col-start-1 col-end-2 row-start-1 row-end-6 sidebar flex flex-col justify-evenly items-center"
  >
    <div>
      <img class="jla-logo-sidebar" src="../../assets/icons/jla-logo.svg" />
    </div>
    <div class="button-box flex flex-col justify-center items-center">
      <RouterLink class="sidebar-button" :to="{ name: 'dashboard' }">Início</RouterLink>
      <RouterLink class="sidebar-button" :to="{ name: 'vehicles' }">Veículos</RouterLink>
      <RouterLink class="sidebar-button" :to="{ name: 'vendors' }">Vendedores</RouterLink>
      <RouterLink class="sidebar-button" :to="{ name: 'sales' }">Vendas </RouterLink>
    </div>
  </nav>
</template>
<script>
import { RouterLink } from 'vue-router'

export default {
  name: 'SidebarComponent',
  components: { RouterLink }
}
</script>

<style scoped>
.button-box {
  background-color: #74776b;
}
</style>
