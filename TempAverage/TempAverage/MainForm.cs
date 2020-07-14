using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TempAverage.Logic;
using Unity;

namespace TempAverage
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly DataLogic data;

        public MainForm(DataLogic data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                Dictionary<DateTime, double> measurements = data.GetMeasurements();
                if (measurements != null)
                {
                    measurementsGridView.Rows.Clear();
                    foreach(var measurement in measurements)
                    {
                        measurementsGridView.Rows.Add(new object[]
                        {
                            measurement.Key.ToShortDateString(),
                            measurement.Value
                        });
                    }
                }
                measurementsGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<MeasurementAddingForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void AverageTempButton_Click(object sender, EventArgs e)
        {
            try
            {
                averageTempTextBox.Text = string.Format("{0:f1}", data.GetAverageTemp()) + "°C";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (measurementsGridView.SelectedRows.Count == 1)
            {
                try
                {
                    data.DeleteMeasurement(Convert
                        .ToDateTime(measurementsGridView
                        .SelectedRows[0].Cells[0].Value));
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
