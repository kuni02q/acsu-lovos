using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Speech.Synthesis;

namespace acsu_lövős
{
    public partial class kepernyo : Form
    {
        Random vel = new Random();
        int pont = 0;
        int rontott = 0;
        int osszes = 0;

        public kepernyo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Loves()
        {
            pont++;
            szoveg1.Text = "Pont: " + pont;
            osszes++;
            szoveg3.Text = "Össz. lövés: " + osszes;

            Loveshang();
        }
        void FelreLoves()
        {
            rontott++;
            szoveg2.Text = "Szar vagy: " + rontott;
            osszes++;
            szoveg3.Text = "Össz. lövés: " + osszes;

            Loveshang();
        }

        void Ujra()
        {
            pont = 0;
            rontott = 0;
            osszes = 0;
            szoveg1.Text = "Pont: " + pont;
            szoveg2.Text = "Szar vagy: " + rontott;
            szoveg3.Text = "Össz. lövés: " + osszes;
            szoveg4.Text = "";

            idozito.Start();
        }

        SpeechSynthesizer beszel = new SpeechSynthesizer();
        int melyikSzoveg;
        List<string> lista = new List<string>();
        void acsuBeszel()
        {
            lista.Add("MIT CSINÁLNAK BURAK");
            lista.Add("A kisnyúl nem bassza meg");
            lista.Add("Lecsavarom a töküket");
            lista.Add("Erre sem képesek buraaak");
            lista.Add("Beszopják a mlretes harcifaszt!");
            lista.Add("Csak a töküket verik?");

            melyikSzoveg = vel.Next(0, lista.Count());

            beszel.Speak(lista[melyikSzoveg]);


        }

        void Loveshang()
        {

            SoundPlayer hang = new SoundPlayer(@"C:\Users\Andras\Desktop\GAMEK\acsu lövős\hang.wav");
            hang.Play();
        }

        private void acsu_Click(object sender, EventArgs e)
        {
            Loves();
            acsuBeszel();
        }

        private void idozito_Tick(object sender, EventArgs e)
        {
            int x;
            int y;
            x = vel.Next(50, kepernyo.ActiveForm.Width - 150);
            y = vel.Next(300, kepernyo.ActiveForm.Height - 150);

            acsu.Location = new Point(x, y);

            if (rontott >= 10)
            {
                idozito.Stop();
                szoveg4.Text = "VESZTETTÉL ACSU JOBB NÁLAD";
            }

            if (pont >= 10)
            {
                idozito.Stop();
                szoveg4.Text = "LEGYŐZTED A FASZFEJT";
            }

        }

        private void kepernyo_MouseClick(object sender, MouseEventArgs e)
        {
            FelreLoves();
        }

        private void ujrakezd_Click(object sender, EventArgs e)
        {
            Ujra();
        }

        private void kilep_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
