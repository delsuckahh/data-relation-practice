using Microsoft.AspNetCore.Identity;

namespace DataRelationPractice.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }

    public class ApplicationUser : IdentityUser
    {
    }
}
