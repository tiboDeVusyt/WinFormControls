namespace WinFormControls
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstAllPeople = new System.Windows.Forms.ListBox();
            this.lstAllCoutries = new System.Windows.Forms.ListBox();
            this.lstDemo = new System.Windows.Forms.ListBox();
            this.btnFilterbyAge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilterByCountry = new System.Windows.Forms.Button();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFilteByName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "All People";
            // 
            // lstAllPeople
            // 
            this.lstAllPeople.FormattingEnabled = true;
            this.lstAllPeople.ItemHeight = 16;
            this.lstAllPeople.Location = new System.Drawing.Point(23, 114);
            this.lstAllPeople.Name = "lstAllPeople";
            this.lstAllPeople.Size = new System.Drawing.Size(380, 116);
            this.lstAllPeople.TabIndex = 1;
            // 
            // lstAllCoutries
            // 
            this.lstAllCoutries.FormattingEnabled = true;
            this.lstAllCoutries.ItemHeight = 16;
            this.lstAllCoutries.Location = new System.Drawing.Point(23, 313);
            this.lstAllCoutries.Name = "lstAllCoutries";
            this.lstAllCoutries.Size = new System.Drawing.Size(380, 68);
            this.lstAllCoutries.TabIndex = 2;
            this.lstAllCoutries.SelectedIndexChanged += new System.EventHandler(this.lstAllCoutries_SelectedIndexChanged);
            // 
            // lstDemo
            // 
            this.lstDemo.FormattingEnabled = true;
            this.lstDemo.ItemHeight = 16;
            this.lstDemo.Location = new System.Drawing.Point(26, 400);
            this.lstDemo.Name = "lstDemo";
            this.lstDemo.Size = new System.Drawing.Size(377, 84);
            this.lstDemo.TabIndex = 3;
            this.lstDemo.SelectedIndexChanged += new System.EventHandler(this.lstDemo_SelectedIndexChanged);
            // 
            // btnFilterbyAge
            // 
            this.btnFilterbyAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterbyAge.Location = new System.Drawing.Point(497, 351);
            this.btnFilterbyAge.Name = "btnFilterbyAge";
            this.btnFilterbyAge.Size = new System.Drawing.Size(99, 51);
            this.btnFilterbyAge.TabIndex = 4;
            this.btnFilterbyAge.Text = "Filter by age";
            this.btnFilterbyAge.UseVisualStyleBackColor = true;
            this.btnFilterbyAge.Click += new System.EventHandler(this.btnFilterbyAge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Filter criteria";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(26, 54);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(476, 22);
            this.txtFilter.TabIndex = 6;
            // 
            // btnFilterByCountry
            // 
            this.btnFilterByCountry.Location = new System.Drawing.Point(623, 351);
            this.btnFilterByCountry.Name = "btnFilterByCountry";
            this.btnFilterByCountry.Size = new System.Drawing.Size(75, 51);
            this.btnFilterByCountry.TabIndex = 7;
            this.btnFilterByCountry.Text = "Filter by country";
            this.btnFilterByCountry.UseVisualStyleBackColor = true;
            this.btnFilterByCountry.Click += new System.EventHandler(this.btnFilterByCountry_Click);
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(144, 236);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(259, 24);
            this.cmbCountries.TabIndex = 8;
            this.cmbCountries.SelectedIndexChanged += new System.EventHandler(this.cmbCountries_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "SelectCountry";
            // 
            // btnFilteByName
            // 
            this.btnFilteByName.Location = new System.Drawing.Point(497, 313);
            this.btnFilteByName.Name = "btnFilteByName";
            this.btnFilteByName.Size = new System.Drawing.Size(135, 23);
            this.btnFilteByName.TabIndex = 10;
            this.btnFilteByName.Text = "Filter by name";
            this.btnFilteByName.UseVisualStyleBackColor = true;
            this.btnFilteByName.Click += new System.EventHandler(this.btnFilteByName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.btnFilteByName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.btnFilterByCountry);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFilterbyAge);
            this.Controls.Add(this.lstDemo);
            this.Controls.Add(this.lstAllCoutries);
            this.Controls.Add(this.lstAllPeople);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAllPeople;
        private System.Windows.Forms.ListBox lstAllCoutries;
        private System.Windows.Forms.ListBox lstDemo;
        private System.Windows.Forms.Button btnFilterbyAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilterByCountry;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFilteByName;
    }
}

