using System;

namespace RestApiModelDDD.Domain.Entitys
{
    public class Client : Base
    {
        public Int16 Id { get; set; }
        public string Name { get; set; }
        public Int32 CPF { get; set; }
        public DateTime EntryDate { get; set; }
        public bool Active { get; set; }
    }
}
