using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogUygulaması.Models;


public class DataContext : IdentityDbContext<AppUser, AppRole, int>
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<WordModel> WordModels { get; set; }
    public DbSet<KonularModel> KonularModel { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<WordModel>().HasData(
            new List<WordModel>
            {
                new WordModel {
                    Id = 1,
                    AnaBaşlık ="Dolar Ve Euro Arasındaki Kapışma",
                    Açıklama ="Lorem ipsum dolor sit, amet consectetur adipisicing elit. Obcaecati praesentium ducimus tenetur impedit qui, dignissimos ea, omnis quisquam deleniti veniam laudantium, exercitationem voluptatem sit commodi. Minima aperiam voluptates, quasi a cumque dolorem, eum repellat rem dicta neque pariatur. Maiores fugiat doloremque placeat, voluptatum nobis repudiandae dolores consequatur dicta ratione non.",
                    MiniAciklama = "Kısa açıklama burada",
                    ResimDosyaAdi = "resim.jpg",
                    Konu = "Finans",
                    DateTime = new DateTime(2025, 5, 22)
                },

                new WordModel {
                    Id = 2,
                    AnaBaşlık ="Doğanın Sorunları",
                    Açıklama ="Lorem ipsum dolor sit, amet consectetur adipisicing elit. Obcaecati praesentium ducimus tenetur impedit qui, dignissimos ea, omnis quisquam deleniti veniam laudantium, exercitationem voluptatem sit commodi. Minima aperiam voluptates, quasi a cumque dolorem, eum repellat rem dicta neque pariatur. Maiores fugiat doloremque placeat, voluptatum nobis repudiandae dolores consequatur dicta ratione non.",
                    MiniAciklama = "Kısa açıklama burada",
                    ResimDosyaAdi = "image.jpg",
                    Konu = "Doğa",
                    DateTime = new DateTime(2025, 5, 22)
                },

                new WordModel {
                    Id = 3,
                    AnaBaşlık ="İntel Ve Amd Arasındaki Savaş",
                    Açıklama ="Lorem ipsum dolor sit, amet consectetur adipisicing elit. Obcaecati praesentium ducimus tenetur impedit qui, dignissimos ea, omnis quisquam deleniti veniam laudantium, exercitationem voluptatem sit commodi. Minima aperiam voluptates, quasi a cumque dolorem, eum repellat rem dicta neque pariatur. Maiores fugiat doloremque placeat, voluptatum nobis repudiandae dolores consequatur dicta ratione non.",
                    MiniAciklama = "Kısa açıklama burada",
                    ResimDosyaAdi = "resim.jpg",
                    Konu = "Finans",
                    DateTime = new DateTime(2025, 5, 22)
                },

                new WordModel {
                    Id = 4,
                    AnaBaşlık ="Trafik Cezalarındaki Artış",
                    Açıklama ="Lorem ipsum dolor sit, amet consectetur adipisicing elit. Obcaecati praesentium ducimus tenetur impedit qui, dignissimos ea, omnis quisquam deleniti veniam laudantium, exercitationem voluptatem sit commodi. Minima aperiam voluptates, quasi a cumque dolorem, eum repellat rem dicta neque pariatur. Maiores fugiat doloremque placeat, voluptatum nobis repudiandae dolores consequatur dicta ratione non.",
                    MiniAciklama = "Kısa açıklama burada",
                    ResimDosyaAdi = "resim.jpg",
                    Konu = "Güncel",
                    DateTime = new DateTime(2025, 5, 22)
                }

            }
        );

        modelBuilder.Entity<KonularModel>().HasData(
            new List<KonularModel>
            {
                new KonularModel {
                    Id = 1,
                    Konu = "Finans"
                },

                new KonularModel {
                    Id = 2,
                    Konu = "Yazılım / Programlama"
                },

                new KonularModel {
                    Id = 3,
                    Konu = "Kişisel Gelişim"
                },

                new KonularModel {
                    Id = 4,
                    Konu = "Günlük Yaşam"
                },
                new KonularModel {
                    Id = 5,
                    Konu = "Eğitim"
                },
                new KonularModel {
                    Id = 6,
                    Konu = "Seyahat"
                },
                new KonularModel {
                    Id = 7,
                    Konu = "Sağlık & Fitness"
                },
                new KonularModel {
                    Id = 8,
                    Konu = "Kitap / Film / Dizi İncelemeleri"
                },
                new KonularModel {
                    Id = 9,
                    Konu = "Girişimcilik"
                },
                new KonularModel {
                    Id = 10,
                    Konu = "Bilim"
                },
                new KonularModel {
                    Id = 11,
                    Konu = "Fotoğrafçılık"
                },
                new KonularModel {
                    Id = 12,
                    Konu = "Finans / Ekonomi"
                },
                new KonularModel {
                    Id = 13,
                    Konu = "Moda & Stil"
                },
                new KonularModel {
                    Id = 14,
                    Konu = "Yemek Tarifleri"
                },
            }
        );

    }

}



