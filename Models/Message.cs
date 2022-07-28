using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_razor_layout.Models
{
    [Table("message")]
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public string Email { get; set; }
        
    }
}
