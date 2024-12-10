using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigrisTech.Entities.Concrete.JsonTable
{
    public class ContactPageInfo
    {
        [DisplayName("Telefon Numarası")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(13, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")] // +905555555555 // 13 characters
        [MinLength(13, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DisplayName("Adres")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(150, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string Address { get; set; }
        [DisplayName("Hakkımızda Özet")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string About { get; set; }
        [DisplayName("Haritadaki Yerimiz")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(20, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string MapArea { get; set; }
        [DisplayName("Twitter")]
        [MaxLength(250, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(20, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string TwitterLink { get; set; }
        [DisplayName("E-Posta Adresi")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(10, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Facebook")]
        [MaxLength(250, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(20, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string FacebookLink { get; set; }
        [DisplayName("Instagram")]
        [MaxLength(250, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(20, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string InstagramLink { get; set; }
        [DisplayName("LinkedIn")]
        [MaxLength(250, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(20, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string LinkedInLink { get; set; }
        [DisplayName("Youtube")]
        [MaxLength(250, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(20, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string YoutubeLink { get; set; }
        [DisplayName("Tanıtım Videosu")]
        [MaxLength(250, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(20, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string GitHubLink { get; set; }
        [DisplayName("Website")]
        [MaxLength(250, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(20, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        public string WebsiteLink { get; set; }

    }
}
