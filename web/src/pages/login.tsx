import React from 'react'
import Head from 'next/head'

import { LoginForm } from '../styles/pages/login'
import { DefaultButton } from '../styles/buttons'
import { Container, LogoTitle } from '../styles/global'

const Login: React.FC = () => {
  return (
    <Container>
      <Head>
        <title>Entrar</title>
      </Head>
      <div>
        <LogoTitle>Logo</LogoTitle>
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
    </Container>
  )
}

export default Login
