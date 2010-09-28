using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serra.Micros.MVP.Interfaces
{
    interface IItemListPresenter
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
