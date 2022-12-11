using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace QLSVKTX
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = @"Data Source = .; Initial catalog =QLSVKTX; Integrated Security = true";
        }
        public SqlConnection getConnection()
        {
            return new SqlConnection(conStr);
        }
    }
}