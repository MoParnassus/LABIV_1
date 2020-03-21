using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace LABIV_1
{
    class CURD
    {
        public void Create(int ID,string kategorie, SqlConnection conn)
        {
            string sql = "INSERT INTO Kategorie('kategorie') VALUES (@NazwaKategorii)";
            var command = new SqlConnection(sql, conn);
            command.Parameters.AddWithValue("@NazwaKategorii", kategorie);
            command.Parameters.AddWithValue("@ID", ID);

            int x = command.Execute;
        }
    }
}
