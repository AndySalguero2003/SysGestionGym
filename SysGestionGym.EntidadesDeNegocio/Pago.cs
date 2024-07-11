using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysGestionGym.EntidadesDeNegocio;

public partial class Pago
{
    [Key]

    public int IdPago { get; set; }
    [ForeignKey("IdUsuario")]
    public int IdUsuario { get; set; }
    [ForeignKey("IdMembresia")]
    public int IdMembresia { get; set; }
    [ForeignKey("IdCliente")]
    public int IdCliente { get; set; }

    public DateOnly FechaPago { get; set; }

    public DateOnly FechaCaducidad { get; set; }

  
    [InverseProperty("Pago")]
    public  Cliente Cliente { get; set; } = null!;

   
    [InverseProperty("Pago")]
    public  Membresia Membresia { get; set; } = null!;

 
    [InverseProperty("Pago")]
    public  Usuario Usuario { get; set; } = null!;
}
