using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Category_Name { get; set; }
        public int Category_parentId { get; set; }
        public string Category_Title { get; set; }
        public bool IsActive { get; set; }
    }
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pr_Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price{get; set; }
        public bool IsActive { get; set; }
    }
}
