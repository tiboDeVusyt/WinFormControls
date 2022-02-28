using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<Person> AllPeople = SeedPeople.Getpersons();
            foreach (var item in AllPeople)
            {
                lstAllPeople.Items.Add(item);
            }
            IEnumerable<Country> allCountries = seedCountry.GetCountries();
            foreach (var item in allCountries)
            {
                lstAllCoutries.Items.Add(item);
            }
            IEnumerable<Country> allCountriesCombobox = seedCountry.Countries;
            foreach (var item in allCountriesCombobox)
            {
                cmbCountries.Items.Add(item);
            }



        }

        private void lstAllCoutries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstDemo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilterbyAge_Click(object sender, EventArgs e)
        {
            IEnumerable<Person> Filterdlist = SeedPeople.People.Where(x => x.Age == Convert.ToInt32(txtFilter.Text)).ToList();
            lstDemo.DataSource = Filterdlist;
        }

        private void btnFilterByCountry_Click(object sender, EventArgs e)
        {
            //lstDemo.Items.Clear();

            //traditional way
            //IEnumerable<Person> AllPeople = SeedPeople.People;
            //foreach (var item in AllPeople)         
            //{
            //    if (item.CountryId == Convert.ToInt32(txtFilter.Text))
            //    {
            //        lstDemo.Items.Add(item);
            //    }
            //}
            //lamda expresion
            IEnumerable<Person> Filterdlist = SeedPeople.People.Where(x => x.CountryId ==Convert.ToInt32(txtFilter.Text)).ToList();
            lstDemo.DataSource = Filterdlist;


            txtFilter.Text = String.Empty;




        }

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = cmbCountries.SelectedIndex + 1;
            IEnumerable<Person> people = SeedPeople.People;
            foreach (var item in people)
            {
                if (item.CountryId  == selected)
                {
                    lstDemo.Items.Add(item);
                }
            }

            //int selected = cmbCountries.SelectedIndex + 1;
            //IEnumerable<Person> list = SeedPeople.People.Where(x => x.CountryId == selected).ToList();
            //lstDemo.DataSource = list;
        }

        private void btnFilteByName_Click(object sender, EventArgs e)
        {
            Person person = SeedPeople.People.Find(x => x.Id == Convert.ToInt32(txtFilter.Text));
            lstDemo.Items.Add((Person)person);
        }
    }
}
