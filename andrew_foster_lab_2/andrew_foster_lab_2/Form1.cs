/* Andrew Foster
 * CPT-206-A80S
 * Lab 2
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace andrew_foster_lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        private void ascPopSort_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPop(this.cityDBDataSet.City);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void descPopSort_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopDesc(this.cityDBDataSet.City);
        }

        private void highPop_Click(object sender, EventArgs e)
        {
            int? maxPop = this.cityTableAdapter.maxPop();
            MessageBox.Show("The highest population for any city in the table is " + maxPop.ToString());
        }

        private void avgPop_Click(object sender, EventArgs e)
        {
            int? avgPop = this.cityTableAdapter.avgPop();
            MessageBox.Show("The average population for all entries = " + avgPop.ToString());
        }

        private void totalPop_Click(object sender, EventArgs e)
        {
            int? totPop = this.cityTableAdapter.totalPop();
            MessageBox.Show("The total population for all entries = " + totPop.ToString());
        }

        private void lowPop_Click(object sender, EventArgs e)
        {
            int? minPop = this.cityTableAdapter.minPop();
            MessageBox.Show("The lowest population for any city in the table is " +  minPop.ToString());
        }

        private void nameSort_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByCityName(this.cityDBDataSet.City);
        }
    }
}
