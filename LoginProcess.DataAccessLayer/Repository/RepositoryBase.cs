using LoginProcess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProcess.DataAccessLayer.Repository
{
    public class RepositoryBase
    {
        protected static LoginProcessDBEntities db;
        private static object obje = new object();
        protected RepositoryBase()
        {
            CreateEntities();
        }

        private static void CreateEntities()
        {
            if (db==null)
            {
                lock (obje)
                {
                    db = new LoginProcessDBEntities();
                }
            }
        }
    }
}
