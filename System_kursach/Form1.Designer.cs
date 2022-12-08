namespace System_kursach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.lblSpread = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGraviton = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGrav = new System.Windows.Forms.Label();
            this.tbGraviton2 = new System.Windows.Forms.TrackBar();
            this.lblGrav2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(4, 1);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(776, 436);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(12, 462);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(135, 45);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Направление";
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(153, 462);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(17, 13);
            this.lblDirection.TabIndex = 3;
            this.lblDirection.Text = "0°";
            // 
            // tbSpreading
            // 
            this.tbSpreading.Location = new System.Drawing.Point(195, 460);
            this.tbSpreading.Maximum = 359;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(135, 45);
            this.tbSpreading.TabIndex = 4;
            this.tbSpreading.Scroll += new System.EventHandler(this.tbSpreading_Scroll);
            // 
            // lblSpread
            // 
            this.lblSpread.AutoSize = true;
            this.lblSpread.Location = new System.Drawing.Point(336, 462);
            this.lblSpread.Name = "lblSpread";
            this.lblSpread.Size = new System.Drawing.Size(17, 13);
            this.lblSpread.TabIndex = 5;
            this.lblSpread.Text = "0°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Разброс";
            // 
            // tbGraviton
            // 
            this.tbGraviton.Location = new System.Drawing.Point(359, 462);
            this.tbGraviton.Maximum = 100;
            this.tbGraviton.Name = "tbGraviton";
            this.tbGraviton.Size = new System.Drawing.Size(135, 45);
            this.tbGraviton.TabIndex = 7;
            this.tbGraviton.Scroll += new System.EventHandler(this.tbGraviton_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Сила гравитонов";
            // 
            // lblGrav
            // 
            this.lblGrav.AutoSize = true;
            this.lblGrav.Location = new System.Drawing.Point(500, 462);
            this.lblGrav.Name = "lblGrav";
            this.lblGrav.Size = new System.Drawing.Size(13, 13);
            this.lblGrav.TabIndex = 9;
            this.lblGrav.Text = "0";
            // 
            // tbGraviton2
            // 
            this.tbGraviton2.Location = new System.Drawing.Point(519, 460);
            this.tbGraviton2.Maximum = 100;
            this.tbGraviton2.Name = "tbGraviton2";
            this.tbGraviton2.Size = new System.Drawing.Size(135, 45);
            this.tbGraviton2.TabIndex = 10;
            this.tbGraviton2.Scroll += new System.EventHandler(this.tbGraviton2_Scroll);
            // 
            // lblGrav2
            // 
            this.lblGrav2.AutoSize = true;
            this.lblGrav2.Location = new System.Drawing.Point(660, 462);
            this.lblGrav2.Name = "lblGrav2";
            this.lblGrav2.Size = new System.Drawing.Size(13, 13);
            this.lblGrav2.TabIndex = 11;
            this.lblGrav2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 518);
            this.Controls.Add(this.lblGrav2);
            this.Controls.Add(this.tbGraviton2);
            this.Controls.Add(this.lblGrav);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGraviton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSpread);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Honda Civic type R";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.Label lblSpread;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbGraviton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGrav;
        private System.Windows.Forms.TrackBar tbGraviton2;
        private System.Windows.Forms.Label lblGrav2;
    }
}

