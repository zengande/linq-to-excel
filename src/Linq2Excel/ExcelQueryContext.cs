using NPOI.SS.UserModel;
using System;

namespace Linq2Excel
{
    public class ExcelQueryContext
    {
        private readonly IWorkbook _workbook;
        public ExcelQueryContext(IWorkbook workbook)
        {
            _workbook = workbook;
        }

        public static ExcelQueryContext CreateQueryContext(IWorkbook workbook)
        {
            return new ExcelQueryContext(workbook);
        }

        public ExcelQueryable<T> Sheet<T>()
        {
            return new ExcelQueryable<T>(new ExcelQueryProvider());
        }
    }
}
