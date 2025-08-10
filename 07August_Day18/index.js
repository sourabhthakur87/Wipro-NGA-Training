const express = require('express');
const fs = require('fs')


const app = express();

app.use(express.json())

const filePath = './data.txt'

app.post('/write', async (req, res) => {
    try {
        const { content } = req.body;
        await fs.writeFile(filePath, content)
        res.send({ message: "File Written Success" })
    } catch (error) {
        res.status(500).send({ error: error.message })
    }
})

app.get('/read', async (req, res) => {
    try {
        const data = await fs.readFile(filePath, 'utf8');
        res.send(data)
    } catch (error) {
        res.status(500).send({ error: error.message })
    }
})

app.get('/', (req, res) => {
    res.send("Hello World");
});

const port = 3000
app.listen(port, () => {
    console.log(`${port} port is running`)
})