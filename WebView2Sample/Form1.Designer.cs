namespace WebView2Sample
{
    partial class Form1
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBorderMain = new System.Windows.Forms.Panel();
            this.wvMain = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.lblUrl = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.pnlBorderPopup = new System.Windows.Forms.Panel();
            this.lblMainStatus = new System.Windows.Forms.Label();
            this.lblPopupStatus = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.pnlBorderMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 13;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpMain.Controls.Add(this.pnlBorderMain, 1, 5);
            this.tlpMain.Controls.Add(this.lblUrl, 1, 1);
            this.tlpMain.Controls.Add(this.tbUrl, 3, 1);
            this.tlpMain.Controls.Add(this.btnGo, 5, 1);
            this.tlpMain.Controls.Add(this.pnlBorderPopup, 7, 5);
            this.tlpMain.Controls.Add(this.lblMainStatus, 1, 3);
            this.tlpMain.Controls.Add(this.lblPopupStatus, 7, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 6;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1607, 1035);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlBorderMain
            // 
            this.pnlBorderMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBorderMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tlpMain.SetColumnSpan(this.pnlBorderMain, 5);
            this.pnlBorderMain.Controls.Add(this.wvMain);
            this.pnlBorderMain.Location = new System.Drawing.Point(11, 132);
            this.pnlBorderMain.Name = "pnlBorderMain";
            this.pnlBorderMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBorderMain.Size = new System.Drawing.Size(777, 900);
            this.pnlBorderMain.TabIndex = 1;
            // 
            // wvMain
            // 
            this.wvMain.CreationProperties = null;
            this.wvMain.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvMain.Location = new System.Drawing.Point(10, 10);
            this.wvMain.Name = "wvMain";
            this.wvMain.Size = new System.Drawing.Size(757, 880);
            this.wvMain.TabIndex = 0;
            this.wvMain.ZoomFactor = 1D;
            // 
            // lblUrl
            // 
            this.lblUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrl.Location = new System.Drawing.Point(11, 15);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(54, 42);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "URL";
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(79, 18);
            this.tbUrl.MaxLength = 512;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(641, 31);
            this.tbUrl.TabIndex = 3;
            this.tbUrl.WordWrap = false;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(734, 18);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(54, 34);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // pnlBorderPopup
            // 
            this.pnlBorderPopup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBorderPopup.BackColor = System.Drawing.SystemColors.Info;
            this.tlpMain.SetColumnSpan(this.pnlBorderPopup, 5);
            this.pnlBorderPopup.Location = new System.Drawing.Point(818, 132);
            this.pnlBorderPopup.Name = "pnlBorderPopup";
            this.pnlBorderPopup.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBorderPopup.Size = new System.Drawing.Size(777, 900);
            this.pnlBorderPopup.TabIndex = 5;
            // 
            // lblMainStatus
            // 
            this.lblMainStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.SetColumnSpan(this.lblMainStatus, 5);
            this.lblMainStatus.Location = new System.Drawing.Point(11, 72);
            this.lblMainStatus.Name = "lblMainStatus";
            this.lblMainStatus.Size = new System.Drawing.Size(777, 42);
            this.lblMainStatus.TabIndex = 6;
            this.lblMainStatus.Text = "Click \"GO\" to begin";
            // 
            // lblPopupStatus
            // 
            this.lblPopupStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.SetColumnSpan(this.lblPopupStatus, 5);
            this.lblPopupStatus.Location = new System.Drawing.Point(818, 72);
            this.lblPopupStatus.Name = "lblPopupStatus";
            this.lblPopupStatus.Size = new System.Drawing.Size(777, 42);
            this.lblPopupStatus.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 1035);
            this.Controls.Add(this.tlpMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.pnlBorderMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel pnlBorderMain;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvMain;
        private Label lblUrl;
        private TextBox tbUrl;
        private Button btnGo;
        private Panel pnlBorderPopup;
        private Label lblMainStatus;
        private Label lblPopupStatus;
    }
}