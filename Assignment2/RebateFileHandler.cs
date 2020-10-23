/*
 * Assignment 2
 * RebateFileHandler -Handles File I/O
 * Written by Akshay Kumar for CS6326.001 on Sep 19, 2020.
 * NetID: axk180196
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Asg2_axk180196
{
    class RebateFileHandler
    {
       
          // Itemlist written to File
         
        public void WriteRebateList(ListView list)
        {
            using (StreamWriter writeText = new StreamWriter("CS6326Asg2.txt"))
            {
                foreach (ListViewItem item in list.Items)
                {
                    RebateRecord rebateItem = (RebateRecord)item.Tag;
                    writeText.WriteLine(rebateItem);
                }
            }
        }
        
         //  New Rebate Records added and lines are read from file
          
        public void ReadRebateList(ListView list)
        {
            using (StreamWriter writeText = new StreamWriter(File.Open("CS6326Asg2.txt", System.IO.FileMode.Append)))
            {

            }
            using (StreamReader readText = new StreamReader("CS6326Asg2.txt"))
            {
                String record;
                string tab = "\t";
                string[] record_split;
                while ((record = readText.ReadLine()) != null)
                {
                    record_split = record.Split(tab.ToCharArray());
                    RebateRecord rebateItem = new RebateRecord(record_split[0],
                        record_split[1], record_split[2], record_split[3], record_split[4],
                        record_split[5], record_split[6], record_split[7], record_split[8],
                        record_split[9], record_split[10], record_split[11], DateTime.Parse(record_split[12]),
                        DateTime.Parse(record_split[13]), DateTime.Parse(record_split[14]), Int32.Parse(record_split[15]));

                    ListViewItem viewItem = new ListViewItem();
                    viewItem.Tag = rebateItem;
                    viewItem.Text = rebateItem.firstName;
                    viewItem.SubItems.Add(rebateItem.lastName);
                    viewItem.SubItems.Add(Regex.Replace(rebateItem.Phone, @"(\d{3})(\d{3})(\d{4})", "($1) $2-$3"));
                    list.Items.Add(viewItem);
                } 
            }
        }
    }
}
