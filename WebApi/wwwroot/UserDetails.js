const title = document.querySelector(".title")
const changedatail = document.querySelector(".changedatail")


const user = sessionStorage.getItem("currentUser")
//In JavaScript, names are written in camelCase: useName
const use_name = JSON.parse(user).name
const use_lname = JSON.parse(user).last_name
const use_email = JSON.parse(user).email
const use_password = JSON.parse(user).password
const id = JSON.parse(user).id
title.textContent = "Hi   " + use_name


const changedatails = () => {
    changedatail.style.display = "block"
    const name3 = document.querySelector("#name")
    const last_name3 = document.querySelector("#last_name")
    const email3 = document.querySelector("#email")
    const password3 = document.querySelector("#password")


    name3.value = use_name
    last_name3.value = use_lname
    email3.value = use_email
    password3.value = use_password

    
}
const Put = async () => {
    const name = document.querySelector("#name").value
    const last_name = document.querySelector("#last_name").value
    const email = document.querySelector("#email").value
    const password = document.querySelector("#password").value
    const user = {
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
      

       
    }
    catch (e) {
        alert(e.message)


    }
}
