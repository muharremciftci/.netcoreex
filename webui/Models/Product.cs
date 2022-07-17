using System.ComponentModel.DataAnnotations;

namespace webui.Models
{
    public class Product
    {
        public int ProductId {get;set;}

        [Required(ErrorMessage="This field needs a value!")]      
        
        [StringLength(200,MinimumLength =10)]
        
        public string Name {get;set;}
        
        [Required(ErrorMessage ="Fiyat Girmelisiniz")]
        [Range(1,50000)]
        public double Price {get;set;}

        public string Description {get;set;}

        [Required]
        public string ImageUrl {get;set;}

        public bool IsApproved {get;set;}

        [Required]
        public int? CategoryId {get;set;}
        


    }
}