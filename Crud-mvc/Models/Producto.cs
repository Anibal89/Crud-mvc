using System;
using System.Collections.Generic;

namespace Crud_mvc.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? NombreProducto { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public int? Cantidad { get; set; }
}
