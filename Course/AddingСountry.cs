using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class AddingСountry : Form
    {
        public Country Country { get; private set; }
        public AddingСountry(Country country = null)
        {
            Country = country ?? new Country();
            InitializeComponent();
            LoadCountryData();
            this.Text = country != null ? "Редагування країни" : "Додавання нової країни";
        }

        // завантажуємо інформацію якщо надана країна
        private void LoadCountryData()
        {
            TBNameCountry.Text = Country.Name;
            TBСapitalCountry.Text = Country.Capital;
            NumUDPopulationCountry.Value = Country.Population > 0 ? Country.Population : 0;
            NumUDAreaCountry.Value = (decimal)(Country.Area > 0 ? Country.Area : 0);

            if (!string.IsNullOrEmpty(Country.PartWorld) && ComboBoxPartWorld.Items.Contains(Country.PartWorld))
            {
                ComboBoxPartWorld.SelectedItem = Country.PartWorld;
            }

            TBAdditionalFacts.Text = Country.AdditionalFacts;
        }

        //Кнопка збереження інформації 
        private void ButtSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBNameCountry.Text))
            {
                MessageBox.Show("Будь ласка, введіть назву країни.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(TBСapitalCountry.Text))
            {
                MessageBox.Show("Будь ласка, введіть столицю країни.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ComboBoxPartWorld.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть континент.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Country.Name = TBNameCountry.Text;
            Country.Capital = TBСapitalCountry.Text;
            Country.Population = (int)NumUDPopulationCountry.Value;
            Country.Area = (long)NumUDAreaCountry.Value;
            Country.PartWorld = ComboBoxPartWorld.SelectedItem.ToString();
            Country.AdditionalFacts = TBAdditionalFacts.Text;

            DialogResult = DialogResult.OK;
            Close();

        }
        private void ButtCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
