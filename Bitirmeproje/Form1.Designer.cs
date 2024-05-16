namespace Bitirmeproje
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            cRUDBindingSource = new BindingSource(components);
            baglanBindingSource = new BindingSource(components);
            form1BindingSource = new BindingSource(components);
            booleanToRotationTransformConverterBindingSource = new BindingSource(components);
            lbl1 = new Label();
            lbl_analiz = new Label();
            btn_hesapla = new Button();
            label1 = new Label();
            lbl_kikare = new Label();
            txt_kadin_a = new TextBox();
            txt_erkek_a = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txt_erkek_b = new TextBox();
            label5 = new Label();
            txt_kadin_b = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label7 = new Label();
            lbl_anlamlilikdüzeyi = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cRUDBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baglanBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)booleanToRotationTransformConverterBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 1);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(375, 380);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(736, 317);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(194, 51);
            button1.TabIndex = 1;
            button1.Text = "Verileri Güncelle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Location = new Point(736, 384);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(194, 51);
            button2.TabIndex = 2;
            button2.Text = "Graik Oluştur";
            button2.UseVisualStyleBackColor = false;
            // 
            // cRUDBindingSource
            // 
            cRUDBindingSource.DataSource = typeof(CRUD);
            // 
            // baglanBindingSource
            // 
            baglanBindingSource.DataSource = typeof(baglan);
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(Form1);
            // 
            // booleanToRotationTransformConverterBindingSource
            // 
            booleanToRotationTransformConverterBindingSource.DataSource = typeof(SciChart.Charting.Common.Databinding.BooleanToRotationTransformConverter);
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(763, 227);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(114, 15);
            lbl1.TabIndex = 3;
            lbl1.Text = "Anova Analiz sonuç:";
            // 
            // lbl_analiz
            // 
            lbl_analiz.AutoSize = true;
            lbl_analiz.Location = new Point(893, 227);
            lbl_analiz.Name = "lbl_analiz";
            lbl_analiz.Size = new Size(15, 15);
            lbl_analiz.TabIndex = 4;
            lbl_analiz.Text = "[]";
            // 
            // btn_hesapla
            // 
            btn_hesapla.BackColor = SystemColors.AppWorkspace;
            btn_hesapla.Location = new Point(413, 289);
            btn_hesapla.Margin = new Padding(3, 2, 3, 2);
            btn_hesapla.Name = "btn_hesapla";
            btn_hesapla.Size = new Size(194, 51);
            btn_hesapla.TabIndex = 5;
            btn_hesapla.Text = "Kikare Hesapla";
            btn_hesapla.UseVisualStyleBackColor = false;
            btn_hesapla.Click += btn_hesapla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(397, 227);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 6;
            label1.Text = "Kikare toplamı sonuç:";
            // 
            // lbl_kikare
            // 
            lbl_kikare.AutoSize = true;
            lbl_kikare.Location = new Point(532, 227);
            lbl_kikare.Name = "lbl_kikare";
            lbl_kikare.Size = new Size(15, 15);
            lbl_kikare.TabIndex = 7;
            lbl_kikare.Text = "[]";
            // 
            // txt_kadin_a
            // 
            txt_kadin_a.Location = new Point(134, 29);
            txt_kadin_a.Margin = new Padding(3, 2, 3, 2);
            txt_kadin_a.Name = "txt_kadin_a";
            txt_kadin_a.Size = new Size(145, 23);
            txt_kadin_a.TabIndex = 8;
            // 
            // txt_erkek_a
            // 
            txt_erkek_a.Location = new Point(134, 59);
            txt_erkek_a.Margin = new Padding(3, 2, 3, 2);
            txt_erkek_a.Name = "txt_erkek_a";
            txt_erkek_a.Size = new Size(145, 23);
            txt_erkek_a.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 31);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 10;
            label3.Text = "KOŞULA1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 62);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 11;
            label4.Text = "KOŞULA2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_erkek_a);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_kadin_a);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(396, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(298, 105);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÜRÜN A";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_erkek_b);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_kadin_b);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(396, 118);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(298, 105);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "ÜRÜN B";
            // 
            // txt_erkek_b
            // 
            txt_erkek_b.Location = new Point(134, 59);
            txt_erkek_b.Margin = new Padding(3, 2, 3, 2);
            txt_erkek_b.Name = "txt_erkek_b";
            txt_erkek_b.Size = new Size(145, 23);
            txt_erkek_b.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 62);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 11;
            label5.Text = "KOŞULB2";
            // 
            // txt_kadin_b
            // 
            txt_kadin_b.Location = new Point(134, 29);
            txt_kadin_b.Margin = new Padding(3, 2, 3, 2);
            txt_kadin_b.Name = "txt_kadin_b";
            txt_kadin_b.Size = new Size(145, 23);
            txt_kadin_b.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 31);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 10;
            label6.Text = "KOŞULB1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(426, 208);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 14;
            label2.Text = "Kikare toplamı sonuç:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 258);
            label7.Name = "label7";
            label7.Size = new Size(136, 15);
            label7.TabIndex = 15;
            label7.Text = "Kikare anlamlılık düzeyi :";
            // 
            // lbl_anlamlilikdüzeyi
            // 
            lbl_anlamlilikdüzeyi.AutoSize = true;
            lbl_anlamlilikdüzeyi.Location = new Point(532, 258);
            lbl_anlamlilikdüzeyi.Name = "lbl_anlamlilikdüzeyi";
            lbl_anlamlilikdüzeyi.Size = new Size(15, 15);
            lbl_anlamlilikdüzeyi.TabIndex = 16;
            lbl_anlamlilikdüzeyi.Text = "[]";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 431);
            Controls.Add(lbl_anlamlilikdüzeyi);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lbl_kikare);
            Controls.Add(label1);
            Controls.Add(btn_hesapla);
            Controls.Add(lbl_analiz);
            Controls.Add(lbl1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cRUDBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)baglanBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)booleanToRotationTransformConverterBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private BindingSource baglanBindingSource;
        private BindingSource cRUDBindingSource;
        private BindingSource form1BindingSource;
        private BindingSource booleanToRotationTransformConverterBindingSource;
        private Label lbl1;
        private Label lbl_analiz;
        private Button btn_hesapla;
        private Label label1;
        private Label lbl_kikare;
        private TextBox txt_kadin_a;
        private TextBox txt_erkek_a;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txt_erkek_b;
        private Label label5;
        private TextBox txt_kadin_b;
        private Label label6;
        private Label label2;
        private Label label7;
        private Label lbl_anlamlilikdüzeyi;
    }
}
