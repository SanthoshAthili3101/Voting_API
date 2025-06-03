

using VotingAPI.Models;

namespace VotingAPI.Repositories
{
    public interface IVotingDetailRepository
    {
        Task VoteCandidate(VotingDetail votingDetail);
        Task<bool> ValidateVote(VotingDetail votingDetail);
    }
}
