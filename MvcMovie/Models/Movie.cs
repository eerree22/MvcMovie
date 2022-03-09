using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "電影名稱為必填項目")]
        [StringLength(60,MinimumLength = 3)]
        [Display(Name ="電影名稱")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "請選擇上映日期")]
        [Display(Name = "上映日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$",ErrorMessage = "The first letter is required to be uppercase. White spaces are allowed while numbers, and special characters are not allowed.")]
        [Required(ErrorMessage = "類別為必填項目")]
        [Display(Name = "類別")]
        public string? Genre { get; set; }

        [Range(1,100,ErrorMessage ="售價需為1~100"), DataType(DataType.Currency)]
        [Required(ErrorMessage = "售價為必填項目")]
        [Display(Name = "售價")]
        [Column(TypeName = "decimal(18,2)")]//跟資料庫欄位寬度對齊
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required(ErrorMessage = "分級為必填項目")]
        [Display(Name = "分級")]
        public string? Rating { get; set; }
    }
}
