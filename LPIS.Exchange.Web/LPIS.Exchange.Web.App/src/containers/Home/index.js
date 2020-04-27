import React, { useState } from 'react'
import PropTypes from 'prop-types'
import { Dropdown } from '../../components'
import './Home.scss'

const Container = ({
  onSubmit,
  currencies,
}) => {
  const [value, setValue] = useState(0);
  const [currencyFrom, setCurrencyFrom] = useState('EUR');
  const [currencyTo, setCurrencyTo] = useState('USD');

  const handleSwitch = () => {
    setCurrencyFrom(currencyTo)
    setCurrencyTo(currencyFrom)
  }

  return (
    <div className="container">
      <form
        className="form"
        onSubmit={(element) => {
          element.preventDefault()
          onSubmit(value, currencyFrom, currencyTo)
        }}
      >
        <input
          type="number"
          min="0"
          value={value}
          onChange={(event) => {
            const val = event.currentTarget.value
            setValue(val)
          }}
          required
        />
        <Dropdown
          onChange={setCurrencyFrom}
          selectedValue={currencyFrom}
          options={currencies}
          className="currency"
          name="currencyFrom"
        />
        <button
          type="button"
          className="switch-button"
          onClick={handleSwitch}
        />
        <Dropdown
          onChange={setCurrencyTo}
          selectedValue={currencyTo}
          options={currencies}
          className="currency"
          name="currencyTo"
        />
        <button type="submit" className="submit-button">confirm</button>
      </form>
    </div>
  )
}

Container.propTypes = {
  onSubmit: PropTypes.func.isRequired,
  currencies: PropTypes.arrayOf(PropTypes.string),
}

Container.defaultProps = {
  currencies: [],
}

export default Container