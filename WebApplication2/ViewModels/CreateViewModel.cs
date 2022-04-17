using System.ComponentModel.DataAnnotations;
namespace WebApplication2.ViewModels;
public class CreateViewModel
{
    [Required]
    [MaxLength(20, ErrorMessage = "Taille Max 50 cc")]
    public string Name { get; set; }
    public string Department { get; set; }
    [Range(300, 5000, ErrorMessage = "Doit être entre 300 et 5000")]
    public int Salary { get; set; }
    public IFormFile Photo { get; set; }
}

