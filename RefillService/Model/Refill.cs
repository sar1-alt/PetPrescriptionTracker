namespace RefillService.Model;
public class Refill
{
    public int Id {get; set; }
    public int PrescriptionId {get; set;}
    public DateTime RefillDate {get; set;}
}