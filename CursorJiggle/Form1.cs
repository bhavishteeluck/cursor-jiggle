using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursorJiggle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeUIElements();
        }

        private void checkBoxInfiniteRepeat_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownRepeatCount.Enabled = !checkBoxInfiniteRepeat.Checked;
            // if infinite repeat checkbox is checked, then disable the repeat numeric-up-down
        }

        private async void buttonToggleTimer_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                // Then cancel the async operation
                backgroundWorker1.CancelAsync();
                updateUIElements(enable: true);
                buttonToggleTimer.Text = "Start";
            }
            else
            {
                updateUIElements(enable: false);
                buttonToggleTimer.Text = "Cancel";
                progressBarInterval.Value = 0;
                progressBarRepeat.Value = 0;

                CursorJiggleData cursorJiggleData = new CursorJiggleData();
                int maxIntervalValue = (int)numericUpDownInterval.Value;
                int maxRepeatValue = (int)numericUpDownRepeatCount.Value;

                cursorJiggleData.currentInterval = 0;
                cursorJiggleData.maxIntervalValue = maxIntervalValue;
                cursorJiggleData.currentRepeatCount = 0;
                cursorJiggleData.maxRepeatValue = maxRepeatValue;
                cursorJiggleData.repeatProgress = 0;
                cursorJiggleData.isInfiniteRepeat = checkBoxInfiniteRepeat.Checked;

                backgroundWorker1.RunWorkerAsync(argument: cursorJiggleData); //start background worker
            }
        }
        void updateUIElements(bool enable)
        {
            if (enable)
            {
                numericUpDownInterval.Enabled = true;

                if (checkBoxInfiniteRepeat.Checked)
                {
                    numericUpDownRepeatCount.Enabled = false;
                }
                else
                {
                    numericUpDownRepeatCount.Enabled = true;
                }
                checkBoxInfiniteRepeat.Enabled = true;
            }
            else
            {
                numericUpDownInterval.Enabled = false;
                numericUpDownRepeatCount.Enabled = false;
                checkBoxInfiniteRepeat.Enabled = false;
            }
        }

        void initializeUIElements()
        {
            numericUpDownInterval.Enabled = true;
            numericUpDownInterval.Value = 1;
            numericUpDownRepeatCount.Enabled = true;
            numericUpDownRepeatCount.Value = 0;
            labelProgressTextInterval.Text = "";
            labelProgressTextRepeat.Text = "";
        }

        public String convertSecondsToReadableFormat(int value)
        {
            String returnValue = "";

            if (value < 60)
            {
                returnValue = value.ToString();
                if (value == 1)
                {
                    returnValue += " second";
                }
                else
                {
                    returnValue += " seconds";
                }
            }
            else
            {
                returnValue = (value / 60).ToString();
                if (value == 60)
                {
                    returnValue += " minute";
                }
                else
                {
                    returnValue += " minutes";
                }
            }

            return returnValue;
        }
        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker1 = sender as BackgroundWorker;
            CursorJiggleData cursorJiggleData = (CursorJiggleData) e.Argument;
            int currentInterval;
            int maxIntervalValue = cursorJiggleData.maxIntervalValue;
            int intervalProgress;
            int currentRepeatCount = cursorJiggleData.currentRepeatCount;
            int maxRepeatValue = cursorJiggleData.maxRepeatValue;
            int repeatProgress = cursorJiggleData.repeatProgress;

            bool isInfiniteRepeat = checkBoxInfiniteRepeat.Checked;


            while (currentRepeatCount <= maxRepeatValue)
            {
                currentInterval = 0;
                cursorJiggleData.currentInterval = 0;
                intervalProgress = 0;
                worker1.ReportProgress(percentProgress: intervalProgress, userState: cursorJiggleData);

                for (currentInterval = 1; currentInterval <= maxIntervalValue; currentInterval++)
                {
                    // Check if backgroundWorker was cancelled
                    if (worker1.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    System.Threading.Thread.Sleep(500);
                    if (worker1.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    System.Threading.Thread.Sleep(500);
                    //
                    cursorJiggleData.currentInterval = currentInterval;
                    intervalProgress = getPercentage(currentInterval, maxIntervalValue);

                    repeatProgress = getPercentage(currentRepeatCount, maxRepeatValue);
                    cursorJiggleData.currentRepeatCount = currentRepeatCount;
                    cursorJiggleData.repeatProgress = repeatProgress;
                    cursorJiggleData.maxRepeatValue = maxRepeatValue;
                    worker1.ReportProgress(percentProgress: intervalProgress, userState: cursorJiggleData);

                }
                if (worker1.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                //move the mouse cursor
                System.Threading.Thread.Sleep(500);
                Cursor.Position = new Point(Cursor.Position.X + 10, Cursor.Position.Y - 10);
                System.Threading.Thread.Sleep(100);
                Cursor.Position = new Point(Cursor.Position.X - 10, Cursor.Position.Y + 10);
                System.Threading.Thread.Sleep(500);

                if (!isInfiniteRepeat)
                {
                    // If infiniteRepeat is true, then don't increment the currentRepeatCount so that the loop never reaches its exit condition.
                    // else if it is false, continue to increment currentRepeatCount
                    currentRepeatCount++;
                }
            }
            
        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CursorJiggleData cursorJiggleData = (CursorJiggleData)e.UserState;
            int currentInterval = cursorJiggleData.currentInterval;
            int maxIntervalValue = cursorJiggleData.maxIntervalValue;
            int intervalProgress = e.ProgressPercentage;

            int currentRepeatCount = cursorJiggleData.currentRepeatCount;
            int maxRepeatValue = cursorJiggleData.maxRepeatValue;
            int repeatProgress = cursorJiggleData.repeatProgress;
            bool isInfiniteRepeat = cursorJiggleData.isInfiniteRepeat;

            if (isInfiniteRepeat)
            {
                progressBarRepeat.Value = 100;
                labelProgressTextRepeat.Text = "Infinite Repeat";
            }
            else if (maxRepeatValue == 0)
            {
                progressBarRepeat.Value = 0;
                labelProgressTextRepeat.Text = "No Repeat";
            }
            else
            {
                progressBarRepeat.Value = repeatProgress;
                labelProgressTextRepeat.Text = $"Repeat: {currentRepeatCount}/{maxRepeatValue} | ({repeatProgress})%";
            }
            progressBarInterval.Value = intervalProgress;
            labelProgressTextInterval.Text = $"Interval Count: {currentInterval}/{maxIntervalValue} | ({intervalProgress})%";
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                progressBarInterval.Value = 0;
                labelProgressTextInterval.Text = "";
                progressBarRepeat.Value = 0;
                labelProgressTextRepeat.Text = "";
            }
            updateUIElements(enable: true);
            buttonToggleTimer.Text = "Start";
        }

        public class CursorJiggleData
        {
            public int currentInterval { get; set; }
            public int maxIntervalValue { get; set; }
            public int currentRepeatCount { get; set; }
            public int maxRepeatValue { get; set; }
            public int repeatProgress { get; set; }
            public bool isInfiniteRepeat { get; set; }
        }
        int getPercentage(int currentValue, int maxValue)
        {
            int returnValue = (int)(((float)currentValue / maxValue) * 100);
            return returnValue;
        }
    }
}
