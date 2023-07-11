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
            this.Measurement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lv7Days = new System.Windows.Forms.ListView();
            this.Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AvgTempDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MeasureUnit2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbTempUnit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvCurrentDay
            // 
            this.lvCurrentDay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TimeOfDay,
            this.Temperature,
            this.Measurement});
            this.lvCurrentDay.HideSelection = false;
            this.lvCurrentDay.Location = new System.Drawing.Point(43, 146);
            this.lvCurrentDay.Name = "lvCurrentDay";
            this.lvCurrentDay.Size = new System.Drawing.Size(364, 260);
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
            // Measurement
            // 
            this.Measurement.Text = "Measurement unit (C/F)";
            this.Measurement.Width = 157;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(43, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 38);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Temperature";
            // 
            // lv7Days
            // 
            this.lv7Days.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Day,
            this.AvgTempDay,
            this.MeasureUnit2});
            this.lv7Days.HideSelection = false;
            this.lv7Days.Location = new System.Drawing.Point(424, 146);
            this.lv7Days.Name = "lv7Days";
            this.lv7Days.Size = new System.Drawing.Size(364, 260);
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
            this.AvgTempDay.Width = 101;
            // 
            // MeasureUnit2
            // 
            this.MeasureUnit2.Text = "Measurement unit (C/F)";
            this.MeasureUnit2.Width = 157;
            // 
            // cbTempUnit
            // 
            this.cbTempUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTempUnit.FormattingEnabled = true;
            this.cbTempUnit.Items.AddRange(new object[] {
            "Celsius (C)",
            "Fahrenheit"});
            this.cbTempUnit.Location = new System.Drawing.Point(43, 13);
            this.cbTempUnit.Name = "cbTempUnit";
            this.cbTempUnit.Size = new System.Drawing.Size(121, 33);
            this.cbTempUnit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weather in this period";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTempUnit);
            this.Controls.Add(this.lv7Days);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lvCurrentDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCurrentDay;
        private System.Windows.Forms.ColumnHeader TimeOfDay;
        private System.Windows.Forms.ColumnHeader Temperature;
        private System.Windows.Forms.ColumnHeader Measurement;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv7Days;
        private System.Windows.Forms.ColumnHeader Day;
        private System.Windows.Forms.ColumnHeader AvgTempDay;
        private System.Windows.Forms.ColumnHeader MeasureUnit2;
        private System.Windows.Forms.ComboBox cbTempUnit;
        private System.Windows.Forms.Label label2;
    }
}

