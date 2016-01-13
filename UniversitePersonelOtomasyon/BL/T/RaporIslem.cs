using Novacode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitePersonelOtomasyon.Models.DataModel;

namespace UniversitePersonelOtomasyon.BL.T
{
    public class RaporIslem
    {
        static string docFilePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "/Uretilen Raporlar";
        public static void İdariPersonelİsimListesiRaporuYazdir()
        {
            docFilePath += "/İdariPersonelİsimListesiRaporu.docx";
            var rapor = DocX.Create(docFilePath);
            rapor.InsertParagraph("Tarih: " + DateTime.Today.ToShortDateString() + "\n\n\n");
            rapor.InsertParagraph("\t\t\tGÖREV BÖLÜMÜNE GÖRE İDARİ PERSONEL LİSTESİ\n\n\n");
            rapor.InsertParagraph("Personel ID\t\t\tAd Soyad\t\t\tGörevi\t\t\tBölümü\t\t\t");
            #region 
            try
            {
                using (var db = new PersonelOtomasyonDBEntities2())
                {
                    //tblidari gorevi dolaş, personel ıd, isim, gorev, fakulte id i yazdır
                    foreach (tblIdariGorev idariGorev in db.tblIdariGorev.ToList())
                    {
                        tblPersoneller personel = db.tblPersoneller.FirstOrDefault(x => x.personel_ID == idariGorev.personel_ID);
                        tblFakülte f = db.tblFakülte.FirstOrDefault(x => x.fakulte_ID == personel.fakulte_ID);
                        string s = personel.personel_ID.ToString() + "\t\t\t" +
                                    personel.personel_Ad + " " + personel.personel_Soyad + "\t\t\t" +
                                    idariGorev.gorev + "\t\t\t" + f.fakutle + "\n";

                        rapor.InsertParagraph(s);
                    }
                }
                System.Windows.Forms.MessageBox.Show(docFilePath + " yolunda rapor oluşturulmuştur.");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("İdari rapor oluşurken hata: " + ex.Message);
            }
            #endregion

            rapor.Save();
        }
        public static void AkademikUnvanaGorePersonelSayiRaporuYazdir()
        {
            docFilePath += "/AkademikUnvanaGörePersonelSayiRaporu.docx";
            var rapor = DocX.Create(docFilePath);
            rapor.InsertParagraph("Tarih: " + DateTime.Today.ToShortDateString());
            int profErkek, profKadin, DocErkek, DocKadin, YrdDErkek, YrdDKadin, OGrvErkek, OGrvKadin, OktErkek, OktKadin, UzmErkek, UzmKadin, ArgorErkek, ArgorKadin, CvrErkek, CvrKadin;
            profErkek = profKadin = DocErkek = DocKadin = YrdDErkek = YrdDKadin = OGrvErkek = OGrvKadin = OktErkek = OktKadin = UzmErkek = UzmKadin = ArgorErkek = ArgorKadin = CvrErkek = CvrKadin = 0;

            //personelleri dolaş, unvanId lerine bak, cinsiyetlerine bak, sayıları yaz.
            try
            {
                using (var db = new PersonelOtomasyonDBEntities2())
                {
                    #region personellerin unvanlarına ve cinsiyetlerine göre sayımı

                    foreach (var personel in db.tblPersoneller.ToList())
                    {
                        switch (personel.unvan_ID)
                        {
                            case 1:
                                if (personel.cinsiyet_ID == 1)
                                    profErkek += 1;
                                else
                                    profKadin += 1;
                                break;

                            case 2:
                                if (personel.cinsiyet_ID == 1)
                                    DocErkek += 1;
                                else
                                    DocKadin += 1;
                                break;

                            case 3:
                                if (personel.cinsiyet_ID == 1)
                                    YrdDErkek += 1;
                                else
                                    YrdDKadin += 1;
                                break;


                            case 4:
                                if (personel.cinsiyet_ID == 1)
                                    OGrvErkek += 1;
                                else
                                    OGrvKadin += 1;
                                break;

                            case 5:
                                if (personel.cinsiyet_ID == 1)
                                    OktErkek += 1;
                                else
                                    OktKadin += 1;
                                break;

                            case 6:
                                if (personel.cinsiyet_ID == 1)
                                    UzmErkek += 1;
                                else
                                    UzmKadin += 1;
                                break;

                            case 7:
                                if (personel.cinsiyet_ID == 1)
                                    ArgorErkek += 1;
                                else
                                    ArgorKadin += 1;
                                break;

                            case 8:
                                if (personel.cinsiyet_ID == 1)
                                    CvrErkek += 1;
                                else
                                    CvrKadin += 1;
                                break;
                        }
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Rapor islem sınıfında hata: " + ex.Message);
            }

            rapor.InsertParagraph("AKADEMİK UNVANLARA GÖRE PERSONEL SAYI RAPORU");
            string sRapor = "Profesör\t E:" + profErkek + "\t K:" + profKadin + "\n" +
                            "Doçent \t E:" + DocErkek + "\t K:" + DocKadin + "\n" +
                             "Yrd. Doç.\t E:" + YrdDErkek + "\t K:" + YrdDKadin + "\n" +
                             "Öğr. Görevlisi\t E:" + OGrvErkek + "\t K" + OGrvKadin + "\n" +
                             "Uzman \t E:" + UzmErkek + "\t K:" + UzmKadin + "\n" +
                             "Ar.Gör. \t E:" + ArgorErkek + "\t K:" + ArgorKadin + "\n" +
                             "Çevirici \t E:" + CvrErkek + "\t K:" + CvrKadin + "\n";
            rapor.InsertParagraph(sRapor);
            rapor.Save();
            System.Windows.Forms.MessageBox.Show(docFilePath + " yolunda rapor oluşturulmuştur.");
        }

    }
}
