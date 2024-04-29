using ASPNETWEBSQL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ASPNETWEBSQL
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {

        OkulEntities ef = new OkulEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDataToList();
            }
        }
        private void BindDataToList()
        {
            using (var context = new OkulEntities())
            {
                //var products = context.Ogrenci.ToList();
                //DataList1.DataSource = products;
                //DataList1.DataBind();


                GridView1.DataSource =ef.Ogrenci.ToList();
                GridView1.DataBind();

            }
        }
        protected void btnEkle_Click(object sender, EventArgs e)
        {
            // Yeni ürün oluştur
            Ogrenci yeniOgreci = new Ogrenci
            {
                ogrenciNo = txtOgrenciNo.Text,
                adSoyad=txtOgrenciAd.Text,
                adres=txtOgrenciAdres.Text,

            };

            // DbContext ile veritabanına ekle
            using (var context = new OkulEntities())
            {
                context.Ogrenci.Add(yeniOgreci);
                context.SaveChanges();
            }

            // Veriyi güncelle
            BindDataToList();
        }
      

        protected void btnSil_Click1(object sender, EventArgs e)
        {
            string id = txtOgrenciNo.Text; // Öğrenci numarasını al

            // DbContext ile öğrenciyi bul ve sil
            using (var context = new OkulEntities())
            {
                var student = context.Ogrenci.FirstOrDefault(s => s.ogrenciNo == id);
                if (student != null)
                {
                    context.Ogrenci.Remove(student);
                    context.SaveChanges();
                }
            }

            // Veriyi güncelle
            BindDataToList();

        }
        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            string id = txtOgrenciNo.Text; // Öğrenci numarasını al

            // DbContext ile öğrenciyi bul
            using (var context = new OkulEntities())
            {
                var student = context.Ogrenci.FirstOrDefault(s => s.ogrenciNo == id);
                if (student != null)
                {
                    // Mevcut öğrenciyi güncelle
                    student.adSoyad = txtOgrenciAd.Text;
                    student.adres = txtOgrenciAdres.Text;
                    context.SaveChanges(); // Değişiklikleri kaydet
                }
            }

            // Veriyi güncelle
            BindDataToList();

        }


    }
}