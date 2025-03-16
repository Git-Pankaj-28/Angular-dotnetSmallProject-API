using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enquiry.API.Model
{
    //3  added this table
    public class EnquiryStatus
    {
        // as we have already created Db so that using DatabseGenerated option here
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StatusId {  get; set; }

        public string Status {  get; set; } = string.Empty;
    }
}
