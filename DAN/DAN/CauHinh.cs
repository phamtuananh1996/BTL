using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAN
{
    class CauHinh
    {
        SqlConnection con;
        SqlCommand comd;
        private String conec;
       
        public CauHinh(String conec)
        {
            this.conec = conec;
        }
        private void Connection()
        {
            con = new SqlConnection(conec);
            con.Open();
        }
        
        }
    }

