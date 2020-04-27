import React from 'react'
import PropTypes from 'prop-types'
import './Title.css'

const Title = ({
  children,
  border
}) => (
  <h1 className={`title ${border ? 'border' : ''}`} aria-label='title' >{children}</h1>
)

Title.propTypes = {
  children: PropTypes.node.isRequired,
  border: PropTypes.bool
}

Title.defaultProps = {
  border: false,
}

export default Title
