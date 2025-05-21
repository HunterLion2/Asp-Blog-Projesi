namespace BlogUygulaması.Models;

public class WordModel
{
    public int Id { get; set; }
    public string Resim { get; set; } = null!;
    public DateTime DateTime { get; set; }
    public string AnaBaşlık { get; set; } = null!;
    public string Açıklama { get; set; } = null!;

}

