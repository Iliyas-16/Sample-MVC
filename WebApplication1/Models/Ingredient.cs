using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Models;

public partial class Ingredient
{
    [Key]
    public int Id { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Name { get; set; }
}
