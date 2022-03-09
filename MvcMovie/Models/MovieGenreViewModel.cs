using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set; }//下拉選單中的電影類別
        public string? MovieGenre { get; set; }//USER選的電影類別
        public string? SearchString { get; set; }//USER輸入的電影名稱
    }
}
