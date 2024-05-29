using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLDTLesion06.Models
{
    public class NLDTSong
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="NLDT:hay nhap tieu de")]
        [DisplayName("tieu de")]
        public string NLDTTitle { get; set; }
        [Required(ErrorMessage = "NLDT:hay nhap tac gia")]
        public string NLDTAuthor { get; set;}
        [Required(ErrorMessage = "NLDT:hay nhap nghe si")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="ten qua ngan vui long nhap lai")]
        [DisplayName("nghe si")]
        public string NLDTArtist  { get; set; }
        [Required(ErrorMessage ="NLDT:hay nhap nam xuat ban")]
        [RegularExpression(@"[0-9]{4,4}",ErrorMessage ="nam xuat ban phai co 2 ki tu so")]
        [Range(1900,2024,ErrorMessage ="NLDT: nam xuat ban nam trong 1900-1024")]
        [DisplayName("nam xuat ban" )]
        public int NLDTYearRelease { get; set; }
    }
}