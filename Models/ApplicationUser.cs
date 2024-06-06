using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace gs_net.Models
{
    [Table("Usuarios")]
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public override string Email { get; set; }

        [Required]
        public string JobTitle { get; set; }

        [Required]
        public override string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        public override bool EmailConfirmed { get; set; }

        [Column("EmailConfirmed", TypeName = "NUMBER(1)")]
        public byte EmailConfirmedByte
        {
            get { return (byte)(EmailConfirmed ? 1 : 0); }
            set { EmailConfirmed = (value == 1); }
        }

        [NotMapped]
        public override bool PhoneNumberConfirmed { get; set; }

        [Column("PhoneNumberConfirmed", TypeName = "NUMBER(1)")]
        public byte PhoneNumberConfirmedByte
        {
            get { return (byte)(PhoneNumberConfirmed ? 1 : 0); }
            set { PhoneNumberConfirmed = (value == 1); }
        }

        [NotMapped]
        public override bool TwoFactorEnabled { get; set; }

        [Column("TwoFactorEnabled", TypeName = "NUMBER(1)")]
        public byte TwoFactorEnabledByte
        {
            get { return (byte)(TwoFactorEnabled ? 1 : 0); }
            set { TwoFactorEnabled = (value == 1); }
        }

        [NotMapped]
        public override bool LockoutEnabled { get; set; }

        [Column("LockoutEnabled", TypeName = "NUMBER(1)")]
        public byte LockoutEnabledByte
        {
            get { return (byte)(LockoutEnabled ? 1 : 0); }
            set { LockoutEnabled = (value == 1); }
        }
    }
}