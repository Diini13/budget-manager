using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Expense_Tracker.Models
{
    public class Appuser:IdentityUser
    {
    [StringLength(100)]
    [MaxLength(100)]
    [Required]
    public string? Name { get; set; }

    public string? Address { get; set; }
    
    }
}