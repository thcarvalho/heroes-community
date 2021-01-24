import React from 'react'
import Head from 'next/head'
import Image from 'next/image'
import { Container, LogoTitle } from '../styles/global'
import { DefaultButton } from '../styles/buttons'
import { SelectAvatarContainer } from '../styles/pages/select-avatar'

const SelectAvatar: React.FC = () => {
  return (
    <Container>
      <Head>
        <title>Adicione uma foto</title>
      </Head>
      <div>
        <LogoTitle>Logo</LogoTitle>
        <SelectAvatarContainer>
          <label htmlFor="avatar">
            <Image
              src="/avatar-template.png"
              width={162}
              height={162}
              alt="Seu avatar"
            />
          </label>
          <input type="file" name="avatar" id="avatar" />

          <p>Adicione uma foto ao seu perfil</p>
          <DefaultButton>Continuar</DefaultButton>
        </SelectAvatarContainer>
      </div>
    </Container>
  )
}

export default SelectAvatar
