﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuppliersOdev
{
    public class Suppliers
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }    

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string Address { get; set; }

    }
}
