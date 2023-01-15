using BOL;
namespace DAL;

public interface IDmanager{
    List<Department> GetallDepartments();
    Department GetbyId(int id);
    void Insert(Department dept);
    void Update(Department dept);
    void Delete(int id);
}