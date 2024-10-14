using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Models;

[Table("dishes")]
public partial class Dish
{
    [Key]
    public int Id { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ImageUrl { get; set; }

    [Column("price")]
    public int? Price { get; set; }
}
