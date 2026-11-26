const progress = document.querySelector("progress")
const title = document.querySelector(".title")
const changedatail = document.querySelector(".changedatail")


const user = sessionStorage.getItem("currentUser")
const use_name = JSON.parse(user).name
const use_lname = JSON.parse(user).last_name
const use_email = JSON.parse(user).email
const use_password = JSON.parse(user).password
const id = JSON.parse(user).id
title.textContent = "Hi   " + use_name


const changedatails = () => {
    changedatail.style.display = "block"
    const name3 = document.querySelector("#firstName")
    const last_name3 = document.querySelector("#lastName")
    const email3 = document.querySelector("#email")
    const password3 = document.querySelector("#password")


    name3.value = use_name
    last_name3.value = use_lname
    email3.value = use_email
    password3.value = use_password

    
}
const Put = async () => {
  
    const name = document.querySelector("#firstName").value
    const last_name = document.querySelector("#lastName").value
    const email = document.querySelector("#email").value
    const password = document.querySelector("#password").value
    const user = {
        id:id,
        name,
        last_name,
        email,
        password
      

    }
    try {
        const response = await fetch(`api/Users/${id}`, {
            method: 'PUT',
            headers: {

                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        });
      
        if (response.ok) {

            alert("you changes are succside")

        }
        else {
            throw Error("your changes was failed");

        }
       
    }
    catch (e) {
        alert(e.message)


    }
}
 const ValidPass = async () => {

     const password = document.querySelector("#password").value;
     //const progress = document.querySelector("#prog")

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


             if (userResponse < 2) {

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
         alert(e.message)


     }
 }