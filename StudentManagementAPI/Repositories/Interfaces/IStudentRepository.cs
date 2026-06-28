using StudentManagementAPI.Entities;

namespace StudentManagementAPI.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync();
        Task<Student?> GetByIdAsync(int id);
        Task AddAsync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(int id);
        Task UpdateAsync(Task<Student?> student);
    }
}
