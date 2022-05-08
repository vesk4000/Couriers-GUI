namespace Couriers_GUI.Backend.Services.ServiceModels
{
    public class TypesOfServiceServiceModel
    {
        public TypesOfServiceServiceModel() { }

        public TypesOfServiceServiceModel(string type)
        {
            Type = type;
        }

        public TypesOfServiceServiceModel(int id, string type) : this(type)
        {
            Id = id;
        }

        public int Id { get; set; }

        public string Type { get; set; }

		public override string ToString()
		{
            return $"{Id,-3} | {Type}";
		}
	}
}