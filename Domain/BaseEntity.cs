namespace Domain;
public class BaseEntity
{
    public int Id { get; set; }
    public string User { get; set; }
    public bool isActive { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
}
