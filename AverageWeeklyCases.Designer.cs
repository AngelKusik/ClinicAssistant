
namespace ClinicAssistant
{
    partial class formAverageWeeklyCases
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
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelUnitsPrompt = new System.Windows.Forms.Label();
            this.textBoxPastEntriesRegion1 = new System.Windows.Forms.TextBox();
            this.textBoxCasesInput = new System.Windows.Forms.TextBox();
            this.labelGeneralAverageOutput = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxPastEntriesRegion2 = new System.Windows.Forms.TextBox();
            this.textBoxPastEntriesRegion3 = new System.Windows.Forms.TextBox();
            this.labelRegion1Output = new System.Windows.Forms.Label();
            this.labelRegion2Output = new System.Windows.Forms.Label();
            this.labelRegion3Output = new System.Windows.Forms.Label();
            this.labelRegion1 = new System.Windows.Forms.Label();
            this.labelRegion2 = new System.Windows.Forms.Label();
            this.labelRegion3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(176, 688);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(186, 40);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Click to calculate average units shipped.");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(390, 688);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(186, 40);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Click to reset application.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.AutoSize = true;
            this.labelUnitsPrompt.Location = new System.Drawing.Point(63, 33);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(71, 30);
            this.labelUnitsPrompt.TabIndex = 1;
            this.labelUnitsPrompt.Text = "&Cases:";
            // 
            // textBoxPastEntriesRegion1
            // 
            this.textBoxPastEntriesRegion1.Location = new System.Drawing.Point(90, 126);
            this.textBoxPastEntriesRegion1.Multiline = true;
            this.textBoxPastEntriesRegion1.Name = "textBoxPastEntriesRegion1";
            this.textBoxPastEntriesRegion1.ReadOnly = true;
            this.textBoxPastEntriesRegion1.Size = new System.Drawing.Size(166, 384);
            this.textBoxPastEntriesRegion1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBoxPastEntriesRegion1, "Displays region 1 units shipped entered..");
            // 
            // textBoxCasesInput
            // 
            this.textBoxCasesInput.Location = new System.Drawing.Point(140, 33);
            this.textBoxCasesInput.Name = "textBoxCasesInput";
            this.textBoxCasesInput.Size = new System.Drawing.Size(150, 35);
            this.textBoxCasesInput.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxCasesInput, "Enter today\'s units shipped for each region.");
            // 
            // labelGeneralAverageOutput
            // 
            this.labelGeneralAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGeneralAverageOutput.Location = new System.Drawing.Point(63, 616);
            this.labelGeneralAverageOutput.Name = "labelGeneralAverageOutput";
            this.labelGeneralAverageOutput.Size = new System.Drawing.Size(622, 45);
            this.labelGeneralAverageOutput.TabIndex = 12;
            this.labelGeneralAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelGeneralAverageOutput, "Displays total average units shipped considering all 3 regions.");
            // 
            // textBoxPastEntriesRegion2
            // 
            this.textBoxPastEntriesRegion2.Location = new System.Drawing.Point(294, 126);
            this.textBoxPastEntriesRegion2.Multiline = true;
            this.textBoxPastEntriesRegion2.Name = "textBoxPastEntriesRegion2";
            this.textBoxPastEntriesRegion2.ReadOnly = true;
            this.textBoxPastEntriesRegion2.Size = new System.Drawing.Size(166, 384);
            this.textBoxPastEntriesRegion2.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxPastEntriesRegion2, "Displays region 2 units shipped entered.");
            // 
            // textBoxPastEntriesRegion3
            // 
            this.textBoxPastEntriesRegion3.Location = new System.Drawing.Point(498, 126);
            this.textBoxPastEntriesRegion3.Multiline = true;
            this.textBoxPastEntriesRegion3.Name = "textBoxPastEntriesRegion3";
            this.textBoxPastEntriesRegion3.ReadOnly = true;
            this.textBoxPastEntriesRegion3.Size = new System.Drawing.Size(166, 384);
            this.textBoxPastEntriesRegion3.TabIndex = 8;
            this.toolTip1.SetToolTip(this.textBoxPastEntriesRegion3, "Displays region 3 units shipped entered.");
            // 
            // labelRegion1Output
            // 
            this.labelRegion1Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion1Output.Location = new System.Drawing.Point(63, 551);
            this.labelRegion1Output.Name = "labelRegion1Output";
            this.labelRegion1Output.Size = new System.Drawing.Size(205, 45);
            this.labelRegion1Output.TabIndex = 9;
            this.labelRegion1Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelRegion1Output, "Displays region 1 average units shipped.");
            // 
            // labelRegion2Output
            // 
            this.labelRegion2Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion2Output.Location = new System.Drawing.Point(274, 551);
            this.labelRegion2Output.Name = "labelRegion2Output";
            this.labelRegion2Output.Size = new System.Drawing.Size(205, 45);
            this.labelRegion2Output.TabIndex = 10;
            this.labelRegion2Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelRegion2Output, "Displays region 2 average units shipped.");
            // 
            // labelRegion3Output
            // 
            this.labelRegion3Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion3Output.Location = new System.Drawing.Point(485, 551);
            this.labelRegion3Output.Name = "labelRegion3Output";
            this.labelRegion3Output.Size = new System.Drawing.Size(200, 45);
            this.labelRegion3Output.TabIndex = 11;
            this.labelRegion3Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelRegion3Output, "Displays region 3 average units shipped.");
            // 
            // labelRegion1
            // 
            this.labelRegion1.AutoSize = true;
            this.labelRegion1.Location = new System.Drawing.Point(127, 84);
            this.labelRegion1.Name = "labelRegion1";
            this.labelRegion1.Size = new System.Drawing.Size(94, 30);
            this.labelRegion1.TabIndex = 3;
            this.labelRegion1.Text = "Region 1";
            // 
            // labelRegion2
            // 
            this.labelRegion2.AutoSize = true;
            this.labelRegion2.Location = new System.Drawing.Point(331, 84);
            this.labelRegion2.Name = "labelRegion2";
            this.labelRegion2.Size = new System.Drawing.Size(94, 30);
            this.labelRegion2.TabIndex = 4;
            this.labelRegion2.Text = "Region 2";
            // 
            // labelRegion3
            // 
            this.labelRegion3.AutoSize = true;
            this.labelRegion3.Location = new System.Drawing.Point(535, 84);
            this.labelRegion3.Name = "labelRegion3";
            this.labelRegion3.Size = new System.Drawing.Size(94, 30);
            this.labelRegion3.TabIndex = 5;
            this.labelRegion3.Text = "Region 3";
            // 
            // formAverageWeeklyCases
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(753, 765);
            this.Controls.Add(this.labelRegion3Output);
            this.Controls.Add(this.labelRegion2Output);
            this.Controls.Add(this.labelRegion1Output);
            this.Controls.Add(this.labelRegion3);
            this.Controls.Add(this.textBoxPastEntriesRegion3);
            this.Controls.Add(this.labelRegion2);
            this.Controls.Add(this.textBoxPastEntriesRegion2);
            this.Controls.Add(this.labelRegion1);
            this.Controls.Add(this.labelGeneralAverageOutput);
            this.Controls.Add(this.textBoxCasesInput);
            this.Controls.Add(this.textBoxPastEntriesRegion1);
            this.Controls.Add(this.labelUnitsPrompt);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAverageWeeklyCases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Cases";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelUnitsPrompt;
        private System.Windows.Forms.TextBox textBoxPastEntriesRegion1;
        private System.Windows.Forms.TextBox textBoxCasesInput;
        private System.Windows.Forms.Label labelGeneralAverageOutput;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelRegion1;
        private System.Windows.Forms.TextBox textBoxPastEntriesRegion2;
        private System.Windows.Forms.Label labelRegion2;
        private System.Windows.Forms.TextBox textBoxPastEntriesRegion3;
        private System.Windows.Forms.Label labelRegion3;
        private System.Windows.Forms.Label labelRegion1Output;
        private System.Windows.Forms.Label labelRegion2Output;
        private System.Windows.Forms.Label labelRegion3Output;
    }
}

