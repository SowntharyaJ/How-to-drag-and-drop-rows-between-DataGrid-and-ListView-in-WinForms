
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;

namespace DragDropBetweenControls
{
    partial class Form1
    {
        private IContainer components = null;

        private Label labelSfGrid;
        private Label labelListView;

        private SfDataGrid sfDataGrid1;
        private ListView listView1;
        private ColumnHeader columnHeaderShipCountry;

        // Responsive containers
        private TableLayoutPanel rootTable;        // 1 row, 2 columns 
        private Panel leftPanel;                   // holds label + grid
        private Panel rightPanel;                  // holds label + listview

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();

            this.labelSfGrid = new Label();
            this.labelListView = new Label();

            this.sfDataGrid1 = new SfDataGrid();
            this.listView1 = new ListView();
            this.columnHeaderShipCountry = new ColumnHeader();

            this.rootTable = new TableLayoutPanel();
            this.leftPanel = new Panel();
            this.rightPanel = new Panel();

            ((ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();

            // ---- Form DPI settings ----
            this.AutoScaleDimensions = new SizeF(96F, 96F); // 100% baseline
            this.AutoScaleMode = AutoScaleMode.Dpi;

            // ---- Root table: 1 row, 2 columns  ----
            this.rootTable.Dock = DockStyle.Fill;
            this.rootTable.ColumnCount = 2;
            this.rootTable.RowCount = 1;
            this.rootTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            this.rootTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.rootTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.rootTable.Padding = new Padding(12);

            // ---- Left panel (label + grid) ----
            this.leftPanel.Dock = DockStyle.Fill;
            this.leftPanel.Padding = new Padding(0, 0, 8, 0); // small gap to right

            // labelSfGrid
            this.labelSfGrid.AutoSize = true;
            this.labelSfGrid.Text = "SfDataGrid";
            this.labelSfGrid.Font = new Font("Microsoft Sans Serif", 10F);
            this.labelSfGrid.ForeColor = SystemColors.HotTrack;
            this.labelSfGrid.Dock = DockStyle.Top;
            this.labelSfGrid.Padding = new Padding(0, 0, 0, 6);

            // sfDataGrid1
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowDraggingColumns = true;
            this.sfDataGrid1.AllowDraggingRows = true;
            this.sfDataGrid1.AllowDrop = true;
            this.sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Multiple;
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.Dock = DockStyle.Fill;
            // row heights are scaled in Form1.cs

            // add to left panel
            this.leftPanel.Controls.Add(this.sfDataGrid1);
            this.leftPanel.Controls.Add(this.labelSfGrid);

            // ---- Right panel (label + listview) ----
            this.rightPanel.Dock = DockStyle.Fill;
            this.rightPanel.Padding = new Padding(8, 0, 0, 0); // small gap to left

            // labelListView
            this.labelListView.AutoSize = true;
            this.labelListView.Text = "ListView";
            this.labelListView.Font = new Font("Microsoft Sans Serif", 10F);
            this.labelListView.ForeColor = SystemColors.HotTrack;
            this.labelListView.Dock = DockStyle.Top;
            this.labelListView.Padding = new Padding(0, 0, 0, 6);

            // listView1
            this.listView1.AllowDrop = true;
            this.listView1.BackColor = Color.White;
            this.listView1.Columns.AddRange(new ColumnHeader[] { this.columnHeaderShipCountry });
            this.listView1.Font = new Font("Segoe UI", 10F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.listView1.MultiSelect = false;
            this.listView1.View = View.Details;
            this.listView1.Dock = DockStyle.Fill;

            // columnHeaderShipCountry
            this.columnHeaderShipCountry.Text = "Ship Country";
            this.columnHeaderShipCountry.Width = 440;

            // add to right panel
            this.rightPanel.Controls.Add(this.listView1);
            this.rightPanel.Controls.Add(this.labelListView);

            // ---- Add panels to root table ----
            this.rootTable.Controls.Add(this.leftPanel, 0, 0);
            this.rootTable.Controls.Add(this.rightPanel, 1, 0);

            // ---- Form ----
            this.Font = new Font("Segoe UI", 9F);
            this.BackColor = SystemColors.Window;
            this.ClientSize = new Size(1344, 740);
            this.MinimumSize = new Size(659, 477);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Drag and Drop";
            this.WindowState = FormWindowState.Maximized;

            // Add root table
            this.Controls.Add(this.rootTable);

            ((ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
