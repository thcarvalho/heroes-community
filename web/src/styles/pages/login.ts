import styled from 'styled-components'
import colors from '../colors'

export const LoginPage = styled.div`
  width: 100vw;
  height: 100vh;

  display: flex;
  justify-content: center;
  align-items: center;

  h1 {
    margin-bottom: 80px;
    color: ${colors.main_red};
    text-align: center;
  }
`

export const LoginForm = styled.form`
  width: 420px;
  height: 380px;

  background-color: ${colors.main_grey};
  border: 1px solid ${colors.border_grey};
  border-radius: 10px;

  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;

  p {
    display: flex;
    flex-direction: column;

    text-align: center;
    font-weight: 700;
    font-size: 18px;

    margin-bottom: 40px;
  }

  input {
    width: 335px;
    height: 40px;

    border: 1px solid ${colors.border_grey};
    border-radius: 10px;
    padding: 13px;
    outline: none;
    margin-bottom: 40px;

    font-size: 14px;
    font-weight: 700;
    color: #c2c2c2;

    ::placeholder,
    ::-webkit-input-placeholder {
      color: #c2c2c2;
    }
  }
`
