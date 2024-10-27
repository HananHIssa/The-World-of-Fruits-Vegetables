using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.DAL.Data.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string imageName { get; set; }
        public bool isDelete { get; set; }
        public DateTime Data { get; set; }
    }
}
