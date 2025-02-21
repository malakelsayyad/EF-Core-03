﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore; 

namespace DB_First.Models;

[Keyless]
public partial class ProductsAboveAveragePrice
{
    [Required]
    [StringLength(40)]
    public string ProductName { get; set; }

    [Column(TypeName = "money")]
    public decimal? UnitPrice { get; set; }
}