using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempAverage.Logic;
using Unity;

namespace TempAverage
{
    public partial class MeasurementAddingForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly DataLogic data;

        public MeasurementAddingForm(DataLogic data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dateMaskedTextBox.Text))
            {
                MessageBox.Show(
                    "Укажите дату измерения",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(tempMaskedTextBox.Text))
            {
                MessageBox.Show(
                    "Укажите температуру",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            try
            {
                data.AddMeasurement(
                    Convert.ToDateTime(dateMaskedTextBox.Text),
                    belowZeroCheckBox.Checked ?
                    -1.0 * Convert.ToDouble(tempMaskedTextBox.Text) :
                    Convert.ToDouble(tempMaskedTextBox.Text));
                DialogResult = DialogResult.OK;
                Close();
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
