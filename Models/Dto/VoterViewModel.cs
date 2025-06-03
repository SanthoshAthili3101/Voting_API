namespace VotingAPI.Model.Dto
{
    public class VoterViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasVoted { get; set; }
    }
}
