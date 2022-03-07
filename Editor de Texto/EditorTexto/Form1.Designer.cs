﻿

namespace EditorTexto
{
    partial class EditText
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditText));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameFilePath = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.Opciones = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ContentButtons = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.InputSearchRich = new System.Windows.Forms.TextBox();
            this.Words = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.NumberFont = new System.Windows.Forms.ComboBox();
            this.Fonts_load = new System.Windows.Forms.ComboBox();
            this.Underline = new System.Windows.Forms.Button();
            this.Cursive = new System.Windows.Forms.Button();
            this.Bold = new System.Windows.Forms.Button();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.TextContent = new System.Windows.Forms.RichTextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.Opciones.SuspendLayout();
            this.ContentButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.NameFilePath);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.toolStripContainer1);
            this.panel1.Controls.Add(this.Opciones);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 40);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFormMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveFormMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveFormMouseUp);
            // 
            // NameFilePath
            // 
            this.NameFilePath.AutoSize = true;
            this.NameFilePath.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameFilePath.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameFilePath.Location = new System.Drawing.Point(164, 13);
            this.NameFilePath.Name = "NameFilePath";
            this.NameFilePath.Size = new System.Drawing.Size(0, 16);
            this.NameFilePath.TabIndex = 13;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(968, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 30);
            this.button10.TabIndex = 12;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.buttMimizedBtnClick);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(1000, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(115, 29);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // Opciones
            // 
            this.Opciones.AutoSize = false;
            this.Opciones.BackColor = System.Drawing.Color.Transparent;
            this.Opciones.Dock = System.Windows.Forms.DockStyle.None;
            this.Opciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Opciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem});
            this.Opciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.Opciones.Location = new System.Drawing.Point(14, 9);
            this.Opciones.Name = "Opciones";
            this.Opciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Opciones.Size = new System.Drawing.Size(251, 21);
            this.Opciones.TabIndex = 0;
            this.Opciones.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.SaveFileBtn);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.OpenFileSubMenuBtn);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.ExitAppSubMenu);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem,
            this.ViewToolStripMenuItem});
            this.edicionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.PrintDocument);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ViewToolStripMenuItem.Text = "Vista Previa";
            this.ViewToolStripMenuItem.Click += new System.EventHandler(this.ViewPrintDocument);
            // 
            // ContentButtons
            // 
            this.ContentButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContentButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ContentButtons.Controls.Add(this.label2);
            this.ContentButtons.Controls.Add(this.InputSearchRich);
            this.ContentButtons.Controls.Add(this.Words);
            this.ContentButtons.Controls.Add(this.label1);
            this.ContentButtons.Controls.Add(this.Paste);
            this.ContentButtons.Controls.Add(this.Copy);
            this.ContentButtons.Controls.Add(this.NumberFont);
            this.ContentButtons.Controls.Add(this.Fonts_load);
            this.ContentButtons.Controls.Add(this.Underline);
            this.ContentButtons.Controls.Add(this.Cursive);
            this.ContentButtons.Controls.Add(this.Bold);
            this.ContentButtons.Location = new System.Drawing.Point(0, 40);
            this.ContentButtons.Name = "ContentButtons";
            this.ContentButtons.Size = new System.Drawing.Size(1037, 50);
            this.ContentButtons.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(183)))));
            this.label2.Location = new System.Drawing.Point(769, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Buscar";
            // 
            // InputSearchRich
            // 
            this.InputSearchRich.BackColor = System.Drawing.Color.White;
            this.InputSearchRich.Location = new System.Drawing.Point(825, 17);
            this.InputSearchRich.Margin = new System.Windows.Forms.Padding(20);
            this.InputSearchRich.Name = "InputSearchRich";
            this.InputSearchRich.ShortcutsEnabled = false;
            this.InputSearchRich.Size = new System.Drawing.Size(173, 20);
            this.InputSearchRich.TabIndex = 18;
            this.InputSearchRich.WordWrap = false;
            this.InputSearchRich.TextChanged += new System.EventHandler(this.InputSearchRich_TextChanged);
            this.InputSearchRich.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchWords);
            // 
            // Words
            // 
            this.Words.AutoSize = true;
            this.Words.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Words.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(183)))));
            this.Words.Location = new System.Drawing.Point(608, 19);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(14, 16);
            this.Words.TabIndex = 17;
            this.Words.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(491, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = " Palabras escritas";
            // 
            // Paste
            // 
            this.Paste.BackColor = System.Drawing.Color.Transparent;
            this.Paste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Paste.BackgroundImage")));
            this.Paste.FlatAppearance.BorderSize = 0;
            this.Paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paste.Location = new System.Drawing.Point(434, 8);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(30, 30);
            this.Paste.TabIndex = 15;
            this.Paste.UseVisualStyleBackColor = false;
            this.Paste.Click += new System.EventHandler(this.PasteTextBtn);
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.Color.Transparent;
            this.Copy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Copy.BackgroundImage")));
            this.Copy.FlatAppearance.BorderSize = 0;
            this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy.Location = new System.Drawing.Point(389, 8);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(30, 30);
            this.Copy.TabIndex = 14;
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.CopyTextBtn);
            // 
            // NumberFont
            // 
            this.NumberFont.FormattingEnabled = true;
            this.NumberFont.Location = new System.Drawing.Point(315, 14);
            this.NumberFont.Name = "NumberFont";
            this.NumberFont.Size = new System.Drawing.Size(46, 21);
            this.NumberFont.TabIndex = 5;
            this.NumberFont.SelectedIndexChanged += new System.EventHandler(this.SelectedNumberFontCombobox);
            // 
            // Fonts_load
            // 
            this.Fonts_load.FormattingEnabled = true;
            this.Fonts_load.Location = new System.Drawing.Point(143, 14);
            this.Fonts_load.Name = "Fonts_load";
            this.Fonts_load.Size = new System.Drawing.Size(163, 21);
            this.Fonts_load.TabIndex = 4;
            this.Fonts_load.SelectedIndexChanged += new System.EventHandler(this.SelectTypeFontCombobox);
            // 
            // Underline
            // 
            this.Underline.BackColor = System.Drawing.Color.Transparent;
            this.Underline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Underline.BackgroundImage")));
            this.Underline.FlatAppearance.BorderSize = 0;
            this.Underline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Underline.Location = new System.Drawing.Point(71, 8);
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(30, 30);
            this.Underline.TabIndex = 2;
            this.Underline.UseVisualStyleBackColor = false;
            this.Underline.Click += new System.EventHandler(this.TextUnderlineEvent);
            // 
            // Cursive
            // 
            this.Cursive.BackColor = System.Drawing.Color.Transparent;
            this.Cursive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cursive.BackgroundImage")));
            this.Cursive.FlatAppearance.BorderSize = 0;
            this.Cursive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cursive.Location = new System.Drawing.Point(39, 8);
            this.Cursive.Name = "Cursive";
            this.Cursive.Size = new System.Drawing.Size(30, 30);
            this.Cursive.TabIndex = 1;
            this.Cursive.UseVisualStyleBackColor = false;
            this.Cursive.Click += new System.EventHandler(this.TextCursiveEvent);
            // 
            // Bold
            // 
            this.Bold.BackColor = System.Drawing.Color.Transparent;
            this.Bold.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bold.BackgroundImage")));
            this.Bold.FlatAppearance.BorderSize = 0;
            this.Bold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bold.Location = new System.Drawing.Point(8, 8);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(30, 30);
            this.Bold.TabIndex = 0;
            this.Bold.UseVisualStyleBackColor = false;
            this.Bold.Click += new System.EventHandler(this.TextBEvent);
            // 
            // OpenDialog
            // 
            this.OpenDialog.FileName = "OpenFile";
            this.OpenDialog.Filter = "Rich Text Format  (*.rtf)|*.rtf";
            this.OpenDialog.InitialDirectory = "C:\\\\";
            // 
            // TextContent
            // 
            this.TextContent.BackColor = System.Drawing.Color.White;
            this.TextContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextContent.CausesValidation = false;
            this.TextContent.DetectUrls = false;
            this.TextContent.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextContent.ForeColor = System.Drawing.Color.Black;
            this.TextContent.HideSelection = false;
            this.TextContent.Location = new System.Drawing.Point(40, 102);
            this.TextContent.Name = "TextContent";
            this.TextContent.ShowSelectionMargin = true;
            this.TextContent.Size = new System.Drawing.Size(954, 328);
            this.TextContent.TabIndex = 0;
            this.TextContent.Text = "";
            this.TextContent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalWords);
            this.TextContent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TotalWordsKeyUp);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Print_Document);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1035, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EditText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1035, 456);
            this.Controls.Add(this.ContentButtons);
            this.Controls.Add(this.TextContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditText";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.Opciones.ResumeLayout(false);
            this.Opciones.PerformLayout();
            this.ContentButtons.ResumeLayout(false);
            this.ContentButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip Opciones;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel ContentButtons;
        private System.Windows.Forms.Button Bold;
        private System.Windows.Forms.Button Underline;
        private System.Windows.Forms.Button Cursive;
        private System.Windows.Forms.ComboBox NumberFont;
        private System.Windows.Forms.ComboBox Fonts_load;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label Words;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Label NameFilePath;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.RichTextBox TextContent;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox InputSearchRich;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
    }
}

