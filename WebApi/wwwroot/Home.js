const progress = document.querySelector("#prog")

const PostData = async () => {

      const FirstName = document.querySelector("#name").value
      const LastName = document.querySelector("#last_name").value
      const Email = document.querySelector("#email").value
      const Password = document.querySelector("#password").value

      const user = {
          FirstName,
          LastName,
          Email,
          Password

      };
      try {
       
          if (progress.value < 3) {
              throw Error("you can't sign in. you have problem with your password")
          }
          else {
              const response = await fetch('api/Users', {
                  method: 'POST',
                  headers: {

                      'Content-Type': 'application/json'
                  },
                  body: JSON.stringify(user)
              }
              );


              if (response.ok) {
                  const userResponse = await response.json();
                  alert("your sign was succesed")
              }
              else {
                  throw Error("your sign was failed")
              }
          }
    }
    catch (e) {
        alert(e.message);
  

    }
      };
async function Login(){
   const email = document.querySelector("#log_email").value
    const password =  document.querySelector("#log_password").value

    const user = {

       email,
       password

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
    //const progress = document.querySelector("#prog")
    //const user = {
    //    name,
    //    last_name,
    //    email,
    //    password

    //}
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
           
        }
        else {
            throw Error("your sign is failed")
        }
        

    }
    catch (e) {
        alert(e)


    }
}