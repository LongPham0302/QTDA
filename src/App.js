import React, { useEffect, useState } from 'react';
import Title from './components/Title';
import Control from './components/Control';
import Form from './components/Form';
import List from './components/List';
import { orderBy as fucorderBy, filter, includes, remove, reject } from 'lodash';
const { v4: uuidv4 } = require('uuid');
function App() {
    const [items, SetItems] = useState([])
    const [isShowForm, SetisShowForm] = useState(false)
    const [strSearch, SetstrSearch] = useState('')
    const [orderBy, SetorderBy] = useState('name')
    const [orderDir, SetorderDir] = useState('asc')
    const [itemSelected, SetitemSelected] = useState(null)
    useEffect(() => {
        let items = JSON.parse(localStorage.getItem('task')) || [];
        SetItems(items)
    }, [])
    function handleToggleForm() {
        SetisShowForm(!isShowForm)
        SetitemSelected(null)
    }
    function HandelSearch(value) {
        SetstrSearch(value)
    }
    const handleSort = (orderBy, orderDir) => {
        SetorderBy(orderBy);
        SetorderDir(orderDir);
    }
    function handleDelete(id) {
        const newItems = [...items]
        remove(newItems, (item) => {
            return item.id === id
        })
        SetItems(newItems)
    }
    function handleSubmit(item) {
        let id = null;
        if (item.id !== '') {
            item = reject(items, { id: item.id });
            id = item.id;
        }
        else {
            id = uuidv4();
        }
        SetItems([...items, { id: id, name: item.name, level: +item.level }])
        SetisShowForm(false)

        localStorage.setItem("task", JSON.stringify(items));
    }
    function handelEdit(item) {
        SetisShowForm(true)
        SetitemSelected(item)
        localStorage.setItem('task', JSON.stringify(items));
    }
    function closeForm() {
        SetisShowForm(false)
    }
    let elForm = null;
    let itemsHandel = [];
    itemsHandel = filter(items || [], (item) => {
        return includes(item.name.toLowerCase(), strSearch.toLowerCase());
    });

    itemsHandel = fucorderBy(itemsHandel, [orderBy], [orderDir]);

    if (isShowForm) {
        elForm = <Form
            itemSelected={itemSelected}
            handleSubmit={handleSubmit}
            onClickCancel={closeForm}
        />;
    }
    return (
        <div>
            <Title />
            <Control
                onclickAdd={handleToggleForm}
                isShowForm={isShowForm}
                HandelSearch={HandelSearch}
                orderBy={orderBy}
                orderDir={orderDir}
                handleSort={handleSort} />
            <div className="row">
                {elForm}
            </div>

            <List items={itemsHandel}
                handleDelete={handleDelete}
                handelEdit={handelEdit}
            />
        </div>
    );

}

export default App;