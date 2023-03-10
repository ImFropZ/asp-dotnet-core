using System.ComponentModel.DataAnnotations;

namespace tutorial_web.Models
{
    public class Jokes
    {
        [Required(ErrorMessage = "ID is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "JokeQuestion is required")]
        public string JokeQuestion { get; set; }

        [Required(ErrorMessage = "JokeAnswer is required")]
        public string JokeAnswer { get; set; }

        public Jokes()
        {
            
        }
    }
}
