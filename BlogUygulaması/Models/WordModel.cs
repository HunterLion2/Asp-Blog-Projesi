using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogUygulaması.Models;

public class WordModel
{
    public int Id { get; set; }

    [Display(Name = "Resim")]
    [NotMapped]
    public IFormFile Resim { get; set; } = null!;
    public string? ResimDosyaAdi { get; set; }

    public int KonularId { get; set; }
    
    [Display(Name = "Konu")]
    public KonularModel? Konular { get; set; } = null!;

    [Required]
    [Display(Name = "DateTime")]
    public DateTime DateTime { get; set; }

    [Required]
    [Display(Name = "AnaBaşlık")]
    public string AnaBaşlık { get; set; } = null!;

    [Required]
    [Display(Name = "Açıklama")]
    public string Açıklama { get; set; } = null!;

    [Required]
    [Display(Name = "MiniAciklama")]
    public string MiniAciklama { get; set; } = null!;

}

