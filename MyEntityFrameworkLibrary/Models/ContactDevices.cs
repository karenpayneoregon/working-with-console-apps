#nullable disable
namespace MyEntityFrameworkLibrary.Models
{
    public partial class ContactDevices
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public int? PhoneTypeIdentifier { get; set; }
        public string PhoneNumber { get; set; }

        public virtual Contacts Contact { get; set; }
        public virtual PhoneType PhoneTypeIdentifierNavigation { get; set; }
    }
}