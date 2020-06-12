import React, { Component } from 'react';
import { hot } from 'react-hot-loader';
import './App.css';

import {
  BrowserRouter as Router,
  Switch,
  Route,
} from 'react-router-dom';

import Products from './Containers/Products';

class App extends Component {
  render() {
    return (
      <div className="App">

        <div className="container">
          <Router>
            <Switch>
              <Route exact path="/">
                <Products {...this.props} />
              </Route>

            </Switch>
          </Router>
        </div>
      </div>
    );
  }
}

export default hot(module)(App);
