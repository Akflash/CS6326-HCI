using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg3_axk180196
{
    public partial class Form1 : Form
    {
        
        DateTime[] entrytimeRecordInit;
        DateTime[] endtimeRecordInit;
        DateTime[] entryTimeRecFinal;
        DateTime[] endTimeRecFinal;

        double entryTimeMin = 0;
        double entryTimeMax = 0;
        double interRecordMinTime = 0;
        double interRecordMaxTime = 0;
        double averageEntryTime = 0;
        double averageInterRecordTime = 0;
        double totalTime = 0;
        double backspaceCount = 0;
        int numberOfRecords;

        double[] timePerRecord;
        double[] timeDifference;
       
        public Form1()
        {
            InitializeComponent();
        }

        // Select the Rebate Form text file to be Evaluated
        private void browseButtonClicked(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog = new OpenFileDialog();
            openfileDialog.InitialDirectory = @"C:\"; //By default to C: folder
            // Allows only text files
            openfileDialog.Title = "SELECT A .txt File";
            openfileDialog.Filter = "TEXT Files|*.txt";
            openfileDialog.FilterIndex = 2;
            openfileDialog.RestoreDirectory = true;
            if (openfileDialog.ShowDialog() == DialogResult.OK)
                textFileName.Text = openfileDialog.FileName;
        }

        // File displayed using the absolute file path
        private void openButtonClick(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(textFileName.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }


        //Values are resetted to null or 0
        private void ResetFields()
        {

           
            timePerRecord = null;
            timeDifference = null;
            entrytimeRecordInit = null;
            endtimeRecordInit = null;
            entryTimeRecFinal = null;
            endTimeRecFinal = null;
            entryTimeMin = 0;
            entryTimeMax = 0;
            interRecordMinTime = 0;
            interRecordMaxTime = 0;
            averageEntryTime = 0;
            averageInterRecordTime = 0;
            totalTime = 0;
            backspaceCount = 0;
            numberOfRecords = 0;

        }

        // Average Calculation
        double averageCalculate(double[] time)
        {
            double s = 0;
            for (int i = 0; i < time.Length; i++)
                s = s + time[i];
            return s/time.Length;
        }

        //  Time taken for each individual record
        void timetakenRecords()
        {
            int length = numberOfRecords;
            int i = 0;
            entryTimeRecFinal = new DateTime[numberOfRecords];
            endTimeRecFinal = new DateTime[numberOfRecords];
            while (i < numberOfRecords)
            {
                entryTimeRecFinal[i] = entrytimeRecordInit[i];
                endTimeRecFinal[i] = endtimeRecordInit[i];
                i++;
            }
        }
        void timeTaken_per_Record()
        {
            int i = 0;
            timePerRecord = new double[numberOfRecords];

            while (i < numberOfRecords)
            {
                timePerRecord[i] = endTimeRecFinal[i].Subtract(entryTimeRecFinal[i]).TotalSeconds;
                totalTime += timePerRecord[i];
                i++;       
            }
            Console.WriteLine(timePerRecord);
            entryTimeMax = timePerRecord.Max();
            entryTimeMin = timePerRecord.Min();
            averageEntryTime = averageCalculate(timePerRecord);
        }

        //  Time between writing current record from finishing the previous record in the List (current record - prev record)
        void timeTaken_btwn_interRecord()
        {
            int i = 0;
            timeDifference = new double[numberOfRecords - 1];
            while (i < numberOfRecords - 1)
            {
                timeDifference[i] = entryTimeRecFinal[i + 1].Subtract(endTimeRecFinal[i]).TotalSeconds;
                totalTime += timeDifference[i];
                i++;
            }
            interRecordMaxTime = timeDifference.Max();
            interRecordMinTime = timeDifference.Min();
            averageInterRecordTime = averageCalculate(timeDifference);
        }

        // Read the data from file
        private void ReadData(string fileName)
        {
            try
            {
                StreamReader read_file = new StreamReader(fileName, true);
                string data;
                int index = 0;
                entrytimeRecordInit = new DateTime[100];
                endtimeRecordInit = new DateTime[100];
                while ((data = read_file.ReadLine()) != null)
                {
                    string[] items = data.Split('\t');

                    DateTime entryTimeRecFinals = DateTime.ParseExact(items[13], "HH:mm:ss", CultureInfo.InvariantCulture);
                    DateTime endTimeRecFinals = DateTime.ParseExact(items[14], "HH:mm:ss", CultureInfo.InvariantCulture);

                    entrytimeRecordInit[index] = entryTimeRecFinals;
                    endtimeRecordInit[index] = endTimeRecFinals;
                    backspaceCount += Convert.ToInt32(items[15]);
                    index++;
                }
                read_file.Close();
                numberOfRecords = index;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // Text box Population
        private void displayResult()
        {
            noOfRecords.Text = Convert.ToString(numberOfRecords);
            backspaceCountValue.Text = Convert.ToString(backspaceCount);
            minEntryTime.Text = TimeSpan.FromSeconds(entryTimeMin).ToString(@"mm\:ss");
            maxEntryTime.Text = TimeSpan.FromSeconds(entryTimeMax).ToString(@"mm\:ss");
            minInterRT.Text = TimeSpan.FromSeconds(interRecordMinTime).ToString(@"mm\:ss");
            maxInterRT.Text = TimeSpan.FromSeconds(interRecordMaxTime).ToString(@"mm\:ss");
            avgEntryTime.Text = TimeSpan.FromSeconds(averageEntryTime).ToString(@"mm\:ss");
            avgInterRT.Text = TimeSpan.FromSeconds(averageInterRecordTime).ToString(@"mm\:ss");
            totalTimeTaken.Text = TimeSpan.FromSeconds(totalTime).ToString(@"mm\:ss");
        }
  
        // Write details to file
        private void Write_To_File()
        {
            StreamWriter writeFile = new System.IO.StreamWriter("CS6326Asg3.txt", false);
            writeFile.WriteLine("Number of records : " + noOfRecords.Text);
            writeFile.WriteLine("Minimum entry time : " + minEntryTime.Text);
            writeFile.WriteLine("Maximum entry time : " + maxEntryTime.Text);
            writeFile.WriteLine("Average entry time : " + avgEntryTime.Text);
            writeFile.WriteLine("Minimum inter-record time : " + minInterRT.Text);
            writeFile.WriteLine("Maximum inter-record time : " + maxInterRT.Text);
            writeFile.WriteLine("Average inter-record time : " + avgInterRT.Text);
            writeFile.WriteLine("Total time : " + totalTimeTaken.Text);
            writeFile.WriteLine("Backspace Count : " + backspaceCountValue.Text);
            writeFile.Close();
        }

        // Click to evaluate the fields
        // Handle evaluation of the data file
        private void evaluateButtonClicked(object sender, EventArgs e)
        {
            ResetFields();
            ReadData(textFileName.Text);
            timetakenRecords();
            timeTaken_per_Record();
            timeTaken_btwn_interRecord();
            displayResult();
            Write_To_File();
        }

        private void MaxInterRTLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
