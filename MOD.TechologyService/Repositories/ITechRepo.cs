using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TechnologyService.Models;
namespace MOD.TechnologyService.Repositories
{
    public interface ITechRepo
    {
        string Add(Technology item);
        string Edit(Technology item);
        IEnumerable<Technology> GetAllTechnologies();

        Technology GetTechnology(string name);
        Technology GetTechnologyById(int id);
    }
}
