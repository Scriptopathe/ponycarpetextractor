namespace InteractiveInterpreter
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_bottomPanel = new System.Windows.Forms.Panel();
            this.m_codeTextbox = new ICSharpCode.TextEditor.TextEditorControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_exeButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.m_tabControl = new System.Windows.Forms.TabControl();
            this.m_statusTabPage = new System.Windows.Forms.TabPage();
            this.m_statusList = new System.Windows.Forms.ListView();
            this.m_variableColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_valuesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_typeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_consolePage = new System.Windows.Forms.TabPage();
            this.m_consoleTextbox = new System.Windows.Forms.TextBox();
            this.m_errorsPage = new System.Windows.Forms.TabPage();
            this.m_errorsTextbox = new System.Windows.Forms.TextBox();
            this.m_bottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.m_tabControl.SuspendLayout();
            this.m_statusTabPage.SuspendLayout();
            this.m_consolePage.SuspendLayout();
            this.m_errorsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_bottomPanel
            // 
            this.m_bottomPanel.Controls.Add(this.m_codeTextbox);
            this.m_bottomPanel.Controls.Add(this.panel1);
            this.m_bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_bottomPanel.Location = new System.Drawing.Point(0, 0);
            this.m_bottomPanel.Name = "m_bottomPanel";
            this.m_bottomPanel.Size = new System.Drawing.Size(591, 273);
            this.m_bottomPanel.TabIndex = 0;
            // 
            // m_codeTextbox
            // 
            this.m_codeTextbox.ConvertTabsToSpaces = true;
            this.m_codeTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_codeTextbox.IsReadOnly = false;
            this.m_codeTextbox.Location = new System.Drawing.Point(0, 0);
            this.m_codeTextbox.Name = "m_codeTextbox";
            this.m_codeTextbox.Size = new System.Drawing.Size(591, 249);
            this.m_codeTextbox.TabIndex = 0;
            this.m_codeTextbox.Text = resources.GetString("m_codeTextbox.Text");
            this.m_codeTextbox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_exeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 24);
            this.panel1.TabIndex = 2;
            // 
            // m_exeButton
            // 
            this.m_exeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_exeButton.Location = new System.Drawing.Point(516, 0);
            this.m_exeButton.MaximumSize = new System.Drawing.Size(80, 22);
            this.m_exeButton.Name = "m_exeButton";
            this.m_exeButton.Size = new System.Drawing.Size(75, 22);
            this.m_exeButton.TabIndex = 1;
            this.m_exeButton.Text = "Exécuter";
            this.m_exeButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.m_tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.m_bottomPanel);
            this.splitContainer1.Size = new System.Drawing.Size(591, 472);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 2;
            // 
            // m_tabControl
            // 
            this.m_tabControl.Controls.Add(this.m_statusTabPage);
            this.m_tabControl.Controls.Add(this.m_consolePage);
            this.m_tabControl.Controls.Add(this.m_errorsPage);
            this.m_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tabControl.Location = new System.Drawing.Point(0, 0);
            this.m_tabControl.Name = "m_tabControl";
            this.m_tabControl.SelectedIndex = 0;
            this.m_tabControl.Size = new System.Drawing.Size(591, 195);
            this.m_tabControl.TabIndex = 0;
            // 
            // m_statusTabPage
            // 
            this.m_statusTabPage.Controls.Add(this.m_statusList);
            this.m_statusTabPage.Location = new System.Drawing.Point(4, 22);
            this.m_statusTabPage.Name = "m_statusTabPage";
            this.m_statusTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.m_statusTabPage.Size = new System.Drawing.Size(583, 169);
            this.m_statusTabPage.TabIndex = 0;
            this.m_statusTabPage.Text = "Status";
            this.m_statusTabPage.UseVisualStyleBackColor = true;
            // 
            // m_statusList
            // 
            this.m_statusList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.m_variableColumn,
            this.m_valuesHeader,
            this.m_typeHeader});
            this.m_statusList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_statusList.FullRowSelect = true;
            this.m_statusList.GridLines = true;
            this.m_statusList.Location = new System.Drawing.Point(3, 3);
            this.m_statusList.Name = "m_statusList";
            this.m_statusList.Size = new System.Drawing.Size(577, 163);
            this.m_statusList.TabIndex = 0;
            this.m_statusList.UseCompatibleStateImageBehavior = false;
            this.m_statusList.View = System.Windows.Forms.View.Details;
            // 
            // m_variableColumn
            // 
            this.m_variableColumn.Text = "Variables";
            this.m_variableColumn.Width = 140;
            // 
            // m_valuesHeader
            // 
            this.m_valuesHeader.Text = "Values";
            this.m_valuesHeader.Width = 274;
            // 
            // m_typeHeader
            // 
            this.m_typeHeader.Text = "Types";
            this.m_typeHeader.Width = 157;
            // 
            // m_consolePage
            // 
            this.m_consolePage.Controls.Add(this.m_consoleTextbox);
            this.m_consolePage.Location = new System.Drawing.Point(4, 22);
            this.m_consolePage.Name = "m_consolePage";
            this.m_consolePage.Padding = new System.Windows.Forms.Padding(3);
            this.m_consolePage.Size = new System.Drawing.Size(583, 169);
            this.m_consolePage.TabIndex = 1;
            this.m_consolePage.Text = "Console";
            this.m_consolePage.UseVisualStyleBackColor = true;
            // 
            // m_consoleTextbox
            // 
            this.m_consoleTextbox.AcceptsReturn = true;
            this.m_consoleTextbox.AcceptsTab = true;
            this.m_consoleTextbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_consoleTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_consoleTextbox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_consoleTextbox.ForeColor = System.Drawing.Color.Lime;
            this.m_consoleTextbox.Location = new System.Drawing.Point(3, 3);
            this.m_consoleTextbox.Multiline = true;
            this.m_consoleTextbox.Name = "m_consoleTextbox";
            this.m_consoleTextbox.ReadOnly = true;
            this.m_consoleTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_consoleTextbox.Size = new System.Drawing.Size(577, 163);
            this.m_consoleTextbox.TabIndex = 0;
            // 
            // m_errorsPage
            // 
            this.m_errorsPage.Controls.Add(this.m_errorsTextbox);
            this.m_errorsPage.Location = new System.Drawing.Point(4, 22);
            this.m_errorsPage.Name = "m_errorsPage";
            this.m_errorsPage.Padding = new System.Windows.Forms.Padding(3);
            this.m_errorsPage.Size = new System.Drawing.Size(583, 169);
            this.m_errorsPage.TabIndex = 2;
            this.m_errorsPage.Text = "Errors";
            this.m_errorsPage.UseVisualStyleBackColor = true;
            // 
            // m_errorsTextbox
            // 
            this.m_errorsTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_errorsTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_errorsTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.m_errorsTextbox.Location = new System.Drawing.Point(3, 3);
            this.m_errorsTextbox.Multiline = true;
            this.m_errorsTextbox.Name = "m_errorsTextbox";
            this.m_errorsTextbox.ReadOnly = true;
            this.m_errorsTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_errorsTextbox.Size = new System.Drawing.Size(577, 163);
            this.m_errorsTextbox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 482);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Pony Carpet Extractor";
            this.m_bottomPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.m_tabControl.ResumeLayout(false);
            this.m_statusTabPage.ResumeLayout(false);
            this.m_consolePage.ResumeLayout(false);
            this.m_consolePage.PerformLayout();
            this.m_errorsPage.ResumeLayout(false);
            this.m_errorsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_bottomPanel;
        private System.Windows.Forms.Button m_exeButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private ICSharpCode.TextEditor.TextEditorControl m_codeTextbox;
        private System.Windows.Forms.TabControl m_tabControl;
        private System.Windows.Forms.TabPage m_statusTabPage;
        private System.Windows.Forms.ListView m_statusList;
        private System.Windows.Forms.ColumnHeader m_variableColumn;
        private System.Windows.Forms.ColumnHeader m_valuesHeader;
        private System.Windows.Forms.ColumnHeader m_typeHeader;
        private System.Windows.Forms.TabPage m_consolePage;
        private System.Windows.Forms.TextBox m_consoleTextbox;
        private System.Windows.Forms.TabPage m_errorsPage;
        private System.Windows.Forms.TextBox m_errorsTextbox;
    }
}

