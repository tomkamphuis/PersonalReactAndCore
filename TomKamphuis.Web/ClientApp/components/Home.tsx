import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <div>
            <h1>Hello, I am robot!</h1>
            <p>This is a mere example of how to build and deploy an application using .NET Core and React.</p>
        </div>;
    }
}
