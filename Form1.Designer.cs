namespace hajoegyszeru_vinklarik1119
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbszabad = new Label();
            lbszabadhely = new Label();
            lbgyerek = new Label();
            rtbadat = new RichTextBox();
            groupBox1 = new GroupBox();
            txkat = new TextBox();
            txtervez = new TextBox();
            txfoglalt = new TextBox();
            btment = new Button();
            btkilep = new Button();
            cbnem = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 28);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Adatok:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 58);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Neme:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 101);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Kategória:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 142);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 3;
            label4.Text = "Tervezhető utasszám:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 184);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 4;
            label5.Text = "Foglalt helyek száma:";
            // 
            // lbszabad
            // 
            lbszabad.AutoSize = true;
            lbszabad.Location = new Point(410, 228);
            lbszabad.Name = "lbszabad";
            lbszabad.Size = new Size(126, 15);
            lbszabad.TabIndex = 5;
            lbszabad.Text = "Szabad helyek száma:";
            // 
            // lbszabadhely
            // 
            lbszabadhely.AutoSize = true;
            lbszabadhely.Location = new Point(17, 29);
            lbszabadhely.Name = "lbszabadhely";
            lbszabadhely.Size = new Size(126, 15);
            lbszabadhely.TabIndex = 6;
            lbszabadhely.Text = "Szabad helyek száma:";
            // 
            // lbgyerek
            // 
            lbgyerek.AutoSize = true;
            lbgyerek.Location = new Point(17, 68);
            lbgyerek.Name = "lbgyerek";
            lbgyerek.Size = new Size(128, 15);
            lbgyerek.TabIndex = 7;
            lbgyerek.Text = "Gyerek utasok száma:";
            // 
            // rtbadat
            // 
            rtbadat.Location = new Point(34, 55);
            rtbadat.Name = "rtbadat";
            rtbadat.Size = new Size(345, 244);
            rtbadat.TabIndex = 8;
            rtbadat.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 192);
            groupBox1.Controls.Add(lbgyerek);
            groupBox1.Controls.Add(lbszabadhely);
            groupBox1.Location = new Point(34, 324);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 100);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // txkat
            // 
            txkat.Location = new Point(476, 101);
            txkat.Name = "txkat";
            txkat.Size = new Size(198, 23);
            txkat.TabIndex = 10;
            // 
            // txtervez
            // 
            txtervez.Location = new Point(544, 139);
            txtervez.Name = "txtervez";
            txtervez.Size = new Size(124, 23);
            txtervez.TabIndex = 11;
            txtervez.TextChanged += txtervez_TextChanged;
            // 
            // txfoglalt
            // 
            txfoglalt.Location = new Point(540, 184);
            txfoglalt.Name = "txfoglalt";
            txfoglalt.Size = new Size(123, 23);
            txfoglalt.TabIndex = 12;
            txfoglalt.TextChanged += txfoglalt_TextChanged;
            // 
            // btment
            // 
            btment.Location = new Point(693, 101);
            btment.Name = "btment";
            btment.Size = new Size(79, 43);
            btment.TabIndex = 13;
            btment.Text = "Mentés";
            btment.UseVisualStyleBackColor = true;
            btment.Click += btment_Click;
            // 
            // btkilep
            // 
            btkilep.Location = new Point(693, 161);
            btkilep.Name = "btkilep";
            btkilep.Size = new Size(79, 43);
            btkilep.TabIndex = 14;
            btkilep.Text = "Kilépés";
            btkilep.UseVisualStyleBackColor = true;
            btkilep.Click += button2_Click;
            // 
            // cbnem
            // 
            cbnem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbnem.FormattingEnabled = true;
            cbnem.Items.AddRange(new object[] { "Férfi", "Nő", "Gyerek" });
            cbnem.Location = new Point(458, 58);
            cbnem.Name = "cbnem";
            cbnem.Size = new Size(176, 23);
            cbnem.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(cbnem);
            Controls.Add(btkilep);
            Controls.Add(btment);
            Controls.Add(txfoglalt);
            Controls.Add(txtervez);
            Controls.Add(txkat);
            Controls.Add(groupBox1);
            Controls.Add(rtbadat);
            Controls.Add(lbszabad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hajó létszám adatok";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbszabad;
        private Label lbszabadhely;
        private Label lbgyerek;
        private RichTextBox rtbadat;
        private GroupBox groupBox1;
        private TextBox txkat;
        private TextBox txtervez;
        private TextBox txfoglalt;
        private Button btment;
        private Button btkilep;
        private ComboBox cbnem;
    }
}
