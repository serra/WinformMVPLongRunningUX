using System.Collections.Generic;
using System.Threading;
using Serra.Micros.MVP.Infra;
using Serra.Micros.MVP.Interfaces;
using Serra.Micros.MVP.Model;

namespace Serra.Micros.MVP.Presenters
{
    internal class ItemListPresenter : IItemListPresenter
    {
        private readonly SynchronizationContext _syncCtxt;
        private readonly IItemListView _view;
        private readonly ICommandManager _mngr;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// It is assumed that the presenter is created from the thread,
        /// to which view-calls should be synchronized.
        /// </remarks>
        public ItemListPresenter(IItemListView itemListView, ICommandManager cmdManager)
        {
            _view = itemListView;
            _mngr = cmdManager;
            _syncCtxt = SynchronizationContext.Current; // let's assume we're constructed from the UI thread.
        }

        #region IItemListPresenter Members

        public void StartLoadingItemsSession()
        {
            ShowBusy();
            ClearResults();

            _mngr.Post(LoadItems);
        }

        public void Start()
        {
            SetReady();
        }

        #endregion

        /// <summary>
        /// Gets items and updates the view.
        /// </summary>
        private void LoadItems()
        {
            UpdateViewWith(GetItems());
            SetReady();
        }

        private Item[] GetItems()
        {
            var items = new List<Item>();

            for (int i = 1; i < 100; i++)
                items.Add(new Item {SequenceNumber = i, Name = string.Format("item {0:0000}", i)});

            return items.ToArray();
        }

        #region View update methods
        /// <remarks>
        /// Synchronizes the view update to _syncCtxt.
        /// </remarks>
        private void UpdateViewWith(Item[] newItems)
        {
            _syncCtxt.Post(state => _view.AddResults(newItems), newItems);
        }

        /// <remarks>
        /// Synchronizes the view update to _syncCtxt.
        /// </remarks>        
        private void ShowBusy()
        {
            _syncCtxt.Post(state => _view.ShowBusy(), null);
        }

        /// <remarks>
        /// Synchronizes the view update to _syncCtxt.
        /// </remarks>
        private void ClearResults()
        {
            _syncCtxt.Post(state => _view.ClearResults(), null);
        }

        /// <remarks>
        /// Synchronizes the view update to _syncCtxt.
        /// </remarks>
        private void SetReady()
        {
            _syncCtxt.Post(state => _view.SetReady(), null);
        }
        #endregion
    }
}