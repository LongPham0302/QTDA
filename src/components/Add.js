import React, { Component } from 'react';

class Add extends Component {
    constructor(props) {
        super(props);
        this.state = {

        };
        this.HandelAdd = this.HandelAdd.bind(this);

    };
    HandelAdd() {
        this.props.HandelAdd();
    }
    render() {
        let elmControl = <button onClick={this.HandelAdd}
            type="button"
            className="btn btn-info btn-block" > Add Task </button>
        if (this.props.isShowForm === true)

            elmControl = <button onClick={this.HandelAdd}
                type="button"
                className="btn btn-success btn-block" > Close Task </button>
        return (
            <div className="col-xs-5 col-sm-5 col-md-5 col-lg-5" >
                {elmControl}
            </div>
        );
    }
}

export default Add;