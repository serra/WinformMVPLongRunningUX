namespace Serra.Micros.MVP.Interfaces
{
    internal interface IItemListPresenter
    {
        /// <summary>
        /// Start a new loading session.
        /// Discards any running sessions.
        /// </summary>
        void StartLoadingItemsSession();

        /// <summary>
        /// Flag that the view is ready get calls from the presenters.
        /// </summary>
        void Start();
    }
}