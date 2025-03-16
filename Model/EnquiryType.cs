using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enquiry.API.Model
{
    // 4 . added this table
    public class EnquiryType
    {
        // as we have already created Db so that using DatabseGenerated option here
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Typeid {  get; set; }
        public string Typename {  get; set; }=string.Empty;
    }
}
