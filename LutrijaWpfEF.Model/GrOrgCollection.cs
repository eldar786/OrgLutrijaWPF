﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LutrijaWpfEF.Model
{
    public class GrOrgCollection : ObservableCollection<GrOrg>
    {

        public static GrOrgCollection GetAllGrOrg()
        {
            GrOrgCollection grOrgList = new GrOrgCollection();
            GrOrg grOrg = null;

            string queryString = "SELECT SIFRA, NAZIV, ADRESA, TELEFON, OPIS FROM DB_FINANSIJE..IBS.GR_ORGANIZACIJE";
            using (SqlConnection connection = new SqlConnection(
                "Server=192.168.1.213;Database=Lutrija;MultipleActiveResultSets=true;User ID=sa;Password=Lutrija1;"))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        grOrg = GrOrg.GetGrOrgFromResultSet(reader);
                        grOrgList.Add(grOrg);
                    }

                    //foreach (var item in reader)
                    //{
                    //    //if (reader["SIFRA"].ToString() == "130400600")
                    //    //{
                    //    GrOrgList.Items.Add(item);

                    //    //}
                    //}
                }
            }
            return grOrgList;
        }
    }
}
