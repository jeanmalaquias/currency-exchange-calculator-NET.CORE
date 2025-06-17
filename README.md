# 💱 Currency Exchange Calculator (.NET Core + React)

A simple yet powerful full-stack application for converting currencies. Built with .NET Core 2.2 for the backend API and React for the frontend interface.

---

## 🔧 Tech Stack
- **Backend**: ASP.NET Core 2.2 Web API (C#)
- **Frontend**: React.js (JavaScript, functional components)
- **API**: Fetches live currency rates from a free open-source exchange rates API
- **Exchange Rates Source**: Third-party API (e.g., exchangerate.host or equivalent)
- **CORS** enabled for seamless frontend-backend communication

---

## 🚀 Features
- 🎯 Real-time currency conversions
- 💡 Support for major world currencies (USD, EUR, GBP, JPY, etc.)
- 🌐 Clean, responsive React UI with intuitive input/output fields
- 🔄 Automatic updates on exchange rates (dictated by API source)
- 🔒 CORS-enabled backend allowing React apps to fetch rates

---

## 📥 Quick Start

### Backend Setup (ASP.NET Core 2.2)
1. Clone the repo:
   ```bash
   git clone https://github.com/jeanmalaquias/currency-exchange-calculator-NET.CORE.git
   cd currency-exchange-calculator-NET.CORE/backend

dotnet restore
dotnet run

https://localhost:5001/api/exchange?from=USD&to=EUR&amount=100

cd ../frontend

npm install
npm start

http://localhost:3000
