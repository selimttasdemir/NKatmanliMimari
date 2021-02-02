using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using System.Data;

namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand cmd = new SqlCommand("select * from tblbilgi", baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["Ad"].ToString();
                ent.Soyad = dr["Soyad"].ToString();
                ent.Gorev = dr["Gorev"].ToString();
                ent.Sehir = dr["Sehir"].ToString();
                ent.Maas = short.Parse(dr["Maas"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut = new SqlCommand("insert into tblbilgi (ad , soyad , maas , gorev , sehir) values (@p1,@p2,@p3,@p4,@p5)", baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p.Ad);
            komut.Parameters.AddWithValue("@p2", p.Soyad);
            komut.Parameters.AddWithValue("@p3", p.Maas.ToString());
            komut.Parameters.AddWithValue("@p4", p.Gorev);
            komut.Parameters.AddWithValue("@p5", p.Sehir);

            return komut.ExecuteNonQuery();
        }

        public static bool PersonelSil(int p)
        {
            SqlCommand cmd = new SqlCommand("delete from tblbilgi where ID = @p1",baglanti.bgl);
            if (cmd.Connection.State !=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", p);
            return cmd.ExecuteNonQuery() > 0;
        }
        public static bool PersonelGuncelle(EntityPersonel ent)
        {
            SqlCommand cmd = new SqlCommand("update tblbilgi set ad = @p1, soyad= @p2 , maas= @p3 , gorev = @p4, sehir= @p5 where ID = @p6", baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", ent.Ad);
            cmd.Parameters.AddWithValue("@p2", ent.Soyad);
            cmd.Parameters.AddWithValue("@p3", ent.Maas);
            cmd.Parameters.AddWithValue("@p4", ent.Gorev);
            cmd.Parameters.AddWithValue("@p5", ent.Sehir);
            cmd.Parameters.AddWithValue("@p6", ent.Id);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
