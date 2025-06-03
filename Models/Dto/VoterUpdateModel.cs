using System.ComponentModel.DataAnnotations;

namespace VotingAPI.Model.Dto
{
    public class VoterUpdateModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public bool HasVoted { get; set; }
    }
}
