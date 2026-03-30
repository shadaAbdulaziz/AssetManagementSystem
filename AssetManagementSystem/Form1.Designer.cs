namespace AssetManagementSystem
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
            btnAdd = new Button();
            dgvAssets = new DataGridView();
            label1 = new Label();
            typeTxt = new TextBox();
            label2 = new Label();
            brandTxt = new TextBox();
            label3 = new Label();
            modelTxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            priceNum = new NumericUpDown();
            label6 = new Label();
            butDelete = new Button();
            dateTimePicker = new DateTimePicker();
            comboCountry = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAssets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceNum).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(95, 678);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(288, 66);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Asset";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvAssets
            // 
            dgvAssets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssets.Location = new Point(623, 178);
            dgvAssets.Name = "dgvAssets";
            dgvAssets.RowHeadersWidth = 102;
            dgvAssets.Size = new Size(1218, 581);
            dgvAssets.TabIndex = 1;
            dgvAssets.CellFormatting += dgvAssets_CellFormatting;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 123);
            label1.Name = "label1";
            label1.Size = new Size(96, 41);
            label1.TabIndex = 3;
            label1.Text = "Office";
            // 
            // typeTxt
            // 
            typeTxt.Location = new Point(298, 217);
            typeTxt.Name = "typeTxt";
            typeTxt.Size = new Size(301, 47);
            typeTxt.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 217);
            label2.Name = "label2";
            label2.Size = new Size(81, 41);
            label2.TabIndex = 5;
            label2.Text = "Type";
            // 
            // brandTxt
            // 
            brandTxt.Location = new Point(298, 307);
            brandTxt.Name = "brandTxt";
            brandTxt.Size = new Size(301, 47);
            brandTxt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 307);
            label3.Name = "label3";
            label3.Size = new Size(95, 41);
            label3.TabIndex = 7;
            label3.Text = "Brand";
            // 
            // modelTxt
            // 
            modelTxt.Location = new Point(298, 405);
            modelTxt.Name = "modelTxt";
            modelTxt.Size = new Size(301, 47);
            modelTxt.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 405);
            label4.Name = "label4";
            label4.Size = new Size(104, 41);
            label4.TabIndex = 9;
            label4.Text = "Model";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 485);
            label5.Name = "label5";
            label5.Size = new Size(82, 41);
            label5.TabIndex = 10;
            label5.Text = "Price";
            // 
            // priceNum
            // 
            priceNum.Location = new Point(298, 485);
            priceNum.Name = "priceNum";
            priceNum.Size = new Size(256, 47);
            priceNum.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 576);
            label6.Name = "label6";
            label6.Size = new Size(207, 41);
            label6.TabIndex = 12;
            label6.Text = "Purchase Date";
            // 
            // butDelete
            // 
            butDelete.Location = new Point(95, 794);
            butDelete.Name = "butDelete";
            butDelete.Size = new Size(288, 66);
            butDelete.TabIndex = 13;
            butDelete.Text = "Delete Asset";
            butDelete.UseVisualStyleBackColor = true;
            butDelete.Click += butDelete_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(298, 570);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(301, 47);
            dateTimePicker.TabIndex = 14;
            // 
            // comboCountry
            // 
            comboCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCountry.FormattingEnabled = true;
            comboCountry.Location = new Point(298, 123);
            comboCountry.Name = "comboCountry";
            comboCountry.Size = new Size(301, 49);
            comboCountry.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(560, 487);
            label7.Name = "label7";
            label7.Size = new Size(34, 41);
            label7.TabIndex = 16;
            label7.Text = "$";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1868, 1034);
            Controls.Add(label7);
            Controls.Add(comboCountry);
            Controls.Add(dateTimePicker);
            Controls.Add(butDelete);
            Controls.Add(label6);
            Controls.Add(priceNum);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(modelTxt);
            Controls.Add(label3);
            Controls.Add(brandTxt);
            Controls.Add(label2);
            Controls.Add(typeTxt);
            Controls.Add(label1);
            Controls.Add(dgvAssets);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAssets).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private DataGridView dgvAssets;
        private Label label1;
        private TextBox typeTxt;
        private Label label2;
        private TextBox brandTxt;
        private Label label3;
        private TextBox modelTxt;
        private Label label4;
        private Label label5;
        private NumericUpDown priceNum;
        private Label label6;
        private Button butDelete;
        private DateTimePicker dateTimePicker;
        private ComboBox comboCountry;
        private Label label7;
    }
}
