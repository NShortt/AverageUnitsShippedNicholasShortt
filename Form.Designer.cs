
namespace AverageUnitsShippedNicholasShortt
{
    partial class formAverageUnitsShipped
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
            this.textBoxPastEntries = new System.Windows.Forms.TextBox();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.Location = new System.Drawing.Point(93, 42);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(65, 35);
            this.labelUnitsPrompt.TabIndex = 0;
            this.labelUnitsPrompt.Text = "&Units:";
            // 
            // textBoxUnitsInput
            // 
            this.textBoxUnitsInput.Location = new System.Drawing.Point(164, 42);
            this.textBoxUnitsInput.Name = "textBoxUnitsInput";
            this.textBoxUnitsInput.Size = new System.Drawing.Size(81, 35);
            this.textBoxUnitsInput.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxUnitsInput, "Enter the units shipped for specified day.");
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(251, 42);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(84, 35);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day 1";
            // 
            // textBoxPastEntries
            // 
            this.textBoxPastEntries.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPastEntries.Location = new System.Drawing.Point(70, 93);
            this.textBoxPastEntries.Multiline = true;
            this.textBoxPastEntries.Name = "textBoxPastEntries";
            this.textBoxPastEntries.ReadOnly = true;
            this.textBoxPastEntries.Size = new System.Drawing.Size(290, 221);
            this.textBoxPastEntries.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxPastEntries, "Displays the units shipped for all days entered so far.");
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(70, 317);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(290, 38);
            this.labelAverageOutput.TabIndex = 4;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelAverageOutput, "Displays the calculated average units for the week.");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(12, 382);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(131, 40);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to process current units shipped");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(150, 382);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(131, 40);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset form and start new week of entry.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonEnterReset);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(285, 382);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(131, 40);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to close the application.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // formAverageUnitsShipped
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(428, 434);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.textBoxPastEntries);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxUnitsInput);
            this.Controls.Add(this.labelUnitsPrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAverageUnitsShipped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnitsPrompt;
        private System.Windows.Forms.TextBox textBoxUnitsInput;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxPastEntries;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

