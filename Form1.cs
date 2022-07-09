using System.Diagnostics;

namespace Cpp2IL_GUI;

public partial class Form1 : Form
{
    bool selectedFolder;
    string file;
    string folder;
    string outFolder;
    NumericUpDown numbox = new NumericUpDown();
    CheckBox skipAnalysis = new CheckBox();
    CheckBox skipTxt = new CheckBox();
    CheckBox rps = new CheckBox();
    CheckBox attrchk = new CheckBox();
    CheckBox parchk = new CheckBox();
    CheckBox sty = new CheckBox();
    CheckBox analyzeall = new CheckBox();
    CheckBox skipdmp = new CheckBox();
    CheckBox attrestore = new CheckBox();
    CheckBox verbose = new CheckBox();
    CheckBox il = new CheckBox();
    private System.ComponentModel.IContainer components = null;
    private void InitializeComponent()
    {
        // window components
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(450, 450);
        this.Text = "Cpp2IL-GUI";

        // logo
        TextBox logo = new System.Windows.Forms.TextBox();
        logo.Text = "Cpp2IL-GUI";
        logo.ReadOnly = true;
        logo.AcceptsReturn = false;
        logo.AcceptsTab = false;
        logo.Enabled = false;
        logo.Location = new Point(110, 10);
        logo.Font = new Font("Comic Sans MS", 30f, FontStyle.Regular);
        logo.Size = new Size(500, 100);
        logo.BorderStyle = BorderStyle.None;
        this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        logo.BackColor = this.BackColor;
        Controls.Add(logo);

        // text before file/folder
        TextBox path = new System.Windows.Forms.TextBox();
        path.Text = "Game Path";
        path.ReadOnly = true;
        path.AcceptsReturn = false;
        path.AcceptsTab = false;
        path.Enabled = false;
        path.Location = new Point(35, 80);
        path.Font = new Font("Comic Sans MS", 15f, FontStyle.Regular);
        path.Size = new Size(100, 100);
        path.BorderStyle = BorderStyle.None;
        path.BackColor = this.BackColor;
        Controls.Add(path);

        // button to select file
        Button selectFile = new Button();
        selectFile.Location = new Point(180, 80);
        selectFile.Size = new Size(80, 30);
        selectFile.Text = "Select a file";
        selectFile.Click += selectFile_Click;
        Controls.Add(selectFile);

        // button to select folder
        Button selectFolder = new Button();
        selectFolder.Location = new Point(280, 80);
        selectFolder.Size = new Size(100, 30);
        selectFolder.Text = "Select a folder";
        selectFolder.Click += selectFolder_Click;
        Controls.Add(selectFolder);

        // text for analysislevel
        TextBox level = new TextBox();
        level.Text = "Analysis level";
        level.ReadOnly = true;
        level.AcceptsReturn = false;
        level.AcceptsTab = false;
        level.Enabled = false;
        level.Location = new Point(35, 120);
        level.Font = new Font("Comic Sans MS", 15f, FontStyle.Regular);
        level.Size = new Size(140, 100);
        level.BorderStyle = BorderStyle.None;
        level.BackColor = this.BackColor;
        Controls.Add(level);

        // numericbox for analysislevel
        numbox.Size = new Size(30, 10);
        numbox.Location = new Point(175, 125);
        numbox.Visible = true;
        numbox.Maximum = 4;
        Controls.Add(numbox);

        // text for skip analysis
        TextBox skip = new TextBox();
        skip.Text = "Skip Analysis";
        skip.ReadOnly = true;
        skip.AcceptsReturn = false;
        skip.AcceptsTab = false;
        skip.Enabled = false;
        skip.Location = new Point(240, 120);
        skip.Font = new Font("Comic Sans MS", 15f, FontStyle.Regular);
        skip.Size = new Size(130, 100);
        skip.BorderStyle = BorderStyle.None;
        skip.BackColor = this.BackColor;
        Controls.Add(skip);

        // checkbox components
        this.skipAnalysis.Location = new Point(375, 125);
        this.skipAnalysis.Size = new Size(20, 20);
        this.Controls.Add(skipAnalysis);

        // text for skip-metadata-txts
        TextBox skipmeta = new TextBox();
        skipmeta.Text = "Skip Metadata Txts";
        skipmeta.ReadOnly = true;
        skipmeta.AcceptsReturn = false;
        skipmeta.AcceptsTab = false;
        skipmeta.Enabled = false;
        skipmeta.Location = new Point(35, 160);
        skipmeta.Font = new Font("Comic Sans MS", 15f, FontStyle.Regular);
        skipmeta.Size = new Size(140, 100);
        skipmeta.BorderStyle = BorderStyle.None;
        skipmeta.BackColor = this.BackColor;
        Controls.Add(skipmeta);

        // checkbox for skip-metadata-txts
        this.skipTxt.Location = new Point(185, 165);
        this.skipTxt.Size = new Size(20, 20);
        this.Controls.Add(skipTxt);

        // text for reg prompts
        TextBox prompts = new TextBox();
        prompts.Text = "Disable RPs";
        prompts.ReadOnly = true;
        prompts.AcceptsReturn = false;
        prompts.AcceptsTab = false;
        prompts.Enabled = false;
        prompts.Location = new Point(240, 160);
        prompts.Font = new Font("Comic Sans MS", 15f, FontStyle.Regular);
        prompts.Size = new Size(130, 100);
        prompts.BorderStyle = BorderStyle.None;
        prompts.BackColor = this.BackColor;
        Controls.Add(prompts);

        // checkbox for prompts
        this.rps.Location = new Point(375, 165);
        this.rps.Size = new Size(20, 20);
        this.Controls.Add(rps);

        // text for supress attr
        TextBox attr = new TextBox();
        attr.Text = "Supress Attribs";
        attr.ReadOnly = true;
        attr.AcceptsReturn = false;
        attr.AcceptsTab = false;
        attr.Enabled = false;
        attr.Location = new Point(35, 200);
        attr.Font = new Font("Comic Sans MS", 15f, FontStyle.Regular);
        attr.Size = new Size(150, 100);
        attr.BorderStyle = BorderStyle.None;
        attr.BackColor = this.BackColor;
        Controls.Add(attr);

        // checkbox for attr
        this.attrchk.Location = new Point(195, 205);
        this.attrchk.Size = new Size(20, 20);
        this.Controls.Add(attrchk);

        // text for parallel
        TextBox parallel = new TextBox();
        parallel.Text = "Run Parallel";
        parallel.ReadOnly = true;
        parallel.AcceptsReturn = false;
        parallel.AcceptsTab = false;
        parallel.Enabled = false;
        parallel.Location = new Point(240, 200);
        parallel.Font = new Font("Comic Sans MS", 15f, FontStyle.Regular);
        parallel.Size = new Size(130, 100);
        parallel.BorderStyle = BorderStyle.None;
        parallel.BackColor = this.BackColor;
        Controls.Add(parallel);

        // checkbox for parallel
        this.parchk.Location = new Point(375, 205);
        this.parchk.Size = new Size(20, 20);
        this.Controls.Add(parchk);

        // text for ignore safety
        TextBox safety = new TextBox();
        safety.Text = "Ignore Safety";
        safety.ReadOnly = true;
        safety.AcceptsReturn = false;
        safety.AcceptsTab = false;
        safety.Enabled = false;
        safety.Location = new Point(35, 240);
        safety.Font = new Font("Comic Sans MS", 15f, FontStyle.Regular);
        safety.Size = new Size(150, 100);
        safety.BorderStyle = BorderStyle.None;
        safety.BackColor = this.BackColor;
        Controls.Add(safety);

        // checkbox for safetyt
        this.sty.Location = new Point(185, 245);
        this.sty.Size = new Size(20, 20);
        this.Controls.Add(sty);

        // analyze all text
        TextBox analyze = new TextBox();
        analyze.Text = "Analyze All";
        analyze.ReadOnly = true;
        analyze.AcceptsReturn = false;
        analyze.AcceptsTab = false;
        analyze.Enabled = false;
        analyze.Location = new Point(240, 240);
        analyze.Font = new Font("Comic Sans MS", 15f, FontStyle.Regular);
        analyze.Size = new Size(130, 100);
        analyze.BorderStyle = BorderStyle.None;
        analyze.BackColor = this.BackColor;
        Controls.Add(analyze);

        // checkbox for analyzeall
        this.analyzeall.Location = new Point(375, 245);
        this.analyzeall.Size = new Size(20, 20);
        this.Controls.Add(analyzeall);

        // text for skip dumps
        TextBox skipdumps = new TextBox();
        skipdumps.Text = "Skip m() dumps";
        skipdumps.ReadOnly = true;
        skipdumps.AcceptsReturn = false;
        skipdumps.AcceptsTab = false;
        skipdumps.Enabled = false;
        skipdumps.Location = new Point(35, 280);
        skipdumps.Font = new Font("Comic Sans MS", 15f, FontStyle.Regular);
        skipdumps.Size = new Size(150, 100);
        skipdumps.BorderStyle = BorderStyle.None;
        skipdumps.BackColor = this.BackColor;
        Controls.Add(skipdumps);

        // chkbox for skip dumps
        this.skipdmp.Location = new Point(195, 285);
        this.skipdmp.Size = new Size(20, 20);
        this.Controls.Add(skipdmp);

        // attr restore text
        TextBox attrrestore = new TextBox();
        attrrestore.Text = "Restore Attr";
        attrrestore.ReadOnly = true;
        attrrestore.AcceptsReturn = false;
        attrrestore.AcceptsTab = false;
        attrrestore.Enabled = false;
        attrrestore.Location = new Point(240, 280);
        attrrestore.Font = new Font("Comic Sans MS", 15f, FontStyle.Regular);
        attrrestore.Size = new Size(130, 100);
        attrrestore.BorderStyle = BorderStyle.None;
        attrrestore.BackColor = this.BackColor;
        Controls.Add(attrrestore);
        
        // chkbox for skip dumps
        this.attrestore.Location = new Point(375, 285);
        this.attrestore.Size = new Size(20, 20);
        this.Controls.Add(attrestore);

        // text for verbose
        TextBox verb = new TextBox();
        verb.Text = "Run Verbose";
        verb.ReadOnly = true;
        verb.AcceptsReturn = false;
        verb.AcceptsTab = false;
        verb.Enabled = false;
        verb.Location = new Point(35, 320);
        verb.Font = new Font("Comic Sans MS", 15f, FontStyle.Regular);
        verb.Size = new Size(150, 100);
        verb.BorderStyle = BorderStyle.None;
        verb.BackColor = this.BackColor;
        Controls.Add(verb);

        // checkbox for verbose
        this.verbose.Location = new Point(185, 325);
        this.verbose.Size = new Size(20, 20);
        this.Controls.Add(verbose);

        // il text
        TextBox iltext = new TextBox();
        iltext.Text = "Enable IL";
        iltext.ReadOnly = true;
        iltext.AcceptsReturn = false;
        iltext.AcceptsTab = false;
        iltext.Enabled = false;
        iltext.Location = new Point(240, 320);
        iltext.Font = new Font("Comic Sans MS", 15f, FontStyle.Regular);
        iltext.Size = new Size(130, 100);
        iltext.BorderStyle = BorderStyle.None;
        iltext.BackColor = this.BackColor;
        Controls.Add(iltext);
        
        // chkbox for il
        this.il.Location = new Point(375, 325);
        this.il.Size = new Size(20, 20);
        this.Controls.Add(il);

        // select out folder
        TextBox outfldr = new TextBox();
        outfldr.Text = "Select output folder";
        outfldr.ReadOnly = true;
        outfldr.AcceptsReturn = false;
        outfldr.AcceptsTab = false;
        outfldr.Enabled = false;
        outfldr.Location = new Point(35, 360);
        outfldr.Font = new Font("Comic Sans MS", 15f, FontStyle.Regular);
        outfldr.Size = new Size(200, 100);
        outfldr.BorderStyle = BorderStyle.None;
        outfldr.BackColor = this.BackColor;
        Controls.Add(outfldr);

        // out folder button
        Button outFolder = new Button();
        outFolder.Location = new Point(260, 360);
        outFolder.Size = new Size(100, 30);
        outFolder.Text = "Select a folder";
        outFolder.Click += outFolder_Click;
        Controls.Add(outFolder);

        // execute cpp2il button
        Button run = new Button();
        run.Location = new Point(170, 405);
        run.Size = new Size(100, 30);
        run.Text = "Run Cpp2IL";
        run.Click += run_Click;
        Controls.Add(run);
    }

    private void selectFile_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        DialogResult result = openFileDialog1.ShowDialog();
        file = openFileDialog1.FileName;
        selectedFolder = false;
    }

    private void selectFolder_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog openFileDialog2 = new FolderBrowserDialog();
        DialogResult result = openFileDialog2.ShowDialog();
        folder = openFileDialog2.SelectedPath;
        selectedFolder = true;
    }

    private void outFolder_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog openFileDialog3 = new FolderBrowserDialog();
        DialogResult result = openFileDialog3.ShowDialog();
        outFolder = openFileDialog3.SelectedPath;
        selectedFolder = true;
    }

    private void run_Click(object sender, EventArgs e)
    {
        string cliArgs = $"--game-path {file + folder} --output-root {outFolder}";
        if (String.IsNullOrEmpty(file) && String.IsNullOrEmpty(folder) || !String.IsNullOrEmpty(file) && !String.IsNullOrEmpty(folder))
        {
            file = null;
            folder = null;
            MessageBox.Show("invalid file/folder params\nmake sure you:\n1. selected a file/folder\n2. didnt select both types\n\nreselect the desired type");
            return;
        } else if (String.IsNullOrEmpty(outFolder)) {
            MessageBox.Show("Select an output folder");
            return;
        }
        if (skipAnalysis.Checked == false) {
            cliArgs = cliArgs + " --analysis-level " + numbox.Value;
        }
        if (skipAnalysis.Checked) {
            cliArgs = cliArgs + " --skip-analysis";
        }
        if (skipTxt.Checked) {
            cliArgs = cliArgs + " --skip-metadata-txts";
        }
        if (rps.Checked) {
            cliArgs = cliArgs + " --disable-registration-prompts";
        }
        if (verbose.Checked) {
            cliArgs = cliArgs + " --verbose";
        }
        if (il.Checked) {
            cliArgs = cliArgs + " --experimental-enable-il-to-assembly-please";
        }
        if (attrchk.Checked) {
            cliArgs = cliArgs + " --suppress-attributes";
        }
        if (parchk.Checked) {
            cliArgs = cliArgs + " --parallel";
        }
        if (analyzeall.Checked) {
            cliArgs = cliArgs + " --analyze-all";
        }
        if (skipdmp.Checked) {
            cliArgs = cliArgs + " --skip-method-dumps";
        }
        if (attrestore.Checked) {
            cliArgs = cliArgs + " --simple-attribute-restoration";
        }
        if (sty.Checked) {
            cliArgs = cliArgs + " --throw-safety-out-the-window";
        }
        Process process = Process.Start("Cpp2IL.exe", cliArgs);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    public Form1()
    {
        InitializeComponent();
    }
}
