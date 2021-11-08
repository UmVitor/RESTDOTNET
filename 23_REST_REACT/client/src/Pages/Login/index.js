import React from 'react';
import './styles.css'

import logoImage from '../../Assets/logo.svg';
import padlock from '../../Assets/padlock.png';

export default function Login(){
    return (
            <div className="login-container">
                <section className="form">
                    <img src={logoImage} alt='Login' />
                    <form>
                        <h1>Access you Account</h1>
                        <input placeholder="Username" />
                        <input type="password" placeholder="Password" />
                        
                        <button className="button" type="submit">Login</button>
                        
                    </form>
                </section>
                <img src={padlock} alt='Login' />
            </div>

    );
}