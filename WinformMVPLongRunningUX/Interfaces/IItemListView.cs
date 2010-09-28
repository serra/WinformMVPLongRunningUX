using Serra.Micros.MVP.Model;

namespace Serra.Micros.MVP.Interfaces
{
    internal interface IItemListView
    {
        /// <summary>
        /// Indicate that a background process is working.
        /// </summary>
        void ShowBusy();

        /// <summary>
        /// Clear the complete result set.
        /// </summary>
        void ClearResults();

        /// <summary>
        /// Append the results to any results add since the last ClearResults() call.
        /// </summary>
        /// <param name="itemsToAdd"></param>
        void AddResults(Item[] itemsToAdd);

        /// <summary>
        /// Show that a session can be started.
        /// </summary>
        void SetReady();
    }
}