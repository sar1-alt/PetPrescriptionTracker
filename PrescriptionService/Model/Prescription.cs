namespace PrescriptionService.Model;

public class Prescription
{
    public int Id { get; set; }
    public int PetId { get; set; }
    public string MedicationName { get; set; } = "";
    public String Dosage { get; set; } = "";
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public String VetName { get; set; } = "";

}