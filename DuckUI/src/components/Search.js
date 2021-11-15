
import React from 'react';
import { TextField } from '@material-ui/core';

export default class MyComponent extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      repos: [],
      query: '',
      loading: false,
    }
  }

  handleChange = event => {
    this.setState({ query: event.target.value });
  }

  handleSubmit = event => {
    event.preventDefault();
    const query = {
      query: this.state.query
    };
    localStorage.setItem("query",JSON.stringify(this.state.query));
    const queeyData = localStorage.getItem('query');
    console.log(queeyData);
    // const queeyData = localStorage.getItem('query') === 'true';
    // console.log(queeyData);

    
    const apiUrl = `http://localhost:60858/api/Duck/` + this.state.query;
    fetch(apiUrl)
      .then((res) => res.json())
      .then((repos) => {
        this.setState({ repos: repos.relatedTopics, loading: false });
      }).catch(function (error) {
        console.log(error);
      }
      );
 
  }
  render() {
    return (
      <div >
        <form onSubmit={this.handleSubmit}>
      
          <TextField id="query" label="Search" variant="outlined"
            size="small" fullWidth 
            placeholder="Search Query" onChange={this.handleChange} 

            />
          {/* <Button olor="primary" variant="contained" type="submit" > Search </Button> */}
        </form>
        <hr />
        <div>
          <ul style={{ listStyle: 'none' }}>
            {this.state.repos.map((repo, index) => {
              return (
                <li key={index} style={{ listStyle: 'none' }}>
                  <a href={repo.firstURL}>{repo.firstURL}</a>
                  <br />
                  <span>{repo.text}</span>
                </li>
              );
            })}
          </ul>
        </div>
      </div>
    )
  }
}

