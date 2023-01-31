using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]

        public int ContactID { get; set; }
        [StringLength(50)]

        public string UserName { get; set; } // Kullanıcı isim
        [StringLength(50)]

        public string UserMail { get; set; } // Kullanıcı mail
        [StringLength(50)]

        public string Subject { get; set; } // Kullanıcı konu

        public string Message { get; set; } // Kullanıcı mesaj
    }
}
