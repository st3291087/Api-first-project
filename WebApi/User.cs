using System.ComponentModel.DataAnnotations;

namespace WebApi
{
    public class User
    {
        //In C#, public properties are written in PascalCase (Id). Do not rename them: the stored data uses lowercase names. Tip: PropertyNameCaseInsensitive = true in the JSON options keeps the names.
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
    
    public class LogUsers
    {
        public string logEmail { get; set; }
        public string logPassword { get; set; }
    }
}
