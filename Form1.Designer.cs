namespace LR4_Video
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.watchBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openImageBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.moveForwardBox = new System.Windows.Forms.PictureBox();
            this.checkedFilterBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.smax = new System.Windows.Forms.TextBox();
            this.hmax = new System.Windows.Forms.TextBox();
            this.smin = new System.Windows.Forms.TextBox();
            this.vmax = new System.Windows.Forms.TextBox();
            this.vmin = new System.Windows.Forms.TextBox();
            this.hmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMinContourSize = new System.Windows.Forms.TextBox();
            this.textBoxMaxContourSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.filterBox = new System.Windows.Forms.CheckBox();
            this.fpsBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.askTempBtn = new System.Windows.Forms.CheckBox();
            this.stopSignBox = new System.Windows.Forms.PictureBox();
            this.leftSighBox = new System.Windows.Forms.PictureBox();
            this.leftPercentBox = new System.Windows.Forms.TextBox();
            this.stopPercentBox = new System.Windows.Forms.TextBox();
            this.mfPercentBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.autoBox = new System.Windows.Forms.CheckBox();
            this.tempBtn = new System.Windows.Forms.Button();
            this.detectObjBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveForwardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopSignBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSighBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watchBtn,
            this.toolStripSeparator1,
            this.openImageBtn,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(508, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // watchBtn
            // 
            this.watchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.watchBtn.Image = ((System.Drawing.Image)(resources.GetObject("watchBtn.Image")));
            this.watchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.watchBtn.Name = "watchBtn";
            this.watchBtn.Size = new System.Drawing.Size(56, 24);
            this.watchBtn.Text = "Видео";
            this.watchBtn.Click += new System.EventHandler(this.watchBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // openImageBtn
            // 
            this.openImageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openImageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openImageBtn.Name = "openImageBtn";
            this.openImageBtn.Size = new System.Drawing.Size(111, 24);
            this.openImageBtn.Text = "Изображение";
            this.openImageBtn.Click += new System.EventHandler(this.openImageBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // moveForwardBox
            // 
            this.moveForwardBox.Location = new System.Drawing.Point(10, 52);
            this.moveForwardBox.Name = "moveForwardBox";
            this.moveForwardBox.Size = new System.Drawing.Size(80, 80);
            this.moveForwardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moveForwardBox.TabIndex = 3;
            this.moveForwardBox.TabStop = false;
            // 
            // checkedFilterBox
            // 
            this.checkedFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checkedFilterBox.FormattingEnabled = true;
            this.checkedFilterBox.Items.AddRange(new object[] {
            "CvtColor",
            "InRangeS",
            "Canny",
            "Filter2D",
            "Smooth",
            "Normal"});
            this.checkedFilterBox.Location = new System.Drawing.Point(12, 64);
            this.checkedFilterBox.Name = "checkedFilterBox";
            this.checkedFilterBox.Size = new System.Drawing.Size(127, 24);
            this.checkedFilterBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите фильтр:";
            // 
            // smax
            // 
            this.smax.Location = new System.Drawing.Point(68, 124);
            this.smax.Name = "smax";
            this.smax.Size = new System.Drawing.Size(48, 22);
            this.smax.TabIndex = 15;
            // 
            // hmax
            // 
            this.hmax.Location = new System.Drawing.Point(68, 59);
            this.hmax.Name = "hmax";
            this.hmax.Size = new System.Drawing.Size(48, 22);
            this.hmax.TabIndex = 14;
            // 
            // smin
            // 
            this.smin.Location = new System.Drawing.Point(68, 96);
            this.smin.Name = "smin";
            this.smin.Size = new System.Drawing.Size(48, 22);
            this.smin.TabIndex = 13;
            // 
            // vmax
            // 
            this.vmax.Location = new System.Drawing.Point(187, 59);
            this.vmax.Name = "vmax";
            this.vmax.Size = new System.Drawing.Size(48, 22);
            this.vmax.TabIndex = 12;
            // 
            // vmin
            // 
            this.vmin.Location = new System.Drawing.Point(187, 31);
            this.vmin.Name = "vmin";
            this.vmin.Size = new System.Drawing.Size(48, 22);
            this.vmin.TabIndex = 11;
            // 
            // hmin
            // 
            this.hmin.Location = new System.Drawing.Point(69, 31);
            this.hmin.Name = "hmin";
            this.hmin.Size = new System.Drawing.Size(48, 22);
            this.hmin.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hmin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Hmax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Smin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Smax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Vmin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Vmax";
            // 
            // textBoxMinContourSize
            // 
            this.textBoxMinContourSize.Location = new System.Drawing.Point(15, 122);
            this.textBoxMinContourSize.Name = "textBoxMinContourSize";
            this.textBoxMinContourSize.Size = new System.Drawing.Size(79, 22);
            this.textBoxMinContourSize.TabIndex = 26;
            // 
            // textBoxMaxContourSize
            // 
            this.textBoxMaxContourSize.Location = new System.Drawing.Point(102, 122);
            this.textBoxMaxContourSize.Name = "textBoxMaxContourSize";
            this.textBoxMaxContourSize.Size = new System.Drawing.Size(79, 22);
            this.textBoxMaxContourSize.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "MinSize";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "MaxSize";
            // 
            // filterBox
            // 
            this.filterBox.AutoSize = true;
            this.filterBox.Location = new System.Drawing.Point(15, 49);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(109, 20);
            this.filterBox.TabIndex = 40;
            this.filterBox.Text = "Фильтрация";
            this.filterBox.UseVisualStyleBackColor = true;
            this.filterBox.CheckedChanged += new System.EventHandler(this.filterBox_CheckedChanged);
            // 
            // fpsBox
            // 
            this.fpsBox.Location = new System.Drawing.Point(163, 64);
            this.fpsBox.Name = "fpsBox";
            this.fpsBox.ReadOnly = true;
            this.fpsBox.Size = new System.Drawing.Size(51, 22);
            this.fpsBox.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(169, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 16);
            this.label13.TabIndex = 42;
            this.label13.Text = "FPS";
            // 
            // askTempBtn
            // 
            this.askTempBtn.AutoSize = true;
            this.askTempBtn.Location = new System.Drawing.Point(15, 75);
            this.askTempBtn.Name = "askTempBtn";
            this.askTempBtn.Size = new System.Drawing.Size(166, 20);
            this.askTempBtn.TabIndex = 43;
            this.askTempBtn.Text = "Сохранить шаблоны?";
            this.askTempBtn.UseVisualStyleBackColor = true;
            // 
            // stopSignBox
            // 
            this.stopSignBox.Location = new System.Drawing.Point(96, 52);
            this.stopSignBox.Name = "stopSignBox";
            this.stopSignBox.Size = new System.Drawing.Size(80, 80);
            this.stopSignBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stopSignBox.TabIndex = 44;
            this.stopSignBox.TabStop = false;
            // 
            // leftSighBox
            // 
            this.leftSighBox.Location = new System.Drawing.Point(182, 52);
            this.leftSighBox.Name = "leftSighBox";
            this.leftSighBox.Size = new System.Drawing.Size(80, 80);
            this.leftSighBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftSighBox.TabIndex = 45;
            this.leftSighBox.TabStop = false;
            // 
            // leftPercentBox
            // 
            this.leftPercentBox.Location = new System.Drawing.Point(182, 138);
            this.leftPercentBox.Name = "leftPercentBox";
            this.leftPercentBox.ReadOnly = true;
            this.leftPercentBox.Size = new System.Drawing.Size(80, 22);
            this.leftPercentBox.TabIndex = 65;
            // 
            // stopPercentBox
            // 
            this.stopPercentBox.Location = new System.Drawing.Point(96, 138);
            this.stopPercentBox.Name = "stopPercentBox";
            this.stopPercentBox.ReadOnly = true;
            this.stopPercentBox.Size = new System.Drawing.Size(80, 22);
            this.stopPercentBox.TabIndex = 64;
            // 
            // mfPercentBox
            // 
            this.mfPercentBox.Location = new System.Drawing.Point(10, 138);
            this.mfPercentBox.Name = "mfPercentBox";
            this.mfPercentBox.ReadOnly = true;
            this.mfPercentBox.Size = new System.Drawing.Size(80, 22);
            this.mfPercentBox.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 66;
            this.label11.Text = "Forward";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(108, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 67;
            this.label14.Text = "STOP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(207, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 16);
            this.label15.TabIndex = 68;
            this.label15.Text = "Left";
            // 
            // autoBox
            // 
            this.autoBox.AutoSize = true;
            this.autoBox.Location = new System.Drawing.Point(15, 23);
            this.autoBox.Name = "autoBox";
            this.autoBox.Size = new System.Drawing.Size(104, 20);
            this.autoBox.TabIndex = 69;
            this.autoBox.Text = "АвтоРежим";
            this.autoBox.UseVisualStyleBackColor = true;
            this.autoBox.CheckedChanged += new System.EventHandler(this.autoBox_CheckedChanged);
            // 
            // tempBtn
            // 
            this.tempBtn.Enabled = false;
            this.tempBtn.Location = new System.Drawing.Point(12, 330);
            this.tempBtn.Name = "tempBtn";
            this.tempBtn.Size = new System.Drawing.Size(202, 36);
            this.tempBtn.TabIndex = 70;
            this.tempBtn.Text = "Загрузить шаблон";
            this.tempBtn.UseVisualStyleBackColor = true;
            this.tempBtn.Click += new System.EventHandler(this.tempBtn_Click);
            // 
            // detectObjBtn
            // 
            this.detectObjBtn.Location = new System.Drawing.Point(12, 292);
            this.detectObjBtn.Name = "detectObjBtn";
            this.detectObjBtn.Size = new System.Drawing.Size(202, 36);
            this.detectObjBtn.TabIndex = 71;
            this.detectObjBtn.Text = "Детектировать объекты";
            this.detectObjBtn.UseVisualStyleBackColor = true;
            this.detectObjBtn.Click += new System.EventHandler(this.detectObjBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.hmin);
            this.groupBox1.Controls.Add(this.smin);
            this.groupBox1.Controls.Add(this.hmax);
            this.groupBox1.Controls.Add(this.smax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.vmin);
            this.groupBox1.Controls.Add(this.vmax);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(229, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 173);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цветовой ключ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.leftSighBox);
            this.groupBox2.Controls.Add(this.moveForwardBox);
            this.groupBox2.Controls.Add(this.stopSignBox);
            this.groupBox2.Controls.Add(this.mfPercentBox);
            this.groupBox2.Controls.Add(this.stopPercentBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.leftPercentBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(229, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 175);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.autoBox);
            this.groupBox3.Controls.Add(this.textBoxMinContourSize);
            this.groupBox3.Controls.Add(this.textBoxMaxContourSize);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.filterBox);
            this.groupBox3.Controls.Add(this.askTempBtn);
            this.groupBox3.Location = new System.Drawing.Point(12, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 158);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 378);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.detectObjBtn);
            this.Controls.Add(this.tempBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.fpsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedFilterBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "FedotovaTA221-328";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveForwardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopSignBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSighBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton watchBtn;
        private System.Windows.Forms.ToolStripButton openImageBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PictureBox moveForwardBox;
        private System.Windows.Forms.ComboBox checkedFilterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox smax;
        private System.Windows.Forms.TextBox hmax;
        private System.Windows.Forms.TextBox smin;
        private System.Windows.Forms.TextBox vmax;
        private System.Windows.Forms.TextBox vmin;
        private System.Windows.Forms.TextBox hmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMinContourSize;
        private System.Windows.Forms.TextBox textBoxMaxContourSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox filterBox;
        private System.Windows.Forms.TextBox fpsBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox askTempBtn;
        private System.Windows.Forms.PictureBox stopSignBox;
        private System.Windows.Forms.PictureBox leftSighBox;
        private System.Windows.Forms.TextBox leftPercentBox;
        private System.Windows.Forms.TextBox stopPercentBox;
        private System.Windows.Forms.TextBox mfPercentBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox autoBox;
        private System.Windows.Forms.Button tempBtn;
        private System.Windows.Forms.Button detectObjBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

