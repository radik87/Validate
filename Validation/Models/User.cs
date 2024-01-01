using System.ComponentModel.DataAnnotations;

namespace Validation.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [StringLength(8)]
        public string Passport { get; set; }

        [StringLength(10)]
        public string? Rnokpp { get; set; }

        public DateTime BirthDate { get; set; }

        public string? DeviceOsName { get; set; }

        public Guid? DeviceId { get; set; }
    }
}
