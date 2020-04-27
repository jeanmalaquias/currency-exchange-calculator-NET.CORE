import React from 'react'
import PropTypes from 'prop-types'
import './Dropdown.scss'
import Arrow from './Arrow'

const Dropdown = ({
  options,
  selectedValue,
  onChange,
  className,
  name,
  ...props
}) => (
  <label htmlFor={name} {...props} className={`drop-down-container ${className}`}>
    <select
      name={name}
      value={selectedValue}
      onChange={(event) => onChange(event.target.value)}
      className="drop-down"
    >
      {options.map((code) => (
        <option
          key={code}
          value={code}
        >
          {code}
        </option>
      ))}
    </select>
    <div className="arrow">
      <Arrow />
    </div>
  </label>
)

Dropdown.propTypes = {
  options: PropTypes.arrayOf(PropTypes.string),
  name: PropTypes.string.isRequired,
  selectedValue: PropTypes.string.isRequired,
}

Dropdown.defaultProps = {
  options: [],
}


export default Dropdown
