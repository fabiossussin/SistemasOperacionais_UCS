using System;
using System.Collections.Generic;
using System.Text;
using Ucs_SO.Reader;

namespace Ucs_SO.Principal
{
    public class Principal
    {

        public void Start() =>
            new CsvReader().FileReader();

    }
}
