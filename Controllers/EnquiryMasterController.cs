using Enquiry.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace Enquiry.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowCors")]  // enabled the cors with policy name 
    public class EnquiryMasterController : ControllerBase
    {
        // 7 adding instance of Dbcontext class

        private readonly EnquiryDbContext _context;

        public EnquiryMasterController(EnquiryDbContext context)
        {
            _context = context;
        }


        // 8 now creating CRUD operations  
        [HttpGet("GetAllStatus")]
        public List<EnquiryStatus> GetEnquiryStatuses()
        {
            var list = _context.EnquiryStatus.ToList();
            return list;
        }
        [HttpGet("GetAllTypes")]
        public List<EnquiryType> GetEnquiryTypes()
        {
            var list =_context.EnquiryType.ToList();
            return list;
        }
        [HttpGet("GetAllEnquries")]
        public List<EnquiryModel> GetAllEnquiry() { 
            var list=_context.EnquiryModel.ToList();
            return list;
        }
        [HttpPost("CreateNewEnquiry")]
        public EnquiryModel AddNewEnquiry(EnquiryModel obj)
        {
             obj.CreatedDate = DateTime.Now;
            _context.EnquiryModel.Add(obj);
            _context.SaveChanges();
            return obj;

        }
        [HttpPut("UpdateEnquiry")]
        public EnquiryModel Update(EnquiryModel obj)
        {
            var record= _context.EnquiryModel.SingleOrDefault(m=>m.EnquiryId==obj.EnquiryId);
            if(record != null)
            {
                record.Resolution = obj.Resolution;
                record.EnquiryStatusId=obj.EnquiryStatusId;
                _context.SaveChanges();
            }
            return obj;
        }
        [HttpDelete("DeleteById")]
        public bool  Delete(int id)
        {
            var record=_context.EnquiryModel.SingleOrDefault(m=>m.EnquiryId == id);
            if(record != null)
            {
                _context.Remove(record);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
