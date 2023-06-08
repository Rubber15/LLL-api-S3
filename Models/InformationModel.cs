using System.ComponentModel.DataAnnotations;

namespace LLL_api.Models
{
    public class InformationModel
    {
        [Key]
        public int InfromationID { get; set; }

        [Required]
        public string Information { get; set; }

        // Add more properties as needed
    }
}