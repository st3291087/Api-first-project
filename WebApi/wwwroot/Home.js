   
const PostData = async () => {

  
        ValidPass()
        const progress = document.querySelector("#prog").value
    if (progress < 3)
        return;
  
    const name = document.querySelector("#name").value
    const last_name = document.querySelector("#last_name").value
    const email = document.querySelector("#email").value
    const password = document.querySelector("#password").value

    const user =  {
        name,
        last_name,
        email,
        password

    }
    try {
        const response = await fetch('api/Users', {
            method: 'POST',
            headers: {

                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        });
        const userResponse = await response.json();

        if (response.ok) {
        
            alert("your sign is succesed")
        }
        else {
            throw Error("your sign is failed")
        }
    }
    catch (e) {
        alert(e)
  

    }
}
async function Login(){
   const email = document.querySelector("#log_email").value
    const password =  document.querySelector("#log_password").value

    const user = {

        logEmail: email,
        logPassword: password

    }   
     try {
         const response = await fetch('api/Users/login', {
            method: 'POST',
            headers: {

                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
         });
         //onst userResponse = await response.json();

         if (response.ok) {
    
             const currentUser = await response.json();
             sessionStorage.setItem("currentUser", JSON.stringify(currentUser))
             window.location.href="UsairDetails.html"
        
            
        }
        else {
       
            throw Error("your details arent found")
        }
    }
     catch (e) {
        alert(e.message)
    }
};
const ValidPass = async () => {

    const password = document.querySelector("#password").value;
    const progress = document.querySelector("#prog")
    //name, last_name and email are not defined in ValidPass: where do they come from?
    const user = {
        name,
        last_name,
        email,
        password

    }
    try {
        const response = await fetch('api/Pass', {
            method: 'POST',
            headers: {

                'Content-Type': 'application/json'
            },
            body: JSON.stringify(password)
        });
       

        if (response.ok) {
            const userResponse = await response.json();
            progress.value = userResponse
         
           
            if (userResponse < 3) {

                alert("your password is weak")
            }
            else {
                alert("your password is good")
            }
        }
        else {
            throw Error("your sign is failed")
        }
        

    }
    catch (e) {
        alert(e)


    }
}