namespace WeatherForecastSiemens
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
            this.lvCurrentDay = new System.Windows.Forms.ListView();
            this.TimeOfDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbTempActual = new System.Windows.Forms.TextBox();
            this.lv7Days = new System.Windows.Forms.ListView();
            this.Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AvgTempDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbTempUnit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOras = new System.Windows.Forms.ComboBox();
            this.tbAstro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.tbWindSpeed = new System.Windows.Forms.TextBox();
            this.tbPrecipitation = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvCurrentDay
            // 
            this.lvCurrentDay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TimeOfDay,
            this.Temperature});
            this.lvCurrentDay.HideSelection = false;
            this.lvCurrentDay.Location = new System.Drawing.Point(43, 283);
            this.lvCurrentDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvCurrentDay.Name = "lvCurrentDay";
            this.lvCurrentDay.Size = new System.Drawing.Size(257, 215);
            this.lvCurrentDay.TabIndex = 0;
            this.lvCurrentDay.UseCompatibleStateImageBehavior = false;
            this.lvCurrentDay.View = System.Windows.Forms.View.Details;
            // 
            // TimeOfDay
            // 
            this.TimeOfDay.Text = "Time of day";
            this.TimeOfDay.Width = 102;
            // 
            // Temperature
            // 
            this.Temperature.Text = "Temperature";
            this.Temperature.Width = 101;
            // 
            // tbTempActual
            // 
            this.tbTempActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTempActual.Location = new System.Drawing.Point(44, 60);
            this.tbTempActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTempActual.Name = "tbTempActual";
            this.tbTempActual.Size = new System.Drawing.Size(172, 45);
            this.tbTempActual.TabIndex = 1;
            // 
            // lv7Days
            // 
            this.lv7Days.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Day,
            this.AvgTempDay});
            this.lv7Days.HideSelection = false;
            this.lv7Days.Location = new System.Drawing.Point(327, 146);
            this.lv7Days.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv7Days.Name = "lv7Days";
            this.lv7Days.Size = new System.Drawing.Size(313, 227);
            this.lv7Days.TabIndex = 3;
            this.lv7Days.UseCompatibleStateImageBehavior = false;
            this.lv7Days.View = System.Windows.Forms.View.Details;
            // 
            // Day
            // 
            this.Day.Text = "Day";
            this.Day.Width = 102;
            // 
            // AvgTempDay
            // 
            this.AvgTempDay.Text = "Average Temperature";
            this.AvgTempDay.Width = 129;
            // 
            // cbTempUnit
            // 
            this.cbTempUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTempUnit.FormattingEnabled = true;
            this.cbTempUnit.Items.AddRange(new object[] {
            "Celsius (C)",
            "Fahrenheit"});
            this.cbTempUnit.Location = new System.Drawing.Point(330, 71);
            this.cbTempUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTempUnit.Name = "cbTempUnit";
            this.cbTempUnit.Size = new System.Drawing.Size(318, 33);
            this.cbTempUnit.TabIndex = 4;
            this.cbTempUnit.SelectedIndexChanged += new System.EventHandler(this.cbTempUnit_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weather in this period";
            // 
            // cbOras
            // 
            this.cbOras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOras.FormattingEnabled = true;
            this.cbOras.Location = new System.Drawing.Point(330, 21);
            this.cbOras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOras.Name = "cbOras";
            this.cbOras.Size = new System.Drawing.Size(318, 33);
            this.cbOras.TabIndex = 6;
            this.cbOras.SelectedIndexChanged += new System.EventHandler(this.cbOras_SelectedIndexChanged);
            // 
            // tbAstro
            // 
            this.tbAstro.Location = new System.Drawing.Point(326, 397);
            this.tbAstro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAstro.Multiline = true;
            this.tbAstro.Name = "tbAstro";
            this.tbAstro.Size = new System.Drawing.Size(313, 101);
            this.tbAstro.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Astronomy";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(44, 21);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(223, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 62);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hourly weather";
            // 
            // tbHumidity
            // 
            this.tbHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHumidity.Location = new System.Drawing.Point(43, 121);
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.Size = new System.Drawing.Size(164, 30);
            this.tbHumidity.TabIndex = 12;
            // 
            // tbWindSpeed
            // 
            this.tbWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWindSpeed.Location = new System.Drawing.Point(43, 162);
            this.tbWindSpeed.Name = "tbWindSpeed";
            this.tbWindSpeed.Size = new System.Drawing.Size(130, 30);
            this.tbWindSpeed.TabIndex = 13;
            // 
            // tbPrecipitation
            // 
            this.tbPrecipitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecipitation.Location = new System.Drawing.Point(43, 205);
            this.tbPrecipitation.Name = "tbPrecipitation";
            this.tbPrecipitation.Size = new System.Drawing.Size(130, 30);
            this.tbPrecipitation.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(213, 121);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(87, 25);
            this.panel4.TabIndex = 15;
            this.panel4.Text = "Humidity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Wind Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Precipitation";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(670, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 477);
            this.panel1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tbPrecipitation);
            this.Controls.Add(this.tbWindSpeed);
            this.Controls.Add(this.tbHumidity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAstro);
            this.Controls.Add(this.cbOras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTempUnit);
            this.Controls.Add(this.lv7Days);
            this.Controls.Add(this.tbTempActual);
            this.Controls.Add(this.lvCurrentDay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCurrentDay;
        private System.Windows.Forms.ColumnHeader TimeOfDay;
        private System.Windows.Forms.ColumnHeader Temperature;
        private System.Windows.Forms.TextBox tbTempActual;
        private System.Windows.Forms.ListView lv7Days;
        private System.Windows.Forms.ColumnHeader Day;
        private System.Windows.Forms.ColumnHeader AvgTempDay;
        private System.Windows.Forms.ComboBox cbTempUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOras;
        private System.Windows.Forms.TextBox tbAstro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.TextBox tbWindSpeed;
        private System.Windows.Forms.TextBox tbPrecipitation;
        private System.Windows.Forms.Label panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}

