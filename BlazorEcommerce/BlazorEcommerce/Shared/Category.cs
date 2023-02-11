using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; } = String.Empty;
        public String Url { get; set; } = String.Empty;
    }
}
