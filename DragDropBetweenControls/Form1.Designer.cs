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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            label1 = new Label();
            listView1 = new ListView();
            columnHeaderShipCountry = new ColumnHeader();
            sfDataGrid1 = new SfDataGrid();
            label2 = new Label();
            ((ISupportInitialize)sfDataGrid1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(101, 95);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 1;
            label1.Text = "SfDataGrid";
            // 
            // listView1
            // 
            listView1.AllowDrop = true;
            listView1.BackColor = Color.White;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderShipCountry });
            listView1.Font = new Font("Segoe UI", 10F);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(1318, 122);
            listView1.Margin = new Padding(7, 8, 7, 8);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(313, 545);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeaderShipCountry
            // 
            columnHeaderShipCountry.Text = "Ship Country";
            columnHeaderShipCountry.Width = 270;
            // 
            // sfDataGrid1
            // 
            sfDataGrid1.AccessibleName = "Table";
            sfDataGrid1.AllowDraggingColumns = true;
            sfDataGrid1.AllowDraggingRows = true;
            sfDataGrid1.AllowDrop = true;
            sfDataGrid1.AllowFiltering = true;
            sfDataGrid1.AllowResizingColumns = true;
            sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            sfDataGrid1.Location = new Point(101, 122);
            sfDataGrid1.Margin = new Padding(7, 8, 7, 8);
            sfDataGrid1.Name = "sfDataGrid1";
            sfDataGrid1.PreviewRowHeight = 35;
            sfDataGrid1.RowHeight = 24;
            sfDataGrid1.SelectionMode = GridSelectionMode.Multiple;
            sfDataGrid1.ShowGroupDropArea = true;
            sfDataGrid1.Size = new Size(1150, 545);
            sfDataGrid1.Style.DragPreviewRowStyle.Font = new Font("Segoe UI", 9F);
            sfDataGrid1.TabIndex = 0;
            sfDataGrid1.Text = "sfDataGrid1";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(1318, 95);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "ListView";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1344, 740);
            Controls.Add(listView1);
            Controls.Add(sfDataGrid1);
            Controls.Add(label2);
            Controls.Add(label1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MinimumSize = new System.Drawing.Size(659, 477);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drag and Drop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeaderShipCountry;
        private SfDataGrid sfDataGrid1;
        private Label label2;
    }
}

