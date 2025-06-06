﻿

using VotingAPI.Models;

namespace VotingAPI.Repositories
{
    public interface ICandidateRepository
    {
        Task AddCandidate(Candidate candidate);
        Task UpdateCandidate(Candidate candidate);
        Task<IEnumerable<Candidate>> GetCandidates();
        Task<Candidate?> GetCandidateById(int id);
        Task<bool> IsCandidateExists(string title);
    }
}
