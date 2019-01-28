using System.Windows.Forms;

namespace YDM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextArea = new System.Windows.Forms.TextBox();
            this.AddAuto_Timer = new System.Windows.Forms.Timer(this.components);
            this.StartService_Timer = new System.Windows.Forms.Timer(this.components);
            this.YDMStation_1 = new System.Windows.Forms.PictureBox();
            this.YDMStation_3 = new System.Windows.Forms.PictureBox();
            this.YDMStation_2 = new System.Windows.Forms.PictureBox();
            this.YDMStation_5 = new System.Windows.Forms.PictureBox();
            this.YDMStation_6 = new System.Windows.Forms.PictureBox();
            this.YDMStation_4 = new System.Windows.Forms.PictureBox();
            this.YDMStation_8 = new System.Windows.Forms.PictureBox();
            this.YDMStation_9 = new System.Windows.Forms.PictureBox();
            this.YDMStation_7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.QuitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_7)).BeginInit();
            this.SuspendLayout();
            // 
            // TextArea
            // 
            this.TextArea.Location = new System.Drawing.Point(28, 13);
            this.TextArea.Multiline = true;
            this.TextArea.Name = "TextArea";
            this.TextArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextArea.Size = new System.Drawing.Size(281, 267);
            this.TextArea.TabIndex = 0;
            // 
            // AddAuto_Timer
            // 
            this.AddAuto_Timer.Interval = 1500;
            this.AddAuto_Timer.Tick += new System.EventHandler(this.AddAuto_Timer_Tick);
            // 
            // StartService_Timer
            // 
            this.StartService_Timer.Interval = 1000;
            this.StartService_Timer.Tick += new System.EventHandler(this.StartService_Timer_Tick);
            // 
            // YDMStation_1
            // 
            this.YDMStation_1.Image = ((System.Drawing.Image)(resources.GetObject("YDMStation_1.Image")));
            this.YDMStation_1.Location = new System.Drawing.Point(357, 12);
            this.YDMStation_1.Name = "YDMStation_1";
            this.YDMStation_1.Size = new System.Drawing.Size(100, 50);
            this.YDMStation_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YDMStation_1.TabIndex = 1;
            this.YDMStation_1.TabStop = false;
            // 
            // YDMStation_3
            // 
            this.YDMStation_3.Image = ((System.Drawing.Image)(resources.GetObject("YDMStation_3.Image")));
            this.YDMStation_3.Location = new System.Drawing.Point(672, 12);
            this.YDMStation_3.Name = "YDMStation_3";
            this.YDMStation_3.Size = new System.Drawing.Size(100, 50);
            this.YDMStation_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YDMStation_3.TabIndex = 2;
            this.YDMStation_3.TabStop = false;
            // 
            // YDMStation_2
            // 
            this.YDMStation_2.Image = ((System.Drawing.Image)(resources.GetObject("YDMStation_2.Image")));
            this.YDMStation_2.Location = new System.Drawing.Point(512, 12);
            this.YDMStation_2.Name = "YDMStation_2";
            this.YDMStation_2.Size = new System.Drawing.Size(100, 50);
            this.YDMStation_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YDMStation_2.TabIndex = 3;
            this.YDMStation_2.TabStop = false;
            // 
            // YDMStation_5
            // 
            this.YDMStation_5.Image = ((System.Drawing.Image)(resources.GetObject("YDMStation_5.Image")));
            this.YDMStation_5.Location = new System.Drawing.Point(512, 105);
            this.YDMStation_5.Name = "YDMStation_5";
            this.YDMStation_5.Size = new System.Drawing.Size(100, 50);
            this.YDMStation_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YDMStation_5.TabIndex = 6;
            this.YDMStation_5.TabStop = false;
            // 
            // YDMStation_6
            // 
            this.YDMStation_6.Image = ((System.Drawing.Image)(resources.GetObject("YDMStation_6.Image")));
            this.YDMStation_6.Location = new System.Drawing.Point(672, 105);
            this.YDMStation_6.Name = "YDMStation_6";
            this.YDMStation_6.Size = new System.Drawing.Size(100, 50);
            this.YDMStation_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YDMStation_6.TabIndex = 5;
            this.YDMStation_6.TabStop = false;
            // 
            // YDMStation_4
            // 
            this.YDMStation_4.Image = ((System.Drawing.Image)(resources.GetObject("YDMStation_4.Image")));
            this.YDMStation_4.Location = new System.Drawing.Point(357, 105);
            this.YDMStation_4.Name = "YDMStation_4";
            this.YDMStation_4.Size = new System.Drawing.Size(100, 50);
            this.YDMStation_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YDMStation_4.TabIndex = 4;
            this.YDMStation_4.TabStop = false;
            // 
            // YDMStation_8
            // 
            this.YDMStation_8.Image = ((System.Drawing.Image)(resources.GetObject("YDMStation_8.Image")));
            this.YDMStation_8.Location = new System.Drawing.Point(512, 194);
            this.YDMStation_8.Name = "YDMStation_8";
            this.YDMStation_8.Size = new System.Drawing.Size(100, 50);
            this.YDMStation_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YDMStation_8.TabIndex = 9;
            this.YDMStation_8.TabStop = false;
            // 
            // YDMStation_9
            // 
            this.YDMStation_9.Image = ((System.Drawing.Image)(resources.GetObject("YDMStation_9.Image")));
            this.YDMStation_9.Location = new System.Drawing.Point(672, 194);
            this.YDMStation_9.Name = "YDMStation_9";
            this.YDMStation_9.Size = new System.Drawing.Size(100, 50);
            this.YDMStation_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YDMStation_9.TabIndex = 8;
            this.YDMStation_9.TabStop = false;
            // 
            // YDMStation_7
            // 
            this.YDMStation_7.Image = ((System.Drawing.Image)(resources.GetObject("YDMStation_7.Image")));
            this.YDMStation_7.Location = new System.Drawing.Point(357, 194);
            this.YDMStation_7.Name = "YDMStation_7";
            this.YDMStation_7.Size = new System.Drawing.Size(100, 50);
            this.YDMStation_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YDMStation_7.TabIndex = 7;
            this.YDMStation_7.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Azad kassa :))";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Azad kassa :))";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(669, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Azad kassa :))";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Azad kassa :))";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Azad kassa :))";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(669, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Azad kassa :))";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Azad kassa :))";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Azad kassa :))";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(669, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Azad kassa :))";
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(28, 299);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(744, 72);
            this.QuitBtn.TabIndex = 19;
            this.QuitBtn.Text = "Q    U     I      T";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YDMStation_8);
            this.Controls.Add(this.YDMStation_9);
            this.Controls.Add(this.YDMStation_7);
            this.Controls.Add(this.YDMStation_5);
            this.Controls.Add(this.YDMStation_6);
            this.Controls.Add(this.YDMStation_4);
            this.Controls.Add(this.YDMStation_2);
            this.Controls.Add(this.YDMStation_3);
            this.Controls.Add(this.YDMStation_1);
            this.Controls.Add(this.TextArea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YDMStation_7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextArea;
        private System.Windows.Forms.Timer AddAuto_Timer;
        private System.Windows.Forms.Timer StartService_Timer;
        private PictureBox YDMStation_1;
        private PictureBox YDMStation_3;
        private PictureBox YDMStation_2;
        private PictureBox YDMStation_5;
        private PictureBox YDMStation_6;
        private PictureBox YDMStation_4;
        private PictureBox YDMStation_8;
        private PictureBox YDMStation_9;
        private PictureBox YDMStation_7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button QuitBtn;
    }
}

