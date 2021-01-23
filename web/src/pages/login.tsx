import React from 'react'
import Head from 'next/head'

import { LoginForm, LoginPage } from '../styles/pages/login'
import { DefaultButton } from '../styles/buttons'

const Login: React.FC = () => {
  return (
    <LoginPage>
      <Head>
        <title>Entrar</title>
      </Head>
      <div>
        <h1>Logo</h1>
        <LoginForm>
          <p>
            <span>Cadastre-se</span>
            <span>ou</span>
            <span>Entre com um novo usuário</span>
          </p>
          <input placeholder="Digite seu username" type="text" />
          <DefaultButton>Acessar</DefaultButton>
        </LoginForm>
      </div>
    </LoginPage>
  )
}

export default Login
