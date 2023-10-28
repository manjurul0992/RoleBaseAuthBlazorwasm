using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentMash.Shared.Models
{
    public class BuyerPost
    {
        public int BuyerPostId { get; set; }
        [Required,StringLength(8)]
        public string Title { get; set; } = null!;
        [Required]
        public string GBRanking { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public string CreatedByUserId { get; set; } = null!;
        [Required]
        public DateTime PostedDate { get; set; }=DateTime.Now;  

        
    }
}
