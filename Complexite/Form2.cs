using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complexite
{
    public partial class decryptageForm : MetroFramework.Forms.MetroForm
    {
        cryptageForm formC = new cryptageForm();
        public char[,] matriceDec;
        public char[,] matriceDec1;
        public decryptageForm()
        {
            matriceDec = formC.getMat();
            matriceDec1 = formC.getMat1();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

          /*  StreamReader keyFile = new StreamReader("key.txt");
            StreamReader textFile = new StreamReader("text.txt");
            keyText.Text = keyFile.ReadToEnd();
            crsText.Text = textFile.ReadToEnd();
            keyFile.Close();
            textFile.Close();*/

        }
        
        private void metroTile1_Click(object sender, EventArgs e)
        {
            cryptageForm form = new cryptageForm();
            form.Show();
            this.Dispose();
        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            if (rdBtn1.Checked)
            {
                DeCrypter1();
            }
            else if (rdBtn2.Checked)
            {
                DeCrypter2();
            }
            else if (rdBtn3.Checked)
            {
                DeCrypter3();
            }

        }

        void DeCrypter() {
            string crypted = crsText.Text.ToLower();
            string decrypted = "";
            string key = keyText.Text.ToLower();
            string a = "";
            int kk = 0;

            for (int i = 0; i < crypted.Length; i++)
            {
                if (kk >= key.Length) kk = 0;
                a += key[kk];
                kk++;
            }
            kk = 0;
            while (kk < a.Length)
            {
                int m1 = (int)(a[kk]) - 97;
                for (int j = 0; j < 26; j++)
                {
                    if (matriceDec[m1, j].ToString().Equals(crypted[kk].ToString().ToUpper()))
                    {
                        decrypted += matriceDec[0, j].ToString().ToLower();
                        break;
                    }
                }
                kk++;
            }
            decStext.Text = decrypted;
        }

        void DeCrypter1()
        {
            string crypted = crsText.Text.ToLower();
            string decrypted = "";
            string key = keyText.Text.ToLower();
            int kk = 0;
            Console.WriteLine(key.Length);

            kk = 0;
            while (kk < key.Length)
            {
                int m1 = (int)(key[kk]) - 97;
               
                for (int j = 0; j < 26; j++)
                {
                    if (matriceDec[m1, j].ToString().Equals(crypted[kk].ToString().ToUpper()))
                    {
                        decrypted += matriceDec[0, j].ToString().ToLower();
                        break;
                    }
                }
                kk++;
            }
            decStext.Text = decrypted;
        }

        void DeCrypter2()
        {
            string crypted = crsText.Text;
            string decrypted = "";
            string key = keyText.Text;
            int kk = 0;
            Console.WriteLine(key.Length);

            kk = 0;
            while (kk < key.Length)
            {
                int m1 = (int)(key[kk]) - 32;

                for (int j = 0; j < 95; j++)
                {
                    if (matriceDec1[m1, j].ToString().Equals(crypted[kk].ToString()))
                    {
                        decrypted += matriceDec1[0, j].ToString();
                        break;
                    }
                }
                kk++;
            }
            decStext.Text = decrypted;
        }
        void DeCrypter3()
        {
            string crypted = crsText.Text;
            string decrypted = "";
            string key = keyText.Text;
            int kk = 0;
            Console.WriteLine(key.Length);

            kk = 0;
            while (kk < crypted.Length)
            {
                /*int m1 = (int)(key[kk]) - 32;

                for (int j = 0; j < 95; j++)
                {
                    if (matriceDec1[m1, j].ToString().Equals(crypted[kk].ToString()))
                    {
                        decrypted += matriceDec1[0, j].ToString();
                        break;
                    }
                }*/
                decrypted += (char)(((int)crypted[kk])-(int)key[kk]);
                kk++;
            }
            decStext.Text = decrypted;
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                if((myStream = ofd.OpenFile()) != null)
                {
                    string strFileName = ofd.FileName;
                    string fileText = File.ReadAllText(strFileName);
                    crsText.Text = fileText;
                }
            }
        }

        private void OpenFileBtn1_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = ofd.OpenFile()) != null)
                {
                    string strFileName = ofd.FileName;
                    string fileText = File.ReadAllText(strFileName);
                    keyText.Text = fileText;
                }
            }
        }
    }
}
