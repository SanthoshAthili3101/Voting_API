
namespace VotingAPI.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICandidateRepository Candidate { get; }
        IVoterRepository Voter { get; }
        IVotingDetailRepository VotingDetail { get; }
    }
}
