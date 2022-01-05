using LoginProcess.DataAccessLayer.Repository;
using LoginProcess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProcess.BusinessLayer.Test
{
    public class Test
    {
        Repository<Tag> repotag = new Repository<Tag>();
        Repository<SocialMediaUser> repouser = new Repository<SocialMediaUser>();
        Repository<Post> repopost = new Repository<Post>();
        Repository<Comment> repocomment = new Repository<Comment>();
        public void List()
        {
            List<Tag> liste = repotag.List();
        }
        
        public void CommentTest()
        {
            SocialMediaUser user = repouser.Find(x => x.Id == 1);
            Post post = repopost.Find(x => x.Id == 1);
            Comment com = new Comment()
            {
                Text = "Yorum",
                CreatedTime = DateTime.Now,
                ModifyTime = DateTime.Now,
                ModifyUsername = "Admin",
                Post = null,
                SocialMediaUser = null
            };
            repocomment.Insert(com);
        }
    }
}
