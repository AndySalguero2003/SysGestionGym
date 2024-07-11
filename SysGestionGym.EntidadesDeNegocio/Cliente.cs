using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysGestionGym.EntidadesDeNegocio;

public partial class Cliente
{
    [Key]
    public int IdCliente { get; set; }

    [StringLength(30)]
   
    public string Nombre { get; set; } = null!;

    [StringLength(30)]
 
    public string Apellido { get; set; } = null!;

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Peso { get; set; }

    public int Altura { get; set; }

    public DateOnly FechaRegistro { get; set; }

    [InverseProperty("Cliente")]
    public  List<Pago> Pago { get; set; } = new List<Pago>();
}
