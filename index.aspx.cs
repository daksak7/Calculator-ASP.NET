using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMW1_23137564450
{
    public partial class index : System.Web.UI.Page
    {
        static int birincisayi, ikincisayi;
        static string islem;
        static float sonuc;
        static int kontrol = 0;
        static int eklemekontrol = 0;
        static Boolean isSet = false;
        static Boolean sonuckontrol = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }


        protected void Button9_Click(object sender, EventArgs e)
        {

        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            switch (islem)
            {
                case "+":
                    switch (sonuckontrol)
                    {
                        default:
                            sonuc = birincisayi + ikincisayi;
                            sonuckontrol = true;
                            break;
                        case true:
                            sonuc = sonuc + ikincisayi;
                            break;
                    }
                    break;
                case "-":
                    switch (sonuckontrol)
                    {
                        default:
                            sonuc = birincisayi - ikincisayi;
                            sonuckontrol = true;
                            break;
                        case true:
                            sonuc = sonuc - ikincisayi;
                            break;
                    }
                    break;
            }
            eklemekontrol = 1;
            ikincisayi = 0;
            birincisayi = 0;
            TextBox1.Text = Convert.ToString(sonuc);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            //2
            if (kontrol == 0)  //kontrol değeri birinci sayıyı mı yazıyor ikinciyi mi onu kontrol ediyor.
            {
                birincisayi = Convert.ToInt32(Convert.ToString(birincisayi) + Convert.ToString(2));
                TextBox1.Text = Convert.ToString(birincisayi);
            }
            else if (kontrol == 1)
            {
                if (eklemekontrol == 0)  // eklemekontrol 0 iken sayıya eklemeye devam ediyor
                {   //eklemekontrol değeri bir sayının 2.hanesi ve devamındaki basışları kontrol ediyor.
                    ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + Convert.ToString(2));
                    TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                }
                else
                {
                    //ikinci sayının değerini sıfılayabilmem gerekiyor!??
                    if (isSet == false) //iki sayıyı mı işleyeceğiz yoksa sonuçla bir sayıyı mı ısleyecegız ona bakıyor
                    {  //
                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "2");
                        TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                    }
                    else
                    {

                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "2");
                        TextBox1.Text = Convert.ToString(sonuc) + islem + Convert.ToString(ikincisayi);
                    }
                }
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //1
            if (kontrol == 0)  //kontrol değeri birinci sayıyı mı yazıyor ikinciyi mi onu kontrol ediyor.
            {              // işlem butonuna basılmış mı basılmamış mı ona da bakıyor.
                birincisayi = Convert.ToInt32(Convert.ToString(birincisayi) + Convert.ToString(1));
                TextBox1.Text = Convert.ToString(birincisayi);
            }
            else if (kontrol == 1)
            {
                if (eklemekontrol == 0)
                {   //eklemekontrol değeri bir sayının 2.hanesi ve devamındaki basışları kontrol ediyor.
                    ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + Convert.ToString(1));
                    TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                }
                else
                {
                    //ikinci sayının değerini sıfılayabilmem gerekiyor!??
                    if (isSet == false) //iki sayıyı mı işleyeceğiz yoksa sonuçla bir sayıyı mı ısleyecegız ona bakıyor
                    {  //
                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "1");
                        TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                    }
                    else
                    {

                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "1");
                        TextBox1.Text = Convert.ToString(sonuc) + islem + Convert.ToString(ikincisayi);
                    }
                }
            }
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //3
            if (kontrol == 0)  //kontrol değeri birinci sayıyı mı yazıyor ikinciyi mi onu kontrol ediyor.
            {              // işlem butonuna basılmış mı basılmamış mı ona da bakıyor.
                birincisayi = Convert.ToInt32(Convert.ToString(birincisayi) + Convert.ToString(3));
                TextBox1.Text = Convert.ToString(birincisayi);
            }
            else if (kontrol == 1)
            {
                if (eklemekontrol == 0)
                {   //eklemekontrol değeri bir sayının 2.hanesi ve devamındaki basışları kontrol ediyor.
                    ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + Convert.ToString(3));
                    TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                }
                else
                {
                    //ikinci sayının değerini sıfılayabilmem gerekiyor!??
                    if (isSet == false) //iki sayıyı mı işleyeceğiz yoksa sonuçla bir sayıyı mı ısleyecegız ona bakıyor
                    {  //
                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "3");
                        TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                    }
                    else
                    {

                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "3");
                        TextBox1.Text = Convert.ToString(sonuc) + islem + Convert.ToString(ikincisayi);
                    }
                }
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //4
            if (kontrol == 0)  //kontrol değeri birinci sayıyı mı yazıyor ikinciyi mi onu kontrol ediyor.
            {              // işlem butonuna basılmış mı basılmamış mı ona da bakıyor.
                birincisayi = Convert.ToInt32(Convert.ToString(birincisayi) + Convert.ToString(4));
                TextBox1.Text = Convert.ToString(birincisayi);
            }
            else if (kontrol == 1)
            {
                if (eklemekontrol == 0)
                {   //eklemekontrol değeri bir sayının 2.hanesi ve devamındaki basışları kontrol ediyor.
                    ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + Convert.ToString(4));
                    TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                }
                else
                {
                    //ikinci sayının değerini sıfılayabilmem gerekiyor!??
                    if (isSet == false) //iki sayıyı mı işleyeceğiz yoksa sonuçla bir sayıyı mı ısleyecegız ona bakıyor
                    {  //
                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "4");
                        TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                    }
                    else
                    {

                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "4");
                        TextBox1.Text = Convert.ToString(sonuc) + islem + Convert.ToString(ikincisayi);
                    }
                }
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            //5
            if (kontrol == 0)  //kontrol değeri birinci sayıyı mı yazıyor ikinciyi mi onu kontrol ediyor.
            {              // işlem butonuna basılmış mı basılmamış mı ona da bakıyor.
                birincisayi = Convert.ToInt32(Convert.ToString(birincisayi) + Convert.ToString(5));
                TextBox1.Text = Convert.ToString(birincisayi);
            }
            else if (kontrol == 1)
            {
                if (eklemekontrol == 0)
                {   //eklemekontrol değeri bir sayının 2.hanesi ve devamındaki basışları kontrol ediyor.
                    ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + Convert.ToString(5));
                    TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                }
                else
                {    //ikinci sayının değerini sıfılayabilmem gerekiyor!??         
                    if (isSet == false) //iki sayıyı mı işleyeceğiz yoksa sonuçla bir sayıyı mı ısleyecegız ona bakıyor
                    {  //
                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "5");
                        TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                    }
                    else {
                    ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "5");
                    TextBox1.Text = Convert.ToString(sonuc) + islem + Convert.ToString(ikincisayi);
                    }
                }
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            //6
            if (kontrol == 0)  //kontrol değeri birinci sayıyı mı yazıyor ikinciyi mi onu kontrol ediyor.
            {              // işlem butonuna basılmış mı basılmamış mı ona da bakıyor.
                birincisayi = Convert.ToInt32(Convert.ToString(birincisayi) + Convert.ToString(6));
                TextBox1.Text = Convert.ToString(birincisayi);
            }
            else if (kontrol == 1)
            {
                if (eklemekontrol == 0)
                {   //eklemekontrol değeri bir sayının 2.hanesi ve devamındaki basışları kontrol ediyor.
                    ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + Convert.ToString(6));
                    TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                }
                else
                {
                    //ikinci sayının değerini sıfılayabilmem gerekiyor!??
                    if (isSet == false) //iki sayıyı mı işleyeceğiz yoksa sonuçla bir sayıyı mı ısleyecegız ona bakıyor
                    {  //
                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "6");
                        TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                    }
                    else
                    {
                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "6");
                        TextBox1.Text = Convert.ToString(sonuc) + islem + Convert.ToString(ikincisayi);
                    }
                }
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            //7
            if (kontrol == 0)  //kontrol değeri birinci sayıyı mı yazıyor ikinciyi mi onu kontrol ediyor.
            {              // işlem butonuna basılmış mı basılmamış mı ona da bakıyor.
                birincisayi = Convert.ToInt32(Convert.ToString(birincisayi) + Convert.ToString(7));
                TextBox1.Text = Convert.ToString(birincisayi);
            }
            else if (kontrol == 1)
            {
                if (eklemekontrol == 0)
                {   //eklemekontrol değeri bir sayının 2.hanesi ve devamındaki basışları kontrol ediyor.
                    ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + Convert.ToString(7));
                    TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                }
                else
                {
                    //ikinci sayının değerini sıfılayabilmem gerekiyor!??
                    if (isSet == false) //iki sayıyı mı işleyeceğiz yoksa sonuçla bir sayıyı mı ısleyecegız ona bakıyor
                    {  //
                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "7");
                        TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                    }
                    else
                    {

                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "7");
                        TextBox1.Text = Convert.ToString(sonuc) + islem + Convert.ToString(ikincisayi);
                    }
                }
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            //8
            if (kontrol == 0)  //kontrol değeri birinci sayıyı mı yazıyor ikinciyi mi onu kontrol ediyor.
            {              // işlem butonuna basılmış mı basılmamış mı ona da bakıyor.
                birincisayi = Convert.ToInt32(Convert.ToString(birincisayi) + Convert.ToString(8));
                TextBox1.Text = Convert.ToString(birincisayi);
            }
            else if (kontrol == 1)
            {
                if (eklemekontrol == 0)
                {   //eklemekontrol değeri bir sayının 2.hanesi ve devamındaki basışları kontrol ediyor.
                    ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + Convert.ToString(8));
                    TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                }
                else
                {
                    //ikinci sayının değerini sıfılayabilmem gerekiyor!??
                    if (isSet == false) //iki sayıyı mı işleyeceğiz yoksa sonuçla bir sayıyı mı ısleyecegız ona bakıyor
                    {  //
                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "8");
                        TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                    }
                    else
                    {

                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "8");
                        TextBox1.Text = Convert.ToString(sonuc) + islem + Convert.ToString(ikincisayi);
                    }
                }
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            //9
            if (kontrol == 0)  //kontrol değeri birinci sayıyı mı yazıyor ikinciyi mi onu kontrol ediyor.
            {              // işlem butonuna basılmış mı basılmamış mı ona da bakıyor.
                birincisayi = Convert.ToInt32(Convert.ToString(birincisayi) + Convert.ToString(9));
                TextBox1.Text = Convert.ToString(birincisayi);
            }
            else if (kontrol == 1)
            {
                if (eklemekontrol == 0)
                {   //eklemekontrol değeri bir sayının 2.hanesi ve devamındaki basışları kontrol ediyor.
                    ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + Convert.ToString(9));
                    TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                }
                else
                {
                    //ikinci sayının değerini sıfılayabilmem gerekiyor!??
                    if (isSet == false) //iki sayıyı mı işleyeceğiz yoksa sonuçla bir sayıyı mı ısleyecegız ona bakıyor
                    {  //
                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "9");
                        TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                    }
                    else
                    {

                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "9");
                        TextBox1.Text = Convert.ToString(sonuc) + islem + Convert.ToString(ikincisayi);
                    }
                }
            }
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            //0
            if (kontrol == 0)  //kontrol değeri birinci sayıyı mı yazıyor ikinciyi mi onu kontrol ediyor.
            {              // işlem butonuna basılmış mı basılmamış mı ona da bakıyor.
                birincisayi = Convert.ToInt32(Convert.ToString(birincisayi) + Convert.ToString(0));
                TextBox1.Text = Convert.ToString(birincisayi);
            }
            else if (kontrol == 1)
            {
                if (eklemekontrol == 0)
                {   //eklemekontrol değeri bir sayının 2.hanesi ve devamındaki basışları kontrol ediyor.
                    ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + Convert.ToString(0));
                    TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                }
                else
                {
                    //ikinci sayının değerini sıfılayabilmem gerekiyor!??
                    if (isSet == false) //iki sayıyı mı işleyeceğiz yoksa sonuçla bir sayıyı mı ısleyecegız ona bakıyor
                    {  //
                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "0");
                        TextBox1.Text = Convert.ToString(birincisayi) + islem + Convert.ToString(ikincisayi);
                    }
                    else
                    {

                        ikincisayi = Convert.ToInt32(Convert.ToString(ikincisayi) + "0");
                        TextBox1.Text = Convert.ToString(sonuc) + islem + Convert.ToString(ikincisayi);
                    }
                }
            }
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            islem = "+";
            isSet = true;
            TextBox1.Text = TextBox1.Text + islem;
            kontrol = 1;
        //    if (kontrol==1) //eğer ortada hesaplanmış bir sonuç varsa eski 2.sayıyı siliyor yeniden kullanabilmek için.
        //    {
        //        ikincisayi = 0;
         //   }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            islem = "-";
            isSet = true;
            TextBox1.Text = TextBox1.Text + islem;
            kontrol = 1;
         //   if (kontrol==1) //eğer ortada hesaplanmış bir sonuç varsa eski 2.sayıyı siliyor yeniden kullanabilmek için.
         //   {
         //       ikincisayi = 0;
         //   }
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
            birincisayi = 0;
            ikincisayi = 0;
            sonuc = 0;
            kontrol = 0;
            eklemekontrol = 0;
        }
    }
}
    