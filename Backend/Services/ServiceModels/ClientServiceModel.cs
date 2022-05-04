namespace Couriers_GUI.Backend.Services.ServiceModels
{
	public class ClientServiceModel
	{
		public ClientServiceModel() { }

		public ClientServiceModel(string name, string phoneNumber)
		{
			Name = name;

			PhoneNumber = phoneNumber;
		}

		public ClientServiceModel(int id, string name, string phoneNumber) : this(name, phoneNumber)
		{
			Id = id;
		}

		public int Id { get; set; }

		public string Name { get; set; }

		public string PhoneNumber { get; set; }
	}
}