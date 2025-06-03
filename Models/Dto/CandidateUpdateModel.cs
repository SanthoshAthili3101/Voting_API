using System.ComponentModel.DataAnnotations;

namespace VotingAPI.Model.Dto
{
    public class CandidateUpdateModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Votes { get; set; }
    }
}
