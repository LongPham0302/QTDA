import React, { Component } from 'react';

class Item extends Component {
    constructor(props) {
        super(props);
        this.state = {

        };
        this.handleDelete = this.handleDelete.bind(this)
        this.handelEdit = this.handelEdit.bind(this)
    }
    showLevel(level) {
        let elmLevel = <span className="label label-default">Small</span>;

        if (level === 1) {
            elmLevel = <span className="label label-info">Medium</span>;
        }
        else if (level === 2) {
            elmLevel = <span className="label label-danger">Hight</span>;
        }
        return elmLevel;
    }
    handleDelete(id) {
        this.props.handleDelete(id)
    }
    handelEdit(item) {
        this.props.handelEdit(item)
    }
    render() {
        const { item } = this.props;
        const index = this.props.index;

        return (
            <tr>
                <td className="text-center">{index}</td>
                <td>{item.name}</td>
                <td className="text-center">{this.showLevel(item.level)}</td>
                <td>
                    <button onClick={() => this.handelEdit(item)} type="button" className="btn btn-warning">Edit</button>
                    <button onClick={() => { this.handleDelete(item.id) }} type="button" className="btn btn-danger">Delete</button>
                </td>
            </tr>
        );
    }

}

export default Item;