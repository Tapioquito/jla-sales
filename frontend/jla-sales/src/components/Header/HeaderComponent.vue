<template>
  <nav class="container d.flex justify-content-between">
    <div class="container d.flex flex-column justify-content-center">
      <p class="header-greeting">Olá, {{ username }}</p>
      <p class="lougout-text" @click="handleLogOut">Sair</p>
    </div>
    <span class="border"></span>
  </nav>
</template>
<script>
export default {
  name: 'HeaderComponent',
  data() {
    return {
      username: 'Usuário'
    }
  },
  methods: {
    handleLogOut() {
      this.$router.push('/')
    }
  }
}
</script>
<style>
.border {
  display: flex;

  width: 746px;
}
</style>
