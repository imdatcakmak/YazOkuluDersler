using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;
namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut2 = new SqlCommand("Select * from Tbl_Dersler", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.DERSID = Convert.ToInt32(dr["Dersid"].ToString());
                ent.DERSAD = dr["DersAd"].ToString();
                ent.MIN = int.Parse(dr["DersMinKontenjan"].ToString());
                ent.MAX = int.Parse(dr["DersMaxKontenjan"].ToString());
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_BasvuruForm (Ogrid,Dersid) values(@p1,@p2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", parametre.BASOGRID);
            komut.Parameters.AddWithValue("@p2", parametre.BASDERSID);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }

    }
}
