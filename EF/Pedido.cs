﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Pedido
    {
        public long Id { get; set; }
        public Consumidor Consumidor { get; set; }
    }
}
