const { v4: uuidv4 } = require('uuid');

let items = [
    {
        id: uuidv4(),
        name: "Phạm Lan Chinh",
        level: 0
    },
    {
        id: uuidv4(),
        name: "Phạm Lan Hương",
        level: 1
    },
    {
        id: uuidv4(),
        name: "Phạm Lan Ngọc",
        level: 2
    }
];

export default items;