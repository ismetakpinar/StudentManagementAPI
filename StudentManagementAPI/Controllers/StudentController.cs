using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Dtos;
using StudentManagementAPI.Entities;
using StudentManagementAPI.Repositories.Interfaces;

namespace StudentManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentController(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var student = await _studentRepository.GetAllAsync();
            return Ok(student);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _studentRepository.GetByIdAsync(id);
            if (student == null) return NotFound();

            return Ok(student);
        }
        [HttpPost]
        public async Task<IActionResult> Create(StudentDto dto)
        {
            var student = _mapper.Map<Student>(dto);
            await _studentRepository.AddAsync(student);
            return Ok("Öğrenci Başarıyla Eklendi");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateStudentDto dto)
        {
            var student = _studentRepository.GetByIdAsync(id);

            if (student == null) return NotFound();
            _mapper.Map(dto, student);
            await _studentRepository.UpdateAsync(student);
            return Ok("Güncelleme Başarılı");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _studentRepository.DeleteAsync(id);

            return Ok("Öğrenci Başarıyla Silindi");
        }
    }
}