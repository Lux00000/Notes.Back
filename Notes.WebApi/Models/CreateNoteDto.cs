using Notes.Application.Notes.Commands.CreateNote;
using Notes.Application.Common.Mappings;
using AutoMapper;
namespace Notes.WebApi.Models
{
    public class CreateNoteDto : IMapWith<CreateNoteCommands>
    {
        public string Title { get; set; }
        public string Details { get; set; }
        public void Mapping(Profile profile) 
        {
            profile.CreateMap<CreateNoteDto, CreateNoteCommands>()
                .ForMember(noteCommand => noteCommand.Title,
                opt => opt.MapFrom(noteDto => noteDto.Title))
                .ForMember(noteCommand => noteCommand.Details,
                opt => opt.MapFrom(noteDto => noteDto.Details));
        }
    }
}
