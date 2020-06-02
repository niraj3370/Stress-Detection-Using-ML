namespace AnomalyDetectionSample
{
    partial class Main
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
            this.btnTraining = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccuracy = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtThal = new System.Windows.Forms.TextBox();
            this.txtCa = new System.Windows.Forms.TextBox();
            this.txtSlope = new System.Windows.Forms.TextBox();
            this.txtOldPeak = new System.Windows.Forms.TextBox();
            this.txtExang = new System.Windows.Forms.TextBox();
            this.txtThalac = new System.Windows.Forms.TextBox();
            this.txtRestEcg = new System.Windows.Forms.TextBox();
            this.txtFbs = new System.Windows.Forms.TextBox();
            this.txtChol = new System.Windows.Forms.TextBox();
            this.txtTrestBps = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTraining
            // 
            this.btnTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraining.Location = new System.Drawing.Point(192, 34);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(11, 48);
            this.btnTraining.TabIndex = 0;
            this.btnTraining.Text = "Training";
            this.btnTraining.UseVisualStyleBackColor = true;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accuracy :";
            // 
            // txtAccuracy
            // 
            this.txtAccuracy.Location = new System.Drawing.Point(414, 50);
            this.txtAccuracy.Name = "txtAccuracy";
            this.txtAccuracy.Size = new System.Drawing.Size(16, 29);
            this.txtAccuracy.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(355, 344);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(182, 78);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTraining);
            this.groupBox1.Controls.Add(this.txtAccuracy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1052, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtThal);
            this.groupBox2.Controls.Add(this.txtCa);
            this.groupBox2.Controls.Add(this.txtSlope);
            this.groupBox2.Controls.Add(this.txtOldPeak);
            this.groupBox2.Controls.Add(this.txtExang);
            this.groupBox2.Controls.Add(this.txtThalac);
            this.groupBox2.Controls.Add(this.txtRestEcg);
            this.groupBox2.Controls.Add(this.txtFbs);
            this.groupBox2.Controls.Add(this.txtChol);
            this.groupBox2.Controls.Add(this.txtTrestBps);
            this.groupBox2.Controls.Add(this.txtCp);
            this.groupBox2.Controls.Add(this.txtSex);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnTest);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 465);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Testing";
            // 
            // txtThal
            // 
            this.txtThal.Location = new System.Drawing.Point(437, 236);
            this.txtThal.Name = "txtThal";
            this.txtThal.Size = new System.Drawing.Size(100, 23);
            this.txtThal.TabIndex = 25;
            this.txtThal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThal_KeyPress);
            // 
            // txtCa
            // 
            this.txtCa.Location = new System.Drawing.Point(437, 185);
            this.txtCa.Name = "txtCa";
            this.txtCa.Size = new System.Drawing.Size(100, 23);
            this.txtCa.TabIndex = 24;
            this.txtCa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCa_KeyPress);
            // 
            // txtSlope
            // 
            this.txtSlope.Location = new System.Drawing.Point(437, 134);
            this.txtSlope.Name = "txtSlope";
            this.txtSlope.Size = new System.Drawing.Size(100, 23);
            this.txtSlope.TabIndex = 23;
            this.txtSlope.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSlope_KeyPress);
            // 
            // txtOldPeak
            // 
            this.txtOldPeak.Location = new System.Drawing.Point(437, 83);
            this.txtOldPeak.Name = "txtOldPeak";
            this.txtOldPeak.Size = new System.Drawing.Size(100, 23);
            this.txtOldPeak.TabIndex = 22;
            this.txtOldPeak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOldPeak_KeyPress);
            // 
            // txtExang
            // 
            this.txtExang.Location = new System.Drawing.Point(437, 32);
            this.txtExang.Name = "txtExang";
            this.txtExang.Size = new System.Drawing.Size(100, 23);
            this.txtExang.TabIndex = 21;
            this.txtExang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExang_KeyPress);
            // 
            // txtThalac
            // 
            this.txtThalac.Location = new System.Drawing.Point(119, 396);
            this.txtThalac.Name = "txtThalac";
            this.txtThalac.Size = new System.Drawing.Size(100, 23);
            this.txtThalac.TabIndex = 20;
            this.txtThalac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThalac_KeyPress);
            // 
            // txtRestEcg
            // 
            this.txtRestEcg.Location = new System.Drawing.Point(119, 344);
            this.txtRestEcg.Name = "txtRestEcg";
            this.txtRestEcg.Size = new System.Drawing.Size(100, 23);
            this.txtRestEcg.TabIndex = 19;
            this.txtRestEcg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRestEcg_KeyPress);
            // 
            // txtFbs
            // 
            this.txtFbs.Location = new System.Drawing.Point(119, 292);
            this.txtFbs.Name = "txtFbs";
            this.txtFbs.Size = new System.Drawing.Size(100, 23);
            this.txtFbs.TabIndex = 18;
            this.txtFbs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFbs_KeyPress);
            // 
            // txtChol
            // 
            this.txtChol.Location = new System.Drawing.Point(119, 240);
            this.txtChol.Name = "txtChol";
            this.txtChol.Size = new System.Drawing.Size(100, 23);
            this.txtChol.TabIndex = 17;
            this.txtChol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChol_KeyPress);
            // 
            // txtTrestBps
            // 
            this.txtTrestBps.Location = new System.Drawing.Point(119, 188);
            this.txtTrestBps.Name = "txtTrestBps";
            this.txtTrestBps.Size = new System.Drawing.Size(100, 23);
            this.txtTrestBps.TabIndex = 16;
            this.txtTrestBps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrestBps_KeyPress);
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(119, 136);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(100, 23);
            this.txtCp.TabIndex = 15;
            this.txtCp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCp_KeyPress);
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(119, 84);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 23);
            this.txtSex.TabIndex = 14;
            this.txtSex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSex_KeyPress);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(119, 32);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 23);
            this.txtAge.TabIndex = 13;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(352, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Thal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(352, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Ca";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(352, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Slope";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "OldPeak";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Exang";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Thalac";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "RestEcg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fbs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "TrestBps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "CP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Age";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(241, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Please enter only number";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(295, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 29);
            this.label16.TabIndex = 7;
            this.label16.Text = "Testing";
            this.label16.Click += new System.EventHandler(this.Label16_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(731, 631);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stress Disease Prediction";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccuracy;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtThal;
        private System.Windows.Forms.TextBox txtCa;
        private System.Windows.Forms.TextBox txtSlope;
        private System.Windows.Forms.TextBox txtOldPeak;
        private System.Windows.Forms.TextBox txtExang;
        private System.Windows.Forms.TextBox txtThalac;
        private System.Windows.Forms.TextBox txtRestEcg;
        private System.Windows.Forms.TextBox txtFbs;
        private System.Windows.Forms.TextBox txtTrestBps;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtChol;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}