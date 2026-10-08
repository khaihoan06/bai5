namespace bai5
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
            splitContainer1 = new SplitContainer();
            tabControlLeft = new TabControl();
            tabPageCustomer = new TabPage();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtCustomerName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageShipping = new TabPage();
            comboShipping = new ComboBox();
            dataGridView1 = new DataGridView();
            colItem = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colWeight = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            toolTime = new ToolStripStatusLabel();
            toolTotalQty = new ToolStripStatusLabel();
            toolTotalWeight = new ToolStripStatusLabel();
            toolTotalAmount = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControlLeft.SuspendLayout();
            tabPageCustomer.SuspendLayout();
            tabPageShipping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControlLeft);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(1225, 418);
            splitContainer1.SplitterDistance = 398;
            splitContainer1.TabIndex = 0;
            // 
            // tabControlLeft
            // 
            tabControlLeft.Controls.Add(tabPageCustomer);
            tabControlLeft.Controls.Add(tabPageShipping);
            tabControlLeft.Dock = DockStyle.Fill;
            tabControlLeft.Location = new Point(0, 0);
            tabControlLeft.Name = "tabControlLeft";
            tabControlLeft.SelectedIndex = 0;
            tabControlLeft.Size = new Size(398, 418);
            tabControlLeft.TabIndex = 0;
            // 
            // tabPageCustomer
            // 
            tabPageCustomer.Controls.Add(txtPhone);
            tabPageCustomer.Controls.Add(txtAddress);
            tabPageCustomer.Controls.Add(txtCustomerName);
            tabPageCustomer.Controls.Add(label3);
            tabPageCustomer.Controls.Add(label2);
            tabPageCustomer.Controls.Add(label1);
            tabPageCustomer.Location = new Point(4, 34);
            tabPageCustomer.Name = "tabPageCustomer";
            tabPageCustomer.Padding = new Padding(3);
            tabPageCustomer.Size = new Size(390, 380);
            tabPageCustomer.TabIndex = 0;
            tabPageCustomer.Text = "Customer";
            tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 197);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(220, 31);
            txtPhone.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 86);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(220, 80);
            txtAddress.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(12, 40);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(220, 31);
            txtCustomerName.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 3;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 4;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 5;
            label1.Text = "Customer Name";
            // 
            // tabPageShipping
            // 
            tabPageShipping.Controls.Add(comboShipping);
            tabPageShipping.Location = new Point(4, 34);
            tabPageShipping.Name = "tabPageShipping";
            tabPageShipping.Padding = new Padding(3);
            tabPageShipping.Size = new Size(252, 388);
            tabPageShipping.TabIndex = 1;
            tabPageShipping.Text = "Shipping";
            tabPageShipping.UseVisualStyleBackColor = true;
            // 
            // comboShipping
            // 
            comboShipping.DropDownStyle = ComboBoxStyle.DropDownList;
            comboShipping.FormattingEnabled = true;
            comboShipping.Items.AddRange(new object[] { "Standard", "Express", "Overnight" });
            comboShipping.Location = new Point(12, 12);
            comboShipping.Name = "comboShipping";
            comboShipping.Size = new Size(220, 33);
            comboShipping.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colItem, colQty, colWeight, colUnitPrice, colAmount });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(823, 418);
            dataGridView1.TabIndex = 0;
            // 
            // colItem
            // 
            colItem.HeaderText = "Item Name";
            colItem.MinimumWidth = 8;
            colItem.Name = "colItem";
            colItem.Width = 160;
            // 
            // colQty
            // 
            colQty.HeaderText = "Quantity";
            colQty.MinimumWidth = 8;
            colQty.Name = "colQty";
            colQty.Width = 150;
            // 
            // colWeight
            // 
            colWeight.HeaderText = "Weight (kg)";
            colWeight.MinimumWidth = 8;
            colWeight.Name = "colWeight";
            colWeight.Width = 150;
            // 
            // colUnitPrice
            // 
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.MinimumWidth = 8;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.Width = 150;
            // 
            // colAmount
            // 
            colAmount.HeaderText = "Amount";
            colAmount.MinimumWidth = 8;
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            colAmount.Width = 150;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolTime, toolTotalQty, toolTotalWeight, toolTotalAmount });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1225, 32);
            statusStrip1.TabIndex = 1;
            // 
            // toolTime
            // 
            toolTime.Name = "toolTime";
            toolTime.Size = new Size(54, 25);
            toolTime.Text = "Time:";
            // 
            // toolTotalQty
            // 
            toolTotalQty.Name = "toolTotalQty";
            toolTotalQty.Size = new Size(102, 25);
            toolTotalQty.Text = "Total Qty: 0";
            // 
            // toolTotalWeight
            // 
            toolTotalWeight.Name = "toolTotalWeight";
            toolTotalWeight.Size = new Size(145, 25);
            toolTotalWeight.Text = "Total Wt: 0.00 kg";
            // 
            // toolTotalAmount
            // 
            toolTotalAmount.Name = "toolTotalAmount";
            toolTotalAmount.Size = new Size(131, 25);
            toolTotalAmount.Text = "Total Amt: 0.00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 450);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Delivery Order Dashboard";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControlLeft.ResumeLayout(false);
            tabPageCustomer.ResumeLayout(false);
            tabPageCustomer.PerformLayout();
            tabPageShipping.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlLeft;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.TabPage tabPageShipping;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboShipping;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolTime;
        private System.Windows.Forms.ToolStripStatusLabel toolTotalQty;
        private System.Windows.Forms.ToolStripStatusLabel toolTotalWeight;
        private System.Windows.Forms.ToolStripStatusLabel toolTotalAmount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        #endregion
    }
}
