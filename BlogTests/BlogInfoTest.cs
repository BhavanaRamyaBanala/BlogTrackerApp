using BlogLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTests
{
    public class BlogInfoTest
    {
        [Test]
        public void BlogInfo_ValidProperties_PassesValidation()
        {
            var blogInfo = new BlogInfo
            {
                BlogId = 7,
                Title = "RainbowSchoolAzure",
                Subject = "Azure Schhol webapp",
                BlogUrl = "https://github.com/BhavanaRamyaBanala/RainbowSchool_Azure",
                EmpEmailId = "ramya@gmail.com",

            };
        }
    }
}