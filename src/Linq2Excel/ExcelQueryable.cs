using Linq2Excel.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Linq2Excel
{
    public class ExcelQueryable<T> : IQueryable<T>
    {
        private readonly ExcelQueryProvider _provider;

        public ExcelQueryable(ExcelQueryProvider provider)
        {
            Checker.NotNull(provider, nameof(provider));

            _provider = provider;
        }

        #region override
        public Type ElementType => typeof(T);

        public Expression Expression { get; }

        public IQueryProvider Provider => _provider;

        public IEnumerator<T> GetEnumerator() =>
            (_provider.Execute(Expression) as IEnumerable<T>)?.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() =>
            (_provider.Execute(Expression) as IEnumerable)?.GetEnumerator();
        #endregion
    }
}
