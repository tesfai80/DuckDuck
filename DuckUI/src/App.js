import React, { useEffect, useState } from 'react';
import './App.css';
import Header from './components/Header';
import Search from './components/Search';

function App() {
 
  return (
    <div className='App'>
      <br/>
      <Header/>
      <br/>
      <div className='container'>
        <br/>
       <Search/>
      </div>
      <footer>
        <div className='footer'>
         <span>powered by tesfay</span>
        </div>
      </footer>
    </div>
  );
}
export default App;
