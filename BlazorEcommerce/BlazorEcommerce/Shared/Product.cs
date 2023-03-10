using Framework.Front.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared;

public class Product:ModelBase
{
    public string Title { get; set; } = string.Empty;
    public string Description{ get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    [Column(TypeName ="decimal(18.2)")]
    public decimal Price{ get; set; }

    public Category? Category { get; set; }
    public int CategoryId { get; set; }

}
