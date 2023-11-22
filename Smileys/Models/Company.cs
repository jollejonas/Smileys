using System.ComponentModel.DataAnnotations;

namespace Smileys.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public int CVR {  get; set; }
        [Required]
        public string Name {  get; set; }
        [Required]
        public string Address {  get; set; }
        public string? CurrentSmileyUrl { get; set; }
        public string? PreviousSmiley1Url { get; set; }
        public string? PreviousSmiley2Urls { get; set; }
        public string? PreviousSmiley3Urls {  get; set; }

    }
}
