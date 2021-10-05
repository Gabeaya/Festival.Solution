using System.Collections.Generic;

namespace Festival.Models
{
    public class Stage
    {
        public Stage()
        {
            this.Artist = new HashSet<Artist>();
        }

        public int StageId { get; set; }
        public string Name { get; set; }
        public string Capacity { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Artist> Artists { get; set; }
    }
}