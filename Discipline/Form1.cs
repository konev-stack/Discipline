using System;
using System.Windows.Forms;



namespace Discipline
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static int freeSpace = 6;


        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkbox1.Enabled = false;
            metroCheckBox1.Enabled = false;
            metroCheckBox2.Enabled = false;
            metroCheckBox3.Enabled = false;
            metroCheckBox4.Enabled = false;
            metroCheckBox5.Enabled = false;
            //------------------------------
            cleartask1.Enabled = false;
            cleartask2.Enabled = false;
            cleartask3.Enabled = false;
            cleartask4.Enabled = false;
            cleartask5.Enabled = false;
            cleartask6.Enabled = false;
            //------------------------------
            task1.ReadOnly = true;
            task2.ReadOnly = true;
            task3.ReadOnly = true;
            task4.ReadOnly = true;
            task5.ReadOnly = true;
            task6.ReadOnly = true;
            //------------------------------
            task1due.ReadOnly = true;
            task2due.ReadOnly = true;
            task3due.ReadOnly = true;
            task4due.ReadOnly = true;
            task5due.ReadOnly = true;
            task6due.ReadOnly = true;

            task1.Text = Properties.Settings.Default.tasktask1;
            task2.Text = Properties.Settings.Default.tasktask2;
            task3.Text = Properties.Settings.Default.tasktask3;
            task4.Text = Properties.Settings.Default.tasktask4;
            task5.Text = Properties.Settings.Default.tasktask5;
            task6.Text = Properties.Settings.Default.tasktask6;
            //-------------------------------------------------
            task1due.Text = Properties.Settings.Default.taskdue1;
            task2due.Text = Properties.Settings.Default.taskdue2;
            task3due.Text = Properties.Settings.Default.taskdue3;
            task4due.Text = Properties.Settings.Default.taskdue4;
            task5due.Text = Properties.Settings.Default.taskdue5;
            task6due.Text = Properties.Settings.Default.taskdue6;

            if (task1.Text != "")
            {
                freeSpace -= 1;
                checkbox1.Enabled = true;
                cleartask1.Enabled = true;
            }

            if (task2.Text != "")
            {
                freeSpace -= 1;
                metroCheckBox1.Enabled = true;
                cleartask2.Enabled = true;
            }

            if (task3.Text != "")
            {
                freeSpace -= 1;
                metroCheckBox2.Enabled = true;
                cleartask3.Enabled = true;
            }

            if (task4.Text != "")
            {
                freeSpace -= 1;
                metroCheckBox3.Enabled = true;
                cleartask4.Enabled = true;
            }

            if (task5.Text != "")
            {
                freeSpace -= 1;
                metroCheckBox4.Enabled = true;
                cleartask5.Enabled = true;
            }

            if (task6.Text != "")
            {
                freeSpace -= 1;
                metroCheckBox5.Enabled = true;
                cleartask6.Enabled = true;
            }

            tasklabel.Visible = false;
            tasksLeft.Text = freeSpace.ToString();
        }

        private void tasksLeft_Click(object sender, EventArgs e)
        {

        }

        private void task1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if (writetaskTextBox.Text == "")
            {
                MessageBox.Show("You must enter a valid task.");
                return;
            }
            else if (dueTextBox.Text == "")
            {
                MessageBox.Show("You must enter a valid date.");
                return;
            }
            if (freeSpace <= 0)
            {
                MessageBox.Show("You can enter only 6 tasks.");
                return;
            }

            tasklabel.Visible = true;

            //-------------------------------------------------------------
            //TASK 1
            if (task1.Text == "")
            {

                task1.Text = writetaskTextBox.Text;
                task1due.Text = dueTextBox.Text;

                checkbox1.Enabled = true;
                cleartask1.Enabled = true;
            }

            //-------------------------------------------------------------
            //TASK 2
            else if (task2.Text == "")
            {

                task2.Text = writetaskTextBox.Text;
                task2due.Text = dueTextBox.Text;

                metroCheckBox1.Enabled = true;
                cleartask2.Enabled = true;
            }
            //-------------------------------------------------------------
            //TASK 3
            else if (task3.Text == "")
            {

                task3.Text = writetaskTextBox.Text;
                task3due.Text = dueTextBox.Text;

                metroCheckBox2.Enabled = true;
                cleartask3.Enabled = true;
            }
            //-------------------------------------------------------------
            //TASK 4
            else if (task4.Text == "")
            {

                task4.Text = writetaskTextBox.Text;
                task4due.Text = dueTextBox.Text;

                metroCheckBox3.Enabled = true;
                cleartask4.Enabled = true;
            }
            //-------------------------------------------------------------
            //TASK 5
            else if (task5.Text == "")
            {

                task5.Text = writetaskTextBox.Text;
                task5due.Text = dueTextBox.Text;

                metroCheckBox4.Enabled = true;
                cleartask5.Enabled = true;
            }
            //-------------------------------------------------------------
            //TASK 6
            else if (task6.Text == "")
            {
                task6.Text = writetaskTextBox.Text;
                task6due.Text = dueTextBox.Text;

                metroCheckBox5.Enabled = true;
                cleartask6.Enabled = true;
            }
            //-------------------------------------------------------------
            //end
            if (writetaskTextBox.Text != "" || dueTextBox.Text != "")
            {
                freeSpace -= 1;
                tasksLeft.Text = freeSpace.ToString();
            }
            else
                return;


            writetaskTextBox.Text = "";
            dueTextBox.Text = "";


        }


        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {

            task1.Text = "Finished";
            task1due.Text = "Finished";
            checkbox1.Enabled = false;

        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            task2due.Text = "Finished";
            task2.Text = "Finished";
            metroCheckBox1.Enabled = false;

        }

        private void dueTextBox_Click(object sender, EventArgs e)
        {

        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            task3due.Text = "Finished";
            task3.Text = "Finished";
            metroCheckBox2.Enabled = false;
        }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            task4due.Text = "Finished";
            task4.Text = "Finished";
            metroCheckBox3.Enabled = false;
        }

        private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            task5due.Text = "Finished";
            task5.Text = "Finished";
            metroCheckBox4.Enabled = false;
        }

        private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            task6due.Text = "Finished";
            task6.Text = "Finished";
            metroCheckBox5.Enabled = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

            
            //----------------------------------------------------------//
            checkbox1.Enabled = false;
            metroCheckBox1.Enabled = false;
            metroCheckBox2.Enabled = false;
            metroCheckBox3.Enabled = false;
            metroCheckBox4.Enabled = false;
            metroCheckBox5.Enabled = false;
            //-----------------------------
            cleartask1.Enabled = false;
            cleartask2.Enabled = false;
            cleartask3.Enabled = false;
            cleartask4.Enabled = false;
            cleartask5.Enabled = false;
            cleartask6.Enabled = false;
            //-----------------------------
            checkbox1.Checked = false;
            metroCheckBox1.Checked = false;
            metroCheckBox2.Checked = false;
            metroCheckBox3.Checked = false;
            metroCheckBox4.Checked = false;
            metroCheckBox5.Checked = false;

            //----------------------------------------------------------//
            freeSpace = 6;
            tasksLeft.Text = freeSpace.ToString();


            task1.Text = "";
            task2.Text = "";
            task3.Text = "";
            task4.Text = "";
            task5.Text = "";
            task6.Text = "";
            //----------------------------------------------------------//
            task1due.Text = "";
            task2due.Text = "";
            task3due.Text = "";
            task4due.Text = "";
            task5due.Text = "";
            task6due.Text = "";

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }



        private void cleartask1_Click(object sender, EventArgs e)
        {
            freeSpace += 1;
            tasksLeft.Text = freeSpace.ToString();
            checkbox1.Checked = false;
            checkbox1.Enabled = false;

            task1.Text = "";
            task1due.Text = "";

            cleartask1.Enabled = false;
        }

        private void cleartask2_Click(object sender, EventArgs e)
        {
            freeSpace += 1;
            tasksLeft.Text = freeSpace.ToString();
            metroCheckBox1.Checked = false;
            metroCheckBox1.Enabled = false;

            task2.Text = "";
            task2due.Text = "";

            cleartask2.Enabled = false;

        }

        private void cleartask3_Click(object sender, EventArgs e)
        {
            freeSpace += 1;
            tasksLeft.Text = freeSpace.ToString();
            metroCheckBox2.Checked = false;
            metroCheckBox2.Enabled = false;

            task3.Text = "";
            task3due.Text = "";

            cleartask3.Enabled = false;
        }

        private void cleartask4_Click(object sender, EventArgs e)
        {
            freeSpace += 1;
            tasksLeft.Text = freeSpace.ToString();
            metroCheckBox3.Checked = false;
            metroCheckBox3.Enabled = false;

            task4.Text = "";
            task4due.Text = "";

            cleartask4.Enabled = false;
        }

        private void cleartask5_Click(object sender, EventArgs e)
        {
            freeSpace += 1;
            tasksLeft.Text = freeSpace.ToString();
            metroCheckBox4.Checked = false;
            metroCheckBox4.Enabled = false;

            task5.Text = "";
            task5due.Text = "";

            cleartask5.Enabled = false;
        }
        private void cleartask6_Click(object sender, EventArgs e)
        {
            freeSpace += 1;
            tasksLeft.Text = freeSpace.ToString();
            metroCheckBox5.Checked = false;
            metroCheckBox5.Enabled = false;


            task6.Text = "";
            task6due.Text = "";

            cleartask6.Enabled = false;
        }




        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.tasktask1 = task1.Text;
            Properties.Settings.Default.tasktask2 = task2.Text;
            Properties.Settings.Default.tasktask3 = task3.Text;
            Properties.Settings.Default.tasktask4 = task4.Text;
            Properties.Settings.Default.tasktask5 = task5.Text;
            Properties.Settings.Default.tasktask6 = task6.Text;
            //-------------------------------------------------
            Properties.Settings.Default.taskdue1 = task1due.Text;
            Properties.Settings.Default.taskdue2 = task2due.Text;
            Properties.Settings.Default.taskdue3 = task3due.Text;
            Properties.Settings.Default.taskdue4 = task4due.Text;
            Properties.Settings.Default.taskdue5 = task5due.Text;
            Properties.Settings.Default.taskdue6 = task6due.Text;
            //-------------------------------------------------
            Properties.Settings.Default.Save();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.tasktask1 = task1.Text;
        }

        private void testtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }
}
