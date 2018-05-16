import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import 'isomorphic-fetch';

interface IFetchProductState {
	products: IProduct[];
	loading: boolean;
}

interface IProduct {
	name: string;
	description: string;
	websiteUrl: string;
	id: number;
}

export class FetchProduct extends React.Component<RouteComponentProps<{}>, IFetchProductState> {
	constructor() {
		super();
		this.state = { products: [], loading: true };

		fetch('api/Product/Products')
			.then(response => response.json() as Promise<IProduct[]>)
			.then(data => {
				this.setState({ products: data, loading: false });
			});
	}

	public render() {
		let contents = this.state.loading
			? <p><em>Loading...</em></p>
			: FetchProduct.renderProductsTable(this.state.products);

		return <div>
			<h1>Stuff developed</h1>
			<p>I've worked on numerous projects in the past couple of years. Here you can find an overview on worked on stuff and what I did on making these products even better.</p>
			{ contents }
		</div>;
	}

	private static renderProductsTable(products: IProduct[]) {
		return <table className='table'>
			<thead>
				<tr>
					<th>Name</th>
					<th>Website</th>
					<th>Description</th>
				</tr>
			</thead>
			<tbody>
				{products.map(product =>
				<tr key={ product.id }>
					<td>{ product.name }</td>
					<td>{ product.websiteUrl }</td>
					<td>{product.description }</td>
				</tr>
			)}
			</tbody>
		</table>;
	}
}