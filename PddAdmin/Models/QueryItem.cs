using System;
using System.Collections.Generic;

namespace PddAdmin.Models
{
    public partial class QueryItem
    {
        public QueryItem()
        {
            Responses = new HashSet<Responses>();
        }

        public int Id { get; set; }
        public string ChapterKey { get; set; }
        public string Query { get; set; }
        public string ImageUri { get; set; }
        public string Thema { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<Responses> Responses { get; set; }
    }
}
