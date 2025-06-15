using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotnet_store.Models;

public class AccountLoginModel {

    [Required]
    [Display(Name = "Eposta")]
    [EmailAddress]    
    public string Email { get; set; } = null!;

    [Required]
    [Display(Name = "Parola")]
    [DataType(DataType.Password)] // Bu değer de girilecek data tipinin ne olduğunu belirtiriz.
    public string Password { get; set; } = null!;

    public bool BeniHatirla { get; set; } = true;
}