﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas_importantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new DataConfiguracao();
            data.SolicitarFormatoData();
            data.ExibirMenuDataTecnologia();
        }
    }
}
