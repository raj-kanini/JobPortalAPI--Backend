using System.ComponentModel.DataAnnotations;

namespace Job_Portal_API.Model
{
    public class Job_Description
    {
        [Key]

        public int Id {  get; set; }
        //[Required]
        public string JobTitle {  get; set; }

        public string shortDescription {  get; set; }
        //[Required]
        public string Description { get; set; }
        //[Required]
       // public byte[] JobImage { get; set; }
        //[Required]
        public string Location {  get; set; }
        //[Required]
        public string Ctc{ get; set; }

    }
}
