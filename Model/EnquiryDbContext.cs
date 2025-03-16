using Microsoft.EntityFrameworkCore;

namespace Enquiry.API.Model
{
    public class EnquiryDbContext :DbContext  // inheritated from Dbcontext 
    {
        // 1 .created constructor with DbContextOptions then add this class to program.cs file 
        public EnquiryDbContext(DbContextOptions<EnquiryDbContext> options):base(options)
        {
            
        }
        // 6 added below DbSet next add new API controller 
        public DbSet<EnquiryModel> EnquiryModel { get; set; }
        public DbSet<EnquiryStatus> EnquiryStatus { get; set; }
        public DbSet<EnquiryType> EnquiryType { get; set; } 

    }
}
