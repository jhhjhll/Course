using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class MainForm : Form
    {
        private CountryСollection collection = new CountryСollection();
        private List<Country> DisplayedList = new List<Country>();


        private DataTable countriesTable = new DataTable();
        private JSON dataService = new JSON();
        public MainForm()
        {
            InitializeComponent();
            SetupDataTable();
            LoadData();
        }

        //ініціалізація таблиці з країнами
        private void SetupDataTable()
        {
            // додаємо стовпці в DataTable
            countriesTable.Columns.Add("Назва", typeof(string));
            countriesTable.Columns.Add("Столиця", typeof(string));
            countriesTable.Columns.Add("Населення", typeof(long));
            countriesTable.Columns.Add("Площа", typeof(double));
            countriesTable.Columns.Add("Частина світу", typeof(string));

            // привязуємо DataTable до DataGridView
            TableCountries.DataSource = countriesTable;
        }

        //додати країну до таблиці
        private void AddCountryToTable(Country country)
        {
            countriesTable.Rows.Add(
                country.Name,
                country.Capital,
                country.Population,
                country.Area,
                country.PartWorld
            );
        }

        // Оновлення таблиці зі списком країн
        private void RefreshCountriesList(List<Country> list = null)
        {
            countriesTable.Clear();
            DisplayedList = list ?? collection.GetAllInfo();
            foreach (var country in DisplayedList)
            {
                AddCountryToTable(country);
            }
            AdditionalInformation(DisplayedList);
            TableCountries.ClearSelection();
        }

        // Завантажуємо країни з JSON файлу
        private void LoadData()
        {
            var loaded = dataService.LoadCountries();
            collection.SetAllInfo(loaded);

            DisplayedList = collection.GetAllInfo();
            RefreshCountriesList();
        }

        // Зберігаємо країни в JSON файл
        private void SaveData()
        {
            dataService.SaveCountries(collection.GetAllInfo());
        }

        //додати країну
        private void ButtAddСountry_Click(object sender, EventArgs e)
        {
            var formToAdd = new AddingСountry();

            if (formToAdd.ShowDialog() == DialogResult.OK)
            {
                Country newInfoCoutry = formToAdd.Country;
                collection.Add(newInfoCoutry);
                AddCountryToTable(newInfoCoutry);
                RefreshCountriesList();
                SaveData();
                MessageBox.Show("Країну успішно додано");
            }
        }

        //редагувати країну
        private void ButtEditCountry_Click(object sender, EventArgs e)
        {
            if (TableCountries.SelectedRows.Count > 0)
            {
                int i = TableCountries.SelectedRows[0].Index;
                Country selectContry = DisplayedList[i];
                int indexInCollection = collection.GetAtIndexOf(selectContry);

                if (indexInCollection != -1)
                {
                    var editForm = new AddingСountry(selectContry);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        collection.UpdateAtIndex(indexInCollection, editForm.Country);
                        RefreshCountriesList();
                        SaveData();
                        MessageBox.Show("Інформацію про країну оновлено!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка виберіть країну");
            }
        }

        //детальна інформація про країну 
        private void ButtDetailsCountry_Click(object sender, EventArgs e)
        {
            if (TableCountries.SelectedRows.Count > 0)
            {
                int i = TableCountries.SelectedRows[0].Index;
                Country selectCoutry = DisplayedList[i];

                var detailForm = new DetailedInformationCountry(selectCoutry);
                detailForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Будь ласка виберіть країну");
            }
        }

        //видалити країну
        private void ButtDeleteCountry_Click(object sender, EventArgs e)
        {
            if (TableCountries.SelectedRows.Count > 0)
            {
                int i = TableCountries.SelectedRows[0].Index;

                Country selected = DisplayedList[i];

                int indexInCollection = collection.GetAtIndexOf(selected);

                var result = MessageBox.Show($"Ви впевнені що хочете видалити цю країну?", "Підтвердження", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    collection.DeleteAtIndex(indexInCollection);
                    RefreshCountriesList();
                    SaveData();
                    MessageBox.Show($"Країна успішно видалено");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка виберіть країну");
            }
        }

        //пошук
        private void ButtSearchCountries_Click(object sender, EventArgs e)
        {
            string searchInfo = TBoxSearchCountries.Text.Trim().ToLower();

            if (ComboBoxPartWorld.SelectedItem != null && ComboBoxPartWorld.SelectedIndex != 0)
            {
                searchInfo = ComboBoxPartWorld.SelectedItem.ToString().Trim().ToLower();
            }

            if (string.IsNullOrWhiteSpace(searchInfo))
            {
                DisplayedList = collection.GetAllInfo();
                RefreshCountriesList(DisplayedList);
                lblSearchResults.Text = "";
                return;
            }

            DisplayedList = collection.Search(searchInfo);

            RefreshCountriesList(DisplayedList);
            lblSearchResults.Text = $"Знайдено результатів {DisplayedList.Count}";
        }
        private void AdditionalInformation(List<Country> countries)
        {
            lblNumberCountries.Text = $"Кількість країн: {countries.Count.ToString()}";
            lblTotalPopulation.Text = $"Загальне населення: {countries.Sum(c => (long)c.Population).ToString()} осіб ";
            double Аrea = Math.Round(countries.Average(c => c.Area));
            lblАverageАrea.Text = $"Середня площа: {Convert.ToString(Аrea)} км²";
        }
    }
}
