using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KTM_WebTM_NguyễnTrungNguyên.CONGNGHE
{
    public class congnghe
    {
        [ScaffoldColumn(false)]
        public int TenID { get; set; }
        [Required, System.ComponentModel.DataAnnotations.StringLength(100), Display(Name = "Tên")]
        public string NOIDUNG { get; set; }
        [Required, StringLength(1000), Display(Name = "congnghe Description"),
        DataType(DataType.MultilineText)]
        public string NGAYGUI { get; set; }
   
        public int? TACGIAID { get; set; }
        public virtual congnghe Category { get; set; }
    }
}