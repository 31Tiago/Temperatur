using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Wetterdatenauswertung
{
    public partial class Form1 : Form
    {
        private List<Wetterdaten> wetterdatenList = new List<Wetterdaten>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    LoadCsvData(filePath);
                }
            }
        }

        private void LoadCsvData(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines.Skip(1))
                {
                    var values = line.Split(';'); 
                    DateTime datum = DateTime.Parse(values[0], CultureInfo.InvariantCulture);
                    double temperatur = double.Parse(values[1].Replace(',', '.'), CultureInfo.InvariantCulture); 
                    double luftfeuchtigkeit = double.Parse(values[2].Replace(',', '.'), CultureInfo.InvariantCulture);
                    wetterdatenList.Add(new Wetterdaten(datum, temperatur, luftfeuchtigkeit));
                }
                MessageBox.Show("Daten erfolgreich geladen.");
                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Daten: " + ex.Message);
            }
        }


        private void UpdateDataGridView()
        {
            dgvWetterdaten.DataSource = null;
            dgvWetterdaten.DataSource = wetterdatenList;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (wetterdatenList.Count == 0)
            {
                MessageBox.Show("Keine Daten zum Berechnen.");
                return;
            }

            double avgTemp = wetterdatenList.Average(w => w.Temperatur);
            double avgHumidity = wetterdatenList.Average(w => w.Luftfeuchtigkeit);

            lblAvgTemp.Text = $"Durchschnittliche Temperatur: {avgTemp:F2}°C";
            lblAvgHumidity.Text = $"Durchschnittliche Luftfeuchtigkeit: {avgHumidity:F2}%";

            var maxTemp = wetterdatenList.Max(w => w.Temperatur);
            var minTemp = wetterdatenList.Min(w => w.Temperatur);
            var maxHumidity = wetterdatenList.Max(w => w.Luftfeuchtigkeit);
            var minHumidity = wetterdatenList.Min(w => w.Luftfeuchtigkeit);

            lblMaxTemp.Text = $"Höchste Temperatur: {maxTemp}°C";
            lblMinTemp.Text = $"Niedrigste Temperatur: {minTemp}°C";
            lblMaxHumidity.Text = $"Höchste Luftfeuchtigkeit: {maxHumidity}%";
            lblMinHumidity.Text = $"Niedrigste Luftfeuchtigkeit: {minHumidity}%";

            var highHumidityDays = wetterdatenList.Count(w => w.Luftfeuchtigkeit > 79);
            lblOutput.Text = $"Tage mit Luftfeuchtigkeit > 79%: {highHumidityDays}";
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime datum = dtpDatum.Value;
                double temperatur = double.Parse(tbTemperatur.Text);
                double luftfeuchtigkeit = double.Parse(tbLuftfeuchtigkeit.Text);
                var newData = new Wetterdaten(datum, temperatur, luftfeuchtigkeit);
                wetterdatenList.Add(newData);
                MessageBox.Show("Daten erfolgreich hinzugefügt.");
                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Hinzufügen der Daten: " + ex.Message);
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    SaveCsvData(filePath);
                }
            }
        }

        private void SaveCsvData(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Datum,Temperatur,Luftfeuchtigkeit");
                    foreach (var data in wetterdatenList)
                    {
                        writer.WriteLine($"{data.Datum},{data.Temperatur},{data.Luftfeuchtigkeit}");
                    }
                }
                MessageBox.Show("Daten erfolgreich gespeichert.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern der Daten: " + ex.Message);
            }
        }

        private void tbTemperatur_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!double.TryParse(tbTemperatur.Text, out double temperatur) || temperatur < -50 || temperatur > 50)
            {
                e.Cancel = true;
                tbTemperatur.Select(0, tbTemperatur.Text.Length);
                errorProvider.SetError(tbTemperatur, "Bitte geben Sie eine gültige Temperatur zwischen -50 und +50 °C ein.");
            }
            else
            {
                errorProvider.SetError(tbTemperatur, null);
            }
        }

        private void tbLuftfeuchtigkeit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!double.TryParse(tbLuftfeuchtigkeit.Text, out double luftfeuchtigkeit) || luftfeuchtigkeit < 0 || luftfeuchtigkeit > 100)
            {
                e.Cancel = true;
                tbLuftfeuchtigkeit.Select(0, tbLuftfeuchtigkeit.Text.Length);
                errorProvider.SetError(tbLuftfeuchtigkeit, "Bitte geben Sie eine gültige Luftfeuchtigkeit zwischen 0 und 100 % ein.");
            }
            else
            {
                errorProvider.SetError(tbLuftfeuchtigkeit, null);
            }
        }

        private void groupBoxOutput_Enter(object sender, EventArgs e)
        {

        }
    }
}
