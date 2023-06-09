﻿using AutoMapper;
using StudentDetails.Students;

namespace StudentDetails;

public class StudentDetailsApplicationAutoMapperProfile : Profile
{
    public StudentDetailsApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Student, StudentDto>();
        CreateMap<CreateUpdateStudentDto, Student>();
    }
}
