namespace WeatherWindowApp
{
    partial class WeatherWindow
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
            this.cityNameBox = new System.Windows.Forms.TextBox();
            this.showCities = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.showWeather = new System.Windows.Forms.Label();
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(94, 172);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(56, 19);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cityNameBox
            // 
            this.cityNameBox.Location = new System.Drawing.Point(55, 139);
            this.cityNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityNameBox.Name = "cityNameBox";
            this.cityNameBox.Size = new System.Drawing.Size(131, 20);
            this.cityNameBox.TabIndex = 3;
            this.cityNameBox.UseWaitCursor = true;
            this.cityNameBox.TextChanged += new System.EventHandler(this.cityNameBox_TextChanged);
            // 
            // showCities
            // 
            this.showCities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showCities.ForeColor = System.Drawing.SystemColors.WindowText;
            this.showCities.Location = new System.Drawing.Point(245, 48);
            this.showCities.Name = "showCities";
            this.showCities.Size = new System.Drawing.Size(120, 338);
            this.showCities.TabIndex = 5;
            this.showCities.UseTabStops = false;
            this.showCities.Click += new System.EventHandler(this.showCities_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(55, 207);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(55, 20);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(131, 207);
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
            this.showWeather.Location = new System.Drawing.Point(424, 139);
            this.showWeather.Name = "showWeather";
            this.showWeather.Size = new System.Drawing.Size(0, 13);
            this.showWeather.TabIndex = 9;
            this.showWeather.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showWeather.Click += new System.EventHandler(this.label1_Click);
            // 
            // weatherIcon
            // 
            this.weatherIcon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.weatherIcon.ImageLocation = "";
            this.weatherIcon.Location = new System.Drawing.Point(507, 22);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(100, 100);
            this.weatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weatherIcon.TabIndex = 10;
            this.weatherIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(242, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "List of cities:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(55, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 13);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "labelText";
            // 
            // WeatherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weatherIcon);
            this.Controls.Add(this.showWeather);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.showCities);
            this.Controls.Add(this.cityNameBox);
            this.Controls.Add(this.searchButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WeatherWindow";
            this.Text = "WeatherWindow";
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox cityNameBox;
        private System.Windows.Forms.ListBox showCities;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label showWeather;
        private System.Windows.Forms.PictureBox weatherIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
    }
}

