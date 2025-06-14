using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BlogUygulaması.Models;

public class AppUserCreate
{
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; } = null!;

    [Required]
    [Display(Name = "AdSoyad")]
    public string AdSoyad { get; set; } = null!;

    [Required]
    [Display(Name = "Parola")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
    
    [Required]
    [Display(Name = "Parola")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Parola Eşleşmiyor")]
    public string ConfirmPassword { get; set; } = null!;    
}