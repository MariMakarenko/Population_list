using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Populations_list.entities
{
    public class city
    {
        public int id { get; set; }
        public int cityId { get; set; }
        public string cityName { get; set; }
        public int count { get; set; }
        public int update_at { get; set; }
    }
}
