using Serra.Micros.MVP.Model;

namespace Serra.Micros.MVP.Interfaces
{
    internal interface IItemListView
    {
        void ShowProgress(int progress, int progressMax);
        void AddResults(Item[] itemsToAdd);
        void ShowStartOfNewSession();
        void SetReadyToStartSession();
    }
}