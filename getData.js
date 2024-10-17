
async function getData()
{
    const response = await fetch('https://localhost:7293/Home/GetApiScheme');
    const data = await response.json(); //use json when receiving, easier to work with
    if(!response.ok)
    {
        console.log("Error", response.status, response.statusText);
        return;
    }

    else 
    {
        console.log("success", response.status, response.statusText, data);

    }
const datalist = document.getElementById('dataList');
datalist.innerHTML = '';

for(const elements of data)
{
    const li = document.createElement("li");
    if(elements.image)
    {
        const imageUrl = URL.createObjectURL(new Blob([elements.image]));

        li.innerHTML = `    
    Name: ${elements.name}, 
    Age: ${elements.age}, 
    Email: ${elements.email}, 
    Place: ${elements.place}, 
    PhoneNr: ${elements.phoneNr}, 
    Image: <img src="${imageUrl}" alt="Image" width="100" height="100">
    <a href="${imageUrl}" download="image.png">Download Image</a>`;

    }

    else 
    {
        li.innerHTML = `Name: ${elements.name}, 
        Age: ${elements.age}, 
        Email: ${elements.email}, 
        Place: ${elements.place}, 
        PhoneNr: ${elements.phoneNr}, 
        Image: No image available`;
    }

    datalist.appendChild(li);

}

}

getData();