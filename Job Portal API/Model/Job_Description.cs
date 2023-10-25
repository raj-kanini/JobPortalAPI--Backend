using System.ComponentModel.DataAnnotations;

namespace Job_Portal_API.Model
{
    public class Job_Description
    {
        [Key]

        public int Id {  get; set; }

        //[Required]
        // Job Title
        public string JobTitle {  get; set; }

        // Short Job Description
        public string shortDescription {  get; set; }

        //[Required]
        // Detailed Job Description
        public string Description { get; set; }

        // [Required]
        // public byte[] JobImage { get; set; }

        //[Required]
        // Location of the Job
        public string Location {  get; set; }

        //[Required]
        // Compensation (CTC - Cost to Company)
        public string Ctc{ get; set; }

    }
}
