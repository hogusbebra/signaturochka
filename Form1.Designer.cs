namespace signaturochka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.regbox = new System.Windows.Forms.TextBox();
            this.passwordbox_reg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regb = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordbox_log = new System.Windows.Forms.TextBox();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.logb = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mailbox = new System.Windows.Forms.TextBox();
            this.numbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // regbox
            // 
            this.regbox.Location = new System.Drawing.Point(75, 62);
            this.regbox.Name = "regbox";
            this.regbox.Size = new System.Drawing.Size(221, 20);
            this.regbox.TabIndex = 0;
            // 
            // passwordbox_reg
            // 
            this.passwordbox_reg.Location = new System.Drawing.Point(75, 88);
            this.passwordbox_reg.Name = "passwordbox_reg";
            this.passwordbox_reg.Size = new System.Drawing.Size(221, 20);
            this.passwordbox_reg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // regb
            // 
            this.regb.Location = new System.Drawing.Point(111, 178);
            this.regb.Name = "regb";
            this.regb.Size = new System.Drawing.Size(142, 24);
            this.regb.TabIndex = 4;
            this.regb.Text = "Зарегистрироваться";
            this.regb.UseVisualStyleBackColor = true;
            this.regb.Click += new System.EventHandler(this.regb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Логин";
            // 
            // passwordbox_log
            // 
            this.passwordbox_log.Location = new System.Drawing.Point(464, 91);
            this.passwordbox_log.Name = "passwordbox_log";
            this.passwordbox_log.Size = new System.Drawing.Size(221, 20);
            this.passwordbox_log.TabIndex = 6;
            // 
            // loginbox
            // 
            this.loginbox.Location = new System.Drawing.Point(464, 65);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(221, 20);
            this.loginbox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(122, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Регистрация";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(514, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Авторизация";
            // 
            // logb
            // 
            this.logb.Location = new System.Drawing.Point(507, 152);
            this.logb.Name = "logb";
            this.logb.Size = new System.Drawing.Size(142, 24);
            this.logb.TabIndex = 11;
            this.logb.Text = "Войти";
            this.logb.UseVisualStyleBackColor = true;
            this.logb.Click += new System.EventHandler(this.logb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // mailbox
            // 
            this.mailbox.Location = new System.Drawing.Point(75, 114);
            this.mailbox.Name = "mailbox";
            this.mailbox.Size = new System.Drawing.Size(221, 20);
            this.mailbox.TabIndex = 13;
            // 
            // numbox
            // 
            this.numbox.Location = new System.Drawing.Point(75, 140);
            this.numbox.Name = "numbox";
            this.numbox.Size = new System.Drawing.Size(221, 20);
            this.numbox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 117);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Почта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Номер";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numbox);
            this.Controls.Add(this.mailbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordbox_log);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.regb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordbox_reg);
            this.Controls.Add(this.regbox);
            this.Name = "Form1";
            this.Text = "Registation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regbox;
        private System.Windows.Forms.TextBox passwordbox_reg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button regb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordbox_log;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button logb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox mailbox;
        private System.Windows.Forms.TextBox numbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

