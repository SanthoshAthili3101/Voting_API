namespace VotingAPI.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<VotingDetail> VotesReceived { get; set; }
    }
}
