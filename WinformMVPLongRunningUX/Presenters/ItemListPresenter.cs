using System;
using Serra.Micros.MVP.Interfaces;

namespace Serra.Micros.MVP.Presenters
{
    internal class ItemListPresenter : IItemListPresenter
    {
        private IItemListView _view;

        public ItemListPresenter(IItemListView itemListView)
        {
            _view = itemListView;

        }

        public void StartLoadingItemsSessions()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            _view.SetReadyToStartSession();
        }
    }
}