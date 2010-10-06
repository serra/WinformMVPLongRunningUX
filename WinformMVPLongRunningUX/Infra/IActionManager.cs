using System;

namespace Serra.Micros.MVP.Infra
{
    public interface IActionManager
    {
        void Post(Action action);
    }
}