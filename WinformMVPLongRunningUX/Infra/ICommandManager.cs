using System;

namespace Serra.Micros.MVP.Infra
{
    public interface ICommandManager
    {
        void Post(Action action);
    }
}