using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Pages.Models
{
    public class CategoryData
    {
        public string Category { get; set; }

        public CategoryData(string category)
        {
            this.Category = category;
        }
    }
}
