import styled from 'styled-components'
import colors from './colors'

export const DefaultButton = styled.button`
  width: 255px;
  height: 35px;

  outline: none;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  border: none;
  border-radius: 10px;

  background-color: ${colors.main_red};
  color: #fff;
  font-weight: 700;
  font-family: 18px;

  cursor: pointer;
  transition: background-color 0.2s;

  &:hover {
    background-color: ${colors.hover_red};
  }
`
