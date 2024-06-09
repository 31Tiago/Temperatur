namespace Wetterdatenauswertung
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox tbTemperatur;
        private System.Windows.Forms.TextBox tbLuftfeuchtigkeit;
        private System.Windows.Forms.Label lblAvgTemp;
        private System.Windows.Forms.Label lblAvgHumidity;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Label lblMaxHumidity;
        private System.Windows.Forms.Label lblMinHumidity;
        private System.Windows.Forms.DataGridView dgvWetterdaten;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblTemperatur;
        private System.Windows.Forms.Label lblLuftfeuchtigkeit;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tbTemperatur = new System.Windows.Forms.TextBox();
            this.tbLuftfeuchtigkeit = new System.Windows.Forms.TextBox();
            this.lblAvgTemp = new System.Windows.Forms.Label();
            this.lblAvgHumidity = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.lblMaxHumidity = new System.Windows.Forms.Label();
            this.lblMinHumidity = new System.Windows.Forms.Label();
            this.dgvWetterdaten = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblTemperatur = new System.Windows.Forms.Label();
            this.lblLuftfeuchtigkeit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWetterdaten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxFile.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Einlesen Datei";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(6, 48);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(100, 23);
            this.btnSaveData.TabIndex = 1;
            this.btnSaveData.Text = "Speichern Datei";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(6, 106);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(100, 23);
            this.btnAddData.TabIndex = 2;
            this.btnAddData.Text = "Speichern Liste";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(112, 106);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Auswerten";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(6, 32);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(180, 20);
            this.dtpDatum.TabIndex = 4;
            // 
            // tbTemperatur
            // 
            this.tbTemperatur.Location = new System.Drawing.Point(6, 71);
            this.tbTemperatur.Name = "tbTemperatur";
            this.tbTemperatur.Size = new System.Drawing.Size(80, 20);
            this.tbTemperatur.TabIndex = 5;
            this.tbTemperatur.Validating += new System.ComponentModel.CancelEventHandler(this.tbTemperatur_Validating);
            // 
            // tbLuftfeuchtigkeit
            // 
            this.tbLuftfeuchtigkeit.Location = new System.Drawing.Point(112, 71);
            this.tbLuftfeuchtigkeit.Name = "tbLuftfeuchtigkeit";
            this.tbLuftfeuchtigkeit.Size = new System.Drawing.Size(74, 20);
            this.tbLuftfeuchtigkeit.TabIndex = 6;
            this.tbLuftfeuchtigkeit.Validating += new System.ComponentModel.CancelEventHandler(this.tbLuftfeuchtigkeit_Validating);
            // 
            // lblAvgTemp
            // 
            this.lblAvgTemp.AutoSize = true;
            this.lblAvgTemp.Location = new System.Drawing.Point(6, 19);
            this.lblAvgTemp.Name = "lblAvgTemp";
            this.lblAvgTemp.Size = new System.Drawing.Size(163, 13);
            this.lblAvgTemp.TabIndex = 7;
            this.lblAvgTemp.Text = "Durchschnittliche Temperatur: 0°C";
            // 
            // lblAvgHumidity
            // 
            this.lblAvgHumidity.AutoSize = true;
            this.lblAvgHumidity.Location = new System.Drawing.Point(6, 41);
            this.lblAvgHumidity.Name = "lblAvgHumidity";
            this.lblAvgHumidity.Size = new System.Drawing.Size(179, 13);
            this.lblAvgHumidity.TabIndex = 8;
            this.lblAvgHumidity.Text = "Durchschnittliche Luftfeuchtigkeit: 0%";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Location = new System.Drawing.Point(6, 63);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(113, 13);
            this.lblMaxTemp.TabIndex = 9;
            this.lblMaxTemp.Text = "Höchste Temperatur: 0°C";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Location = new System.Drawing.Point(6, 85);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(120, 13);
            this.lblMinTemp.TabIndex = 10;
            this.lblMinTemp.Text = "Niedrigste Temperatur: 0°C";
            // 
            // lblMaxHumidity
            // 
            this.lblMaxHumidity.AutoSize = true;
            this.lblMaxHumidity.Location = new System.Drawing.Point(6, 107);
            this.lblMaxHumidity.Name = "lblMaxHumidity";
            this.lblMaxHumidity.Size = new System.Drawing.Size(144, 13);
            this.lblMaxHumidity.TabIndex = 11;
            this.lblMaxHumidity.Text = "Höchste Luftfeuchtigkeit: 0%";
            // 
            // lblMinHumidity
            // 
            this.lblMinHumidity.AutoSize = true;
            this.lblMinHumidity.Location = new System.Drawing.Point(6, 129);
            this.lblMinHumidity.Name = "lblMinHumidity";
            this.lblMinHumidity.Size = new System.Drawing.Size(149, 13);
            this.lblMinHumidity.TabIndex = 12;
            this.lblMinHumidity.Text = "Niedrigste Luftfeuchtigkeit: 0%";
            // 
            // dgvWetterdaten
            // 
            this.dgvWetterdaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWetterdaten.Location = new System.Drawing.Point(260, 12);
            this.dgvWetterdaten.Name = "dgvWetterdaten";
            this.dgvWetterdaten.Size = new System.Drawing.Size(500, 400);
            this.dgvWetterdaten.TabIndex = 13;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.btnLoad);
            this.groupBoxFile.Controls.Add(this.btnSaveData);
            this.groupBoxFile.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(120, 80);
            this.groupBoxFile.TabIndex = 14;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "Dateioperationen";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.lblDatum);
            this.groupBoxInput.Controls.Add(this.lblTemperatur);
            this.groupBoxInput.Controls.Add(this.lblLuftfeuchtigkeit);
            this.groupBoxInput.Controls.Add(this.dtpDatum);
            this.groupBoxInput.Controls.Add(this.tbTemperatur);
            this.groupBoxInput.Controls.Add(this.tbLuftfeuchtigkeit);
            this.groupBoxInput.Controls.Add(this.btnAddData);
            this.groupBoxInput.Controls.Add(this.btnCalculate);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 98);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(200, 135);
            this.groupBoxInput.TabIndex = 15;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Dateneingabe";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.lblAvgTemp);
            this.groupBoxOutput.Controls.Add(this.lblAvgHumidity);
            this.groupBoxOutput.Controls.Add(this.lblMaxTemp);
            this.groupBoxOutput.Controls.Add(this.lblMinTemp);
            this.groupBoxOutput.Controls.Add(this.lblMaxHumidity);
            this.groupBoxOutput.Controls.Add(this.lblMinHumidity);
            this.groupBoxOutput.Location = new System.Drawing.Point(12, 239);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(240, 160);
            this.groupBoxOutput.TabIndex = 16;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Auswertung";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(6, 16);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 17;
            this.lblDatum.Text = "Datum:";
            // 
            // lblTemperatur
            // 
            this.lblTemperatur.AutoSize = true;
            this.lblTemperatur.Location = new System.Drawing.Point(6, 55);
            this.lblTemperatur.Name = "lblTemperatur";
            this.lblTemperatur.Size = new System.Drawing.Size(67, 13);
            this.lblTemperatur.TabIndex = 18;
            this.lblTemperatur.Text = "Temperatur:";
            // 
            // lblLuftfeuchtigkeit
            // 
            this.lblLuftfeuchtigkeit.AutoSize = true;
            this.lblLuftfeuchtigkeit.Location = new System.Drawing.Point(109, 55);
            this.lblLuftfeuchtigkeit.Name = "lblLuftfeuchtigkeit";
            this.lblLuftfeuchtigkeit.Size = new System.Drawing.Size(87, 13);
            this.lblLuftfeuchtigkeit.TabIndex = 19;
            this.lblLuftfeuchtigkeit.Text = "Luftfeuchtigkeit:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.dgvWetterdaten);
            this.Name = "Form1";
            this.Text = "Wetterdatenauswertung";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWetterdaten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}


