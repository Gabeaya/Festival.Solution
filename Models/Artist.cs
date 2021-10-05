namespace Festival.Models
{
  public class Artist
  {
    public int ArtistId { get; set; }
    public string Name { get; set; }
    public string SetList { get; set; }
    public bool OverTwentyOne { get; set; }
    public int StageId { get; set; }
  }
}