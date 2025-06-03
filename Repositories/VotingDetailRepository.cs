using Microsoft.EntityFrameworkCore;
using VotingAPI.Models;

namespace VotingAPI.Repositories
{
    public class VotingDetailRepository : Repository<VotingDetail>, IVotingDetailRepository
    {
        public VotingDetailRepository(VotingDbContext context)
            : base(context)
        {

        }

        private VotingDbContext DbContext => Context as VotingDbContext;

        public async Task VoteCandidate(VotingDetail votingDetail)
        {
            await AddAsync(votingDetail).ConfigureAwait(false);
        }

        public async Task<bool> ValidateVote(VotingDetail votingDetail)
        {
            return await DbContext.VotingDetail.AnyAsync(m => m.VoterId == votingDetail.VoterId && m.CandidateId == votingDetail.CandidateId).ConfigureAwait(false);
        }
    }
}
