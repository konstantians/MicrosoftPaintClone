
namespace MicrosoftPaintClone
{
    partial class mainForm
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
            this.paintMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeSubMenuPanel = new System.Windows.Forms.Panel();
            this.clipboardPanel = new System.Windows.Forms.Panel();
            this.cliboardPasteLabel = new System.Windows.Forms.Label();
            this.clipboardCopyLabel = new System.Windows.Forms.Label();
            this.clipboardCutLabel = new System.Windows.Forms.Label();
            this.clipboardLabel = new System.Windows.Forms.Label();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.toolsLabel = new System.Windows.Forms.Label();
            this.toolsMagnifierPictureBox = new System.Windows.Forms.PictureBox();
            this.toolsColorPickerPictureBox = new System.Windows.Forms.PictureBox();
            this.toolsEraserPictureBox = new System.Windows.Forms.PictureBox();
            this.toolsFillWithColorPictureBox = new System.Windows.Forms.PictureBox();
            this.toolsTextPictureBox = new System.Windows.Forms.PictureBox();
            this.toolsPencilPictureBox = new System.Windows.Forms.PictureBox();
            this.clipboardPastePicturebox = new System.Windows.Forms.PictureBox();
            this.clipboardCopyPicturebox = new System.Windows.Forms.PictureBox();
            this.clipboardCutPicturebox = new System.Windows.Forms.PictureBox();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paintMenuStrip.SuspendLayout();
            this.homeSubMenuPanel.SuspendLayout();
            this.clipboardPanel.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolsMagnifierPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsColorPickerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsEraserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsFillWithColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsTextPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsPencilPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipboardPastePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipboardCopyPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipboardCutPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // paintMenuStrip
            // 
            this.paintMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.paintMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.paintMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.paintMenuStrip.Name = "paintMenuStrip";
            this.paintMenuStrip.Size = new System.Drawing.Size(1184, 24);
            this.paintMenuStrip.TabIndex = 0;
            this.paintMenuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.ToolTipText = "Paint\r\n\r\nClick here to open, save or print \r\nand to see everything else you \r\ncan" +
    " do with your picture.";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // homeSubMenuPanel
            // 
            this.homeSubMenuPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.homeSubMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.homeSubMenuPanel.Controls.Add(this.toolsPanel);
            this.homeSubMenuPanel.Controls.Add(this.clipboardPanel);
            this.homeSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeSubMenuPanel.Location = new System.Drawing.Point(0, 24);
            this.homeSubMenuPanel.Name = "homeSubMenuPanel";
            this.homeSubMenuPanel.Size = new System.Drawing.Size(1184, 130);
            this.homeSubMenuPanel.TabIndex = 1;
            // 
            // clipboardPanel
            // 
            this.clipboardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clipboardPanel.Controls.Add(this.cliboardPasteLabel);
            this.clipboardPanel.Controls.Add(this.clipboardPastePicturebox);
            this.clipboardPanel.Controls.Add(this.clipboardCopyLabel);
            this.clipboardPanel.Controls.Add(this.clipboardCopyPicturebox);
            this.clipboardPanel.Controls.Add(this.clipboardCutPicturebox);
            this.clipboardPanel.Controls.Add(this.clipboardCutLabel);
            this.clipboardPanel.Controls.Add(this.clipboardLabel);
            this.clipboardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.clipboardPanel.Location = new System.Drawing.Point(0, 0);
            this.clipboardPanel.Name = "clipboardPanel";
            this.clipboardPanel.Size = new System.Drawing.Size(201, 128);
            this.clipboardPanel.TabIndex = 2;
            // 
            // cliboardPasteLabel
            // 
            this.cliboardPasteLabel.AutoSize = true;
            this.cliboardPasteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliboardPasteLabel.Location = new System.Drawing.Point(17, 74);
            this.cliboardPasteLabel.Name = "cliboardPasteLabel";
            this.cliboardPasteLabel.Size = new System.Drawing.Size(50, 20);
            this.cliboardPasteLabel.TabIndex = 8;
            this.cliboardPasteLabel.Text = "Paste";
            // 
            // clipboardCopyLabel
            // 
            this.clipboardCopyLabel.AutoSize = true;
            this.clipboardCopyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipboardCopyLabel.Location = new System.Drawing.Point(133, 46);
            this.clipboardCopyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.clipboardCopyLabel.Name = "clipboardCopyLabel";
            this.clipboardCopyLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.clipboardCopyLabel.Size = new System.Drawing.Size(45, 25);
            this.clipboardCopyLabel.TabIndex = 6;
            this.clipboardCopyLabel.Text = "Copy";
            // 
            // clipboardCutLabel
            // 
            this.clipboardCutLabel.AutoSize = true;
            this.clipboardCutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipboardCutLabel.Location = new System.Drawing.Point(133, 12);
            this.clipboardCutLabel.Name = "clipboardCutLabel";
            this.clipboardCutLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.clipboardCutLabel.Size = new System.Drawing.Size(34, 25);
            this.clipboardCutLabel.TabIndex = 3;
            this.clipboardCutLabel.Text = "Cut";
            // 
            // clipboardLabel
            // 
            this.clipboardLabel.AutoSize = true;
            this.clipboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clipboardLabel.Location = new System.Drawing.Point(60, 101);
            this.clipboardLabel.Name = "clipboardLabel";
            this.clipboardLabel.Size = new System.Drawing.Size(76, 20);
            this.clipboardLabel.TabIndex = 0;
            this.clipboardLabel.Text = "Clipboard";
            // 
            // toolsPanel
            // 
            this.toolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolsPanel.Controls.Add(this.toolsMagnifierPictureBox);
            this.toolsPanel.Controls.Add(this.toolsColorPickerPictureBox);
            this.toolsPanel.Controls.Add(this.toolsEraserPictureBox);
            this.toolsPanel.Controls.Add(this.toolsLabel);
            this.toolsPanel.Controls.Add(this.toolsFillWithColorPictureBox);
            this.toolsPanel.Controls.Add(this.toolsTextPictureBox);
            this.toolsPanel.Controls.Add(this.toolsPencilPictureBox);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolsPanel.Location = new System.Drawing.Point(201, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(168, 128);
            this.toolsPanel.TabIndex = 2;
            // 
            // toolsLabel
            // 
            this.toolsLabel.AutoSize = true;
            this.toolsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.toolsLabel.Location = new System.Drawing.Point(53, 101);
            this.toolsLabel.Name = "toolsLabel";
            this.toolsLabel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.toolsLabel.Size = new System.Drawing.Size(55, 20);
            this.toolsLabel.TabIndex = 1;
            this.toolsLabel.Text = "Tools";
            // 
            // toolsMagnifierPictureBox
            // 
            this.toolsMagnifierPictureBox.Image = global::MicrosoftPaintClone.Properties.Resources.magnifier;
            this.toolsMagnifierPictureBox.Location = new System.Drawing.Point(120, 63);
            this.toolsMagnifierPictureBox.Name = "toolsMagnifierPictureBox";
            this.toolsMagnifierPictureBox.Size = new System.Drawing.Size(30, 28);
            this.toolsMagnifierPictureBox.TabIndex = 10;
            this.toolsMagnifierPictureBox.TabStop = false;
            // 
            // toolsColorPickerPictureBox
            // 
            this.toolsColorPickerPictureBox.Image = global::MicrosoftPaintClone.Properties.Resources.colorPicker;
            this.toolsColorPickerPictureBox.Location = new System.Drawing.Point(70, 63);
            this.toolsColorPickerPictureBox.Name = "toolsColorPickerPictureBox";
            this.toolsColorPickerPictureBox.Size = new System.Drawing.Size(30, 28);
            this.toolsColorPickerPictureBox.TabIndex = 9;
            this.toolsColorPickerPictureBox.TabStop = false;
            // 
            // toolsEraserPictureBox
            // 
            this.toolsEraserPictureBox.Image = global::MicrosoftPaintClone.Properties.Resources.eraser;
            this.toolsEraserPictureBox.Location = new System.Drawing.Point(20, 63);
            this.toolsEraserPictureBox.Name = "toolsEraserPictureBox";
            this.toolsEraserPictureBox.Size = new System.Drawing.Size(30, 28);
            this.toolsEraserPictureBox.TabIndex = 8;
            this.toolsEraserPictureBox.TabStop = false;
            // 
            // toolsFillWithColorPictureBox
            // 
            this.toolsFillWithColorPictureBox.Image = global::MicrosoftPaintClone.Properties.Resources.fillWithColor;
            this.toolsFillWithColorPictureBox.Location = new System.Drawing.Point(70, 18);
            this.toolsFillWithColorPictureBox.Name = "toolsFillWithColorPictureBox";
            this.toolsFillWithColorPictureBox.Size = new System.Drawing.Size(30, 28);
            this.toolsFillWithColorPictureBox.TabIndex = 6;
            this.toolsFillWithColorPictureBox.TabStop = false;
            // 
            // toolsTextPictureBox
            // 
            this.toolsTextPictureBox.Image = global::MicrosoftPaintClone.Properties.Resources.text;
            this.toolsTextPictureBox.Location = new System.Drawing.Point(120, 18);
            this.toolsTextPictureBox.Name = "toolsTextPictureBox";
            this.toolsTextPictureBox.Size = new System.Drawing.Size(30, 28);
            this.toolsTextPictureBox.TabIndex = 7;
            this.toolsTextPictureBox.TabStop = false;
            // 
            // toolsPencilPictureBox
            // 
            this.toolsPencilPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolsPencilPictureBox.Image = global::MicrosoftPaintClone.Properties.Resources.pencil;
            this.toolsPencilPictureBox.Location = new System.Drawing.Point(20, 18);
            this.toolsPencilPictureBox.Name = "toolsPencilPictureBox";
            this.toolsPencilPictureBox.Size = new System.Drawing.Size(30, 28);
            this.toolsPencilPictureBox.TabIndex = 5;
            this.toolsPencilPictureBox.TabStop = false;
            // 
            // clipboardPastePicturebox
            // 
            this.clipboardPastePicturebox.Image = global::MicrosoftPaintClone.Properties.Resources.paste;
            this.clipboardPastePicturebox.Location = new System.Drawing.Point(12, 12);
            this.clipboardPastePicturebox.Name = "clipboardPastePicturebox";
            this.clipboardPastePicturebox.Size = new System.Drawing.Size(64, 59);
            this.clipboardPastePicturebox.TabIndex = 7;
            this.clipboardPastePicturebox.TabStop = false;
            // 
            // clipboardCopyPicturebox
            // 
            this.clipboardCopyPicturebox.Image = global::MicrosoftPaintClone.Properties.Resources.copy;
            this.clipboardCopyPicturebox.Location = new System.Drawing.Point(108, 46);
            this.clipboardCopyPicturebox.Name = "clipboardCopyPicturebox";
            this.clipboardCopyPicturebox.Size = new System.Drawing.Size(28, 28);
            this.clipboardCopyPicturebox.TabIndex = 5;
            this.clipboardCopyPicturebox.TabStop = false;
            // 
            // clipboardCutPicturebox
            // 
            this.clipboardCutPicturebox.Image = global::MicrosoftPaintClone.Properties.Resources.cut;
            this.clipboardCutPicturebox.Location = new System.Drawing.Point(108, 12);
            this.clipboardCutPicturebox.Name = "clipboardCutPicturebox";
            this.clipboardCutPicturebox.Size = new System.Drawing.Size(28, 28);
            this.clipboardCutPicturebox.TabIndex = 4;
            this.clipboardCutPicturebox.TabStop = false;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::MicrosoftPaintClone.Properties.Resources.newFile;
            this.newToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.newToolStripMenuItem.Size = new System.Drawing.Size(140, 52);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::MicrosoftPaintClone.Properties.Resources.openFile;
            this.openToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.openToolStripMenuItem.Size = new System.Drawing.Size(140, 52);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::MicrosoftPaintClone.Properties.Resources.saveFile;
            this.saveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 52);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = global::MicrosoftPaintClone.Properties.Resources.savesAsFile;
            this.saveToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(140, 52);
            this.saveToolStripMenuItem1.Text = "Save as";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::MicrosoftPaintClone.Properties.Resources.printFile;
            this.printToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.printToolStripMenuItem.Size = new System.Drawing.Size(140, 50);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::MicrosoftPaintClone.Properties.Resources.aboutPaint;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 52);
            this.exitToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::MicrosoftPaintClone.Properties.Resources.exitImage;
            this.exitToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(140, 52);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.homeSubMenuPanel);
            this.Controls.Add(this.paintMenuStrip);
            this.MainMenuStrip = this.paintMenuStrip;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.paintMenuStrip.ResumeLayout(false);
            this.paintMenuStrip.PerformLayout();
            this.homeSubMenuPanel.ResumeLayout(false);
            this.clipboardPanel.ResumeLayout(false);
            this.clipboardPanel.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolsMagnifierPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsColorPickerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsEraserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsFillWithColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsTextPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsPencilPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipboardPastePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipboardCopyPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipboardCutPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip paintMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Panel homeSubMenuPanel;
        private System.Windows.Forms.Panel clipboardPanel;
        private System.Windows.Forms.Label clipboardLabel;
        private System.Windows.Forms.Label clipboardCutLabel;
        private System.Windows.Forms.PictureBox clipboardCutPicturebox;
        private System.Windows.Forms.Label clipboardCopyLabel;
        private System.Windows.Forms.PictureBox clipboardCopyPicturebox;
        private System.Windows.Forms.PictureBox clipboardPastePicturebox;
        private System.Windows.Forms.Label cliboardPasteLabel;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.PictureBox toolsPencilPictureBox;
        private System.Windows.Forms.Label toolsLabel;
        private System.Windows.Forms.PictureBox toolsFillWithColorPictureBox;
        private System.Windows.Forms.PictureBox toolsTextPictureBox;
        private System.Windows.Forms.PictureBox toolsMagnifierPictureBox;
        private System.Windows.Forms.PictureBox toolsColorPickerPictureBox;
        private System.Windows.Forms.PictureBox toolsEraserPictureBox;
    }
}

