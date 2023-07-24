<template>
  <div class="container-fluid">
    <div class="row row-cols-2 full-height">
      <div class="col white-text d-flex flex-column p-2 justify-content-center">
        <div class="d-flex justify-content-center">
          <img class="jla-logo" src="../../assets/icons/jla-logo.svg" />
        </div>
      </div>

      <div class="col d-flex flex-column p-2 justify-content-center">
        <div class="container justify-content-center">
          <div class="container"><p class="login-title">Entrar</p></div>
          <form>
            <div class="mb-3">
              <label for="exampleInputEmail1" class="form-label">Email </label>
              <input type="email" class="form-control form-width" aria-describedby="emailHelp" />
              <div id="emailHelp" class="form-text">Use seu login fornecido pelo administrador</div>
            </div>
            <div class="mb-3">
              <label for="exampleInputPassword1" class="form-label">Senha</label>
              <input type="password" class="form-control form-width" />
            </div>

            <button type="submit" class="btn btn-primary">Entrar</button>
          </form>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  name: 'LoginView'
}
</script>
<style>
.test {
  background-color: red;
}
</style>
