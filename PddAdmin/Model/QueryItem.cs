using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace PddAdmin.Model
{
    public class QueryItem
    {
        public QueryItem()
        {
            Responses = new HashSet<Responses>();
        }

        public int Id { get; set; }
        public string ChapterKey { get; set; }
        public string Query { get; set; }
        public IFormFile ImageFile { get; set; }
        public string ImageUri { get; set; }
        public string Thema { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<Responses> Responses { get; set; }
    }

    public class Responses
    {
        public int Id { get; set; }
        public string Response { get; set; }
        public bool IsRight { get; set; }
        public int QueryId { get; set; }

        public virtual QueryItem Query { get; set; }
    }




}


