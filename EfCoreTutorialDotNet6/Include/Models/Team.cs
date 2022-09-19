namespace EfCoreTutorialDotNet6.Include.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }=String.Empty;
        public int ComicId { get; set; }
        public List<SuperHero> SuperHeroes { get; set; }=new List<SuperHero>();
    }
}
