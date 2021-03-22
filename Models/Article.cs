using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace veic_web.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public int Type_id { get; set; }
        public int Lang_id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Body { get; set; }
        public DateTime Pubdate { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        [ForeignKey("Type_id")]
        public veic_web.Models.Type Type { get; set; }
    }
}
