namespace Coursework_EF_Test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.workerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aObjNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aInvNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUsageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerIdWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerNavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWorkerDataGridViewTextBoxColumn,
            this.wNameDataGridViewTextBoxColumn,
            this.wPositionDataGridViewTextBoxColumn,
            this.wSexDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(520, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAccountDataGridViewTextBoxColumn,
            this.aPlaceDataGridViewTextBoxColumn,
            this.aObjNameDataGridViewTextBoxColumn,
            this.aInvNumDataGridViewTextBoxColumn,
            this.aDateDataGridViewTextBoxColumn,
            this.aUsageDataGridViewTextBoxColumn,
            this.aPriceDataGridViewTextBoxColumn,
            this.aCountDataGridViewTextBoxColumn,
            this.aSumDataGridViewTextBoxColumn,
            this.aStatusDataGridViewTextBoxColumn,
            this.workerIdWorkerDataGridViewTextBoxColumn,
            this.workerNavDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.accountBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(21, 347);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(520, 225);
            this.dataGridView2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workerToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // workerToolStripMenuItem
            // 
            this.workerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.workerToolStripMenuItem.Name = "workerToolStripMenuItem";
            this.workerToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.workerToolStripMenuItem.Text = "Worker";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.addToolStripMenuItem1.Text = "Add";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(604, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(604, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(604, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Изменить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(604, 425);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Сотрудники";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поиск по ФИО";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Инвентарь";
            // 
            // idAccountDataGridViewTextBoxColumn
            // 
            this.idAccountDataGridViewTextBoxColumn.DataPropertyName = "Id_Account";
            this.idAccountDataGridViewTextBoxColumn.HeaderText = "Id_Account";
            this.idAccountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAccountDataGridViewTextBoxColumn.Name = "idAccountDataGridViewTextBoxColumn";
            this.idAccountDataGridViewTextBoxColumn.Width = 125;
            // 
            // aPlaceDataGridViewTextBoxColumn
            // 
            this.aPlaceDataGridViewTextBoxColumn.DataPropertyName = "APlace";
            this.aPlaceDataGridViewTextBoxColumn.HeaderText = "APlace";
            this.aPlaceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aPlaceDataGridViewTextBoxColumn.Name = "aPlaceDataGridViewTextBoxColumn";
            this.aPlaceDataGridViewTextBoxColumn.Width = 125;
            // 
            // aObjNameDataGridViewTextBoxColumn
            // 
            this.aObjNameDataGridViewTextBoxColumn.DataPropertyName = "AObjName";
            this.aObjNameDataGridViewTextBoxColumn.HeaderText = "AObjName";
            this.aObjNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aObjNameDataGridViewTextBoxColumn.Name = "aObjNameDataGridViewTextBoxColumn";
            this.aObjNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // aInvNumDataGridViewTextBoxColumn
            // 
            this.aInvNumDataGridViewTextBoxColumn.DataPropertyName = "AInvNum";
            this.aInvNumDataGridViewTextBoxColumn.HeaderText = "AInvNum";
            this.aInvNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aInvNumDataGridViewTextBoxColumn.Name = "aInvNumDataGridViewTextBoxColumn";
            this.aInvNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDateDataGridViewTextBoxColumn
            // 
            this.aDateDataGridViewTextBoxColumn.DataPropertyName = "ADate";
            this.aDateDataGridViewTextBoxColumn.HeaderText = "ADate";
            this.aDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDateDataGridViewTextBoxColumn.Name = "aDateDataGridViewTextBoxColumn";
            this.aDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // aUsageDataGridViewTextBoxColumn
            // 
            this.aUsageDataGridViewTextBoxColumn.DataPropertyName = "AUsage";
            this.aUsageDataGridViewTextBoxColumn.HeaderText = "AUsage";
            this.aUsageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aUsageDataGridViewTextBoxColumn.Name = "aUsageDataGridViewTextBoxColumn";
            this.aUsageDataGridViewTextBoxColumn.Width = 125;
            // 
            // aPriceDataGridViewTextBoxColumn
            // 
            this.aPriceDataGridViewTextBoxColumn.DataPropertyName = "APrice";
            this.aPriceDataGridViewTextBoxColumn.HeaderText = "APrice";
            this.aPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aPriceDataGridViewTextBoxColumn.Name = "aPriceDataGridViewTextBoxColumn";
            this.aPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCountDataGridViewTextBoxColumn
            // 
            this.aCountDataGridViewTextBoxColumn.DataPropertyName = "ACount";
            this.aCountDataGridViewTextBoxColumn.HeaderText = "ACount";
            this.aCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCountDataGridViewTextBoxColumn.Name = "aCountDataGridViewTextBoxColumn";
            this.aCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // aSumDataGridViewTextBoxColumn
            // 
            this.aSumDataGridViewTextBoxColumn.DataPropertyName = "ASum";
            this.aSumDataGridViewTextBoxColumn.HeaderText = "ASum";
            this.aSumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aSumDataGridViewTextBoxColumn.Name = "aSumDataGridViewTextBoxColumn";
            this.aSumDataGridViewTextBoxColumn.Width = 125;
            // 
            // aStatusDataGridViewTextBoxColumn
            // 
            this.aStatusDataGridViewTextBoxColumn.DataPropertyName = "AStatus";
            this.aStatusDataGridViewTextBoxColumn.HeaderText = "AStatus";
            this.aStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aStatusDataGridViewTextBoxColumn.Name = "aStatusDataGridViewTextBoxColumn";
            this.aStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // workerIdWorkerDataGridViewTextBoxColumn
            // 
            this.workerIdWorkerDataGridViewTextBoxColumn.DataPropertyName = "WorkerId_Worker";
            this.workerIdWorkerDataGridViewTextBoxColumn.HeaderText = "WorkerId_Worker";
            this.workerIdWorkerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workerIdWorkerDataGridViewTextBoxColumn.Name = "workerIdWorkerDataGridViewTextBoxColumn";
            this.workerIdWorkerDataGridViewTextBoxColumn.Width = 125;
            // 
            // workerNavDataGridViewTextBoxColumn
            // 
            this.workerNavDataGridViewTextBoxColumn.DataPropertyName = "WorkerNav";
            this.workerNavDataGridViewTextBoxColumn.HeaderText = "WorkerNav";
            this.workerNavDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workerNavDataGridViewTextBoxColumn.Name = "workerNavDataGridViewTextBoxColumn";
            this.workerNavDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(Coursework_EF_Test.Entities.Account);
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataSource = typeof(Coursework_EF_Test.Entities.Worker);
            // 
            // idWorkerDataGridViewTextBoxColumn
            // 
            this.idWorkerDataGridViewTextBoxColumn.DataPropertyName = "Id_Worker";
            this.idWorkerDataGridViewTextBoxColumn.HeaderText = "Id_Worker";
            this.idWorkerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idWorkerDataGridViewTextBoxColumn.Name = "idWorkerDataGridViewTextBoxColumn";
            this.idWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idWorkerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idWorkerDataGridViewTextBoxColumn.Width = 125;
            // 
            // wNameDataGridViewTextBoxColumn
            // 
            this.wNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wNameDataGridViewTextBoxColumn.DataPropertyName = "WName";
            this.wNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.wNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wNameDataGridViewTextBoxColumn.Name = "wNameDataGridViewTextBoxColumn";
            this.wNameDataGridViewTextBoxColumn.Width = 74;
            // 
            // wPositionDataGridViewTextBoxColumn
            // 
            this.wPositionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wPositionDataGridViewTextBoxColumn.DataPropertyName = "WPosition";
            this.wPositionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.wPositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wPositionDataGridViewTextBoxColumn.Name = "wPositionDataGridViewTextBoxColumn";
            this.wPositionDataGridViewTextBoxColumn.Width = 119;
            // 
            // wSexDataGridViewTextBoxColumn
            // 
            this.wSexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wSexDataGridViewTextBoxColumn.DataPropertyName = "WSex";
            this.wSexDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.wSexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wSexDataGridViewTextBoxColumn.Name = "wSexDataGridViewTextBoxColumn";
            this.wSexDataGridViewTextBoxColumn.Width = 66;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 593);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Инвентарный учёт";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem workerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aObjNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aInvNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUsageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIdWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerNavDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wSexDataGridViewTextBoxColumn;
    }
}

