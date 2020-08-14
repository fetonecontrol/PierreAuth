namespace PierreAuth.Models
{
  public class FlavorTreat
  {
    public int FlavorTreatId {get;set;}
    public int FlavortId {get;set;}
    public int TreatId {get;set;}
    public Flavor Flavor {get; set;}
    public Treat Treat {get;set;}
  }
}