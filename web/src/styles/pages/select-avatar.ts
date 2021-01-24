import styled from 'styled-components'
import colors from '../colors'

export const SelectAvatarContainer = styled.div`
  width: 420px;
  height: 380px;

  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;

  background-color: ${colors.main_grey};
  border: 1px solid ${colors.border_grey};
  border-radius: 10px;

  p {
    font-size: 18px;
    font-weight: bold;
    margin-top: 43px;
    margin-bottom: 29px;
  }
  input {
    display: none;
  }

  label {
    cursor: pointer;
    transition: opacity 0.2s;

    &:hover {
      opacity: 70%;
    }
  }
`
