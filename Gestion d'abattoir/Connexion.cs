﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_d_abattoir
{
    class Connexion
    {
      public static  SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Abattoire;Integrated Security=True");
    }
}
