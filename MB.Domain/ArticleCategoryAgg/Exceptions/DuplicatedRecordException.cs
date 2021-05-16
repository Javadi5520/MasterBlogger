using System;
using System.Runtime.Serialization;

namespace MB.Domain.ArticleCategoryAgg.Exceptions
{
    public class DuplicatedRecordException : Exception
    {
        public DuplicatedRecordException()
        {
        }

        public DuplicatedRecordException(string message) : base(message)
        {
        }
    }
}