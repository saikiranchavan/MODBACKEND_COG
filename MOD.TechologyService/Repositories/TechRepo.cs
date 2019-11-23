using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TechnologyService.Models;
using MOD.TechnologyService.Context;
namespace MOD.TechnologyService.Repositories
{
    public class TechRepo : ITechRepo
    {
        TechnologyService.Context.TechnologyContext _context;
        public TechRepo(TechnologyContext techContext)
        {
            _context = techContext;
        }
        public string Add(Technology item)
        {
            _context.Technologies.Add(item);
            _context.SaveChanges();
            return "Technologies Added";
        }

        public string Edit(Technology item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return "Technology Edited";
        }

        public IEnumerable<Technology> GetAllTechnologies()
        {
            return  _context.Technologies;
        }

        public Technology GetTechnology(string name)
        {
            return _context.Technologies.SingleOrDefault(i=>i.TechnologyName.Equals(name));
        }

        public Technology GetTechnologyById(int id)
        {
            return _context.Technologies.SingleOrDefault(i =>i.TechID==id);
        }
    }
}
