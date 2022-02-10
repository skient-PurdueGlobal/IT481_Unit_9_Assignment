﻿
namespace IT481_Unit_3_Assignment.PAL
{
    partial class MainPage
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLabel = new System.Windows.Forms.Label();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.addRecordGroup = new System.Windows.Forms.GroupBox();
            this.dbTextBox = new System.Windows.Forms.TextBox();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.dbLabel = new System.Windows.Forms.Label();
            this.serverLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.connectUserButton = new System.Windows.Forms.Button();
            this.countRecordGroup = new System.Windows.Forms.GroupBox();
            this.countRecordButton = new System.Windows.Forms.Button();
            this.countRecordTextBox = new System.Windows.Forms.TextBox();
            this.viewDataButton = new System.Windows.Forms.Button();
            this.connectionGroup = new System.Windows.Forms.GroupBox();
            this.connectionTextBox = new System.Windows.Forms.TextBox();
            this.dbViewer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.addRecordGroup.SuspendLayout();
            this.countRecordGroup.SuspendLayout();
            this.connectionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainSplitContainer.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.tableLabel);
            this.mainSplitContainer.Panel1.Controls.Add(this.tableComboBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.addRecordGroup);
            this.mainSplitContainer.Panel1.Controls.Add(this.countRecordGroup);
            this.mainSplitContainer.Panel1.Controls.Add(this.viewDataButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.connectionGroup);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.dbViewer);
            this.mainSplitContainer.Size = new System.Drawing.Size(1164, 711);
            this.mainSplitContainer.SplitterDistance = 215;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Location = new System.Drawing.Point(407, 135);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(37, 15);
            this.tableLabel.TabIndex = 10;
            this.tableLabel.Text = "Table:";
            // 
            // tableComboBox
            // 
            this.tableComboBox.Enabled = false;
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Items.AddRange(new object[] {
            "Customers",
            "Employees",
            "Orders"});
            this.tableComboBox.Location = new System.Drawing.Point(471, 132);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(283, 23);
            this.tableComboBox.TabIndex = 4;
            this.tableComboBox.SelectedIndexChanged += new System.EventHandler(this.tableComboBox_SelectedIndexChanged);
            // 
            // addRecordGroup
            // 
            this.addRecordGroup.Controls.Add(this.dbTextBox);
            this.addRecordGroup.Controls.Add(this.serverTextBox);
            this.addRecordGroup.Controls.Add(this.dbLabel);
            this.addRecordGroup.Controls.Add(this.serverLabel);
            this.addRecordGroup.Controls.Add(this.passwordTextBox);
            this.addRecordGroup.Controls.Add(this.userTextBox);
            this.addRecordGroup.Controls.Add(this.passwordLabel);
            this.addRecordGroup.Controls.Add(this.userLabel);
            this.addRecordGroup.Controls.Add(this.connectUserButton);
            this.addRecordGroup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addRecordGroup.Location = new System.Drawing.Point(38, 10);
            this.addRecordGroup.Name = "addRecordGroup";
            this.addRecordGroup.Size = new System.Drawing.Size(289, 172);
            this.addRecordGroup.TabIndex = 3;
            this.addRecordGroup.TabStop = false;
            this.addRecordGroup.Text = "User Login";
            // 
            // dbTextBox
            // 
            this.dbTextBox.Location = new System.Drawing.Point(122, 93);
            this.dbTextBox.Name = "dbTextBox";
            this.dbTextBox.Size = new System.Drawing.Size(151, 23);
            this.dbTextBox.TabIndex = 9;
            this.dbTextBox.Text = "Northwind";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(122, 69);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(151, 23);
            this.serverTextBox.TabIndex = 8;
            this.serverTextBox.Text = "dellG3";
            // 
            // dbLabel
            // 
            this.dbLabel.AutoSize = true;
            this.dbLabel.Location = new System.Drawing.Point(14, 96);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(58, 15);
            this.dbLabel.TabIndex = 7;
            this.dbLabel.Text = "Database:";
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(14, 72);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(42, 15);
            this.serverLabel.TabIndex = 6;
            this.serverLabel.Text = "Server:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(122, 45);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(151, 23);
            this.passwordTextBox.TabIndex = 5;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(122, 21);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(151, 23);
            this.userTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(14, 48);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 15);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(14, 24);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(33, 15);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "User:";
            // 
            // connectUserButton
            // 
            this.connectUserButton.Location = new System.Drawing.Point(14, 122);
            this.connectUserButton.Name = "connectUserButton";
            this.connectUserButton.Size = new System.Drawing.Size(259, 42);
            this.connectUserButton.TabIndex = 1;
            this.connectUserButton.Text = "Connect User";
            this.connectUserButton.UseVisualStyleBackColor = true;
            this.connectUserButton.Click += new System.EventHandler(this.connectUserButton_Click);
            // 
            // countRecordGroup
            // 
            this.countRecordGroup.Controls.Add(this.countRecordButton);
            this.countRecordGroup.Controls.Add(this.countRecordTextBox);
            this.countRecordGroup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.countRecordGroup.Location = new System.Drawing.Point(839, 10);
            this.countRecordGroup.Name = "countRecordGroup";
            this.countRecordGroup.Size = new System.Drawing.Size(289, 172);
            this.countRecordGroup.TabIndex = 2;
            this.countRecordGroup.TabStop = false;
            this.countRecordGroup.Text = "No. of Records";
            // 
            // countRecordButton
            // 
            this.countRecordButton.Enabled = false;
            this.countRecordButton.Location = new System.Drawing.Point(14, 122);
            this.countRecordButton.Name = "countRecordButton";
            this.countRecordButton.Size = new System.Drawing.Size(259, 42);
            this.countRecordButton.TabIndex = 1;
            this.countRecordButton.Text = "Count Records";
            this.countRecordButton.UseVisualStyleBackColor = true;
            this.countRecordButton.Click += new System.EventHandler(this.countRecordButton_Click);
            // 
            // countRecordTextBox
            // 
            this.countRecordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.countRecordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countRecordTextBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countRecordTextBox.Location = new System.Drawing.Point(14, 21);
            this.countRecordTextBox.Multiline = true;
            this.countRecordTextBox.Name = "countRecordTextBox";
            this.countRecordTextBox.ReadOnly = true;
            this.countRecordTextBox.Size = new System.Drawing.Size(259, 95);
            this.countRecordTextBox.TabIndex = 0;
            this.countRecordTextBox.Text = "?";
            this.countRecordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewDataButton
            // 
            this.viewDataButton.Enabled = false;
            this.viewDataButton.Location = new System.Drawing.Point(333, 158);
            this.viewDataButton.Name = "viewDataButton";
            this.viewDataButton.Size = new System.Drawing.Size(500, 50);
            this.viewDataButton.TabIndex = 1;
            this.viewDataButton.Text = "View Database";
            this.viewDataButton.UseVisualStyleBackColor = true;
            this.viewDataButton.Click += new System.EventHandler(this.viewDataButton_Click);
            // 
            // connectionGroup
            // 
            this.connectionGroup.Controls.Add(this.connectionTextBox);
            this.connectionGroup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.connectionGroup.Location = new System.Drawing.Point(393, 10);
            this.connectionGroup.Name = "connectionGroup";
            this.connectionGroup.Size = new System.Drawing.Size(377, 111);
            this.connectionGroup.TabIndex = 0;
            this.connectionGroup.TabStop = false;
            this.connectionGroup.Text = "Connection Status";
            // 
            // connectionTextBox
            // 
            this.connectionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.connectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connectionTextBox.Location = new System.Drawing.Point(14, 24);
            this.connectionTextBox.Multiline = true;
            this.connectionTextBox.Name = "connectionTextBox";
            this.connectionTextBox.ReadOnly = true;
            this.connectionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.connectionTextBox.Size = new System.Drawing.Size(347, 81);
            this.connectionTextBox.TabIndex = 0;
            this.connectionTextBox.TabStop = false;
            this.connectionTextBox.Text = "Waiting For Connection...";
            this.connectionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dbViewer
            // 
            this.dbViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbViewer.Location = new System.Drawing.Point(0, 0);
            this.dbViewer.Name = "dbViewer";
            this.dbViewer.RowTemplate.Height = 25;
            this.dbViewer.Size = new System.Drawing.Size(1160, 488);
            this.dbViewer.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 711);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit 9 Assignment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.addRecordGroup.ResumeLayout(false);
            this.addRecordGroup.PerformLayout();
            this.countRecordGroup.ResumeLayout(false);
            this.countRecordGroup.PerformLayout();
            this.connectionGroup.ResumeLayout(false);
            this.connectionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.DataGridView dbViewer;
        private System.Windows.Forms.GroupBox connectionGroup;
        private System.Windows.Forms.TextBox connectionTextBox;
        private System.Windows.Forms.Button viewDataButton;
        private System.Windows.Forms.GroupBox countRecordGroup;
        private System.Windows.Forms.Button countRecordButton;
        private System.Windows.Forms.TextBox countRecordTextBox;
        private System.Windows.Forms.GroupBox addRecordGroup;
        private System.Windows.Forms.Button connectUserButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox dbTextBox;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label dbLabel;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.ComboBox tableComboBox;
    }
}