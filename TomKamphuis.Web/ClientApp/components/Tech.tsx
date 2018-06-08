import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class Tech extends React.Component<RouteComponentProps<{}>, {}> {
	public render() {
		return <div>
			<h1>Tech stack</h1>
			<p>My roots are at the Microsoft stack. I've worked in ASP, ASP.NET WebForms and ASP.NET MVC. Recently I've moved towards .NET Core and the client side frameworks like Angular or React. I've worked a lot woth data stores like MS SQL, Mongo DB and the like and recently played a bit with cloud solutions like Cosmos DB.</p>
			<p>Speaking of which; some parts of the data available on this website are stored in Cosmos DB (Table storage) hosted in Azure. Furthermore the connectionstring is saved in a KeyVault which is only accessible by the application or any of the devs working on the application. Whenever I submit a change to my repository it immediately gets build, runs its unit tests and checks whether the code health is still ok. If everything passes the changes get deployed into production. Nice, swift and really easy for quick deployment. It only applies to the master branch though, so feature branches firts need to be merged back into master.</p>
		</div>;
	}
}
