using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg4_axk180196
{

    public partial class Form1 : Form
    {
        private BackgroundWorker calculatingPrimes = new BackgroundWorker();
        private BackgroundWorker calculatingPrimeFactors = new BackgroundWorker();
        List<long> primeArray = new List<long>();
        List<string> primeFactorArray = new List<string>();

        public Form1()
        {
            InitializeComponent();
            calculatingPrimes.WorkerReportsProgress = true;
            calculatingPrimes.ProgressChanged += calcPrimeProgress;
            calculatingPrimes.DoWork += calculatePrimeWorker;
            calculatingPrimes.RunWorkerCompleted += primeCalcDone;

            calculatingPrimeFactors.WorkerReportsProgress = true;
            calculatingPrimeFactors.ProgressChanged += calcPrimeFactorProgress;
            calculatingPrimeFactors.DoWork += calculatePrimeFactorWorker;
            calculatingPrimeFactors.RunWorkerCompleted += primeFactorCalcDone;
        }

        // Check for prime number 
        bool isPrime(long n)
        {
            if (n <= 1)
                return false;

            // Check divisibility from 2 to sqrt of n 
            for (long i = 2; i <=Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;

            return true;
        }
        // Returns Approximate numbers of Prime numbers lesser than upper Bound 
        // Formula = The Prime Number Theorem: The number of primes not exceeding x is asymptotic to x/ln x.
        //In terms of π(x) we would write:
        //The Prime Number Theorem: π(x) ~ x/ln x.

       long getTotalPrimes(int n)
        {
            
            return (long)Convert.ToDouble(n / Math.Log(n));
        }

        // Returns All prime factors for each number
        string getAllPrimeFactors(long n)
        {
            string result = "";
            if (n == 1)
            {
                return " No Prime Factors";
            }
            for (int i = 0; i < primeArray.Count; i++)
            {
                if (n % primeArray[i] == 0)
                {
                    result += " [ "+primeArray[i].ToString()+" ] ,";
                    
                }
                
            }
            
    
            return result.Substring(0,result.Length-1);
        }

        private void calculatePrimeWorker(object sender, DoWorkEventArgs e)
        {
            long lowerBound = (long)Convert.ToDouble(lowerBoundtextBox.Text);
            long upperBound = (long)Convert.ToDouble(upperBoundtextBox.Text);
            int endPrime = Convert.ToInt32(upperBound);
            long totalPrimes = getTotalPrimes(endPrime);
            Console.WriteLine(totalPrimes);
            long ct = 0;
            totalPrimes++;
            for (long i = 2; i <= endPrime; i++)
            {
                if (isPrime(i))
                {
                    ct++;
                    long percentage = (ct * 100) / totalPrimes;
                    calculatingPrimes.ReportProgress(Convert.ToInt32(percentage)); // Percentage calculate for progressbar for calculating Primes
                    primeArray.Add(i);
                }
            }
        }

        private void calculatePrimeFactorWorker(object sender, DoWorkEventArgs e)
        {
            
                long lowerBound = (long)Convert.ToDouble(lowerBoundtextBox.Text);
                long upperBound = (long)Convert.ToDouble(upperBoundtextBox.Text);
                long total = upperBound - lowerBound + 1;
                long ct = 0;
                for (long i = lowerBound; i <= upperBound; i++)
                {
                primeFactorArray.Add(getAllPrimeFactors(i));
                ct++;
                    calculatingPrimeFactors.ReportProgress(Convert.ToInt32(ct * 100 / total)); // Percentage calculate for progressbar for calculating PrimeFactors
            }
            
            
            
        }

        //progressbar for calculating Primes
        private void calcPrimeProgress(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 100) primeCalculateprogressBar.Value = 100;
            else primeCalculateprogressBar.Value = e.ProgressPercentage;
        }

        //progressbar for calculating PrimeFactors
        private void calcPrimeFactorProgress(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage > 100) primeFactorsprogressBar.Value = 100;
            else primeFactorsprogressBar.Value = e.ProgressPercentage;
        }


        private void calculatePrimeButton_Click(object sender, EventArgs e)
        {
           
            Thread.Sleep(500);
            primeArray.Clear();
            primeFactorArray.Clear();
            resultView.Items.Clear();
            calculatingPrimes.RunWorkerAsync();

        }

        private void primeCalcDone(object sender, RunWorkerCompletedEventArgs e)
        {
            primeCalculateprogressBar.Value = 100;
            Thread.Sleep(1000);
            calculatingPrimeFactors.RunWorkerAsync();
        }

        private void primeFactorCalcDone(object sender, RunWorkerCompletedEventArgs e)
        {
            primeFactorsprogressBar.Value = 100;
            long lowerBound = (long)Convert.ToDouble(lowerBoundtextBox.Text);
            for (int i = 0; i < primeFactorArray.Count; i++)
            {
                // Assign numbers and its respective prime factors in resultView 
                ListViewItem resultViewItem = new ListViewItem();
                resultViewItem.Text = (i + lowerBound).ToString();
                resultViewItem.SubItems.Add(primeFactorArray[i]);
                resultView.Items.Add(resultViewItem);
            }

        }

       
    }
}
