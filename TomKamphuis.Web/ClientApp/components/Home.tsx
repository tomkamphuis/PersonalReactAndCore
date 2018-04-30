import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <div>
            <h1>Hello, I am robot!</h1>
            <p>This is a mere example of how to build and deploy an application using .NET Core and React. This is a good question...</p>
			<p>Test to interact with Azure functions and BetterCodeHub.</p>
			<ul>
				<li>Attempt 1</li>
				<li>Attempt 2</li>
			</ul>
        </div>;
    }
}
