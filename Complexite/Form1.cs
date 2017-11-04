using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Diagnostics;
using System.IO;

namespace Complexite
{
    public partial class cryptageForm : MetroFramework.Forms.MetroForm
    {
        public char[,] matrice;
        public char[,] matrice1;
        
        public cryptageForm()
        {
            //Console.WriteLine("fafafaf"+(int)'ف');
            matrice = new char[26, 26];
            matrice1 = new char[95, 95];
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    matrice[i, j] = (char)(65 + ((i + j) % 26));

                }
            }
            for (int i = 0; i < 95; i++)
            {
                for (int j = 0; j < 95; j++)
                {  
                    matrice1[i, j] = (char)(32+((i + j) % 95));   
                }         
            }

            InitializeComponent();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void CrypterBtn_Click(object sender, EventArgs e)
        {
            StreamWriter timeFile = new StreamWriter("timeElapsedMiliseconde.txt",true);
            Stopwatch sw;
            double timeElapsed = 0;
            if (rdBtn1.Checked) {
                timeFile.WriteLine("Crypter_1 :");
                for (int i = 0; i < 20; i++)
                {
                    sw = new Stopwatch();                    
                    sw.Start();
                    Crypter();
                    sw.Stop();
                    timeElapsed += sw.Elapsed.TotalMilliseconds;
                    timeFile.WriteLine("Time Elapsed :" + sw.Elapsed.TotalMilliseconds);
                }
               
                
            }
            else if (rdBtn2.Checked)
            {
                timeFile.WriteLine("Crypter_2 :");
                for (int i = 0; i < 20; i++)
                {
                    sw = new Stopwatch();
                    sw.Start();
                    Crypter1();
                    sw.Stop();
                    timeElapsed += sw.Elapsed.TotalMilliseconds;
                    timeFile.WriteLine("Time Elapsed :" + sw.Elapsed.TotalMilliseconds);
                }
            }
            else if (rdBtn3.Checked)
            {
                timeFile.WriteLine("Crypter_3 :");
                for (int i = 0; i < 20; i++)
                {
                    sw = new Stopwatch();
                    sw.Start();
                    Crypter2();
                    sw.Stop();
                    timeElapsed += sw.Elapsed.TotalMilliseconds;
                    Console.WriteLine(sw.Elapsed.TotalMilliseconds);
                    timeFile.WriteLine("Time Elapsed :" + sw.Elapsed.TotalMilliseconds);
                }
            }
            else if (rdBtn4.Checked)
            {
                timeFile.WriteLine("Crypter_4 :");
                for (int i = 0; i < 20; i++)
                {
                    sw = new Stopwatch();
                    sw.Start();
                    Crypter3();
                    sw.Stop();
                    timeElapsed += sw.Elapsed.TotalMilliseconds;
                    timeFile.WriteLine("Time Elapsed :" + sw.Elapsed.TotalMilliseconds);
                }
            }
            timeFile.WriteLine("Average Elapsed Time :" + timeElapsed/20);
            timeFile.WriteLine("--------------------------------------------------");
            timeFile.Close();
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            decryptageForm form = new decryptageForm();
            form.Show();
            this.Hide();
        }
        public char charCrypt(char a,char b)
        {
            int m1 = (int)(a) - 97;
            int m2 = (int)(b) - 97;
            return matrice[m1, m2];
        }
        void Crypter()
        {
            string chaine0 = chaineText.Text.ToLower();
            string key = keyText.Text.ToLower();
            string nocrypted = "";
            string crypted = "";
            string a = "";
            int kk = 0;
            int jj = 0;
            StreamWriter hkeyFile = new StreamWriter("Hkey.txt",true);
            StreamWriter htextFile = new StreamWriter("Htext.txt",true);
            StreamWriter keyFile = new StreamWriter("key.txt");
            StreamWriter textFile = new StreamWriter("text.txt");
            hkeyFile.WriteLine("Crypter_1 :");
            htextFile.WriteLine("Crypter_1 :");
            for (int l = 0; l < chaine0.Length; l++)
            {
                if ((int)(chaine0[l]) >= 97 && (int)(chaine0[l]) <= 123)
                    nocrypted += chaine0[l];
            }


            while (kk < nocrypted.Length)
            {
                if (jj >= key.Length) jj = 0;
                a += key[jj];
                jj++;
                kk++;
            }

            kk = 0;

            while (kk < a.Length)
            {
                crypted += charCrypt(a[kk], nocrypted[kk]);
                kk++;
            }
            CryptedText.Text = crypted;
            hkeyFile.WriteLine(a);
            htextFile.WriteLine(crypted);
            keyFile.Write(a);
            textFile.Write(crypted);
            hkeyFile.Close();
            htextFile.Close();
            keyFile.Close();
            textFile.Close();

        }
        void Crypter1()
        {
            string chaine0 = chaineText.Text.ToLower();
            string key = keyText.Text.ToLower();
            string nocrypted = "";
            string crypted = "";
            string a = "";
            int randCar;
            int kk = 0;
            int jj = 0;
            StreamWriter hkeyFile = new StreamWriter("Hkey.txt",true);
            StreamWriter htextFile = new StreamWriter("Htext.txt",true);
            StreamWriter keyFile = new StreamWriter("key.txt");
            StreamWriter textFile = new StreamWriter("text.txt");
            Random rnd = new Random();
            hkeyFile.WriteLine("Crypter_2 :");
            htextFile.WriteLine("Crypter_2 :");
            for (int l = 0; l < chaine0.Length; l++)
            {
                if ((int)(chaine0[l]) >= 97 && (int)(chaine0[l]) <= 123)
                    nocrypted += chaine0[l];
            }
            randCar = nocrypted.Length - key.Length;
            for(int i = 0; i < randCar; i++)
            {
                key +=(char) rnd.Next(65,65+26);
            }
            key = key.ToLower();
            Console.WriteLine(key);
            
            while (kk < key.Length)
            {
                int m1 = (int)(key[kk]) - 97;
                int m2 = (int)(nocrypted[kk]) - 97;
                crypted += matrice[m1, m2];
                kk++;
            }
            CryptedText.Text = crypted;
            hkeyFile.WriteLine(key);
            htextFile.WriteLine(crypted);
            keyFile.Write(key);
            textFile.Write(crypted);
            hkeyFile.Close();
            htextFile.Close();
            keyFile.Close();
            textFile.Close();

        }

        void Crypter2()
        {
            string key = keyText.Text;
            string nocrypted = chaineText.Text;
            string crypted = "";
            string a = "";
            int randCar;
            int kk = 0;
            int jj = 0;
            StreamWriter hkeyFile = new StreamWriter("Hkey.txt", true);
            StreamWriter htextFile = new StreamWriter("Htext.txt", true);
            StreamWriter keyFile = new StreamWriter("key.txt");
            StreamWriter textFile = new StreamWriter("text.txt");
            Random rnd = new Random();
            hkeyFile.WriteLine("Crypter_3 :");
            htextFile.WriteLine("Crypter_3 :");
            randCar = nocrypted.Length - key.Length;
            for (int i = 0; i < randCar; i++)
            {
                key += (char)rnd.Next(32, 127);
            }
            key = key.ToLower();
            

            while (kk < key.Length)
            {
                int m1 = (int)(key[kk]) - 32;
                int m2 = (int)(nocrypted[kk]) - 32;
                crypted += matrice1[m1, m2];
                kk++;
            }
            CryptedText.Text = crypted;
            hkeyFile.WriteLine(key);
            htextFile.WriteLine(crypted);
            keyFile.Write(key);
            textFile.Write(crypted);
            hkeyFile.Close();
            htextFile.Close();
            keyFile.Close();
            textFile.Close();

        }
        void Crypter3()
        {
            string key = keyText.Text;
            string nocrypted = chaineText.Text;
            string crypted = "";
            string a = "";
            int randCar;
            int kk = 0;
            int jj = 0;
            StreamWriter hkeyFile = new StreamWriter("Hkey.txt", true);
            StreamWriter htextFile = new StreamWriter("Htext.txt", true);
            StreamWriter keyFile = new StreamWriter("key.txt");
            StreamWriter textFile = new StreamWriter("text.txt");
            Random rnd = new Random();
            hkeyFile.WriteLine("Crypter_3 :");
            htextFile.WriteLine("Crypter_3 :");
            randCar = nocrypted.Length - key.Length;

            for (int i = 0; i < randCar; i++)
            {
                key += (char)rnd.Next(32, 127);
            }   

            while (kk < nocrypted.Length)
            {
                /*int m1 = (int)(key[kk]) - 32;
                int m2 = (int)(nocrypted[kk]) - 32;*/
                crypted += (char)(((int)nocrypted[kk])+(int)key[kk]);
                kk++;
            }

            CryptedText.Text = crypted;
            hkeyFile.WriteLine(key);
            htextFile.WriteLine(crypted);
            keyFile.Write(key);
            textFile.Write(crypted);
            hkeyFile.Close();
            htextFile.Close();
            keyFile.Close();
            textFile.Close();

        }
        public char[,] getMat()
        {
            return matrice;
        }
        public char[,] getMat1()
        {
            return matrice1;
        }

    }
   
}
