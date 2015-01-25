using PeopleManager.Common.Entities;
using PeopleManager.WinForms.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleManager.WinForms
{
    /// <summary>
    /// Would be nice to refactor to some sort of MVP pattern:
    /// http://codebetter.com/jeremymiller/2007/07/26/the-build-your-own-cab-series-table-of-contents/
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbPeople.DataSource = new HttpPersonRepository().List();
            //foreach(Person person in new HttpPersonRepository().List())
            //{
            //    System.Diagnostics.Debug.WriteLine(person.FirstName);
            //}
        }
    }
}
