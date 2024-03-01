using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BlogLib
{
    internal class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<AdminInfo> adminInfos = new List<AdminInfo>();

            adminInfos.Add(new AdminInfo() { Email = "banala@gamil.com", Password = "banala@123" });
            adminInfos.Add(new AdminInfo() { Email = "satya@gmail.com", Password = "satya@123" });

            context.AdminInfos.AddRange(adminInfos);
            context.SaveChanges();

            List<EmpInfo> empInfos = new List<EmpInfo>();
            empInfos.Add(new EmpInfo() { Email = "ramya@gmail.com", PassCode = 47955, DateOfJoining = new DateTime(2020, 08, 05), Name = "ramya" });
            empInfos.Add(new EmpInfo() { Email = "mallika@gmail.com", PassCode = 5294, DateOfJoining = new DateTime(2019, 10, 25), Name = "mallika" });
            empInfos.Add(new EmpInfo() { Email = "henry@gmail.com", PassCode = 8315, DateOfJoining = new DateTime(2020, 11, 05), Name = "henry" });
            context.EmpInfos.AddRange(empInfos);
            context.SaveChanges();

            List<BlogInfo> blogInfos = new List<BlogInfo>();
            blogInfos.Add(new BlogInfo() { EmpEmailId = "mani@gmail.com", BlogUrl = "https://www.hostinger.in/tutorials/how-to-start-a-food-blog", DateOfCreation = new DateTime(2022, 10, 5), Subject = "Food", Title = "Food blog" });
            blogInfos.Add(new BlogInfo() { EmpEmailId = "purnima@gmail.com", BlogUrl = "https://makeawebsitehub.com/examples-of-blogs/", DateOfCreation = new DateTime(2024, 1, 12), Subject = "Blogs", Title = "Blog website" });
            context.BlogInfos.AddRange(blogInfos);
            context.SaveChanges();

            base.Seed(context);

        }
    }
}
