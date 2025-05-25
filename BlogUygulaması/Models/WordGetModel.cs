using System.ComponentModel.DataAnnotations;

namespace BlogUygulaması.Models;

public class WordGetModel
{
    public int Id { get; set; }
    public string Resim { get; set; }
    public string Konu { get; set; } = null!;
    public DateTime DateTime { get; set; }
    public string AnaBaşlık { get; set; } = null!;
    public string Açıklama { get; set; } = null!;

}

