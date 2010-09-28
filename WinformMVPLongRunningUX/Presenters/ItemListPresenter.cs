using System;
using System.Collections.Generic;
using System.Threading;
using Serra.Micros.MVP.Interfaces;
using Serra.Micros.MVP.Model;

namespace Serra.Micros.MVP.Presenters
{
    internal class ItemListPresenter : IItemListPresenter
    {
        private IItemListView _view;
        private SynchronizationContext _syncCtxt;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemListView"></param>
        /// <remarks>
        /// It is assumed that the presenter is created from the thread,
        /// to which view-calls should be synchronized.
        /// </remarks>
        public ItemListPresenter(IItemListView itemListView)
        {
            _view = itemListView;
            _syncCtxt = SynchronizationContext.Current; // let's assume we're constructed from the UI thread.
        }

        public void StartLoadingItemsSession()
        {
            _view.ShowStartOfNewSession();
            _view.ClearResults();
            Thread t = new Thread(LoadItems);
            t.Start();
        }

        /// <summary>
        /// Gets items and updates the view.
        /// </summary>
        private void LoadItems()
        {
            // call getitems
            UpdateViewWith(GetItems());
#if DEBUG
            Thread.Sleep(1000);
#endif
        }

        private Item[] GetItems()
        {
            var items = new List<Item>();

            for (int i = 1; i < 100; i++)
                items.Add(new Item() {SequenceNumber = i, Name = string.Format("item {0:0000}", i)});

            return items.ToArray();
        }

        /// <remarks>
        /// Synchronizes the view update to _syncCtxt.
        /// </remarks>
        private void UpdateViewWith(Item[] newItems)
        {
            //_view.AddResults(newItems);
            _syncCtxt.Post(state => _view.AddResults(newItems), newItems);
        }
        /// <remarks>
        /// Synchronizes the view update to _syncCtxt.
        /// </remarks>        
        private void ShowBusy()
        {
            _syncCtxt.Post(state => _view.ShowBusy(), null);
        }

        public void Start()
        {
            _view.SetReadyToStartSession();
        }
    }
}