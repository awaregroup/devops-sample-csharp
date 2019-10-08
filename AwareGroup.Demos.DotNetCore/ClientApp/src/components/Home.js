import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = { environmentType: '', loading: true };
    }

    componentDidMount() {
        fetch('/api/settings')
            .then(res => res.json())
            .then((data) => {
                this.setState({ environmentType: data.value.environmentType, loading: false })
            })
            .catch(console.log)
    }

    render() {
        return (
            <div>
                <h1>This application is running on the <strong>{!this.state.loading && this.state.environmentType !== '' && this.state.environmentType}</strong> environment</h1>
            </div>
        );
    }
}
