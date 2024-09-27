using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShoppingListSample.WinForms
{
    partial class ShoppingListForm
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
            itemsDataGridView = new DataGridView();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isCompleteDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            DeleteColumn = new DataGridViewButtonColumn();
            itemBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            nameTextBox = new TextBox();
            label2 = new Label();
            categoryComboBox = new ComboBox();
            label1 = new Label();
            addItemButton = new Button();
            ((System.ComponentModel.ISupportInitialize)itemsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // itemsDataGridView
            // 
            itemsDataGridView.AllowUserToAddRows = false;
            itemsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemsDataGridView.AutoGenerateColumns = false;
            itemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsDataGridView.Columns.AddRange(new DataGridViewColumn[] { categoryDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, isCompleteDataGridViewCheckBoxColumn, DeleteColumn });
            itemsDataGridView.DataSource = itemBindingSource;
            itemsDataGridView.Location = new Point(0, 130);
            itemsDataGridView.Margin = new Padding(4, 5, 4, 5);
            itemsDataGridView.MultiSelect = false;
            itemsDataGridView.Name = "itemsDataGridView";
            itemsDataGridView.RowHeadersWidth = 62;
            itemsDataGridView.ShowEditingIcon = false;
            itemsDataGridView.Size = new Size(1002, 582);
            itemsDataGridView.TabIndex = 0;
            itemsDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // isCompleteDataGridViewCheckBoxColumn
            // 
            isCompleteDataGridViewCheckBoxColumn.DataPropertyName = "IsComplete";
            isCompleteDataGridViewCheckBoxColumn.HeaderText = "Purchased";
            isCompleteDataGridViewCheckBoxColumn.MinimumWidth = 8;
            isCompleteDataGridViewCheckBoxColumn.Name = "isCompleteDataGridViewCheckBoxColumn";
            isCompleteDataGridViewCheckBoxColumn.Width = 150;
            // 
            // DeleteColumn
            // 
            DeleteColumn.HeaderText = "Delete Item";
            DeleteColumn.MinimumWidth = 50;
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.Resizable = DataGridViewTriState.False;
            DeleteColumn.Text = "Delete";
            DeleteColumn.ToolTipText = "Delete Item";
            DeleteColumn.Width = 150;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Shared.Item);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(categoryComboBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(addItemButton);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1002, 120);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Item";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(416, 61);
            nameTextBox.Margin = new Padding(4, 5, 4, 5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(396, 31);
            nameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(111, 59);
            categoryComboBox.Margin = new Padding(4, 5, 4, 5);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(210, 33);
            categoryComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 1;
            label1.Text = "Category";
            // 
            // addItemButton
            // 
            addItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addItemButton.Location = new Point(840, 57);
            addItemButton.Margin = new Padding(4, 5, 4, 5);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(146, 38);
            addItemButton.TabIndex = 0;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += addItemButton_Click;
            // 
            // ShoppingListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 712);
            Controls.Add(groupBox1);
            Controls.Add(itemsDataGridView);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(800, 600);
            Name = "ShoppingListForm";
            Text = "Shopping List";
            ((System.ComponentModel.ISupportInitialize)itemsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView itemsDataGridView;
        private GroupBox groupBox1;
        private BindingSource itemBindingSource;
        private Button addItemButton;
        private TextBox nameTextBox;
        private Label label2;
        private ComboBox categoryComboBox;
        private Label label1;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isCompleteDataGridViewCheckBoxColumn;
        private DataGridViewButtonColumn DeleteColumn;
    }
}
