using System.ComponentModel.DataAnnotations;

namespace GtRacingNews.ViewModels.Race
{
    public class AddNewRaceFormModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "The name must be less than 50 symbols!")]
        public string Name { get; set; }

        [Required]
        public string Date { get; set; }
        public string ChampionshipName { get; set; }
        public ICollection<Data.DataModels.SqlModels.Championship> Championships { get; set; } = new List<Data.DataModels.SqlModels.Championship>();
    }
}
