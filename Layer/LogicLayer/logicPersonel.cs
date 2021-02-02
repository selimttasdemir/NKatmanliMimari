using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class logicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
        public static int LLPersonleEkle(EntityPersonel p)
        {
            if (p.Ad != null && p.Soyad !=null && p.Maas>=4000 && p.Ad.Length>=3)
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLPersonelSil(int per)
        {
            if (per>=1 && per != null)
            {
                return DALPersonel.PersonelSil(per);
            }
            else
            {
                return false;
            }
        }
        public static bool LLPersonleGuncelle (EntityPersonel ent)
        {
            if (ent.Ad.Length>=3 && ent.Ad != null && ent.Maas>=4000)
            {
                return DALPersonel.PersonelGuncelle(ent);
            }
            else
            {
                return false;
            }
        }
    }
}
