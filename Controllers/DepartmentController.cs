using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using DAL;
using BOL;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController : ControllerBase
{
     private readonly ILogger<DepartmentController> _logger;

    public DepartmentController(ILogger<DepartmentController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetDepartments")]
    [EnableCors()]
    public ActionResult<List<Department>> Get(){
        DepartmentManager manager = new DepartmentManager();
       List<Department> mylist=manager.GetallDepartments();
       return mylist;

    }
    [Route("{id}")]
    [HttpGet]
    public ActionResult<Department> GetById(int id){
        DepartmentManager managerr = new DepartmentManager();
        Department dept=new Department();
        dept=managerr.GetbyId(id);
        return dept;
    }
    // [Route("{id}")]
    // [HttpPost]
}

