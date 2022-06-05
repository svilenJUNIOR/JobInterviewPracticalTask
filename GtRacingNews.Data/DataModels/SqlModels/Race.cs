using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace GtRacingNews.Data.DataModels.SqlModels
{
    public class Race
    {
        public Race(string Name, string Date, string championshipId)
        {
            this.Name = Name;
            this.Date = Date;
            this.ChampionshipId = championshipId;
        }
        [Key]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Date { get; set; }
        public string? UserId { get; set; }
        public string?  ChampionshipId { get; set; }
    }
}
