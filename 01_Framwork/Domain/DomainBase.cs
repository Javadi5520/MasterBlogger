using System;

namespace _01_Framwork.Domain
{
    public class DomainBase<T>
    {
        public T Id { get; set; }
        public DateTime CreationDate { get; private set; }

        public DomainBase()
        {
            CreationDate = DateTime.Now;
        }
    }
}