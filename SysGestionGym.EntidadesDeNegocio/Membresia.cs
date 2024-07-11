using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysGestionGym.EntidadesDeNegocio;

public partial class Membresia
{
    [Key]
    public int IdMembresia { get; set; }

    [StringLength(50)]
    
    public string Tipo { get; set; } = null!;

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Precio { get; set; }

    public int DuracionDias { get; set; }

    [InverseProperty("Membresia")]
    public  List<Pago> Pago { get; set; } = new List<Pago>();
}
