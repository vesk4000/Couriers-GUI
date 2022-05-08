namespace Couriers_GUI.Backend.Services.ServiceModels
{
	public class CourierServiceModel
	{
		public CourierServiceModel() { }

		public CourierServiceModel(string name, string phoneNumber)
		{
			Name = name;
			PhoneNumber = phoneNumber;
		}

		public CourierServiceModel(int id, string name, string phoneNumber)
		{
			Id = id;
			Name = name;
			PhoneNumber = phoneNumber;
		}

		public int Id { get; set; }

		public string Name { get; set; }
		
		public string PhoneNumber { get; set; }

		public override string ToString()
		{
			return $"{Id,-3} | {Name,-15} | {PhoneNumber}";
		}
	}
}