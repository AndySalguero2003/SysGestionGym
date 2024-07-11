using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysGestionGym.EntidadesDeNegocio;

public partial class Rol
{
    [Key]
    public int IdRol { get; set; }

    [StringLength(30)]
    
    public string DescripcionRol { get; set; } = null!;
}
