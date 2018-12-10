using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class PointOfInterest
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    //mavigation property, to create a foreing key
    [ForeignKey("CityId")]
    public City City { get; set; }
    public int CityId { get; set; }
}