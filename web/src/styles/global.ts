import styled, { createGlobalStyle } from 'styled-components'
import colors from './colors'

export default createGlobalStyle`
  * {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
  }

  body {
    background: #fff;
    color: #2c2c2c;
    font: 400 16px Roboto, sans-serif
  }
`

export const LogoTitle = styled.h1`
  margin-bottom: 80px;
  color: ${colors.main_red};
  text-align: center;
`
export const Container = styled.div`
  width: 100vw;
  height: 100vh;

  display: flex;
  justify-content: center;
  align-items: center;
`
