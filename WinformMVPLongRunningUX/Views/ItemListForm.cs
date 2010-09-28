using System;
using System.Windows.Forms;
using Serra.Micros.MVP.Interfaces;
using Serra.Micros.MVP.Model;
using Serra.Micros.MVP.Presenters;

namespace Serra.Micros.MVP.Views
{
    public partial class ItemListForm : Form, IItemListView
    {
        private IItemListPresenter _presenter;

        public ItemListForm()
        {
            InitializeComponent();
        }

        #region IItemListView Members

        public void ShowBusy()
        {
            Text = @"Busy ...";
            startLoadingButton.Enabled = false;
        }

        public void ClearResults()
        {
            itemLlistBox.Items.Clear();
        }

        public void AddResults(Item[] itemsToAdd)
        {
            itemLlistBox.Items.AddRange(itemsToAdd);
        }

        public void SetReady()
        {
            Text = @"Ready";
            startLoadingButton.Enabled = true;
        }

        #endregion

        private void ItemListFormLoad(object sender, EventArgs e)
        {
            _presenter = new ItemListPresenter(this);
            _presenter.Start();
        }

        private void StartLoadingButtonClick(object sender, EventArgs e)
        {
            _presenter.StartLoadingItemsSession();
        }
    }
}