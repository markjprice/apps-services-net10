﻿using Microsoft.AspNetCore.Mvc; // To use IActionResult.
using Microsoft.AspNetCore.OData.Query; // To use [EnableQuery].
using Microsoft.AspNetCore.OData.Routing.Controllers; // To use ODataController.
using Northwind.EntityModels; // To use NorthwindContext.

namespace Northwind.OData.Services.Controllers;

public class SuppliersController : ODataController
{
  protected readonly NorthwindContext db;

  public SuppliersController(NorthwindContext db)
  {
    this.db = db;
  }

  [EnableQuery]
  public IActionResult Get()
  {
    return Ok(db.Suppliers);
  }

  [EnableQuery]
  public IActionResult Get(int key)
  {
    return Ok(db.Suppliers.Where(
      supplier => supplier.SupplierId == key));
  }
}
