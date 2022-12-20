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
    internal class Music : IService<Music>
    {
        

        public void Add(Music model)
        {
            Sql.ExecCommand($"Insert into Musics (N'{model.Name}', N'{model.Duration})");
        }

        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE Musics Where Id= {id}");
        }

        public List<Music> GetAll()
        {
           DataTable dt= Sql.ExecQuery("SELECT  * FROM Musics");
            return dt;
        }
    }
}
