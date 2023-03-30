using System;
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
        const int MIN_TEMP = -60;
        const int MAX_TEMP = 60;
        int[] temperatures = new int[MAX_DAYS];
        int nrDays = 0;
        int nrHotDays = 0;
        int lowTemp;
        int highTemp = 0;
        double sum = 0; // sum of all temperatures to calculate average


        public Form1()
        {
            InitializeComponent();
        }

        //Add one more temperature
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int nextTemp;
            double average;

            if (Validator.IsPresent(txtNewTemp) &&
                Validator.isIntInRange(txtNewTemp, MIN_TEMP, MAX_TEMP))
            {
                //read next temperature from user
                nextTemp = Convert.ToInt32(txtNewTemp.Text);
                // add to array
                temperatures[nrDays] = nextTemp;
                lstTemperatures.Items.Add("Temperature was " + nextTemp);
                nrDays++;

                sum += nextTemp;
                // calculate average
                average = sum / nrDays;
                // count days above avergae
                nrHotDays = CountHotDays(temperatures, nrDays, average);
                // then display nrDays and average
                txtNrDays.Text = nrDays.ToString();
                txtAverage.Text = average.ToString("f2");
                txtHotDays.Text = nrHotDays.ToString();

                lowTemp = FindLowest(temperatures, nrDays);
                highTemp = FindHighest(temperatures, nrDays);

                txtLowestTemp.Text = lowTemp.ToString();
                txtHighestTemp.Text = highTemp.ToString();
                //if array is full, disable add button
                if (nrDays == MAX_DAYS)
                {
                    grpEntry.Enabled = false;
                }
            }
        }

        private int CountHotDays(int[] temps, int count, double threshold) 
        {
            int countHot = 0;

            for (int i = 0; i < count; i++)
            {
                if (temps[i] > threshold)
                {
                    countHot++;
                }
            }
            
            return countHot;
        }

        //find lowest temp and return it
        private int FindLowest(int[] temps, int count)
        {
            int countLowest = temps[0];

            for(int i = 1; i < count; i++)
            {
                if (temps[i] < countLowest)
                {
                    countLowest = temps[i];
                }
            }

            return countLowest;
        }

        private int FindHighest(int[] temps, int count)
        {
            int countHighest = temps[0];

            for(int i = 1; i < count; ++i)
            {
                if (temps[i] > countHighest)
                {
                    countHighest = temps[i];
                }
            }
            return countHighest;
        }
    
    }
}
