namespace PetService.Model;

public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Species { get; set; } = "";
    public string breed { get; set; } = "";
    public DateTime BirthDate {get; set;}
    public string OwnerName {get; set;} = "";

}