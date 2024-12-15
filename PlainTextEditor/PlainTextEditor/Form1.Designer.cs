namespace PlainTextEditor
{
    partial class PlainTextEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem lightThemeToolStripMenuItem;
        private ToolStripMenuItem darkThemeToolStripMenuItem;
        private ToolStripMenuItem shortcutsToolStripMenuItem;
        private ToolStripMenuItem modeToolStripMenuItem;
        private ToolStripMenuItem plainTextToolStripMenuItem;
        private ToolStripMenuItem cCToolStripMenuItem;
        private RichTextBox textBoxMain;

        // Newly added components for Compile and Run functionality
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem compileToolStripMenuItem;
        private ToolStripMenuItem runCodeToolStripMenuItem;


        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                printDocument?.Dispose();
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
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            lightThemeToolStripMenuItem = new ToolStripMenuItem();
            darkThemeToolStripMenuItem = new ToolStripMenuItem();
            modeToolStripMenuItem = new ToolStripMenuItem();
            plainTextToolStripMenuItem = new ToolStripMenuItem();
            cCToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem = new ToolStripMenuItem();
            shortcutsToolStripMenuItem = new ToolStripMenuItem();

            // Newly added Run Menu and its items
            runToolStripMenuItem = new ToolStripMenuItem();
            compileToolStripMenuItem = new ToolStripMenuItem();
            runCodeToolStripMenuItem = new ToolStripMenuItem();

            textBoxMain = new RichTextBox();
            panelLineNumbers = new Panel();

            // Newly added output panel
            panelOutput = new Panel();
            outputTextBox = new RichTextBox();

            menuStrip.SuspendLayout();
            panelOutput.SuspendLayout();
            SuspendLayout();
            //
            // menuStrip
            //
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] {
                fileToolStripMenuItem,
                editToolStripMenuItem,
                modeToolStripMenuItem,
                runToolStripMenuItem, // Added Run menu
                helpToolStripMenuItem
            });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(700, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            //
            // fileToolStripMenuItem
            //
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                newToolStripMenuItem,
                openToolStripMenuItem,
                saveToolStripMenuItem,
                saveAsToolStripMenuItem,
                printToolStripMenuItem,
                exitToolStripMenuItem
            });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            //
            // newToolStripMenuItem
            //
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(114, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            //
            // openToolStripMenuItem
            //
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(114, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            //
            // saveToolStripMenuItem
            //
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(114, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            //
            // saveAsToolStripMenuItem
            //
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(114, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            //
            // printToolStripMenuItem
            //
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(114, 22);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            //
            // exitToolStripMenuItem
            //
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(114, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            //
            // editToolStripMenuItem
            //
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { themeToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            //
            // themeToolStripMenuItem
            //
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                lightThemeToolStripMenuItem,
                darkThemeToolStripMenuItem
            });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(110, 22);
            themeToolStripMenuItem.Text = "Theme";
            //
            // lightThemeToolStripMenuItem
            //
            lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            lightThemeToolStripMenuItem.Size = new Size(140, 22);
            lightThemeToolStripMenuItem.Text = "Light Theme";
            lightThemeToolStripMenuItem.Click += lightThemeToolStripMenuItem_Click;
            //
            // darkThemeToolStripMenuItem
            //
            darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            darkThemeToolStripMenuItem.Size = new Size(140, 22);
            darkThemeToolStripMenuItem.Text = "Dark Theme";
            darkThemeToolStripMenuItem.Click += darkThemeToolStripMenuItem_Click;
            //
            // modeToolStripMenuItem
            //
            modeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                plainTextToolStripMenuItem,
                cCToolStripMenuItem
            });
            modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            modeToolStripMenuItem.Size = new Size(50, 20);
            modeToolStripMenuItem.Text = "Mode";
            //
            // plainTextToolStripMenuItem
            //
            plainTextToolStripMenuItem.Name = "plainTextToolStripMenuItem";
            plainTextToolStripMenuItem.Size = new Size(121, 22);
            plainTextToolStripMenuItem.Text = "PlainText";
            plainTextToolStripMenuItem.Click += plainTextToolStripMenuItem_Click;
            //
            // cCToolStripMenuItem
            //
            cCToolStripMenuItem.Name = "cCToolStripMenuItem";
            cCToolStripMenuItem.Size = new Size(121, 22);
            cCToolStripMenuItem.Text = "C/C++";
            cCToolStripMenuItem.Click += cCToolStripMenuItem_Click;
            //
            // helpToolStripMenuItem
            //
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                aToolStripMenuItem,
                shortcutsToolStripMenuItem
            });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            //
            // aToolStripMenuItem
            //
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(124, 22);
            aToolStripMenuItem.Text = "About";
            aToolStripMenuItem.Click += aToolStripMenuItem_Click;
            //
            // shortcutsToolStripMenuItem
            //
            shortcutsToolStripMenuItem.Name = "shortcutsToolStripMenuItem";
            shortcutsToolStripMenuItem.Size = new Size(124, 22);
            shortcutsToolStripMenuItem.Text = "Shortcuts";
            shortcutsToolStripMenuItem.Click += shortcutsToolStripMenuItem_Click;

            //
            // runToolStripMenuItem
            //
            runToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                compileToolStripMenuItem,
                runCodeToolStripMenuItem
            });
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(40, 20);
            runToolStripMenuItem.Text = "Run";
            //
            // compileToolStripMenuItem
            //
            compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            compileToolStripMenuItem.Size = new Size(131, 22);
            compileToolStripMenuItem.Text = "Compile";
            compileToolStripMenuItem.Click += compileToolStripMenuItem_Click;
            //
            // runCodeToolStripMenuItem
            //
            runCodeToolStripMenuItem.Name = "runCodeToolStripMenuItem";
            runCodeToolStripMenuItem.Size = new Size(131, 22);
            runCodeToolStripMenuItem.Text = "Run Code";
            runCodeToolStripMenuItem.Click += runCodeToolStripMenuItem_Click;

            //
            // textBoxMain
            //
            textBoxMain.AcceptsTab = true;
            textBoxMain.Dock = DockStyle.Fill;
            textBoxMain.Location = new Point(25, 24);
            textBoxMain.Name = "textBoxMain";
            textBoxMain.Size = new Size(675, 200);
            textBoxMain.TabIndex = 1;
            textBoxMain.Text = "";
            textBoxMain.TextChanged += textBoxMain_TextChanged;
            //
            // panelLineNumbers
            //
            panelLineNumbers.Dock = DockStyle.Left;
            panelLineNumbers.Width = 25;
            panelLineNumbers.BackColor = IsDarkTheme() ? Color.FromArgb(40, 40, 40) : Color.LightGray;
            panelLineNumbers.Paint += panelLineNumbers_Paint;
            panelLineNumbers.Margin = new Padding(0);
            panelLineNumbers.Padding = new Padding(0);
            //
            // panelOutput
            //
            panelOutput.Dock = DockStyle.Bottom;
            panelOutput.Height = 100;
            panelOutput.Controls.Add(outputTextBox);
            //
            // outputTextBox
            //
            outputTextBox.Dock = DockStyle.Fill;
            outputTextBox.ReadOnly = true;
            outputTextBox.BackColor = IsDarkTheme() ? Color.Black : Color.White;
            outputTextBox.ForeColor = IsDarkTheme() ? Color.White : Color.Black;
            outputTextBox.Font = new Font("Consolas", 10);
            outputTextBox.Text = "";

            //
            // PlainTextEditor
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(700, 400);
            Controls.Add(textBoxMain);
            Controls.Add(panelLineNumbers);
            Controls.Add(panelOutput);
            Controls.Add(menuStrip);
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PlainTextEditor";
            Text = "PlainTextEditor";
            FormClosing += PlainTextEditor_FormClosing;
            KeyDown += PlainTextEditor_KeyDown;
            KeyPress += PlainTextEditor_KeyPress;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panelOutput.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLineNumbers;
        private Panel panelOutput;
        private RichTextBox outputTextBox;
    }
}
