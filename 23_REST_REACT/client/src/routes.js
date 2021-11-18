import React from 'react';
import {BroweserRouter, Route, Switch} from 'react-router-dom';

import Login from './pages/Login';

export default function Routes(){
    return (
        <BrowserRouter>
            <switch>
                <Route pat="/" component={Login}/>
            </switch>
        </BrowserRouter>
    );
}