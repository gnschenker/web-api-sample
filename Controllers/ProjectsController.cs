using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ProjectsController : Controller
    {
        private readonly Project[] _projects = new Project[]
        {
            new Project {id = 1, name = "Pears"},
            new Project {id = 2, name = "Apples"},
            new Project {id = 3, name = "Oranges"},
        };

        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return _projects;
        }

        [HttpGet("{id}")]
        public Project Get(int id)
        {
            return _projects.SingleOrDefault(x => x.id == id);
        }
    }

    public class Project
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
