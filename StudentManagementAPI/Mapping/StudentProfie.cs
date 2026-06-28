using AutoMapper;
using StudentManagementAPI.Dtos;
using StudentManagementAPI.Entities;

namespace StudentManagementAPI.Mappings
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Student, UpdateStudentDto>().ReverseMap();
        }
    }
}
