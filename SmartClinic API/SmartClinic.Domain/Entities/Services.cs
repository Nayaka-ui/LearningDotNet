using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClinic.Domain.Entities
{
    public class Services
    {
        public int Id { get; set; }
        public string? Name { get; set; }    
        public bool IsDeleted { get; set; }
        public ICollection<Token> Tokens { get; set; } = new List<Token>();
    }
}
