using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BlogUygulaması.Models;

public class AppUser : IdentityUser<int>
{
    public string AdSoyad { get; set; } = null!;
}