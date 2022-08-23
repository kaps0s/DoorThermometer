using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_UX_VIRVOU.Forms
{

    public partial class Thermometer : Form
    {
        private List<double> randomTemperatures = new List<double> { 36.6, 36.6, 36.6, 36.6, 36.6 };
        //int seconds = 0;
        public List<Label> LabelsToTransmit = new List<Label>();
        public Thermometer()
        {
            InitializeComponent();
        }

        private void triggerEventIconButton_Click(object sender, EventArgs e)
        {
            LineLabel1.ForeColor = Color.White;
            LineLabel2.ForeColor = Color.White;
            LineLabel3.ForeColor = Color.White;
            LineLabel4.ForeColor = Color.White;



            doorCamPictureBox.ImageLocation = @"..\..\Resources\DoorCamImages\2.jpg";

            this.tML1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            tML1.Visible = true;

            tML1.Text = "Παρακαλώ πλησιάστε κοντά στην κάμερα";


            //ColorTransitToBlackTimer.Interval = 35;
            //ColorTransitToBlackTimer.Enabled = true;

            //thermometerMessagesLabel.Text = "xxxxxxxxxxxxxxxxxx";
            CenterLabelToParent(tML1);


            MessageTimer.Interval = 2000;
            MessageTimer.Enabled = true;

            List<Label> labels = new List<Label> {tML1,LineLabel1,LineLabel2};
            TransmitLabelColorToBlack(labels);

            //tML1.ForeColor = Color.Black;




            //loadingPictureBox.Visible = true;
            sAL.Visible = false;


        }

        private void Thermometer_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            this.Location = new Point(50, 150);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;



            this.BackColor = Color.White;

            List<Label> labels = new List<Label> { tML1, LineLabel1, LineLabel2 };
            LabelsToTransmit.AddRange(labels);

            ColorTransitToBlackTimer.Enabled = false;
            MessageTimer.Enabled = false;

            LineLabel1.ForeColor = Color.White;
            LineLabel2.ForeColor = Color.White;
            LineLabel3.ForeColor = Color.White;
            LineLabel4.ForeColor = Color.White;


            doorCamPictureBox.BorderStyle = BorderStyle.Fixed3D;

            this.tML1.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            this.tML1.AutoSize = false;
            this.tML1.TextAlign = ContentAlignment.MiddleCenter;
            this.tML1.Size = tMPanel1.Size;



            this.sAL.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            this.sAL.AutoSize = false;
            this.sAL.TextAlign = ContentAlignment.MiddleCenter;
            this.sAL.Size = tMPanel1.Size;
            //this.suggestActionLabel.AutoSize = false;
            //this.suggestActionLabel.TextAlign = ContentAlignment.MiddleCenter;

            doorCamPictureBox.ImageLocation = @"..\..\Resources\DoorCamImages\1.jpg";
            doorCamPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            tML1.Visible = false;
            //thermometerMessagesLabel.MaximumSize = new Size(700, 0);
            //thermometerMessagesLabel.AutoSize = true;

            loadingPictureBox.Visible = false;
            loadingPictureBox.ImageLocation = @"..\..\Resources\LoadingImages\loader1.gif";
            loadingPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            sAL.Visible = false;
            //suggestActionLabel.MaximumSize = new Size(700, 0);
            //suggestActionLabel.AutoSize = true;
        }


        public double GetRandomTemperature(double minimum, double maximum)
        {
            if (randomTemperatures.Count > 5)
            {
                randomTemperatures.RemoveRange(5, 5);
            }
            //randomTemperatures.RemoveRange(5, 5);
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                randomTemperatures.Add(random.NextDouble() * (maximum - minimum) + minimum);
            }

            return randomTemperatures[random.Next(10)];
        }

        private void suggestActionLabel_Click(object sender, EventArgs e)
        {

        }

        private void CenterLabelToParent(Label label) {
            int y = (label.Parent.Size.Width - label.Size.Width) / 2;
            label.Location = new Point(y, label.Location.Y);
        }

        public void GetTemperature()
        {
            double temp = Math.Round(GetRandomTemperature(36.6, 41), 1);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            if (temp <= 36.6)
            {
                tML1.ForeColor = Color.Green;
                sAL.Text = "Μπορείτε να περάσετε!";
                CenterLabelToParent(sAL);
                player = new System.Media.SoundPlayer(@"..\..\Resources\Audios\success-1-6297.wav");

            }
            else if (temp < 37.2)
            {
                tML1.ForeColor = Color.Orange;
                sAL.Text = "Ξεκουραστείτε για 5 λεπτά και ξαναδοκιμάστε!";
                CenterLabelToParent(sAL);
                player = new System.Media.SoundPlayer(@"..\..\Resources\Audios\wrong-buzzer-6268.wav");
            }
            else if (temp < 38)
            {
                tML1.ForeColor = Color.Red;
                sAL.Text = "Δεν μπορείτε να περάσετε! Καλό θα ήταν γυρίσετε σπίτι σας!";
                CenterLabelToParent(sAL);
                player = new System.Media.SoundPlayer(@"..\..\Resources\Audios\wrong-buzzer-6268.wav");
            }
            else
            {
                tML1.ForeColor = Color.Red;
                sAL.Text = "Δεν μπορείτε να περάσετε, προτείνω rapid test covid19," +
                    " το συντομότερο διαγνωστικό κεντρό βρίσκεται σε απόσταση 500 μέτρων(Νοσοκομείο Ευαγγέλισμός)!";
                CenterLabelToParent(sAL);
                player = new System.Media.SoundPlayer(@"..\..\Resources\Audios\wrong-buzzer-6268.wav");
            }

            List<Label> labels = new List<Label> {sAL,LineLabel3,LineLabel4};
            TransmitLabelColorToBlack(labels);

            player.Play();
            tML1.Text = "Η θερμοκρασία σας : " + temp.ToString() + " °C";
            //tML1.ForeColor = Color.Red;
            CenterLabelToParent(tML1);

            //TransitLabelColorToRed(tML1);

            loadingPictureBox.Visible = false;
            sAL.Visible = true;
        }

        public int ticks2 = 0;
        private void messageTimer_Tick(object sender, EventArgs e)
        {

            if (ticks2 == 1)
            {
                loadingPictureBox.Visible = true;
                tML1.Text = "Σταθείτε εδώ για τέσσερα(4) δευτερόλεπτα";

                List<Label> labels = new List<Label> {tML1,LineLabel1,LineLabel2};
                TransmitLabelColorToBlack(labels);
            }else if (ticks2 == 3)
            {
                GetTemperature();

                (sender as Timer).Enabled = false;
                ticks2 = 0;
            }

            ticks2 += 1;
        }

        public void TransmitLabelColorToBlack(List<Label> labels)
        {
            LabelsToTransmit.Clear();
            foreach (Label label in labels)
            {
                label.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                LabelsToTransmit.Add(label);
            }


            ColorTransitToBlackTimer.Interval = 20;
            ColorTransitToBlackTimer.Enabled = true;

        }

        public void TransmitLabelColorToRed(List<Label> labels)
        {
            LabelsToTransmit.Clear();
            foreach (Label label in labels)
            {
                label.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                LabelsToTransmit.Add(label);
            }
            //label.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            //LabelsToTransmit = label;
            ColorTransmitToRedTimer.Interval = 20;
            ColorTransmitToRedTimer.Enabled = true;
        }

        public int ticks = 0;
        public int r = 0;
        public int g = 0;
        public int b = 0;

        private void ColorTransitToBlackTimer_Tick(object sender, EventArgs e)
        {
            foreach (Label label in LabelsToTransmit)
            {
                label.ForeColor = System.Drawing.Color.FromArgb(255 - r, 255 - g, 255 - b);
            }
            //LabelToTrasmit.ForeColor = System.Drawing.Color.FromArgb(255-r, 255-g, 255-b);

            if (r < 250)
            {
                r += 10;
                g += 10;
                b += 10;
            }else if (r == 250)
            {
                r += 5;
                g += 5;
                b += 5;
            }
            else
            {
                r = 0;
                g = 0;
                b = 0;
                ticks = 0;
                (sender as Timer).Enabled = false;
                //if ((sender as Timer).Enabled == false)
                //{
                //    MessageBox.Show("!!!!!!!!!!");
                //}
                //(sender as Timer).Enabled = false;
            }

            ticks += 1;
        }


        public int ticks3 = 0;
        public int r3 = 0;
        public int g3 = 0;
        public int b3 = 0;
        private void ColorTransmitToRedTimer_Tick(object sender, EventArgs e)
        {
            foreach (Label label in LabelsToTransmit)
            {
                label.ForeColor = System.Drawing.Color.FromArgb(255 - r, 255 - g, 255 - b);
            }
            //LabelsToTrasmit.ForeColor = System.Drawing.Color.FromArgb(255 - r, 255 - g, 255 - b);

            if (g < 250)
            {
                g += 10;
                b += 10;
            }
            else if (r == 250)
            {
                g += 5;
                b += 5;
            }
            else
            {
                r = 0;
                g = 0;
                b = 0;
                ticks3 = 0;
                (sender as Timer).Enabled = false;
            }

            ticks3 += 1;
        }
    }
}
