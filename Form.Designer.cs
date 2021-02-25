
namespace AverageUnitsShippedNicholasShortt
{
    partial class formAverageUnitsShippedByEmployee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelUnitsPrompt = new System.Windows.Forms.Label();
            this.textBoxUnitsInput = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxEmployee1Entries = new System.Windows.Forms.TextBox();
            this.labelTotalAverageOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxEmployee2Entries = new System.Windows.Forms.TextBox();
            this.textBoxEmployee3Entries = new System.Windows.Forms.TextBox();
            this.labelEmployee1AverageOutput = new System.Windows.Forms.Label();
            this.labelEmployee2AverageOutput = new System.Windows.Forms.Label();
            this.labelEmployee3AverageOutput = new System.Windows.Forms.Label();
            this.labelEmployee1 = new System.Windows.Forms.Label();
            this.labelEmployee2 = new System.Windows.Forms.Label();
            this.labelEmployee3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.Location = new System.Drawing.Point(12, 56);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(65, 35);
            this.labelUnitsPrompt.TabIndex = 1;
            this.labelUnitsPrompt.Text = "&Units:";
            // 
            // textBoxUnitsInput
            // 
            this.textBoxUnitsInput.Location = new System.Drawing.Point(83, 56);
            this.textBoxUnitsInput.Name = "textBoxUnitsInput";
            this.textBoxUnitsInput.Size = new System.Drawing.Size(81, 35);
            this.textBoxUnitsInput.TabIndex = 2;
            this.toolTip.SetToolTip(this.textBoxUnitsInput, "Enter the units shipped for specified day and employee.");
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(12, 18);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(84, 35);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "Day 1";
            // 
            // textBoxEmployee1Entries
            // 
            this.textBoxEmployee1Entries.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEmployee1Entries.Location = new System.Drawing.Point(12, 147);
            this.textBoxEmployee1Entries.Multiline = true;
            this.textBoxEmployee1Entries.Name = "textBoxEmployee1Entries";
            this.textBoxEmployee1Entries.ReadOnly = true;
            this.textBoxEmployee1Entries.Size = new System.Drawing.Size(175, 221);
            this.textBoxEmployee1Entries.TabIndex = 6;
            this.toolTip.SetToolTip(this.textBoxEmployee1Entries, "Displays the units shipped for all days entered so far for employee 1.");
            // 
            // labelTotalAverageOutput
            // 
            this.labelTotalAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalAverageOutput.Location = new System.Drawing.Point(12, 425);
            this.labelTotalAverageOutput.Name = "labelTotalAverageOutput";
            this.labelTotalAverageOutput.Size = new System.Drawing.Size(537, 38);
            this.labelTotalAverageOutput.TabIndex = 12;
            this.labelTotalAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelTotalAverageOutput, "Displays the calculated total average units for the week.");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(12, 466);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(175, 50);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to process current units shipped");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(193, 466);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(175, 50);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset form and start new week of entry.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonEnterReset);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(374, 466);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(175, 50);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to close the application.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // textBoxEmployee2Entries
            // 
            this.textBoxEmployee2Entries.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEmployee2Entries.Location = new System.Drawing.Point(193, 147);
            this.textBoxEmployee2Entries.Multiline = true;
            this.textBoxEmployee2Entries.Name = "textBoxEmployee2Entries";
            this.textBoxEmployee2Entries.ReadOnly = true;
            this.textBoxEmployee2Entries.Size = new System.Drawing.Size(175, 221);
            this.textBoxEmployee2Entries.TabIndex = 7;
            this.toolTip.SetToolTip(this.textBoxEmployee2Entries, "Displays the units shipped for all days entered so far for employee 2.");
            // 
            // textBoxEmployee3Entries
            // 
            this.textBoxEmployee3Entries.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEmployee3Entries.Location = new System.Drawing.Point(374, 147);
            this.textBoxEmployee3Entries.Multiline = true;
            this.textBoxEmployee3Entries.Name = "textBoxEmployee3Entries";
            this.textBoxEmployee3Entries.ReadOnly = true;
            this.textBoxEmployee3Entries.Size = new System.Drawing.Size(175, 221);
            this.textBoxEmployee3Entries.TabIndex = 8;
            this.toolTip.SetToolTip(this.textBoxEmployee3Entries, "Displays the units shipped for all days entered so far for employee 3.");
            // 
            // labelEmployee1AverageOutput
            // 
            this.labelEmployee1AverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployee1AverageOutput.Location = new System.Drawing.Point(12, 371);
            this.labelEmployee1AverageOutput.Name = "labelEmployee1AverageOutput";
            this.labelEmployee1AverageOutput.Size = new System.Drawing.Size(175, 38);
            this.labelEmployee1AverageOutput.TabIndex = 9;
            this.labelEmployee1AverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelEmployee1AverageOutput, "Displays the calculated average units for the week for employee 1.");
            // 
            // labelEmployee2AverageOutput
            // 
            this.labelEmployee2AverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployee2AverageOutput.Location = new System.Drawing.Point(193, 371);
            this.labelEmployee2AverageOutput.Name = "labelEmployee2AverageOutput";
            this.labelEmployee2AverageOutput.Size = new System.Drawing.Size(175, 38);
            this.labelEmployee2AverageOutput.TabIndex = 10;
            this.labelEmployee2AverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelEmployee2AverageOutput, "Displays the calculated average units for the week for employee 2.");
            // 
            // labelEmployee3AverageOutput
            // 
            this.labelEmployee3AverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployee3AverageOutput.Location = new System.Drawing.Point(374, 371);
            this.labelEmployee3AverageOutput.Name = "labelEmployee3AverageOutput";
            this.labelEmployee3AverageOutput.Size = new System.Drawing.Size(175, 38);
            this.labelEmployee3AverageOutput.TabIndex = 11;
            this.labelEmployee3AverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelEmployee3AverageOutput, "Displays the calculated average units for the week for employee 3.");
            // 
            // labelEmployee1
            // 
            this.labelEmployee1.Location = new System.Drawing.Point(32, 109);
            this.labelEmployee1.Name = "labelEmployee1";
            this.labelEmployee1.Size = new System.Drawing.Size(146, 35);
            this.labelEmployee1.TabIndex = 3;
            this.labelEmployee1.Text = "Employee 1";
            this.labelEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployee2
            // 
            this.labelEmployee2.Location = new System.Drawing.Point(212, 109);
            this.labelEmployee2.Name = "labelEmployee2";
            this.labelEmployee2.Size = new System.Drawing.Size(146, 35);
            this.labelEmployee2.TabIndex = 4;
            this.labelEmployee2.Text = "Employee 2";
            this.labelEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployee3
            // 
            this.labelEmployee3.Location = new System.Drawing.Point(392, 109);
            this.labelEmployee3.Name = "labelEmployee3";
            this.labelEmployee3.Size = new System.Drawing.Size(146, 35);
            this.labelEmployee3.TabIndex = 5;
            this.labelEmployee3.Text = "Employee 3";
            this.labelEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formAverageUnitsShippedByEmployee
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(561, 526);
            this.Controls.Add(this.labelEmployee3);
            this.Controls.Add(this.labelEmployee2);
            this.Controls.Add(this.labelEmployee1);
            this.Controls.Add(this.labelEmployee3AverageOutput);
            this.Controls.Add(this.labelEmployee2AverageOutput);
            this.Controls.Add(this.labelEmployee1AverageOutput);
            this.Controls.Add(this.textBoxEmployee3Entries);
            this.Controls.Add(this.textBoxEmployee2Entries);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelTotalAverageOutput);
            this.Controls.Add(this.textBoxEmployee1Entries);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxUnitsInput);
            this.Controls.Add(this.labelUnitsPrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAverageUnitsShippedByEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped By Employee";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnitsPrompt;
        private System.Windows.Forms.TextBox textBoxUnitsInput;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxEmployee1Entries;
        private System.Windows.Forms.Label labelTotalAverageOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox textBoxEmployee2Entries;
        private System.Windows.Forms.TextBox textBoxEmployee3Entries;
        private System.Windows.Forms.Label labelEmployee1AverageOutput;
        private System.Windows.Forms.Label labelEmployee2AverageOutput;
        private System.Windows.Forms.Label labelEmployee3AverageOutput;
        private System.Windows.Forms.Label labelEmployee1;
        private System.Windows.Forms.Label labelEmployee2;
        private System.Windows.Forms.Label labelEmployee3;
    }
}

