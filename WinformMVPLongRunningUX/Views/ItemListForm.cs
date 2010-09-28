using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Serra.Micros.MVP.Interfaces;
using Serra.Micros.MVP.Model;
using Serra.Micros.MVP.Presenters;

namespace Serra.Micros.MVP.Views
{
    public partial class ItemListForm : Form, IItemListView
    {
        public ItemListForm()
        {
            InitializeComponent();
        }

        private IItemListPresenter _presenter;

        private void ItemListForm_Load(object sender, EventArgs e)
        {
            _presenter = new ItemListPresenter(this);
            _presenter.Start();
        }

        public void ShowBusy()
        {
            Text = string.Format("Busy");
            startLoadingButton.Enabled = false;
        }

        public void ClearResults()
        {
            itemLlistBox.Items.Clear();
        }

        public void AddResults(Item[] itemsToAdd)
        {
            throw new NotImplementedException();
        }

        public void ShowStartOfNewSession()
        {
            startLoadingButton.Text = @"Start new";
            startLoadingButton.Enabled = true;
        }

        public void SetReadyToStartSession()
        {
            startLoadingButton.Enabled = true;
            startLoadingButton.Text = @"Start";
        }

        private void startLoadingButton_Click(object sender, EventArgs e)
        {
            _presenter.StartLoadingItemsSession();
        }
    }
}
