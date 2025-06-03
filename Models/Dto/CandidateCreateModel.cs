using System.ComponentModel.DataAnnotations;

namespace VotingAPI.Model.Dto
{
    public class CandidateCreateModel
    {
        [Required]
        public string Name { get; set; }
    }
}
