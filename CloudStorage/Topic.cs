using System.Collections.Generic;

namespace CloudStorage
{
    public class Topic
    {
        public string Name { get; set; }
        public List<Topic> SubTopics { get; set; }
    }
}
