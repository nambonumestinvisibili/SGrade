import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
// import { Home } from './components/Home';
// import { FetchData } from './components/FetchData';
// import { Counter } from './components/Counter';
// import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import GradablePanel from './components/UniversityPanel';
import './custom.css'


export default class App extends Component {
  static displayName = App.name;
  
  constructor(props) {
    super(props)
    this.state = {
      isFetching: false,
      gradable: {}
    }
  }

  componentDidMount() {
    this.fetchGradable()
  }

  fetchGradable() {
    this.setState({...this.state, isFetching: true})
    fetch('https://localhost:44343/api/Universities/3')
      .then(res => res.json())
      .then(res => {
        this.setState({isFetching: false, gradable: res})
        console.log(res)
      })
      .catch(e => {
        console.log(e)
        this.setState({...this.state, isFetching: false})
      })
  }

  render () {
    return (
      <Layout>        
        <GradablePanel gradable={this.state.gradable}/>
        {/* <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <AuthorizeRoute path='/fetch-data' component={FetchData} /> */}
        <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
      </Layout>
    );
  }
}
