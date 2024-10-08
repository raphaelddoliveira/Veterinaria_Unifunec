﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.model
{
    /* -- Loja = {codloja, nomeloja, codbairrofk, codruafk, codcepfk, 
    codcidadefk, codestadofk, codpaisfk, numeroloja, cnpj  } OK */
    internal class Loja
    {
        public int codloja {  get; set; }
        public String nomeloja { get; set; }
        public Bairro bairro { get; set; }
        public Rua rua { get; set; }
        public Cep cep { get; set; }    
        public Cidade cidade { get; set; }
        public Estado estado { get; set; }
        public Pais pais { get; set; }
        public String numeroloja { get; set; }
        public String cnpj { get; set; }    
    }
}
