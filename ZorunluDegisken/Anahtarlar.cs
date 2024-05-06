using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ZorunluDegisken
{
    public class Anahtarlar
    {
        private string _connectionString;

        public string ConnectionString
        {
            get
            {
                
                _connectionString = "Data Source=DERYA\\HUAWEI;Initial Catalog=KutuphaneOtomasyon;User ID=sa;Password=sas";
                return _connectionString;
            }
        }


        public static string mail { get; set; }
        public static bool Rol { get; set; }
    }
}
