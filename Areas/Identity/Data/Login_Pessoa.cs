using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Login_TESTE_02.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Login_Pessoa class
public class Login_Pessoa : IdentityUser
{
    [Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(50)")]
    public string? Nome { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(50)")]
    public string? Sobrenome { get; set; }
}

