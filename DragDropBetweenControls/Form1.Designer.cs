using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace DragDropBetweenControls
{
    partial class Form1
    {
        private IContainer components = null;
        private SfDataGrid sfDataGrid1;
        private ListView listView1;
        private TableLayoutPanel tableLayoutPanel1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.sfDataGrid1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(121, 90);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1506, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowDraggingColumns = true;
            this.sfDataGrid1.AllowDraggingRows = true;
            this.sfDataGrid1.AllowDrop = true;
            this.sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(16, 14);
            this.sfDataGrid1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.PreviewRowHeight = 35;
            this.sfDataGrid1.RowHeight = 26;
            this.sfDataGrid1.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Multiple;
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.Size = new System.Drawing.Size(1176, 572);
            this.sfDataGrid1.Style.DragPreviewRowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1206, 14);
            this.listView1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(284, 572);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1833, 740);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MinimumSize = new System.Drawing.Size(659, 477);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drag and Drop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

