namespace AirPollutionInfo
{
    partial class DialogInfo
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogInfo));
			this.GridViewInfo = new System.Windows.Forms.DataGridView();
			this.InfoDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.O3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PM10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PM25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.GridViewInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// GridViewInfo
			// 
			this.GridViewInfo.AllowUserToResizeColumns = false;
			this.GridViewInfo.AllowUserToResizeRows = false;
			this.GridViewInfo.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridViewInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.GridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridViewInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InfoDateTime,
            this.CityName,
            this.SO2,
            this.CO,
            this.O3,
            this.NO2,
            this.PM10,
            this.PM25});
			this.GridViewInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridViewInfo.GridColor = System.Drawing.Color.SteelBlue;
			this.GridViewInfo.Location = new System.Drawing.Point(0, 0);
			this.GridViewInfo.Name = "GridViewInfo";
			this.GridViewInfo.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridViewInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.GridViewInfo.RowHeadersVisible = false;
			this.GridViewInfo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
			this.GridViewInfo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GridViewInfo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
			this.GridViewInfo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
			this.GridViewInfo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
			this.GridViewInfo.RowTemplate.Height = 20;
			this.GridViewInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.GridViewInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridViewInfo.Size = new System.Drawing.Size(762, 366);
			this.GridViewInfo.TabIndex = 0;
			// 
			// InfoDateTime
			// 
			this.InfoDateTime.FillWeight = 120F;
			this.InfoDateTime.HeaderText = "측정시간";
			this.InfoDateTime.MinimumWidth = 120;
			this.InfoDateTime.Name = "InfoDateTime";
			this.InfoDateTime.ReadOnly = true;
			this.InfoDateTime.Width = 120;
			// 
			// CityName
			// 
			this.CityName.FillWeight = 80F;
			this.CityName.HeaderText = "지역";
			this.CityName.MinimumWidth = 80;
			this.CityName.Name = "CityName";
			this.CityName.ReadOnly = true;
			this.CityName.Width = 80;
			// 
			// SO2
			// 
			this.SO2.HeaderText = "아황산가스";
			this.SO2.MinimumWidth = 100;
			this.SO2.Name = "SO2";
			this.SO2.ReadOnly = true;
			// 
			// CO
			// 
			this.CO.HeaderText = "일산화탄소";
			this.CO.MinimumWidth = 100;
			this.CO.Name = "CO";
			this.CO.ReadOnly = true;
			// 
			// O3
			// 
			this.O3.FillWeight = 60F;
			this.O3.HeaderText = "오존";
			this.O3.MinimumWidth = 60;
			this.O3.Name = "O3";
			this.O3.ReadOnly = true;
			this.O3.Width = 60;
			// 
			// NO2
			// 
			this.NO2.HeaderText = "이산화질소";
			this.NO2.MinimumWidth = 100;
			this.NO2.Name = "NO2";
			this.NO2.ReadOnly = true;
			// 
			// PM10
			// 
			this.PM10.FillWeight = 80F;
			this.PM10.HeaderText = "미세먼지";
			this.PM10.MinimumWidth = 80;
			this.PM10.Name = "PM10";
			this.PM10.ReadOnly = true;
			this.PM10.Width = 80;
			// 
			// PM25
			// 
			this.PM25.HeaderText = "초미세먼지";
			this.PM25.MinimumWidth = 100;
			this.PM25.Name = "PM25";
			this.PM25.ReadOnly = true;
			// 
			// DialogInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(762, 366);
			this.Controls.Add(this.GridViewInfo);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(770, 115);
			this.Name = "DialogInfo";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.Text = "오염지수";
			this.ThemeName = "TelerikMetro";
			this.Load += new System.EventHandler(this.DialogInfo_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridViewInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView GridViewInfo;
		private System.Windows.Forms.DataGridViewTextBoxColumn InfoDateTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
		private System.Windows.Forms.DataGridViewTextBoxColumn SO2;
		private System.Windows.Forms.DataGridViewTextBoxColumn CO;
		private System.Windows.Forms.DataGridViewTextBoxColumn O3;
		private System.Windows.Forms.DataGridViewTextBoxColumn NO2;
		private System.Windows.Forms.DataGridViewTextBoxColumn PM10;
		private System.Windows.Forms.DataGridViewTextBoxColumn PM25;
	}
}
