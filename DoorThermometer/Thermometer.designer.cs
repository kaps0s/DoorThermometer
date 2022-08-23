
namespace UI_UX_VIRVOU.Forms
{
    partial class Thermometer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sAL = new System.Windows.Forms.Label();
            this.loadingPictureBox = new System.Windows.Forms.PictureBox();
            this.tML1 = new System.Windows.Forms.Label();
            this.triggerEventIconButton = new FontAwesome.Sharp.IconButton();
            this.doorCamPictureBox = new System.Windows.Forms.PictureBox();
            this.tMPanel1 = new System.Windows.Forms.Panel();
            this.sApanel = new System.Windows.Forms.Panel();
            this.LineLabel4 = new System.Windows.Forms.Label();
            this.LineLabel3 = new System.Windows.Forms.Label();
            this.MessageTimer = new System.Windows.Forms.Timer(this.components);
            this.ColorTransitToBlackTimer = new System.Windows.Forms.Timer(this.components);
            this.ColorTransmitToRedTimer = new System.Windows.Forms.Timer(this.components);
            this.LineLabel1 = new System.Windows.Forms.Label();
            this.LineLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorCamPictureBox)).BeginInit();
            this.tMPanel1.SuspendLayout();
            this.sApanel.SuspendLayout();
            this.SuspendLayout();
            //
            // sAL
            //
            this.sAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sAL.AutoEllipsis = true;
            this.sAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAL.Location = new System.Drawing.Point(3, 122);
            this.sAL.Name = "sAL";
            this.sAL.Size = new System.Drawing.Size(45, 48);
            this.sAL.TabIndex = 10;
            this.sAL.Text = "x";
            this.sAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sAL.Click += new System.EventHandler(this.suggestActionLabel_Click);
            //
            // loadingPictureBox
            //
            this.loadingPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingPictureBox.Location = new System.Drawing.Point(343, 70);
            this.loadingPictureBox.Name = "loadingPictureBox";
            this.loadingPictureBox.Size = new System.Drawing.Size(212, 201);
            this.loadingPictureBox.TabIndex = 9;
            this.loadingPictureBox.TabStop = false;
            //
            // tML1
            //
            this.tML1.AutoSize = true;
            this.tML1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tML1.Location = new System.Drawing.Point(3, 16);
            this.tML1.Name = "tML1";
            this.tML1.Size = new System.Drawing.Size(30, 32);
            this.tML1.TabIndex = 8;
            this.tML1.Text = "x";
            this.tML1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // triggerEventIconButton
            //
            this.triggerEventIconButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.triggerEventIconButton.IconColor = System.Drawing.Color.Black;
            this.triggerEventIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.triggerEventIconButton.Location = new System.Drawing.Point(0, 0);
            this.triggerEventIconButton.Name = "triggerEventIconButton";
            this.triggerEventIconButton.Size = new System.Drawing.Size(285, 41);
            this.triggerEventIconButton.TabIndex = 7;
            this.triggerEventIconButton.Text = "Ενεργοποίηση Θερμομέτρου";
            this.triggerEventIconButton.UseVisualStyleBackColor = true;
            this.triggerEventIconButton.Click += new System.EventHandler(this.triggerEventIconButton_Click);
            //
            // doorCamPictureBox
            //
            this.doorCamPictureBox.Location = new System.Drawing.Point(915, 0);
            this.doorCamPictureBox.Name = "doorCamPictureBox";
            this.doorCamPictureBox.Size = new System.Drawing.Size(985, 906);
            this.doorCamPictureBox.TabIndex = 6;
            this.doorCamPictureBox.TabStop = false;
            //
            // tMPanel1
            //
            this.tMPanel1.Controls.Add(this.LineLabel1);
            this.tMPanel1.Controls.Add(this.tML1);
            this.tMPanel1.Location = new System.Drawing.Point(12, 151);
            this.tMPanel1.Name = "tMPanel1";
            this.tMPanel1.Size = new System.Drawing.Size(897, 209);
            this.tMPanel1.TabIndex = 11;
            //
            // sApanel
            //
            this.sApanel.Controls.Add(this.LineLabel4);
            this.sApanel.Controls.Add(this.loadingPictureBox);
            this.sApanel.Controls.Add(this.sAL);
            this.sApanel.Controls.Add(this.LineLabel3);
            this.sApanel.Location = new System.Drawing.Point(12, 402);
            this.sApanel.Name = "sApanel";
            this.sApanel.Size = new System.Drawing.Size(897, 362);
            this.sApanel.TabIndex = 12;
            //
            // LineLabel4
            //
            this.LineLabel4.Location = new System.Drawing.Point(-3, 311);
            this.LineLabel4.Name = "LineLabel4";
            this.LineLabel4.Size = new System.Drawing.Size(897, 23);
            this.LineLabel4.TabIndex = 16;
            this.LineLabel4.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "__";
            //
            // LineLabel3
            //
            this.LineLabel3.Location = new System.Drawing.Point(-3, 95);
            this.LineLabel3.Name = "LineLabel3";
            this.LineLabel3.Size = new System.Drawing.Size(897, 27);
            this.LineLabel3.TabIndex = 15;
            this.LineLabel3.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "__";
            //
            // MessageTimer
            //
            this.MessageTimer.Tick += new System.EventHandler(this.messageTimer_Tick);
            //
            // ColorTransitToBlackTimer
            //
            this.ColorTransitToBlackTimer.Tick += new System.EventHandler(this.ColorTransitToBlackTimer_Tick);
            //
            // ColorTransmitToRedTimer
            //
            this.ColorTransmitToRedTimer.Tick += new System.EventHandler(this.ColorTransmitToRedTimer_Tick);
            //
            // LineLabel1
            //
            this.LineLabel1.Location = new System.Drawing.Point(-3, 0);
            this.LineLabel1.Name = "LineLabel1";
            this.LineLabel1.Size = new System.Drawing.Size(897, 23);
            this.LineLabel1.TabIndex = 13;
            this.LineLabel1.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "__\r\n";
            //
            // LineLabel2
            //
            this.LineLabel2.Location = new System.Drawing.Point(9, 350);
            this.LineLabel2.Name = "LineLabel2";
            this.LineLabel2.Size = new System.Drawing.Size(897, 23);
            this.LineLabel2.TabIndex = 14;
            this.LineLabel2.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "__";
            //
            // Thermometer
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 907);
            this.Controls.Add(this.sApanel);
            this.Controls.Add(this.LineLabel2);
            this.Controls.Add(this.tMPanel1);
            this.Controls.Add(this.triggerEventIconButton);
            this.Controls.Add(this.doorCamPictureBox);
            this.Name = "Thermometer";
            this.Text = "Thermometer";
            this.Load += new System.EventHandler(this.Thermometer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorCamPictureBox)).EndInit();
            this.tMPanel1.ResumeLayout(false);
            this.tMPanel1.PerformLayout();
            this.sApanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label sAL;
        private System.Windows.Forms.PictureBox loadingPictureBox;
        private System.Windows.Forms.Label tML1;
        private FontAwesome.Sharp.IconButton triggerEventIconButton;
        private System.Windows.Forms.PictureBox doorCamPictureBox;
        private System.Windows.Forms.Panel tMPanel1;
        private System.Windows.Forms.Panel sApanel;
        private System.Windows.Forms.Timer MessageTimer;
        private System.Windows.Forms.Timer ColorTransitToBlackTimer;
        private System.Windows.Forms.Timer ColorTransmitToRedTimer;
        private System.Windows.Forms.Label LineLabel4;
        private System.Windows.Forms.Label LineLabel3;
        private System.Windows.Forms.Label LineLabel1;
        private System.Windows.Forms.Label LineLabel2;
    }
}
