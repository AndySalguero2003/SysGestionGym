using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysGestionGym.EntidadesDeNegocio;

public partial class Usuario
{
    [Key]
    public int IdUsuario { get; set; }

    public int IdRol { get; set; }

    [StringLength(30)]
  
    public string Nombre { get; set; } = null!;

    [StringLength(30)]
   
    public string Apellido { get; set; } = null!;

    [InverseProperty("IdUsuario")]
    public virtual List<Pago> Pago { get; set; } = new List<Pago>();
}
