using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;
public class BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public bool isActive { get; set; }
    public string CreatedUser { get; set; }
    public DateTime CreateDate { get; set; }
    public string UpdatedUser { get; set; }
    public DateTime UpdateDate { get; set; }
}
