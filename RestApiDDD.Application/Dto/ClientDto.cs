using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDDD.Application.Dto
{
    public class ClientDto
    {
        public Int16 Id { get; set; }
        public string Name { get; set; }
        public Int32 CPF { get; set; }
        public DateTime EntryDate { get; set; }
        public bool Active { get; set; }
    }
}
