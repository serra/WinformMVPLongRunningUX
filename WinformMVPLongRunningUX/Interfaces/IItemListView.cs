using Serra.Micros.MVP.Model;

namespace Serra.Micros.MVP.Interfaces
{
    internal interface IItemListView
    {
        void ShowBusy();
        void ClearResults();
        void AddResults(Item[] itemsToAdd);
        void ShowStartOfNewSession();
        void SetReadyToStartSession();
    }
}