using System;

namespace DesignPatterns.Adapter
{
    [Serializable]
    public class Record
    {
        public Record(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
