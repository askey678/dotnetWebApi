using BOL;

namespace DAL;

public class DepartmentManager:IDmanager{
    public void Delete(int id){
        using(var context = new CollectionContext()){
            context.Departments.Remove(context.Departments.Find(id));
            context.SaveChanges();

        }

    
    }
    public List<Department> GetallDepartments(){
        {
            using (var context = new CollectionContext())
            {
                var departments=from dept in context.Departments select dept;
                return departments.ToList<Department>();
            }
        }
    }

    public Department GetbyId(int id)
    {
        using(var context = new CollectionContext())
        {
            var dept = context.Departments.Find(id);
            return dept;
        }
    }
    public void Insert(Department dept){
        using(var context = new CollectionContext())
        {
            context.Departments.Add(dept);
            context.SaveChanges();
        }
    }

    public void Update(Department dept){
        using ( var context = new CollectionContext()){

            var theDept = context.Departments.Find(dept.id);
            theDept.d_no=dept.d_no;
            theDept.d_name=dept.d_name;
            theDept.balance=dept.balance;
        }
    }
}