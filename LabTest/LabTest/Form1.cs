using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTest
{
    public partial class Form : System.Windows.Forms.Form
    {
        List<string> soldiersNo = new List<string>();
        List<string> soldierNames = new List<string>();
        List<int> targets1 = new List<int>();
        List<int> targets2 = new List<int>();
        List<int> targets3 = new List<int>();
        List<int> targets4 = new List<int>();
        List<int> averages = new List<int>();
        List<int> totals = new List<int>();

        public Form()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                checkSoldierNoLabel.Text = "";

                

                string soldierNo = soldierNoTextBox.Text;
                string soldierName = soldierNameTextBox.Text;

                if (SoldierExists(soldierNo))
                {
                    checkSoldierNoLabel.Text = "Soldier Already Exist!";
                    return;
                }

                if (String.IsNullOrEmpty(score1TextBox.Text))
                {
                    MessageBox.Show("This field is required");
                    return;
                }

                if (String.IsNullOrEmpty(score2TextBox.Text))
                {
                    MessageBox.Show("This field is required");
                    return;
                }

                if (String.IsNullOrEmpty(score3TextBox.Text))
                {
                    MessageBox.Show("This field is required");
                    return;
                }

                if (String.IsNullOrEmpty(score4TextBox.Text))
                {
                    MessageBox.Show("This field is required");
                    return;
                }

                int target1 = Convert.ToInt32(score1TextBox.Text);
                int target2 = Convert.ToInt32(score2TextBox.Text);
                int target3 = Convert.ToInt32(score3TextBox.Text);
                int target4 = Convert.ToInt32(score4TextBox.Text);

                

                soldiersNo.Add(soldierNo);
                soldierNames.Add(soldierName);
                targets1.Add(target1);
                targets2.Add(target2);
                targets3.Add(target3);
                targets4.Add(target4);

                for(int index = 0; index < soldiersNo.Count; index++)
                {
                    for (int index2 = 0; index2 < soldiersNo.Count; index2++)
                    {
                        totals.Add(targets1[index2] + targets2[index2] + targets3[index2] + targets4[index2]);
                    }
                }

                for (int index = 0; index < soldiersNo.Count; index++)
                {
                    for (int index2 = 0; index2 < soldiersNo.Count; index2++)
                    {
                        averages.Add((targets1[index2] + targets2[index2] + targets3[index2] + targets4[index2])/4);
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            showRichTextBox.Text = Display();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(searchByComboBox.Text == "Soldier No")
            {
                int index = 0;
                foreach (string soldierNo in soldiersNo)
                {
                    if (soldierNo == searchTextBox.Text)
                        MessageBox.Show(soldierNo + " " + soldierNames[index]);
                    else
                        MessageBox.Show("Not found");
                    index++;
                }
            }
            else if(searchByComboBox.Text == "Soldier Name")
            {
                int index = 0;
                foreach (string soldierName in soldierNames)
                {
                    if (soldierName == searchTextBox.Text)
                        MessageBox.Show(soldiersNo[index] + " " + soldierNames[index]);
                    else
                        MessageBox.Show("Not found");
                    index++;
                }
            }
        }

        private string Display()
        {
            string message = "";
            message = " Soldier No.\t| Soldier name\t| Average Score\t| Total Score\n";

            for (int index = 0; index < soldiersNo.Count; index++)
            {
                message = message + " " + soldiersNo[index] + "\t " + soldierNames[index] + "\t " + averages[index] + "\t " + totals[index] + "\n";
                //"\t " + averages[index] + "\t " + totals[index] +
            }

            return message;
        }

        private bool SoldierExists(string soldier)
        {
            bool isExists = false;

            foreach (string soldierCheck in soldiersNo)
            {
                if (soldierCheck == soldier)
                    isExists = true;
            }
            return isExists;
        }
    }
}
