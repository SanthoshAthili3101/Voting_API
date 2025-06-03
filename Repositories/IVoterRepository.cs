

using VotingAPI.Models;

namespace VotingAPI.Repositories
{
    public interface IVoterRepository
    {
        Task AddVoter(Voter voter);
        Task UpdateVoter(Voter voter);
        Task<IEnumerable<Voter>> GetVoters();
        Task<Voter?> GetVoterById(int id);
        Task<bool> IsVoterExists(string title);
    }
}
