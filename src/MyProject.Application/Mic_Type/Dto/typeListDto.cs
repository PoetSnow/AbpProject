using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Mic_Type.Dto
{
    public class typeListDto
    {
        public int Id { get; set; }

        public string type_name { get; set; }

        public int parent_id { get; set; }

        public int order_id { get; set; }


        public int n_id { get; set; }

        public string url { get; set; }

        public string description { get; set; }

        public string previewURL { get; set; }

        public int target { get; set; }

        public bool display { get; set; }
    }
}
