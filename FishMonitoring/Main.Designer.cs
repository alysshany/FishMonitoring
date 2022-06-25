
namespace FishMonitoring
{
    partial class frmMain
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtBoxTempEd = new System.Windows.Forms.TextBox();
            this.txtBoxDateBeg = new System.Windows.Forms.TextBox();
            this.txtBoxMinTime = new System.Windows.Forms.TextBox();
            this.txtBoxMin = new System.Windows.Forms.TextBox();
            this.txtBoxMaxTime = new System.Windows.Forms.TextBox();
            this.txtBoxMaxTemp = new System.Windows.Forms.TextBox();
            this.lstBoxMain = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lstBoxFish = new System.Windows.Forms.ListBox();
            this.txtBoxRes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnOk);
            this.pnlMain.Controls.Add(this.btnOpen);
            this.pnlMain.Controls.Add(this.txtBoxTempEd);
            this.pnlMain.Controls.Add(this.txtBoxDateBeg);
            this.pnlMain.Controls.Add(this.txtBoxMinTime);
            this.pnlMain.Controls.Add(this.txtBoxMin);
            this.pnlMain.Controls.Add(this.txtBoxMaxTime);
            this.pnlMain.Controls.Add(this.txtBoxMaxTemp);
            this.pnlMain.Controls.Add(this.lstBoxMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMain.Location = new System.Drawing.Point(495, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(305, 450);
            this.pnlMain.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(181, 364);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(181, 409);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 29);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // txtBoxTempEd
            // 
            this.txtBoxTempEd.Location = new System.Drawing.Point(46, 305);
            this.txtBoxTempEd.Name = "txtBoxTempEd";
            this.txtBoxTempEd.Size = new System.Drawing.Size(205, 27);
            this.txtBoxTempEd.TabIndex = 6;
            // 
            // txtBoxDateBeg
            // 
            this.txtBoxDateBeg.Location = new System.Drawing.Point(46, 271);
            this.txtBoxDateBeg.Name = "txtBoxDateBeg";
            this.txtBoxDateBeg.Size = new System.Drawing.Size(205, 27);
            this.txtBoxDateBeg.TabIndex = 5;
            // 
            // txtBoxMinTime
            // 
            this.txtBoxMinTime.Location = new System.Drawing.Point(157, 158);
            this.txtBoxMinTime.Name = "txtBoxMinTime";
            this.txtBoxMinTime.ReadOnly = true;
            this.txtBoxMinTime.Size = new System.Drawing.Size(94, 27);
            this.txtBoxMinTime.TabIndex = 4;
            // 
            // txtBoxMin
            // 
            this.txtBoxMin.Location = new System.Drawing.Point(46, 158);
            this.txtBoxMin.Name = "txtBoxMin";
            this.txtBoxMin.ReadOnly = true;
            this.txtBoxMin.Size = new System.Drawing.Size(94, 27);
            this.txtBoxMin.TabIndex = 3;
            // 
            // txtBoxMaxTime
            // 
            this.txtBoxMaxTime.Location = new System.Drawing.Point(157, 114);
            this.txtBoxMaxTime.Name = "txtBoxMaxTime";
            this.txtBoxMaxTime.ReadOnly = true;
            this.txtBoxMaxTime.Size = new System.Drawing.Size(94, 27);
            this.txtBoxMaxTime.TabIndex = 2;
            // 
            // txtBoxMaxTemp
            // 
            this.txtBoxMaxTemp.Location = new System.Drawing.Point(46, 114);
            this.txtBoxMaxTemp.Name = "txtBoxMaxTemp";
            this.txtBoxMaxTemp.ReadOnly = true;
            this.txtBoxMaxTemp.Size = new System.Drawing.Size(94, 27);
            this.txtBoxMaxTemp.TabIndex = 1;
            // 
            // lstBoxMain
            // 
            this.lstBoxMain.FormattingEnabled = true;
            this.lstBoxMain.ItemHeight = 20;
            this.lstBoxMain.Items.AddRange(new object[] {
            "Salmon",
            "Pollack"});
            this.lstBoxMain.Location = new System.Drawing.Point(33, 28);
            this.lstBoxMain.Name = "lstBoxMain";
            this.lstBoxMain.Size = new System.Drawing.Size(242, 44);
            this.lstBoxMain.TabIndex = 0;
            this.lstBoxMain.SelectedIndexChanged += new System.EventHandler(this.LstBoxMain_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lstBoxFish
            // 
            this.lstBoxFish.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstBoxFish.FormattingEnabled = true;
            this.lstBoxFish.ItemHeight = 20;
            this.lstBoxFish.Location = new System.Drawing.Point(0, 86);
            this.lstBoxFish.Name = "lstBoxFish";
            this.lstBoxFish.Size = new System.Drawing.Size(495, 364);
            this.lstBoxFish.TabIndex = 1;
            // 
            // txtBoxRes
            // 
            this.txtBoxRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBoxRes.Location = new System.Drawing.Point(0, 0);
            this.txtBoxRes.Name = "txtBoxRes";
            this.txtBoxRes.Size = new System.Drawing.Size(495, 27);
            this.txtBoxRes.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(68, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxRes);
            this.Controls.Add(this.lstBoxFish);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMain";
            this.Text = "Main";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListBox lstBoxMain;
        private System.Windows.Forms.TextBox txtBoxMaxTemp;
        private System.Windows.Forms.TextBox txtBoxMinTime;
        private System.Windows.Forms.TextBox txtBoxMin;
        private System.Windows.Forms.TextBox txtBoxMaxTime;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtBoxTempEd;
        private System.Windows.Forms.TextBox txtBoxDateBeg;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListBox lstBoxFish;
        private System.Windows.Forms.TextBox txtBoxRes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

