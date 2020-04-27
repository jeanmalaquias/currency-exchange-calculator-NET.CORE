import React, { useState, useEffect } from 'react'
import { Title } from '../../components'
import { HomeContainer } from '../../containers'
import { getCurrency, convert } from '../../services'
import './Home.css'

function Home() {
  const [currency, setCurrency] = useState([])
  const [exchange, setExchange] = useState(0)
  
  const handleSubmit = async (value, currencyFrom, currencyTo) => {
    const exchangeValue = await convert(value, currencyFrom, currencyTo)
    setExchange(exchangeValue)
  }

  useEffect(() => {
    const get = async () => {
      const currency = await getCurrency()
      const currencyMap = currency.map(({code}) => code)
      setCurrency(currencyMap)
    }

    if(currency.length === 0) get()
  }, [currency])

  return (
    <div className="Home">
      <header className="Home-header">
        <Title border={currency.length === 0}>LPIS - Currency Exchange Calculator</Title>
        <HomeContainer currencies={currency} onSubmit={handleSubmit} />
        {exchange ? <h3>Total after exchange: {exchange}</h3> : ''}
      </header>
    </div>
  );
}

export default Home;
