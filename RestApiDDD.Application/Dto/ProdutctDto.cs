﻿
namespace RestApiDDD.Application.Dto
{
    class ProdutctDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float Stock { get; set; }
        public bool Active { get; set; }
    }
}
