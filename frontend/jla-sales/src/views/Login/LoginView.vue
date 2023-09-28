<template>
  <div class="container mx-auto">
    <div class="grid grid-cols-2 gap-2 height">
      <div class="col-start-1 col-end-2 flex flex-col justify-center items-center login-logo-area">
        <div class="">
          <img alt="logomarca-da-empresa" class="jla-logo" src="../../assets/icons/jla-logo.svg" />
        </div>
      </div>

      <div class="col-start-2 col-end-3 flex flex-col justify-center items-center">
        <div class="flex flex-col height justify-center items-center">
          <div class=""><p class="login-title">Entrar</p></div>
          <form @submit.prevent="handleLogin">
            <div class="flex flex-col">
              <input placeholder="Email..." type="email" class="input" />
              <div class="label-text">Use seu login fornecido pelo administrador</div>
            </div>
            <div class="flex flex-col">
              <input placeholder="Senha..." type="password" class="input" />
            </div>

            <button type="submit" class="login-button">Login</button>
          </form>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  name: 'LoginView',
  methods: {
    handleLogin() {
      /*inserir lógica de passar os dados do input pra API*/
      this.$router.push('/dashboard')
    }
  }
}
</script>

<style>
.form-gap {
  column-gap: 20px;
}
</style>
