import React, { Component } from 'react';
import Search from './Search';
import Sort from './Sort';
import Add from './Add';

class Control extends Component {
    constructor(props) {
        super(props);
        this.state = {};
        this.HandelAdd = this.HandelAdd.bind(this);
        this.handleSort = this.handleSort.bind(this)
    };
    HandelAdd() {
        this.props.onclickAdd();
    }
    HandelSearchGo() {
        this.props.HandelSearchGo();
    }
    handleSort() {
        this.props.handleSort();
    }
    render() {
        let isShowForm = this.props.isShowForm
        let { orderBy, orderDir } = this.props

        return (
            <div className="row">
                <Search HandelSearchGo={this.props.HandelSearch} />

                <Sort orderBy={orderBy}
                    orderDir={orderDir}
                    handleSort={this.props.handleSort} />

                <Add HandelAdd={this.HandelAdd}
                    isShowForm={isShowForm} />
            </div>

        );
    }
}

export default Control;