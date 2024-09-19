using System;

namespace Base.ObjectsPool
{
    public interface IPoolObject
    {
        event Action<IPoolObject> OnObjectNeededToDeactivate;
        void ResetBeforeBackToPool();
    }
}
