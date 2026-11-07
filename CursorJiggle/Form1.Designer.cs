namespace CursorJiggle
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
            this.buttonToggleTimer = new System.Windows.Forms.Button();
            this.progressBarInterval = new System.Windows.Forms.ProgressBar();
            this.numericUpDownRepeatCount = new System.Windows.Forms.NumericUpDown();
            this.labelRepeatCount = new System.Windows.Forms.Label();
            this.labelInterval = new System.Windows.Forms.Label();
            this.checkBoxInfiniteRepeat = new System.Windows.Forms.CheckBox();
            this.labelProgressTextInterval = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBarRepeat = new System.Windows.Forms.ProgressBar();
            this.labelProgressTextRepeat = new System.Windows.Forms.Label();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonToggleTimer
            // 
            this.buttonToggleTimer.Location = new System.Drawing.Point(120, 241);
            this.buttonToggleTimer.Name = "buttonToggleTimer";
            this.buttonToggleTimer.Size = new System.Drawing.Size(75, 23);
            this.buttonToggleTimer.TabIndex = 0;
            this.buttonToggleTimer.Text = "Start";
            this.buttonToggleTimer.UseVisualStyleBackColor = true;
            this.buttonToggleTimer.Click += new System.EventHandler(this.buttonToggleTimer_Click);
            // 
            // progressBarInterval
            // 
            this.progressBarInterval.Location = new System.Drawing.Point(24, 145);
            this.progressBarInterval.Name = "progressBarInterval";
            this.progressBarInterval.Size = new System.Drawing.Size(259, 20);
            this.progressBarInterval.TabIndex = 1;
            // 
            // numericUpDownRepeatCount
            // 
            this.numericUpDownRepeatCount.Location = new System.Drawing.Point(141, 76);
            this.numericUpDownRepeatCount.Name = "numericUpDownRepeatCount";
            this.numericUpDownRepeatCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRepeatCount.TabIndex = 2;
            // 
            // labelRepeatCount
            // 
            this.labelRepeatCount.AutoSize = true;
            this.labelRepeatCount.Location = new System.Drawing.Point(21, 79);
            this.labelRepeatCount.Name = "labelRepeatCount";
            this.labelRepeatCount.Size = new System.Drawing.Size(73, 13);
            this.labelRepeatCount.TabIndex = 3;
            this.labelRepeatCount.Text = "Repeat Count";
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(21, 52);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(102, 13);
            this.labelInterval.TabIndex = 4;
            this.labelInterval.Text = "Interval (in seconds)";
            // 
            // checkBoxInfiniteRepeat
            // 
            this.checkBoxInfiniteRepeat.AutoSize = true;
            this.checkBoxInfiniteRepeat.Location = new System.Drawing.Point(148, 103);
            this.checkBoxInfiniteRepeat.Name = "checkBoxInfiniteRepeat";
            this.checkBoxInfiniteRepeat.Size = new System.Drawing.Size(95, 17);
            this.checkBoxInfiniteRepeat.TabIndex = 6;
            this.checkBoxInfiniteRepeat.Text = "Infinite Repeat";
            this.checkBoxInfiniteRepeat.UseVisualStyleBackColor = true;
            this.checkBoxInfiniteRepeat.CheckedChanged += new System.EventHandler(this.checkBoxInfiniteRepeat_CheckedChanged);
            // 
            // labelProgressTextInterval
            // 
            this.labelProgressTextInterval.AutoSize = true;
            this.labelProgressTextInterval.Location = new System.Drawing.Point(21, 168);
            this.labelProgressTextInterval.Name = "labelProgressTextInterval";
            this.labelProgressTextInterval.Size = new System.Drawing.Size(103, 13);
            this.labelProgressTextInterval.TabIndex = 7;
            this.labelProgressTextInterval.Text = "intervalProgressText";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBarRepeat
            // 
            this.progressBarRepeat.Location = new System.Drawing.Point(24, 193);
            this.progressBarRepeat.Name = "progressBarRepeat";
            this.progressBarRepeat.Size = new System.Drawing.Size(259, 12);
            this.progressBarRepeat.TabIndex = 8;
            // 
            // labelProgressTextRepeat
            // 
            this.labelProgressTextRepeat.AutoSize = true;
            this.labelProgressTextRepeat.Location = new System.Drawing.Point(21, 208);
            this.labelProgressTextRepeat.Name = "labelProgressTextRepeat";
            this.labelProgressTextRepeat.Size = new System.Drawing.Size(99, 13);
            this.labelProgressTextRepeat.TabIndex = 9;
            this.labelProgressTextRepeat.Text = "repeatProgressText";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(141, 50);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownInterval.TabIndex = 10;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 285);
            this.Controls.Add(this.numericUpDownInterval);
            this.Controls.Add(this.labelProgressTextRepeat);
            this.Controls.Add(this.progressBarRepeat);
            this.Controls.Add(this.labelProgressTextInterval);
            this.Controls.Add(this.checkBoxInfiniteRepeat);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.labelRepeatCount);
            this.Controls.Add(this.numericUpDownRepeatCount);
            this.Controls.Add(this.progressBarInterval);
            this.Controls.Add(this.buttonToggleTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "CursorJiggle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToggleTimer;
        private System.Windows.Forms.NumericUpDown numericUpDownRepeatCount;
        private System.Windows.Forms.Label labelRepeatCount;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.ProgressBar progressBarInterval;
        private System.Windows.Forms.CheckBox checkBoxInfiniteRepeat;
        private System.Windows.Forms.Label labelProgressTextInterval;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBarRepeat;
        private System.Windows.Forms.Label labelProgressTextRepeat;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
    }
}

