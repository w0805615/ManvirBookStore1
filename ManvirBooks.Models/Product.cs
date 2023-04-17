using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ManvirBooks.Models
{
    public class Product
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        
        public string Description { get; set; }
        [Required] 
        public string ISBN { get; set; }
        
        [Required]
        public string Author { get; set; }
        
        [Range(1, 10000)]
        public double ListPrice { get; set; }
        public string ImageUrl { get; set; }
       
        public int CategoryId { get; set; } // foreign key reference
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
      
        public int CoverTypeId { get; set; } // foreign key reference
        [ForeignKey("CategoryId")]
        public CoverType CoverType { get; set; }
    }
}