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

        public void ShowProgress(int progress, int progressMax)
        {
            throw new NotImplementedException();
        }

        public void AddResults(Item[] itemsToAdd)
        {
            throw new NotImplementedException();
        }

        public void ShowStartOfNewSession()
        {
            throw new NotImplementedException();
        }

        public void SetReadyToStartSession()
        {
            startLoadingButton.Enabled = true;
        }
    }
}
