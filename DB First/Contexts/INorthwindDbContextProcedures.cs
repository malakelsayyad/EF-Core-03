﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using DB_First.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace DB_First.Contexts
{
    public partial interface INorthwindDbContextProcedures
    {
        Task<List<SalesByCategoryResult>> SalesByCategoryAsync(string categoryName, string ordYear, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
