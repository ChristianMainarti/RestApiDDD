namespace RestApiModelDDD.Domain.Entitys
{
    public class Product : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float Stock { get; set; }
        public bool Active { get; set; }
    }
}
