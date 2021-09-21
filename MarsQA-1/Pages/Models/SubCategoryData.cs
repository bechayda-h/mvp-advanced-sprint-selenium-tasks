using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Pages.Models
{
    public class SubCategoryData
    {
        public string Category { get; set; }
        public string SubCategory { get; set; }

        public SubCategoryData(string category, string subCategory)
        {
            this.Category = category;
            this.SubCategory = subCategory;
        }
    }
}
