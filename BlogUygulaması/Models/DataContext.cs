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
        
        modelBuilder.Entity<KonularModel>().HasData(
            new List<KonularModel>
            {
                new KonularModel {
                    Id = 1,
                    Konu = "Finans",
                    Resim = "/img/category/finans-yonetimi.png"
                },

                new KonularModel {
                    Id = 2,
                    Konu = "Yazılım / Programlama",
                    Resim = "/img/category/hangi_programlama_dili-740x555.jpg"
                },

                new KonularModel {
                    Id = 3,
                    Konu = "Kişisel Gelişim",
                    Resim = "/img/category/indir.jpg"
                },

                new KonularModel {
                    Id = 4,
                    Konu = "Günlük Yaşam",
                    Resim = "/img/category/gunluk.jpg"
                },
                new KonularModel {
                    Id = 5,
                    Konu = "Eğitim",
                    Resim = "/img/category/egitim.jpg"
                },
                new KonularModel {
                    Id = 6,
                    Konu = "Seyahat",
                    Resim = "/img/category/seyahet.jpg"
                },
                new KonularModel {
                    Id = 7,
                    Konu = "Sağlık & Fitness",
                    Resim = "/img/category/saglık.jpg"
                },
                new KonularModel {
                    Id = 8,
                    Konu = "Kitap / Film / Dizi İncelemeleri",
                    Resim = "/img/category/inceleme.jpg"
                },
                new KonularModel {
                    Id = 9,
                    Konu = "Girişimcilik",
                    Resim = "/img/category/girisimcilik.jpg"
                },
                new KonularModel {
                    Id = 10,
                    Konu = "Bilim",
                    Resim = "/img/category/Bilim.jpg"
                },
                new KonularModel {
                    Id = 11,
                    Konu = "Fotoğrafçılık",
                    Resim = "/img/category/fotografcılık.jpg"
                },
                new KonularModel {
                    Id = 12,
                    Konu = "Finans / Ekonomi",
                    Resim = "/img/category/Finans.jpg"
                },
                new KonularModel {
                    Id = 13,
                    Konu = "Moda & Stil",
                    Resim = "/img/category/Moda.jpg"
                },
            }
        );        

        modelBuilder.Entity<WordModel>().HasData(
            new List<WordModel>
            {
                new WordModel {
                    Id = 1,
                    KonularId = 1,
                    AnaBaşlık ="Dolar Ve Euro Arasındaki Kapışma",
                    Açıklama ="Lorem ipsum dolor sit, amet consectetur adipisicing elit. Obcaecati praesentium ducimus tenetur impedit qui, dignissimos ea, omnis quisquam deleniti veniam laudantium, exercitationem voluptatem sit commodi. Minima aperiam voluptates, quasi a cumque dolorem, eum repellat rem dicta neque pariatur. Maiores fugiat doloremque placeat, voluptatum nobis repudiandae dolores consequatur dicta ratione non.",
                    MiniAciklama = "Kısa açıklama burada",
                    ResimDosyaAdi = "resim.jpg",
                    DateTime = new DateTime(2025, 5, 22)
                },
            }
        );



    }

}



