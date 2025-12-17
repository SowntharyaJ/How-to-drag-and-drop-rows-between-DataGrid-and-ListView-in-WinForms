using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using System.Collections;

namespace DragDropBetweenControls
{
    public partial class Form1 : Form
    {
        private readonly OrderInfoCollection _vm = new OrderInfoCollection();

        public Form1()
        {
            InitializeComponent();
            
            this.sfDataGrid1.DataSource = _vm.Collection1;
            this.sfDataGrid1.AutoGenerateColumns = true;

            // Load initial data into ListView from second collection
            LoadOrders(_vm.Collection2);

            // Wire drag-drop events
            listView1.ItemDrag += ListView1_ItemDrag;
            listView1.DragEnter += ListView1_DragEnter;
            listView1.DragDrop += listView1_DragDrop;
            sfDataGrid1.RowDragDropController.Drop += RowDragDropController_Drop;
        }

        

        private void RowDragDropController_Drop(object sender, GridRowDropEventArgs e)
        {
            if (e.IsFromOutsideSource)
            {
                var draggedOrders = new List<OrderInfo>();
                if (e.Data is IDataObject dataObject)
                {
                    if (dataObject.GetDataPresent(typeof(ListViewItem)))
                    {
                        var listViewItems = dataObject.GetData(typeof(ListViewItem)) as ListViewItem;
                        if (listViewItems?.Tag is OrderInfo orderFromTag)
                            draggedOrders.Add(orderFromTag);
                    }
                }

                var collection = sfDataGrid1.View?.SourceCollection as IList;
                if (collection == null)
                    return;

                int targetRowIndex = sfDataGrid1.TableControl.ResolveToRowIndex(e.TargetRecord as OrderInfo);
                int recordIndex = sfDataGrid1.TableControl.ResolveToRecordIndex(targetRowIndex);
                int insertIndex = (e.DropPosition == DropPosition.DropAbove) ? recordIndex + 1 : recordIndex;

                foreach (var order in draggedOrders)
                {
                    collection.Insert(insertIndex, order);
                    insertIndex++;
                }

                foreach (var order in draggedOrders)
                {
                    var toRemove = listView1.Items
                        .Cast<ListViewItem>()
                        .FirstOrDefault(i => ReferenceEquals(i.Tag, order));
                    if (toRemove != null)
                        listView1.Items.Remove(toRemove);
                }
            }
        }

        private void ListView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void ListView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var item = (ListViewItem)e.Item;
            listView1.DoDragDrop(item, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            var droppedRecords = new List<OrderInfo>();
            var draggedListViewItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            // Track whether the source is SfDataGrid
            bool isFromDataGrid = false;
            if (e.Data.GetDataPresent("Records"))
            {
                isFromDataGrid = true;
                var data = e.Data.GetData("Records");
                if (data is OrderInfo order)
                {
                    droppedRecords.Add(order);
                }
                else if (data is System.Collections.IEnumerable sequence)
                {
                    foreach (var item in sequence)
                        if (item is OrderInfo orderInSequence)
                            droppedRecords.Add(orderInSequence);
                }
            }

            // If dragged from ListView, remove the original item
            if (draggedListViewItem != null)
            {
                if (draggedListViewItem.Tag is OrderInfo orderFromTag)
                    droppedRecords.Add(orderFromTag);
                listView1.Items.Remove(draggedListViewItem);
            }

            // Insert into ListView
            foreach (var order in droppedRecords)
            {
                listView1.Items.Add(new ListViewItem(order.ShipCountry ?? string.Empty) { Tag = order });
            }

            // If the records came from SfDataGrid, remove them from the grid's source
            if (isFromDataGrid)
            {
                var source = sfDataGrid1.View?.SourceCollection as System.Collections.IList;
                if (source != null)
                {
                    foreach (var order in droppedRecords)
                    {
                        if (source.Contains(order))
                            source.Remove(order);
                    }
                }
            }
        }

        private void LoadOrders(IEnumerable<OrderInfo> orders)
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();
            foreach (var o in orders)
            {
                var item = new ListViewItem(o.ShipCountry ?? string.Empty) { Tag = o };
                listView1.Items.Add(item);
            }
            listView1.EndUpdate();
        }
    }
}
