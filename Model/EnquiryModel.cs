using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enquiry.API.Model
{
    // 5 created this model next go back DbContext file and configure DBset there


    // As here we have used the Enquirymodel as model name which is not exactly as table name so for that we can use this table attribute to mapp it to correct Table of DB
    [Table("Enquiry")]
    public class EnquiryModel
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnquiryId { get; set; }
        public int EnquiryTypeId { get; set; } 
        public int EnquiryStatusId { get; set; }

        public string CustomerName { get; set; } = string.Empty;
        public string MobileNo { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; }
        
        public string Message { get; set; } = string.Empty;

        public string Resolution {  get; set; } = string.Empty;


    }
}
