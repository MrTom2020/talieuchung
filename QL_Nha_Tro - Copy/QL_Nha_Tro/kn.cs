using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QL_Nha_Tro
{
    class kn
    {
        public static string cnnStr = "Data Source=DESKTOP-V6FNPVC;Initial Catalog=QL_NT_2;Integrated Security=True";
        public static SqlConnection cnn = new SqlConnection(cnnStr);
    }
}
