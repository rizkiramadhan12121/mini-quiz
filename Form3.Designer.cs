namespace ProgramMiniquiz
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.TrueD = new System.Windows.Forms.RadioButton();
            this.optionA = new System.Windows.Forms.RadioButton();
            this.TrueB = new System.Windows.Forms.RadioButton();
            this.TrueC = new System.Windows.Forms.RadioButton();
            this.timeResult = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Apa Bahasa Inggris Dari Warna Di atas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pertanyaan 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(39, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 88);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(94, 367);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(136, 50);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // TrueD
            // 
            this.TrueD.AutoSize = true;
            this.TrueD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueD.Location = new System.Drawing.Point(65, 326);
            this.TrueD.Name = "TrueD";
            this.TrueD.Size = new System.Drawing.Size(76, 20);
            this.TrueD.TabIndex = 19;
            this.TrueD.TabStop = true;
            this.TrueD.Text = "Orange";
            this.TrueD.UseVisualStyleBackColor = true;
            // 
            // optionA
            // 
            this.optionA.AutoSize = true;
            this.optionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionA.Location = new System.Drawing.Point(65, 192);
            this.optionA.Name = "optionA";
            this.optionA.Size = new System.Drawing.Size(71, 20);
            this.optionA.TabIndex = 18;
            this.optionA.TabStop = true;
            this.optionA.Text = "Yellow";
            this.optionA.UseVisualStyleBackColor = true;
            // 
            // TrueB
            // 
            this.TrueB.AutoSize = true;
            this.TrueB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueB.Location = new System.Drawing.Point(65, 235);
            this.TrueB.Name = "TrueB";
            this.TrueB.Size = new System.Drawing.Size(55, 20);
            this.TrueB.TabIndex = 17;
            this.TrueB.TabStop = true;
            this.TrueB.Text = "blue";
            this.TrueB.UseVisualStyleBackColor = true;
            // 
            // TrueC
            // 
            this.TrueC.AutoSize = true;
            this.TrueC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueC.Location = new System.Drawing.Point(65, 281);
            this.TrueC.Name = "TrueC";
            this.TrueC.Size = new System.Drawing.Size(78, 20);
            this.TrueC.TabIndex = 16;
            this.TrueC.Text = "Purpule";
            this.TrueC.UseVisualStyleBackColor = true;
            // 
            // timeResult
            // 
            this.timeResult.AutoSize = true;
            this.timeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.timeResult.Location = new System.Drawing.Point(282, 16);
            this.timeResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeResult.Name = "timeResult";
            this.timeResult.Size = new System.Drawing.Size(24, 18);
            this.timeResult.TabIndex = 24;
            this.timeResult.Text = "30";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.timeResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.TrueD);
            this.Controls.Add(this.optionA);
            this.Controls.Add(this.TrueB);
            this.Controls.Add(this.TrueC);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton TrueD;
        private System.Windows.Forms.RadioButton optionA;
        private System.Windows.Forms.RadioButton TrueB;
        private System.Windows.Forms.RadioButton TrueC;
        private System.Windows.Forms.Label timeResult;
        private System.Windows.Forms.Timer timer1;
    }
}