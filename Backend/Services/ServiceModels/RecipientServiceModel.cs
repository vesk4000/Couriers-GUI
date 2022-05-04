namespace Couriers_GUI.Backend.Services.ServiceModels
{
    public class RecipientServiceModel
    {
        public RecipientServiceModel() { }

        public RecipientServiceModel(string name)
        {
            Name = name;
        }

        public RecipientServiceModel(int id, string name) : this(name)
        {
            Id = id;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}