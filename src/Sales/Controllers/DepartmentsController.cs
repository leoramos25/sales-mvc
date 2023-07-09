using Microsoft.AspNetCore.Mvc;
using Sales.Models;

namespace Sales.Controllers;

public class DepartmentsController : Controller
{
    private readonly ILogger<DepartmentsController> _logger;

    public DepartmentsController(ILogger<DepartmentsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Department> departments = new List<Department>();
        departments.Add(new Department {Id = 1, Name = "Eletronics"});
        departments.Add(new Department {Id = 2, Name = "Fashion"});

        return View(departments);
    }
}