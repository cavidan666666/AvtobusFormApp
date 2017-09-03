using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtobusForm
{
    class Avtobus
    {
        int umumiYerlerinSayi;
        int bosYerlerinSayi;
        string xetKodu;
        double balans;

        //1 - ci Bular Sabit Deyerler Oldugu Ucun Qarsisina (const) yaziriq

       const double adiBilet = 1.90;
       const double telebeBileti = 1.40;

        public Avtobus(string _xetKodu, int _umumiYerlerinSayi)
        {
            this.umumiYerlerinSayi = _umumiYerlerinSayi;
            //6 - ci  Eger Avtobus Xoda dusmeyibse bos yeerlerin sayi dolu yerlerin sayina beraber olaca mentiqle dusunsek beledi
            this.bosYerlerinSayi = umumiYerlerinSayi;
            //7 - ci ve hemcinin avtobus  xoda dusmemissden qabag  balansda 0 - olur
            this.xetKodu = _xetKodu;
            this. balans = 0;
        }

        //2- ci Sernisin Qebul Etmek Ucun sernisinMindir Metodu Yaziriq
        public void sernisinMindir(bool tamBiletmi) //4 - cu Minen Sexsin Telebe yoxsa adiSernisn Oldugunu bilmek ucun metodun  icine bool tippinde bir tamBiletmi  deyiseni yaziriq
        {

            //3- cu Mentiqle dusunsek sernisin avtobusa minende bosYerlerin Sayi Azalir ona gore bosyerleri hemse bir vahid azaldiriq

            bosYerlerinSayi--;

          
           
            if(tamBiletmi == true)
            {
                balans += adiBilet;
            }

            //5 - ci eger tamBilet true ye beraberfise yeni trudusa balansimiza 1.90  yazacaq eks haldada yeni deyilse balansa 1.40 yazacaq

            else
            {
                balans += telebeBileti;
            }
        }

        //8 - ci sernisin dusurtmek ucun sernisnDusurt metodu yaziriq
        public void sernisinDusurd()
        {
           //9 - cu sernisin dusende bos yerlerin sayi azalir mentiqle dusunsek beledi ona gore o dusunduyumuzu koda yaziriq 

            bosYerlerinSayi++;
        }

        //10 - cu bos yerlerin sayini tapmaq ucun bosYerlerinSayiniGoster adli metod teyin edirik
        public int bosYerlerinSayiniGoster()
        {
            return bosYerlerinSayi;
        }

        //11 - ci balansi tapmaq ucun balansiGoster adli  metod teyin edirik
        public double balansiGoster()
        {
            return balans;
        }
    }
}
