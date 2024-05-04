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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cRUDBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baglanBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)booleanToRotationTransformConverterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(429, 507);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(849, 43);
            button1.Name = "button1";
            button1.Size = new Size(222, 68);
            button1.TabIndex = 1;
            button1.Text = "Verileri Güncelle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Location = new Point(849, 132);
            button2.Name = "button2";
            button2.Size = new Size(222, 68);
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
            lbl1.Location = new Point(525, 43);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(141, 20);
            lbl1.TabIndex = 3;
            lbl1.Text = "Anova Analiz sonuç:";
            // 
            // lbl_analiz
            // 
            lbl_analiz.AutoSize = true;
            lbl_analiz.Location = new Point(673, 43);
            lbl_analiz.Name = "lbl_analiz";
            lbl_analiz.Size = new Size(19, 20);
            lbl_analiz.TabIndex = 4;
            lbl_analiz.Text = "[]";
            // 
            // btn_hesapla
            // 
            btn_hesapla.BackColor = SystemColors.AppWorkspace;
            btn_hesapla.Location = new Point(849, 225);
            btn_hesapla.Name = "btn_hesapla";
            btn_hesapla.Size = new Size(222, 68);
            btn_hesapla.TabIndex = 5;
            btn_hesapla.Text = "Hesapla";
            btn_hesapla.UseVisualStyleBackColor = false;
            btn_hesapla.Click += btn_hesapla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 514);
            Controls.Add(btn_hesapla);
            Controls.Add(lbl_analiz);
            Controls.Add(lbl1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cRUDBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)baglanBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)booleanToRotationTransformConverterBindingSource).EndInit();
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
    }
}
