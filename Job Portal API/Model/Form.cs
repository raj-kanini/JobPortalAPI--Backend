using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Job_Portal_API.Model
{
    public class Form
    {
        [Key]

        public int CandidateId { get; set; }
        //[Required]
        public string Name { get; set; }
        //[Required]
        public string EmailAddress { get; set; }
        //[Required]
        public string Experience { get; set; }
        //[Required]
        public string About { get; set; }

        public string pdf {  get; set; }
        public string location { get; set; }

        // [ForeignKey("Job_Description")]
        //  public int jobId { get; set; }  
        //public ICollection<Form> forms { get; set; }
    }
}
