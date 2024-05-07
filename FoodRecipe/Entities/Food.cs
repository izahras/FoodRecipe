namespace FoodRecipe.Entities
{
    public class Food
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public int Type { get; set; }
       public List<Reciepe> Reciepes { get; set; }
    }
}
