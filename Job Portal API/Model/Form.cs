using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Job_Portal_API.Model
{
    public class Form
    {
        [Key]

        public int CandidateId { get; set; }

        // [Required]
        // Candidate's Name
        public string Name { get; set; }

        //[Required]
        // Candidate's Email Address
        public string EmailAddress { get; set; }

        //[Required]
        // Candidate's Years of Experience
        public string Experience { get; set; }

        //[Required]
        // Additional Information About the Candidate
        public string About { get; set; }

        // Resume or PDF Attachment
        public string pdf {  get; set; }

        // Candidate's Preferred Work Location (e.g., remote, onsite)
        public string location { get; set; }

        // [ForeignKey("Job_Description")]
        // public int jobId { get; set; }  
        // public ICollection<Form> forms { get; set; }
    }
}
