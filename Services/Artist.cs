using Adonet.Abstraction;
using Adonet.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet.Services
{
    internal class Artist : IService<Artist>
    {
        public void Add(Artist model)
        {
            Sql.ExecCommand($"Insert into Artists (N'{model.Name}', N'{model.Surname},N'{model.Birthday},N'{model.Gender})");
        }

        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE Artists Where Id= {id}");
        }


        public List<Artist> GetAll()
        {
           DataTable dt = Sql.ExecQuery("SELECT  * FROM Artists");
            return dt;
        }
    }
}
