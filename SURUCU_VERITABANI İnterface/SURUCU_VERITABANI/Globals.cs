using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SURUCU_VERITABANI
{
    public static class Globals
    {
        public static MySqlConnection con = new MySqlConnection("Server=sql7.freesqldatabase.com;Database=sql7292929;user=sql7292929;pwd='5ifVaGAhYa';");

    }
}
