import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class Tech extends React.Component<RouteComponentProps<{}>, {}> {
	public render() {
		return <div>
			<h1>Tech stack</h1>
			<p>My roots are at the Microsoft stack. I've worked in ASP, ASP.NET WebForms and ASP.NET MVC. Recently I've moved towards .NET Core and the client side frameworks like Angular or React. I've worked a lot woth data stores like MS SQL, Mongo DB and the like and recently played a bit with cloud solutions like Cosmos DB.</p>
		</div>;
	}
}
