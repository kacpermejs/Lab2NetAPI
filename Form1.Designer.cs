namespace WindowsFormsApp1
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
            this.searchButton = new System.Windows.Forms.Button();
            this.bigEkran = new System.Windows.Forms.ListBox();
            this.cityNameBox = new System.Windows.Forms.TextBox();
            this.showCities = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.showWeather = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(503, 75);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(56, 19);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // bigEkran
            // 
            this.bigEkran.FormattingEnabled = true;
            this.bigEkran.Location = new System.Drawing.Point(17, 10);
            this.bigEkran.Margin = new System.Windows.Forms.Padding(2);
            this.bigEkran.Name = "bigEkran";
            this.bigEkran.Size = new System.Drawing.Size(156, 329);
            this.bigEkran.TabIndex = 2;
            this.bigEkran.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cityNameBox
            // 
            this.cityNameBox.Location = new System.Drawing.Point(468, 51);
            this.cityNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityNameBox.Name = "cityNameBox";
            this.cityNameBox.Size = new System.Drawing.Size(120, 20);
            this.cityNameBox.TabIndex = 3;
            this.cityNameBox.UseWaitCursor = true;
            this.cityNameBox.TextChanged += new System.EventHandler(this.cityNameBox_TextChanged);
            // 
            // showCities
            // 
            this.showCities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showCities.ForeColor = System.Drawing.SystemColors.WindowText;
            this.showCities.Location = new System.Drawing.Point(469, 133);
            this.showCities.Name = "showCities";
            this.showCities.Size = new System.Drawing.Size(120, 169);
            this.showCities.TabIndex = 5;
            this.showCities.UseTabStops = false;
            this.showCities.Click += new System.EventHandler(this.showCities_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(468, 334);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(55, 20);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(534, 334);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(55, 20);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // showWeather
            // 
            this.showWeather.AutoSize = true;
            this.showWeather.Location = new System.Drawing.Point(279, 81);
            this.showWeather.Name = "showWeather";
            this.showWeather.Size = new System.Drawing.Size(35, 13);
            this.showWeather.TabIndex = 9;
            this.showWeather.Text = "label1";
            this.showWeather.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.showWeather);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.showCities);
            this.Controls.Add(this.cityNameBox);
            this.Controls.Add(this.bigEkran);
            this.Controls.Add(this.searchButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox bigEkran;
        private System.Windows.Forms.TextBox cityNameBox;
        private System.Windows.Forms.ListBox showCities;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label showWeather;
    }
}

