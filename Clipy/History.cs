using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clipy
{
    public class History
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int GroupID { get; set; }
        public DateTime CreatedAt { get; set; }
        
        public History() { }
        public History(int id, string name, string content)
        {
            Id = id;
            Name = name;
            Content = content;
        }
        
    }
}
