import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchProduct } from './components/FetchProduct';
import { Counter } from './components/Counter';
import { Tech } from './components/Tech';

export const routes = <Layout>
	<Route exact path='/' component={Home} />
	<Route path='/counter' component={Counter} />
	<Route path='/tech' component={Tech} />
	<Route path='/products' component={FetchProduct} />
</Layout>;
