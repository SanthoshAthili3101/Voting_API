using System.ComponentModel.DataAnnotations;

namespace VotingAPI.Model.Dto
{
    public class VoterCreateModel
    {
        [Required]
        public string Name { get; set; }
    }
}
