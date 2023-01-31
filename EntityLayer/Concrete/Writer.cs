using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; } // Yazar Adı
        [StringLength(50)]

        public string WriterSurName { get; set; } // Yazar Soyadı
        [StringLength(100)]

        public string WriterImage { get; set; }// Yazar Görseli
        [StringLength(50)]

        public string WriterMail { get; set; }// Yazar Mail
        [StringLength(20)]

        public string WriterPassword { get; set; }// Yazar Şifre 
        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }

    }
}
