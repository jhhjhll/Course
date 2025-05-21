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
    public partial class DetailedInformationCountry : Form
    {
        private Country country;
        public DetailedInformationCountry(Country country)
        {
            this.country = country;
            InitializeComponent();
            LoadInfo();
        }

        //завантаження інформації конкретної країни
        private void LoadInfo()
        {
            lblNameСountry.Text = country.Name;
            lblСapitalСountry.Text = country.Capital;
            lblPopulationСountry.Text = $"{country.Population.ToString()} осіб";
            lblAreaСountry.Text = $"{country.Area.ToString()} км²";
            lblPartWorldCountry.Text = country.PartWorld;
            TBAdditionalFacts.Text = country.AdditionalFacts;
        }
        private void ButtSave_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
