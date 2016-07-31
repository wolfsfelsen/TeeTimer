namespace TeeTimer
{
    partial class TeeTimer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeeTimer));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tbZiehzeit = new System.Windows.Forms.TextBox();
            this.cbFilterLieferant = new System.Windows.Forms.ComboBox();
            this.cbFilterSorte = new System.Windows.Forms.ComboBox();
            this.lblFilterLieferant = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblFilterSorte = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSuche = new System.Windows.Forms.Label();
            this.tbZiehzeitMax = new System.Windows.Forms.TextBox();
            this.tbZiehzeitMin = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.rtbInformationen = new System.Windows.Forms.RichTextBox();
            this.cbLieferant = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblZiehzeit = new System.Windows.Forms.Label();
            this.cbSorte = new System.Windows.Forms.ComboBox();
            this.splitter = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel1.Controls.Add(this.lblTimer);
            this.splitContainer.Panel1.Controls.Add(this.btnStart);
            this.splitContainer.Panel1.Controls.Add(this.tbZiehzeit);
            this.splitContainer.Panel1.Controls.Add(this.cbFilterLieferant);
            this.splitContainer.Panel1.Controls.Add(this.cbFilterSorte);
            this.splitContainer.Panel1.Controls.Add(this.lblFilterLieferant);
            this.splitContainer.Panel1.Controls.Add(this.lbl2);
            this.splitContainer.Panel1.Controls.Add(this.lbl1);
            this.splitContainer.Panel1.Controls.Add(this.lblFilterSorte);
            this.splitContainer.Panel1.Controls.Add(this.lblFilter);
            this.splitContainer.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer.Panel1.Controls.Add(this.lblSuche);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel2.Controls.Add(this.btnLoeschen);
            this.splitContainer.Panel2.Controls.Add(this.btnSpeichern);
            this.splitContainer.Panel2.Controls.Add(this.tbZiehzeitMax);
            this.splitContainer.Panel2.Controls.Add(this.tbZiehzeitMin);
            this.splitContainer.Panel2.Controls.Add(this.tbName);
            this.splitContainer.Panel2.Controls.Add(this.rtbInformationen);
            this.splitContainer.Panel2.Controls.Add(this.cbLieferant);
            this.splitContainer.Panel2.Controls.Add(this.lbl3);
            this.splitContainer.Panel2.Controls.Add(this.lblZiehzeit);
            this.splitContainer.Panel2.Controls.Add(this.cbSorte);
            // 
            // tbZiehzeit
            // 
            resources.ApplyResources(this.tbZiehzeit, "tbZiehzeit");
            this.tbZiehzeit.Name = "tbZiehzeit";
            // 
            // cbFilterLieferant
            // 
            this.cbFilterLieferant.FormattingEnabled = true;
            resources.ApplyResources(this.cbFilterLieferant, "cbFilterLieferant");
            this.cbFilterLieferant.Name = "cbFilterLieferant";
            // 
            // cbFilterSorte
            // 
            this.cbFilterSorte.FormattingEnabled = true;
            resources.ApplyResources(this.cbFilterSorte, "cbFilterSorte");
            this.cbFilterSorte.Name = "cbFilterSorte";
            // 
            // lblFilterLieferant
            // 
            resources.ApplyResources(this.lblFilterLieferant, "lblFilterLieferant");
            this.lblFilterLieferant.Name = "lblFilterLieferant";
            // 
            // lbl2
            // 
            resources.ApplyResources(this.lbl2, "lbl2");
            this.lbl2.Name = "lbl2";
            // 
            // lbl1
            // 
            resources.ApplyResources(this.lbl1, "lbl1");
            this.lbl1.Name = "lbl1";
            // 
            // lblFilterSorte
            // 
            resources.ApplyResources(this.lblFilterSorte, "lblFilterSorte");
            this.lblFilterSorte.Name = "lblFilterSorte";
            // 
            // lblFilter
            // 
            resources.ApplyResources(this.lblFilter, "lblFilter");
            this.lblFilter.Name = "lblFilter";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // lblSuche
            // 
            resources.ApplyResources(this.lblSuche, "lblSuche");
            this.lblSuche.Name = "lblSuche";
            // 
            // tbZiehzeitMax
            // 
            resources.ApplyResources(this.tbZiehzeitMax, "tbZiehzeitMax");
            this.tbZiehzeitMax.Name = "tbZiehzeitMax";
            // 
            // tbZiehzeitMin
            // 
            resources.ApplyResources(this.tbZiehzeitMin, "tbZiehzeitMin");
            this.tbZiehzeitMin.Name = "tbZiehzeitMin";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // rtbInformationen
            // 
            resources.ApplyResources(this.rtbInformationen, "rtbInformationen");
            this.rtbInformationen.BackColor = System.Drawing.SystemColors.Window;
            this.rtbInformationen.Name = "rtbInformationen";
            // 
            // cbLieferant
            // 
            this.cbLieferant.FormattingEnabled = true;
            resources.ApplyResources(this.cbLieferant, "cbLieferant");
            this.cbLieferant.Name = "cbLieferant";
            // 
            // lbl3
            // 
            resources.ApplyResources(this.lbl3, "lbl3");
            this.lbl3.Name = "lbl3";
            // 
            // lblZiehzeit
            // 
            resources.ApplyResources(this.lblZiehzeit, "lblZiehzeit");
            this.lblZiehzeit.Name = "lblZiehzeit";
            // 
            // cbSorte
            // 
            this.cbSorte.FormattingEnabled = true;
            resources.ApplyResources(this.cbSorte, "cbSorte");
            this.cbSorte.Name = "cbSorte";
            // 
            // splitter
            // 
            resources.ApplyResources(this.splitter, "splitter");
            this.splitter.Name = "splitter";
            this.splitter.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Name = "lblStatus";
            resources.ApplyResources(this.lblStatus, "lblStatus");
            // 
            // btnSpeichern
            // 
            resources.ApplyResources(this.btnSpeichern, "btnSpeichern");
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            // 
            // btnLoeschen
            // 
            resources.ApplyResources(this.btnLoeschen, "btnLoeschen");
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            resources.ApplyResources(this.lblTimer, "lblTimer");
            this.lblTimer.Name = "lblTimer";
            // 
            // TeeTimer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.splitter);
            this.Name = "TeeTimer";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.TeeTimer_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lblSuche;
        private System.Windows.Forms.ComboBox cbFilterLieferant;
        private System.Windows.Forms.ComboBox cbFilterSorte;
        private System.Windows.Forms.Label lblFilterLieferant;
        private System.Windows.Forms.Label lblFilterSorte;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox rtbInformationen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox tbZiehzeitMin;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbLieferant;
        private System.Windows.Forms.Label lblZiehzeit;
        private System.Windows.Forms.ComboBox cbSorte;
        private System.Windows.Forms.TextBox tbZiehzeit;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox tbZiehzeitMax;
        private System.Windows.Forms.Label lbl3;
        public System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnStart;
    }
}

