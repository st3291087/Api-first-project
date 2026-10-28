using System.ComponentModel.DataAnnotations;

namespace WebApi
{
    //In C#, public properties are written in PascalCase without underscores (Id, Name, LastName, Email, Password).
    //If you rename them, file.txt still has the old names, so read it with
    //new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
    public class User
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string last_name { get; set; }
        [Required]

        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }



    }
    
    //In C#, each class goes in its own file, named after the class. LoginUser is a clearer name,
    //and the properties can be just Email and Password
    public class LogUsers
    {
        public string logEmail { get; set; }
        public string logPassword { get; set; }
    }
}
