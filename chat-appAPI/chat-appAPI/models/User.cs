using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace chat_appAPI.models {
    public class User {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string DisplayName { get; set; }
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
    }
}
