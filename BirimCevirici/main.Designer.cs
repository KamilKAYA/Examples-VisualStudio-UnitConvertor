namespace BirimCevirici
{
    partial class mainForm
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
            this.select_proccess = new System.Windows.Forms.ComboBox();
            this.input_unit = new System.Windows.Forms.ComboBox();
            this.output_unit = new System.Windows.Forms.ComboBox();
            this.input_value = new System.Windows.Forms.TextBox();
            this.output_value = new System.Windows.Forms.TextBox();
            this.cross = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // select_proccess
            // 
            this.select_proccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_proccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.select_proccess.FormattingEnabled = true;
            this.select_proccess.Items.AddRange(new object[] {
            "Uzunluk",
            "Alan",
            "Hacim",
            "Alan Karesi",
            "Kütle",
            "Yoğunluk",
            "Kuvvet",
            "Moment",
            "Basınç",
            "Elastiklik Katsayısı",
            "Rijitlik Katsayısı",
            "İş-Enerji",
            "Güç",
            "Sıcaklık"});
            this.select_proccess.Location = new System.Drawing.Point(62, 73);
            this.select_proccess.Name = "select_proccess";
            this.select_proccess.Size = new System.Drawing.Size(666, 32);
            this.select_proccess.TabIndex = 0;
            this.select_proccess.SelectedIndexChanged += new System.EventHandler(this.select_proccess_SelectedIndexChanged);
            // 
            // input_unit
            // 
            this.input_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_unit.Enabled = false;
            this.input_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.input_unit.FormattingEnabled = true;
            this.input_unit.Location = new System.Drawing.Point(209, 144);
            this.input_unit.Name = "input_unit";
            this.input_unit.Size = new System.Drawing.Size(107, 32);
            this.input_unit.TabIndex = 1;
            this.input_unit.SelectedIndexChanged += new System.EventHandler(this.input_unit_SelectedIndexChanged);
            // 
            // output_unit
            // 
            this.output_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.output_unit.Enabled = false;
            this.output_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.output_unit.FormattingEnabled = true;
            this.output_unit.Location = new System.Drawing.Point(621, 144);
            this.output_unit.Name = "output_unit";
            this.output_unit.Size = new System.Drawing.Size(107, 32);
            this.output_unit.TabIndex = 2;
            this.output_unit.SelectedIndexChanged += new System.EventHandler(this.output_unit_SelectedIndexChanged);
            // 
            // input_value
            // 
            this.input_value.Enabled = false;
            this.input_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.input_value.Location = new System.Drawing.Point(62, 144);
            this.input_value.Name = "input_value";
            this.input_value.Size = new System.Drawing.Size(141, 29);
            this.input_value.TabIndex = 3;
            this.input_value.Text = "0";
            this.input_value.TextChanged += new System.EventHandler(this.input_value_TextChanged);
            // 
            // output_value
            // 
            this.output_value.Enabled = false;
            this.output_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.output_value.Location = new System.Drawing.Point(474, 144);
            this.output_value.Name = "output_value";
            this.output_value.Size = new System.Drawing.Size(141, 29);
            this.output_value.TabIndex = 4;
            this.output_value.Text = "0";
            this.output_value.TextChanged += new System.EventHandler(this.output_value_TextChanged);
            // 
            // cross
            // 
            this.cross.Enabled = false;
            this.cross.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cross.Location = new System.Drawing.Point(350, 140);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(75, 40);
            this.cross.TabIndex = 5;
            this.cross.Text = "->";
            this.cross.UseVisualStyleBackColor = true;
            this.cross.Click += new System.EventHandler(this.cross_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 262);
            this.Controls.Add(this.cross);
            this.Controls.Add(this.output_value);
            this.Controls.Add(this.input_value);
            this.Controls.Add(this.output_unit);
            this.Controls.Add(this.input_unit);
            this.Controls.Add(this.select_proccess);
            this.MaximumSize = new System.Drawing.Size(800, 300);
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "mainForm";
            this.Text = "Birim Çevirici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox select_proccess;
        private System.Windows.Forms.ComboBox input_unit;
        private System.Windows.Forms.ComboBox output_unit;
        private System.Windows.Forms.TextBox input_value;
        private System.Windows.Forms.TextBox output_value;
        private System.Windows.Forms.Button cross;
    }
}

