using AutoMapper;
using VotingAPI.Model.Dto;
using VotingAPI.Models;
namespace VotingAPI.Maps
{
    public class CandidateProfile : Profile
    {
        public CandidateProfile()
        {
            CreateMap<Candidate, CandidateViewModel>().ForMember(x => x.Votes, o => o.MapFrom(opt => opt.VotesReceived.Count));
            CreateMap<CandidateUpdateModel, Candidate>();
            CreateMap<CandidateViewModel, CandidateUpdateModel>();
            CreateMap<CandidateCreateModel, Candidate>();
        }
    }
}
