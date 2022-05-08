using Couriers_GUI.Backend.Services.Interfaces;

namespace Couriers_GUI.Backend.Services.ServiceModels
{
    public class AddressServiceModel
    {
        public AddressServiceModel () { }

        public AddressServiceModel(string addressText)
        {
            AddressText = addressText;
        }

        public AddressServiceModel(int id, string addressText) : this(addressText)
        {
            Id = id;
        }

        public int Id { get; set; }

        public string AddressText { get; set; }

		public override string ToString()
		{
            return $"{this.Id,-3} | {this.AddressText}";
		}
	}
}