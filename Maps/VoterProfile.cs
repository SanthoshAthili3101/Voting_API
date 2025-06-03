using AutoMapper;
using VotingAPI.Model.Dto;
using VotingAPI.Models;

namespace VotingAPI.Maps
{
    public class VoterProfile : Profile
    {
        public VoterProfile() 
        {
            CreateMap<Voter, VoterViewModel>().ForMember(x=> x.HasVoted, o=> o.MapFrom(opt => opt.VotesCast.Any()));
            CreateMap<VoterUpdateModel, Voter>();
            CreateMap<VoterViewModel, VoterUpdateModel>();
            CreateMap<VoterCreateModel, Voter>();
        }
    }
}
