async function sendJson() {
    let name = document.getElementById('name').value;
    let age = document.getElementById('age').value;
    let email = document.getElementById('email').value;
    let place = document.getElementById('place').value;
    let phonenr = document.getElementById('phonenr').value;
    let image = document.getElementById('image').files[0];
    
    let dataToSend = new FormData(); 
        dataToSend.append('Name',name);
        dataToSend.append('Age', parseInt(age));
        dataToSend.append('Email',email);
        dataToSend.append('Place',place);
        dataToSend.append('PhoneNr',parseInt(phonenr));
        dataToSend.append('Image',image);
    
    
    let response = await fetch('https://localhost:7293/Home/PostApiScheme',{

        method: "POST",
        body: dataToSend

    });
    console.log("Success", response, response.status, response.statusText);
}