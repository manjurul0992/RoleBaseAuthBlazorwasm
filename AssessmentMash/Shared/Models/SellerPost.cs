using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentMash.Shared.Models
{
    public class SellerPost
    {
        public int SellerPostId { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public string CreatedByUserId { get; set; } = null!;
        [Required]

        public DateTime PostedDate { get; set; }=DateTime.Now;

        [Required]
        public string GSRanking { get; set; } = null!;
    }
}
