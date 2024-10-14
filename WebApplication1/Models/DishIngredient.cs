using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Models;

[Keyless]
public partial class DishIngredient
{
    public int? DishId { get; set; }

    public int? IngredientId { get; set; }

    [ForeignKey("DishId")]
    public virtual Dish? Dish { get; set; }

    [ForeignKey("IngredientId")]
    public virtual Ingredient? Ingredient { get; set; }
}
