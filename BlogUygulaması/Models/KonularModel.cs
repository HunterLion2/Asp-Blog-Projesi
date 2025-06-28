using System.ComponentModel.DataAnnotations;

namespace BlogUygulaması.Models;

public class KonularModel
{

    [Key]
    public int Id { get; set; }
    public string Konu { get; set; } = null!;
    public string Resim { get; set; } = null!;
}