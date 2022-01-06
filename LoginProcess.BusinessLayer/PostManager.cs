using LoginProcess.DataAccessLayer.Repository;
using LoginProcess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProcess.BusinessLayer
{
    public class PostManager
    {
        Repository<Post> repopost = new Repository<Post>();
        public List<Post> GetPosts()
        {
            return repopost.List();
        }
    }
}
