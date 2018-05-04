import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class Home extends React.Component<RouteComponentProps<{}>, {}> {
	public render() {
		return <div>
			<h1>Greetings reader</h1>
			<p>You entered the workspace of Tom Kamphuis. With over { new Date().getFullYear() - 2007 } years of experience in software development, be it as developer, scrum master or agile coach I can help any team becoming more productive and more proficient.</p>
		</div>;
	}
}
