using System.ComponentModel.DataAnnotations;

namespace BlazorDogShowWebApp.Models
{
	public class Trainers
	{
		[Required, Range(1000, int.MaxValue, ErrorMessage = "Enter an ID greater than 1000")]
		public int TrainerID { get; set; }
		[Required(ErrorMessage = "Please enter the Trainers Name")]
		public string TrainerName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter the Dog's Name")]
        public string DogName { get; set; } = string.Empty;
		public string Bio { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please submit a trainer photo")]
        public string Image { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please select the Dog's breed")]
        public int BreedId { get; set; } = 1;

	}
}