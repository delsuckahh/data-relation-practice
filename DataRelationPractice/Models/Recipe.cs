using Microsoft.AspNetCore.Identity;

namespace DataRelationPractice.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public IdentityUser User { get; set; }

    }
}
