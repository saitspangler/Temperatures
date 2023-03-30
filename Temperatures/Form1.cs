using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatures
{
    /*
     * Collects Temperatures daily for up to a month
     * Keeps track of number of days, average temperature, and
     * how many days are above average
     * 
     * Author: Peter
     * When: March
     */
    public partial class Form1 : Form
    {
        // class level declarations
        const int MAX_DAYS = 31;
        int[] temperatures = new int[MAX_DAYS];
        int nrDays = 0;


        public Form1()
        {
            InitializeComponent();
        }

        //Add one more temperature
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //read next temperature 
        }
    }
}
