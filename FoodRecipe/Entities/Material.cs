namespace FoodRecipe.Entities

{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Reciepe> Reciepes { get; set; }
        public List<AlergicMaterial> AlergicMaterials { get; set; }
    }
}
