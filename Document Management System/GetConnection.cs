using System;
using System.Data.SqlClient;

namespace Document_Management_System
{
    internal class GetConnection
    {
        public GetConnection()
        {
        }

        public static implicit operator SqlConnection(GetConnection v)
        {
            throw new NotImplementedException();
        }
    }
}