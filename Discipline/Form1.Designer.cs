
namespace Discipline
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.writetaskTextBox = new MetroFramework.Controls.MetroTextBox();
            this.writeTaskLabel = new System.Windows.Forms.Label();
            this.dueLabel = new System.Windows.Forms.Label();
            this.dueTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addTaskButton = new MetroFramework.Controls.MetroButton();
            this.tasklabel = new System.Windows.Forms.Label();
            this.colorBorder = new System.Windows.Forms.Panel();
            this.task1 = new MetroFramework.Controls.MetroTextBox();
            this.task1due = new MetroFramework.Controls.MetroTextBox();
            this.checkbox1 = new MetroFramework.Controls.MetroCheckBox();
            this.task2 = new MetroFramework.Controls.MetroTextBox();
            this.task2due = new MetroFramework.Controls.MetroTextBox();
            this.task3 = new MetroFramework.Controls.MetroTextBox();
            this.task3due = new MetroFramework.Controls.MetroTextBox();
            this.task4 = new MetroFramework.Controls.MetroTextBox();
            this.task4due = new MetroFramework.Controls.MetroTextBox();
            this.task5 = new MetroFramework.Controls.MetroTextBox();
            this.task5due = new MetroFramework.Controls.MetroTextBox();
            this.task6 = new MetroFramework.Controls.MetroTextBox();
            this.task6due = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox5 = new MetroFramework.Controls.MetroCheckBox();
            this.resetButton = new MetroFramework.Controls.MetroButton();
            this.cleartask1 = new MetroFramework.Controls.MetroButton();
            this.cleartask2 = new MetroFramework.Controls.MetroButton();
            this.cleartask3 = new MetroFramework.Controls.MetroButton();
            this.cleartask4 = new MetroFramework.Controls.MetroButton();
            this.cleartask5 = new MetroFramework.Controls.MetroButton();
            this.cleartask6 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tasksLeft = new MetroFramework.Controls.MetroLabel();
            this.quote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // writetaskTextBox
            // 
            // 
            // 
            // 
            this.writetaskTextBox.CustomButton.Image = null;
            this.writetaskTextBox.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.writetaskTextBox.CustomButton.Name = "";
            this.writetaskTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.writetaskTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.writetaskTextBox.CustomButton.TabIndex = 1;
            this.writetaskTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.writetaskTextBox.CustomButton.UseSelectable = true;
            this.writetaskTextBox.CustomButton.Visible = false;
            this.writetaskTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.writetaskTextBox.Lines = new string[0];
            this.writetaskTextBox.Location = new System.Drawing.Point(245, 63);
            this.writetaskTextBox.MaxLength = 32767;
            this.writetaskTextBox.Name = "writetaskTextBox";
            this.writetaskTextBox.PasswordChar = '\0';
            this.writetaskTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.writetaskTextBox.SelectedText = "";
            this.writetaskTextBox.SelectionLength = 0;
            this.writetaskTextBox.SelectionStart = 0;
            this.writetaskTextBox.ShortcutsEnabled = true;
            this.writetaskTextBox.Size = new System.Drawing.Size(148, 30);
            this.writetaskTextBox.TabIndex = 1;
            this.writetaskTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.writetaskTextBox.UseSelectable = true;
            this.writetaskTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.writetaskTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // writeTaskLabel
            // 
            this.writeTaskLabel.AutoSize = true;
            this.writeTaskLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeTaskLabel.Location = new System.Drawing.Point(264, 23);
            this.writeTaskLabel.Name = "writeTaskLabel";
            this.writeTaskLabel.Size = new System.Drawing.Size(113, 30);
            this.writeTaskLabel.TabIndex = 2;
            this.writeTaskLabel.Text = "Write Task:";
            // 
            // dueLabel
            // 
            this.dueLabel.AutoSize = true;
            this.dueLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueLabel.Location = new System.Drawing.Point(505, 23);
            this.dueLabel.Name = "dueLabel";
            this.dueLabel.Size = new System.Drawing.Size(56, 30);
            this.dueLabel.TabIndex = 3;
            this.dueLabel.Text = "Due:";
            this.dueLabel.Click += new System.EventHandler(this.tasksLeft_Click);
            // 
            // dueTextBox
            // 
            // 
            // 
            // 
            this.dueTextBox.CustomButton.Image = null;
            this.dueTextBox.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.dueTextBox.CustomButton.Name = "";
            this.dueTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.dueTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dueTextBox.CustomButton.TabIndex = 1;
            this.dueTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dueTextBox.CustomButton.UseSelectable = true;
            this.dueTextBox.CustomButton.Visible = false;
            this.dueTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.dueTextBox.Lines = new string[0];
            this.dueTextBox.Location = new System.Drawing.Point(454, 63);
            this.dueTextBox.MaxLength = 32767;
            this.dueTextBox.Name = "dueTextBox";
            this.dueTextBox.PasswordChar = '\0';
            this.dueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dueTextBox.SelectedText = "";
            this.dueTextBox.SelectionLength = 0;
            this.dueTextBox.SelectionStart = 0;
            this.dueTextBox.ShortcutsEnabled = true;
            this.dueTextBox.Size = new System.Drawing.Size(148, 30);
            this.dueTextBox.TabIndex = 4;
            this.dueTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dueTextBox.UseSelectable = true;
            this.dueTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dueTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.dueTextBox.Click += new System.EventHandler(this.dueTextBox_Click);
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addTaskButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addTaskButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addTaskButton.Location = new System.Drawing.Point(653, 50);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(116, 43);
            this.addTaskButton.TabIndex = 5;
            this.addTaskButton.TabStop = false;
            this.addTaskButton.Text = "ADD TASK";
            this.addTaskButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.addTaskButton.UseCustomBackColor = true;
            this.addTaskButton.UseCustomForeColor = true;
            this.addTaskButton.UseMnemonic = false;
            this.addTaskButton.UseSelectable = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // tasklabel
            // 
            this.tasklabel.AutoSize = true;
            this.tasklabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tasklabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.tasklabel.Location = new System.Drawing.Point(313, 141);
            this.tasklabel.Name = "tasklabel";
            this.tasklabel.Size = new System.Drawing.Size(76, 30);
            this.tasklabel.TabIndex = 6;
            this.tasklabel.Text = "TASKS:";
            this.tasklabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // colorBorder
            // 
            this.colorBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.colorBorder.Location = new System.Drawing.Point(1, 119);
            this.colorBorder.Name = "colorBorder";
            this.colorBorder.Size = new System.Drawing.Size(804, 10);
            this.colorBorder.TabIndex = 8;
            // 
            // task1
            // 
            // 
            // 
            // 
            this.task1.CustomButton.Image = null;
            this.task1.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.task1.CustomButton.Name = "";
            this.task1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.task1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.task1.CustomButton.TabIndex = 1;
            this.task1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.task1.CustomButton.UseSelectable = true;
            this.task1.CustomButton.Visible = false;
            this.task1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.task1.Lines = new string[0];
            this.task1.Location = new System.Drawing.Point(163, 198);
            this.task1.MaxLength = 32767;
            this.task1.Name = "task1";
            this.task1.PasswordChar = '\0';
            this.task1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.task1.SelectedText = "";
            this.task1.SelectionLength = 0;
            this.task1.SelectionStart = 0;
            this.task1.ShortcutsEnabled = true;
            this.task1.Size = new System.Drawing.Size(148, 30);
            this.task1.TabIndex = 9;
            this.task1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.task1.UseSelectable = true;
            this.task1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.task1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.task1.Click += new System.EventHandler(this.task1_Click);
            // 
            // task1due
            // 
            // 
            // 
            // 
            this.task1due.CustomButton.Image = null;
            this.task1due.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.task1due.CustomButton.Name = "";
            this.task1due.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.task1due.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.task1due.CustomButton.TabIndex = 1;
            this.task1due.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.task1due.CustomButton.UseSelectable = true;
            this.task1due.CustomButton.Visible = false;
            this.task1due.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.task1due.Lines = new string[0];
            this.task1due.Location = new System.Drawing.Point(358, 198);
            this.task1due.MaxLength = 32767;
            this.task1due.Name = "task1due";
            this.task1due.PasswordChar = '\0';
            this.task1due.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.task1due.SelectedText = "";
            this.task1due.SelectionLength = 0;
            this.task1due.SelectionStart = 0;
            this.task1due.ShortcutsEnabled = true;
            this.task1due.Size = new System.Drawing.Size(148, 30);
            this.task1due.TabIndex = 10;
            this.task1due.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.task1due.UseSelectable = true;
            this.task1due.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.task1due.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.task1due.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Location = new System.Drawing.Point(523, 213);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(32, 15);
            this.checkbox1.TabIndex = 11;
            this.checkbox1.Text = "✓";
            this.checkbox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkbox1.UseSelectable = true;
            this.checkbox1.CheckedChanged += new System.EventHandler(this.checkbox1_CheckedChanged);
            // 
            // task2
            // 
            // 
            // 
            // 
            this.task2.CustomButton.Image = null;
            this.task2.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.task2.CustomButton.Name = "";
            this.task2.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.task2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.task2.CustomButton.TabIndex = 1;
            this.task2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.task2.CustomButton.UseSelectable = true;
            this.task2.CustomButton.Visible = false;
            this.task2.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.task2.Lines = new string[0];
            this.task2.Location = new System.Drawing.Point(163, 234);
            this.task2.MaxLength = 32767;
            this.task2.Name = "task2";
            this.task2.PasswordChar = '\0';
            this.task2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.task2.SelectedText = "";
            this.task2.SelectionLength = 0;
            this.task2.SelectionStart = 0;
            this.task2.ShortcutsEnabled = true;
            this.task2.Size = new System.Drawing.Size(148, 30);
            this.task2.TabIndex = 12;
            this.task2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.task2.UseSelectable = true;
            this.task2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.task2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // task2due
            // 
            // 
            // 
            // 
            this.task2due.CustomButton.Image = null;
            this.task2due.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.task2due.CustomButton.Name = "";
            this.task2due.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.task2due.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.task2due.CustomButton.TabIndex = 1;
            this.task2due.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.task2due.CustomButton.UseSelectable = true;
            this.task2due.CustomButton.Visible = false;
            this.task2due.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.task2due.Lines = new string[0];
            this.task2due.Location = new System.Drawing.Point(358, 234);
            this.task2due.MaxLength = 32767;
            this.task2due.Name = "task2due";
            this.task2due.PasswordChar = '\0';
            this.task2due.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.task2due.SelectedText = "";
            this.task2due.SelectionLength = 0;
            this.task2due.SelectionStart = 0;
            this.task2due.ShortcutsEnabled = true;
            this.task2due.Size = new System.Drawing.Size(148, 30);
            this.task2due.TabIndex = 13;
            this.task2due.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.task2due.UseSelectable = true;
            this.task2due.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.task2due.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // task3
            // 
            // 
            // 
            // 
            this.task3.CustomButton.Image = null;
            this.task3.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.task3.CustomButton.Name = "";
            this.task3.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.task3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.task3.CustomButton.TabIndex = 1;
            this.task3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.task3.CustomButton.UseSelectable = true;
            this.task3.CustomButton.Visible = false;
            this.task3.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.task3.Lines = new string[0];
            this.task3.Location = new System.Drawing.Point(163, 270);
            this.task3.MaxLength = 32767;
            this.task3.Name = "task3";
            this.task3.PasswordChar = '\0';
            this.task3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.task3.SelectedText = "";
            this.task3.SelectionLength = 0;
            this.task3.SelectionStart = 0;
            this.task3.ShortcutsEnabled = true;
            this.task3.Size = new System.Drawing.Size(148, 30);
            this.task3.TabIndex = 14;
            this.task3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.task3.UseSelectable = true;
            this.task3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.task3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // task3due
            // 
            // 
            // 
            // 
            this.task3due.CustomButton.Image = null;
            this.task3due.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.task3due.CustomButton.Name = "";
            this.task3due.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.task3due.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.task3due.CustomButton.TabIndex = 1;
            this.task3due.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.task3due.CustomButton.UseSelectable = true;
            this.task3due.CustomButton.Visible = false;
            this.task3due.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.task3due.Lines = new string[0];
            this.task3due.Location = new System.Drawing.Point(358, 270);
            this.task3due.MaxLength = 32767;
            this.task3due.Name = "task3due";
            this.task3due.PasswordChar = '\0';
            this.task3due.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.task3due.SelectedText = "";
            this.task3due.SelectionLength = 0;
            this.task3due.SelectionStart = 0;
            this.task3due.ShortcutsEnabled = true;
            this.task3due.Size = new System.Drawing.Size(148, 30);
            this.task3due.TabIndex = 15;
            this.task3due.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.task3due.UseSelectable = true;
            this.task3due.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.task3due.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // task4
            // 
            // 
            // 
            // 
            this.task4.CustomButton.Image = null;
            this.task4.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.task4.CustomButton.Name = "";
            this.task4.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.task4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.task4.CustomButton.TabIndex = 1;
            this.task4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.task4.CustomButton.UseSelectable = true;
            this.task4.CustomButton.Visible = false;
            this.task4.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.task4.Lines = new string[0];
            this.task4.Location = new System.Drawing.Point(163, 306);
            this.task4.MaxLength = 32767;
            this.task4.Name = "task4";
            this.task4.PasswordChar = '\0';
            this.task4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.task4.SelectedText = "";
            this.task4.SelectionLength = 0;
            this.task4.SelectionStart = 0;
            this.task4.ShortcutsEnabled = true;
            this.task4.Size = new System.Drawing.Size(148, 30);
            this.task4.TabIndex = 16;
            this.task4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.task4.UseSelectable = true;
            this.task4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.task4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // task4due
            // 
            // 
            // 
            // 
            this.task4due.CustomButton.Image = null;
            this.task4due.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.task4due.CustomButton.Name = "";
            this.task4due.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.task4due.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.task4due.CustomButton.TabIndex = 1;
            this.task4due.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.task4due.CustomButton.UseSelectable = true;
            this.task4due.CustomButton.Visible = false;
            this.task4due.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.task4due.Lines = new string[0];
            this.task4due.Location = new System.Drawing.Point(358, 306);
            this.task4due.MaxLength = 32767;
            this.task4due.Name = "task4due";
            this.task4due.PasswordChar = '\0';
            this.task4due.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.task4due.SelectedText = "";
            this.task4due.SelectionLength = 0;
            this.task4due.SelectionStart = 0;
            this.task4due.ShortcutsEnabled = true;
            this.task4due.Size = new System.Drawing.Size(148, 30);
            this.task4due.TabIndex = 17;
            this.task4due.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.task4due.UseSelectable = true;
            this.task4due.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.task4due.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // task5
            // 
            // 
            // 
            // 
            this.task5.CustomButton.Image = null;
            this.task5.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.task5.CustomButton.Name = "";
            this.task5.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.task5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.task5.CustomButton.TabIndex = 1;
            this.task5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.task5.CustomButton.UseSelectable = true;
            this.task5.CustomButton.Visible = false;
            this.task5.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.task5.Lines = new string[0];
            this.task5.Location = new System.Drawing.Point(163, 342);
            this.task5.MaxLength = 32767;
            this.task5.Name = "task5";
            this.task5.PasswordChar = '\0';
            this.task5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.task5.SelectedText = "";
            this.task5.SelectionLength = 0;
            this.task5.SelectionStart = 0;
            this.task5.ShortcutsEnabled = true;
            this.task5.Size = new System.Drawing.Size(148, 30);
            this.task5.TabIndex = 18;
            this.task5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.task5.UseSelectable = true;
            this.task5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.task5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // task5due
            // 
            // 
            // 
            // 
            this.task5due.CustomButton.Image = null;
            this.task5due.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.task5due.CustomButton.Name = "";
            this.task5due.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.task5due.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.task5due.CustomButton.TabIndex = 1;
            this.task5due.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.task5due.CustomButton.UseSelectable = true;
            this.task5due.CustomButton.Visible = false;
            this.task5due.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.task5due.Lines = new string[0];
            this.task5due.Location = new System.Drawing.Point(358, 342);
            this.task5due.MaxLength = 32767;
            this.task5due.Name = "task5due";
            this.task5due.PasswordChar = '\0';
            this.task5due.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.task5due.SelectedText = "";
            this.task5due.SelectionLength = 0;
            this.task5due.SelectionStart = 0;
            this.task5due.ShortcutsEnabled = true;
            this.task5due.Size = new System.Drawing.Size(148, 30);
            this.task5due.TabIndex = 19;
            this.task5due.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.task5due.UseSelectable = true;
            this.task5due.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.task5due.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // task6
            // 
            // 
            // 
            // 
            this.task6.CustomButton.Image = null;
            this.task6.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.task6.CustomButton.Name = "";
            this.task6.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.task6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.task6.CustomButton.TabIndex = 1;
            this.task6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.task6.CustomButton.UseSelectable = true;
            this.task6.CustomButton.Visible = false;
            this.task6.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.task6.Lines = new string[0];
            this.task6.Location = new System.Drawing.Point(163, 378);
            this.task6.MaxLength = 32767;
            this.task6.Name = "task6";
            this.task6.PasswordChar = '\0';
            this.task6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.task6.SelectedText = "";
            this.task6.SelectionLength = 0;
            this.task6.SelectionStart = 0;
            this.task6.ShortcutsEnabled = true;
            this.task6.Size = new System.Drawing.Size(148, 30);
            this.task6.TabIndex = 20;
            this.task6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.task6.UseSelectable = true;
            this.task6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.task6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // task6due
            // 
            // 
            // 
            // 
            this.task6due.CustomButton.Image = null;
            this.task6due.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.task6due.CustomButton.Name = "";
            this.task6due.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.task6due.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.task6due.CustomButton.TabIndex = 1;
            this.task6due.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.task6due.CustomButton.UseSelectable = true;
            this.task6due.CustomButton.Visible = false;
            this.task6due.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.task6due.Lines = new string[0];
            this.task6due.Location = new System.Drawing.Point(358, 378);
            this.task6due.MaxLength = 32767;
            this.task6due.Name = "task6due";
            this.task6due.PasswordChar = '\0';
            this.task6due.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.task6due.SelectedText = "";
            this.task6due.SelectionLength = 0;
            this.task6due.SelectionStart = 0;
            this.task6due.ShortcutsEnabled = true;
            this.task6due.Size = new System.Drawing.Size(148, 30);
            this.task6due.TabIndex = 21;
            this.task6due.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.task6due.UseSelectable = true;
            this.task6due.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.task6due.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.BackColor = System.Drawing.Color.White;
            this.metroCheckBox1.Location = new System.Drawing.Point(523, 249);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(32, 15);
            this.metroCheckBox1.TabIndex = 22;
            this.metroCheckBox1.Text = "✓";
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(523, 285);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(32, 15);
            this.metroCheckBox2.TabIndex = 23;
            this.metroCheckBox2.Text = "✓";
            this.metroCheckBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox2.UseSelectable = true;
            this.metroCheckBox2.CheckedChanged += new System.EventHandler(this.metroCheckBox2_CheckedChanged);
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Location = new System.Drawing.Point(523, 321);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(32, 15);
            this.metroCheckBox3.TabIndex = 24;
            this.metroCheckBox3.Text = "✓";
            this.metroCheckBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox3.UseSelectable = true;
            this.metroCheckBox3.CheckedChanged += new System.EventHandler(this.metroCheckBox3_CheckedChanged);
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.AutoSize = true;
            this.metroCheckBox4.Location = new System.Drawing.Point(523, 357);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(32, 15);
            this.metroCheckBox4.TabIndex = 25;
            this.metroCheckBox4.Text = "✓";
            this.metroCheckBox4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox4.UseSelectable = true;
            this.metroCheckBox4.CheckedChanged += new System.EventHandler(this.metroCheckBox4_CheckedChanged);
            // 
            // metroCheckBox5
            // 
            this.metroCheckBox5.AutoSize = true;
            this.metroCheckBox5.Location = new System.Drawing.Point(523, 393);
            this.metroCheckBox5.Name = "metroCheckBox5";
            this.metroCheckBox5.Size = new System.Drawing.Size(32, 15);
            this.metroCheckBox5.TabIndex = 26;
            this.metroCheckBox5.Text = "✓";
            this.metroCheckBox5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox5.UseSelectable = true;
            this.metroCheckBox5.CheckedChanged += new System.EventHandler(this.metroCheckBox5_CheckedChanged);
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = true;
            this.resetButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.resetButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetButton.Location = new System.Drawing.Point(11, 408);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(101, 28);
            this.resetButton.TabIndex = 27;
            this.resetButton.TabStop = false;
            this.resetButton.Text = "RESET ALL";
            this.resetButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.resetButton.UseCustomBackColor = true;
            this.resetButton.UseCustomForeColor = true;
            this.resetButton.UseMnemonic = false;
            this.resetButton.UseSelectable = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // cleartask1
            // 
            this.cleartask1.Location = new System.Drawing.Point(561, 205);
            this.cleartask1.Name = "cleartask1";
            this.cleartask1.Size = new System.Drawing.Size(87, 23);
            this.cleartask1.TabIndex = 28;
            this.cleartask1.Text = "CLEAR TASK";
            this.cleartask1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cleartask1.UseSelectable = true;
            this.cleartask1.Click += new System.EventHandler(this.cleartask1_Click);
            // 
            // cleartask2
            // 
            this.cleartask2.Location = new System.Drawing.Point(561, 241);
            this.cleartask2.Name = "cleartask2";
            this.cleartask2.Size = new System.Drawing.Size(87, 23);
            this.cleartask2.TabIndex = 29;
            this.cleartask2.Text = "CLEAR TASK";
            this.cleartask2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cleartask2.UseSelectable = true;
            this.cleartask2.Click += new System.EventHandler(this.cleartask2_Click);
            // 
            // cleartask3
            // 
            this.cleartask3.Location = new System.Drawing.Point(561, 277);
            this.cleartask3.Name = "cleartask3";
            this.cleartask3.Size = new System.Drawing.Size(87, 23);
            this.cleartask3.TabIndex = 30;
            this.cleartask3.Text = "CLEAR TASK";
            this.cleartask3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cleartask3.UseSelectable = true;
            this.cleartask3.Click += new System.EventHandler(this.cleartask3_Click);
            // 
            // cleartask4
            // 
            this.cleartask4.Location = new System.Drawing.Point(561, 313);
            this.cleartask4.Name = "cleartask4";
            this.cleartask4.Size = new System.Drawing.Size(87, 23);
            this.cleartask4.TabIndex = 31;
            this.cleartask4.Text = "CLEAR TASK";
            this.cleartask4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cleartask4.UseSelectable = true;
            this.cleartask4.Click += new System.EventHandler(this.cleartask4_Click);
            // 
            // cleartask5
            // 
            this.cleartask5.Location = new System.Drawing.Point(561, 349);
            this.cleartask5.Name = "cleartask5";
            this.cleartask5.Size = new System.Drawing.Size(87, 23);
            this.cleartask5.TabIndex = 32;
            this.cleartask5.Text = "CLEAR TASK";
            this.cleartask5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cleartask5.UseSelectable = true;
            this.cleartask5.Click += new System.EventHandler(this.cleartask5_Click);
            // 
            // cleartask6
            // 
            this.cleartask6.Location = new System.Drawing.Point(561, 385);
            this.cleartask6.Name = "cleartask6";
            this.cleartask6.Size = new System.Drawing.Size(87, 23);
            this.cleartask6.TabIndex = 33;
            this.cleartask6.Text = "CLEAR TASK";
            this.cleartask6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cleartask6.UseSelectable = true;
            this.cleartask6.Click += new System.EventHandler(this.cleartask6_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(705, 158);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "TASKS LEFT";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tasksLeft
            // 
            this.tasksLeft.AutoSize = true;
            this.tasksLeft.Location = new System.Drawing.Point(690, 158);
            this.tasksLeft.Name = "tasksLeft";
            this.tasksLeft.Size = new System.Drawing.Size(0, 0);
            this.tasksLeft.TabIndex = 35;
            this.tasksLeft.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tasksLeft.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // quote
            // 
            this.quote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quote.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quote.ForeColor = System.Drawing.Color.Crimson;
            this.quote.Location = new System.Drawing.Point(46, 106);
            this.quote.Name = "quote";
            this.quote.Size = new System.Drawing.Size(715, 35);
            this.quote.TabIndex = 37;
            this.quote.Text = "Discipline, consistency, and perseverance will take you places motivation never c" +
    "ould.";
            this.quote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(803, 446);
            this.Controls.Add(this.quote);
            this.Controls.Add(this.tasksLeft);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cleartask6);
            this.Controls.Add(this.cleartask5);
            this.Controls.Add(this.cleartask4);
            this.Controls.Add(this.cleartask3);
            this.Controls.Add(this.cleartask2);
            this.Controls.Add(this.cleartask1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.metroCheckBox5);
            this.Controls.Add(this.metroCheckBox4);
            this.Controls.Add(this.metroCheckBox3);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.task6due);
            this.Controls.Add(this.task6);
            this.Controls.Add(this.task5due);
            this.Controls.Add(this.task5);
            this.Controls.Add(this.task4due);
            this.Controls.Add(this.task4);
            this.Controls.Add(this.task3due);
            this.Controls.Add(this.task3);
            this.Controls.Add(this.task2due);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.checkbox1);
            this.Controls.Add(this.task1due);
            this.Controls.Add(this.task1);
            this.Controls.Add(this.colorBorder);
            this.Controls.Add(this.tasklabel);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.dueTextBox);
            this.Controls.Add(this.dueLabel);
            this.Controls.Add(this.writeTaskLabel);
            this.Controls.Add(this.writetaskTextBox);
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Build Discipline";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Turquoise;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox writetaskTextBox;
        private System.Windows.Forms.Label writeTaskLabel;
        private System.Windows.Forms.Label dueLabel;
        private MetroFramework.Controls.MetroTextBox dueTextBox;
        private MetroFramework.Controls.MetroButton addTaskButton;
        private System.Windows.Forms.Label tasklabel;
        private System.Windows.Forms.Panel colorBorder;
        private MetroFramework.Controls.MetroTextBox task1;
        private MetroFramework.Controls.MetroTextBox task1due;
        private MetroFramework.Controls.MetroCheckBox checkbox1;
        private MetroFramework.Controls.MetroTextBox task2;
        private MetroFramework.Controls.MetroTextBox task2due;
        private MetroFramework.Controls.MetroTextBox task3;
        private MetroFramework.Controls.MetroTextBox task3due;
        private MetroFramework.Controls.MetroTextBox task4;
        private MetroFramework.Controls.MetroTextBox task4due;
        private MetroFramework.Controls.MetroTextBox task5;
        private MetroFramework.Controls.MetroTextBox task5due;
        private MetroFramework.Controls.MetroTextBox task6;
        private MetroFramework.Controls.MetroTextBox task6due;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox5;
        private MetroFramework.Controls.MetroButton resetButton;
        private MetroFramework.Controls.MetroButton cleartask1;
        private MetroFramework.Controls.MetroButton cleartask2;
        private MetroFramework.Controls.MetroButton cleartask3;
        private MetroFramework.Controls.MetroButton cleartask4;
        private MetroFramework.Controls.MetroButton cleartask5;
        private MetroFramework.Controls.MetroButton cleartask6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel tasksLeft;
        private System.Windows.Forms.Label quote;
    }
}

