namespace Couriers_GUI.Backend.Services.ServiceModels
{
    public class DispatcherServiceModel
    {
        public DispatcherServiceModel() { }

        public DispatcherServiceModel(string name, string phoneNumber)
        {
            Name = name;

            PhoneNumber = phoneNumber;
        }

        public DispatcherServiceModel(int id, string name, string phoneNumber) : this(name, phoneNumber)
        {
            Id = id;
        }

        public int Id { get; set; }

        public string Name { get; set; }
        
        public string PhoneNumber { get; set; }
    }
}