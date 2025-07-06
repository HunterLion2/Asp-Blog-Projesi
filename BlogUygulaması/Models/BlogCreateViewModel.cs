using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BlogUygulaması.Models;
public class BlogCreateViewModel
{
    public WordModel Word { get; set; }

    [BindNever]
    public List<KonularModel> KonularList { get; set; }
}