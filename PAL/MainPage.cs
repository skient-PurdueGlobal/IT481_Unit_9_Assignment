using System;
using System.Data;
using System.Windows.Forms;

namespace IT481_Unit_3_Assignment.PAL
{
    public partial class MainPage : Form
    {
        //Intialize BAL Class
        BAL.BusinessLayer busAccess;

        public MainPage()
        {
            InitializeComponent();
        }

        //Event Methods
        private void MainPage_Load(object sender, EventArgs e)
        {
            tableComboBox.SelectedIndex = 0;
        }
        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void viewDataButton_Click(object sender, EventArgs e)
        {
            dbViewer.DataSource = busAccess.Populate_DataGrid(tableComboBox.SelectedIndex);
            if ((dbViewer.DataSource as DataTable).Rows.Count == 0)
                connectionTextBox.Text += Environment.NewLine + "User access DENIED for selected table...";
            else
                connectionTextBox.Text += Environment.NewLine + "Data Grid View Populated...";
        }
        private void countRecordButton_Click(object sender, EventArgs e)
        {
            countRecordTextBox.Text = busAccess.Count_Records(tableComboBox.SelectedIndex).ToString();
            connectionTextBox.Text += Environment.NewLine + "Records Counted...";
        }
        private void connectUserButton_Click(object sender, EventArgs e)
        {
            if (userTextBox.TextLength == 0 || passwordTextBox.TextLength == 0 || serverTextBox.TextLength == 0 || dbTextBox.TextLength == 0)
                MessageBox.Show("You must provide inputs for User, Password, Server, and Database fields!!");
            else
            {
                busAccess = new BAL.BusinessLayer(userTextBox.Text, passwordTextBox.Text, serverTextBox.Text, dbTextBox.Text);
                connectionTextBox.Text = busAccess.Load_Data();
                if (!connectionTextBox.Text.Contains("Error"))
                {
                    viewDataButton.Enabled = true;
                    countRecordButton.Enabled = true;
                    tableComboBox.Enabled = true;
                }
            }
        }
        private void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbViewer.DataSource = null;
            countRecordTextBox.Text = "?";
            //connectionTextBox.Text += Environment.NewLine + "Viewer & Count Reset...";
        }
    }
}
