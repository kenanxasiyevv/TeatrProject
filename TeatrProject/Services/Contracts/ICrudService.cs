using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatrProject.Models;

namespace TeatrProject.Services.Contracts
{
    internal interface ICrudService
    {
        void Add(Entity entity);
        void Delete(int id);
        void Update(int id, Entity entity);
        Entity Get(int id);
    }
}
