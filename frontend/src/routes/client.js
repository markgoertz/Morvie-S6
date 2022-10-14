const axios = require('axios');

export async function getAll(){
    try{
        const response = await axios.get('http://localhost:8000/');
        return await response.json();
    }
    catch(error){
        console.log(error);
        return [];
    }
}