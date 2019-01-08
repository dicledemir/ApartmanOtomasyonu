namespace ApartmanOtomasyonu
{
    partial class frmtransactions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpIncomes = new System.Windows.Forms.TabPage();
            this.dgwIncomes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbInComesAmount = new System.Windows.Forms.TextBox();
            this.dtpIncomesDate = new System.Windows.Forms.DateTimePicker();
            this.nudRoomsNo = new System.Windows.Forms.NumericUpDown();
            this.btnInsertInComes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpExpenses = new System.Windows.Forms.TabPage();
            this.dgwExpense = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInsertExpenses = new System.Windows.Forms.Button();
            this.dtpExpensesDate = new System.Windows.Forms.DateTimePicker();
            this.tbExpensesAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbElectricity = new System.Windows.Forms.RadioButton();
            this.rbWater = new System.Windows.Forms.RadioButton();
            this.rbelevator = new System.Windows.Forms.RadioButton();
            this.rbCleaning = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tpIncomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIncomes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomsNo)).BeginInit();
            this.tpExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExpense)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpIncomes);
            this.tabControl1.Controls.Add(this.tpExpenses);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 418);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.frmtransactions_Load);
            // 
            // tpIncomes
            // 
            this.tpIncomes.Controls.Add(this.dgwIncomes);
            this.tpIncomes.Controls.Add(this.groupBox1);
            this.tpIncomes.Location = new System.Drawing.Point(4, 25);
            this.tpIncomes.Name = "tpIncomes";
            this.tpIncomes.Padding = new System.Windows.Forms.Padding(3);
            this.tpIncomes.Size = new System.Drawing.Size(655, 389);
            this.tpIncomes.TabIndex = 0;
            this.tpIncomes.Text = "Gelirler";
            this.tpIncomes.UseVisualStyleBackColor = true;
            // 
            // dgwIncomes
            // 
            this.dgwIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIncomes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwIncomes.Location = new System.Drawing.Point(3, 236);
            this.dgwIncomes.Name = "dgwIncomes";
            this.dgwIncomes.RowTemplate.Height = 24;
            this.dgwIncomes.Size = new System.Drawing.Size(649, 150);
            this.dgwIncomes.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbInComesAmount);
            this.groupBox1.Controls.Add(this.dtpIncomesDate);
            this.groupBox1.Controls.Add(this.nudRoomsNo);
            this.groupBox1.Controls.Add(this.btnInsertInComes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(555, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Aidat ekle";
            // 
            // tbInComesAmount
            // 
            this.tbInComesAmount.Location = new System.Drawing.Point(105, 95);
            this.tbInComesAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbInComesAmount.Name = "tbInComesAmount";
            this.tbInComesAmount.Size = new System.Drawing.Size(132, 22);
            this.tbInComesAmount.TabIndex = 6;
            this.tbInComesAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInComesAmount_KeyPress);
            // 
            // dtpIncomesDate
            // 
            this.dtpIncomesDate.Location = new System.Drawing.Point(357, 36);
            this.dtpIncomesDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpIncomesDate.Name = "dtpIncomesDate";
            this.dtpIncomesDate.Size = new System.Drawing.Size(179, 22);
            this.dtpIncomesDate.TabIndex = 5;
            // 
            // nudRoomsNo
            // 
            this.nudRoomsNo.Location = new System.Drawing.Point(105, 36);
            this.nudRoomsNo.Margin = new System.Windows.Forms.Padding(4);
            this.nudRoomsNo.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudRoomsNo.Name = "nudRoomsNo";
            this.nudRoomsNo.Size = new System.Drawing.Size(103, 22);
            this.nudRoomsNo.TabIndex = 4;
            // 
            // btnInsertInComes
            // 
            this.btnInsertInComes.Location = new System.Drawing.Point(296, 95);
            this.btnInsertInComes.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertInComes.Name = "btnInsertInComes";
            this.btnInsertInComes.Size = new System.Drawing.Size(241, 28);
            this.btnInsertInComes.TabIndex = 3;
            this.btnInsertInComes.Text = "Ekle";
            this.btnInsertInComes.UseVisualStyleBackColor = true;
            this.btnInsertInComes.Click += new System.EventHandler(this.btnInsertInComes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tutar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daire No:";
            // 
            // tpExpenses
            // 
            this.tpExpenses.Controls.Add(this.dgwExpense);
            this.tpExpenses.Controls.Add(this.groupBox2);
            this.tpExpenses.Location = new System.Drawing.Point(4, 25);
            this.tpExpenses.Name = "tpExpenses";
            this.tpExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpExpenses.Size = new System.Drawing.Size(655, 389);
            this.tpExpenses.TabIndex = 1;
            this.tpExpenses.Text = "Giderler";
            this.tpExpenses.UseVisualStyleBackColor = true;
            // 
            // dgwExpense
            // 
            this.dgwExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwExpense.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwExpense.Location = new System.Drawing.Point(3, 236);
            this.dgwExpense.Name = "dgwExpense";
            this.dgwExpense.RowTemplate.Height = 24;
            this.dgwExpense.Size = new System.Drawing.Size(649, 150);
            this.dgwExpense.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCleaning);
            this.groupBox2.Controls.Add(this.rbelevator);
            this.groupBox2.Controls.Add(this.rbWater);
            this.groupBox2.Controls.Add(this.rbElectricity);
            this.groupBox2.Controls.Add(this.btnInsertExpenses);
            this.groupBox2.Controls.Add(this.dtpExpensesDate);
            this.groupBox2.Controls.Add(this.tbExpensesAmount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(639, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Gider Ekle";
            // 
            // btnInsertExpenses
            // 
            this.btnInsertExpenses.Location = new System.Drawing.Point(215, 170);
            this.btnInsertExpenses.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertExpenses.Name = "btnInsertExpenses";
            this.btnInsertExpenses.Size = new System.Drawing.Size(273, 28);
            this.btnInsertExpenses.TabIndex = 8;
            this.btnInsertExpenses.Text = "Ekle";
            this.btnInsertExpenses.UseVisualStyleBackColor = true;
            this.btnInsertExpenses.Click += new System.EventHandler(this.btnInsertExpenses_Click);
            // 
            // dtpExpensesDate
            // 
            this.dtpExpensesDate.Location = new System.Drawing.Point(289, 98);
            this.dtpExpensesDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpensesDate.Name = "dtpExpensesDate";
            this.dtpExpensesDate.Size = new System.Drawing.Size(199, 22);
            this.dtpExpensesDate.TabIndex = 7;
            // 
            // tbExpensesAmount
            // 
            this.tbExpensesAmount.Location = new System.Drawing.Point(295, 46);
            this.tbExpensesAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbExpensesAmount.Name = "tbExpensesAmount";
            this.tbExpensesAmount.Size = new System.Drawing.Size(132, 22);
            this.tbExpensesAmount.TabIndex = 6;
            this.tbExpensesAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbExpensesAmount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tutar:";
            // 
            // rbElectricity
            // 
            this.rbElectricity.AutoSize = true;
            this.rbElectricity.Location = new System.Drawing.Point(17, 37);
            this.rbElectricity.Name = "rbElectricity";
            this.rbElectricity.Size = new System.Drawing.Size(82, 21);
            this.rbElectricity.TabIndex = 9;
            this.rbElectricity.TabStop = true;
            this.rbElectricity.Text = "Elektirik:";
            this.rbElectricity.UseVisualStyleBackColor = true;
            // 
            // rbWater
            // 
            this.rbWater.AutoSize = true;
            this.rbWater.Location = new System.Drawing.Point(17, 78);
            this.rbWater.Name = "rbWater";
            this.rbWater.Size = new System.Drawing.Size(46, 21);
            this.rbWater.TabIndex = 10;
            this.rbWater.TabStop = true;
            this.rbWater.Text = "Su";
            this.rbWater.UseVisualStyleBackColor = true;
            // 
            // rbelevator
            // 
            this.rbelevator.AutoSize = true;
            this.rbelevator.Location = new System.Drawing.Point(17, 119);
            this.rbelevator.Name = "rbelevator";
            this.rbelevator.Size = new System.Drawing.Size(81, 21);
            this.rbelevator.TabIndex = 11;
            this.rbelevator.TabStop = true;
            this.rbelevator.Text = "Asansör";
            this.rbelevator.UseVisualStyleBackColor = true;
            // 
            // rbCleaning
            // 
            this.rbCleaning.AutoSize = true;
            this.rbCleaning.Location = new System.Drawing.Point(17, 160);
            this.rbCleaning.Name = "rbCleaning";
            this.rbCleaning.Size = new System.Drawing.Size(80, 21);
            this.rbCleaning.TabIndex = 12;
            this.rbCleaning.TabStop = true;
            this.rbCleaning.Text = "Temizlik";
            this.rbCleaning.UseVisualStyleBackColor = true;
            // 
            // frmtransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 418);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmtransactions";
            this.Text = "frmtransactions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmtransactions_FormClosed);
            this.Load += new System.EventHandler(this.frmtransactions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpIncomes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIncomes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomsNo)).EndInit();
            this.tpExpenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwExpense)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpIncomes;
        private System.Windows.Forms.DataGridView dgwIncomes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbInComesAmount;
        private System.Windows.Forms.DateTimePicker dtpIncomesDate;
        private System.Windows.Forms.NumericUpDown nudRoomsNo;
        private System.Windows.Forms.Button btnInsertInComes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpExpenses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInsertExpenses;
        private System.Windows.Forms.DateTimePicker dtpExpensesDate;
        private System.Windows.Forms.TextBox tbExpensesAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgwExpense;
        private System.Windows.Forms.RadioButton rbCleaning;
        private System.Windows.Forms.RadioButton rbelevator;
        private System.Windows.Forms.RadioButton rbWater;
        private System.Windows.Forms.RadioButton rbElectricity;
    }
}