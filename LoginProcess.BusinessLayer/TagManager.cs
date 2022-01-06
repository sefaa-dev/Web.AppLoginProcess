using LoginProcess.DataAccessLayer.Repository;
using LoginProcess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProcess.BusinessLayer
{
    public class TagManager
    {
        Repository<Tag> repotag = new Repository<Tag>();
        public List<Tag> GetTag()
        {
            return repotag.List();
        }
        public Tag GetTag(int id)
        {
            return repotag.Find(x => x.Id == id);
        }
    }
}
