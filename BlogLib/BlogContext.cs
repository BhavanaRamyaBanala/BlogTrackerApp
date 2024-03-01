using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLib
{
    internal class BlogContext:DbContext
    {
        public BlogContext()
            : base("name=BlogContext")
        {
            Database.SetInitializer<BlogContext>(new BlogInitializer());
        }
        public virtual DbSet<AdminInfo> AdminInfos { get; set; }
        public virtual DbSet<EmpInfo> EmpInfos { get; set; }
        public virtual DbSet<BlogInfo> BlogInfos { get; set; }
    }
}
