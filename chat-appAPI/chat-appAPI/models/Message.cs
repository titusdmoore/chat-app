using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace chat_appAPI.models {
    public class Message {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool HasTitle { get; set; }
        [MaxLength(40)]
        public string Title { get; set; }
        [MaxLength(355)]
        public string Content { get; set; }

        // FK to users of the message 
        public int RecId { get; set; }
        public virtual User RecUser { get; set; }

        public int SendId { get; set; }
        public virtual User SendUser { get; set; }
    }
}
