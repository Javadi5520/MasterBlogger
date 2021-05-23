using System;

namespace _01_Framwork.Infrastructure
{
    public interface IUnitOfWork
    {
        void BeginTran();
        void CommitTran();
        void Rollback();
    }
}