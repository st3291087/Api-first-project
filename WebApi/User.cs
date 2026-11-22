using System.ComponentModel.DataAnnotations;

namespace WebApi
{
    public class User
    {
        //In C#, public properties are written in PascalCase: Id. The data file stores the current names: if you rename them, set PropertyNameCaseInsensitive = true in the JsonSerializerOptions, so the existing file still loads
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
