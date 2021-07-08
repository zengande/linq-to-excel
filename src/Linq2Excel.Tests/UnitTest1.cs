using NPOI.SS.UserModel;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace Linq2Excel.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using var fileStream = new FileStream(@"D:\Users\Desktop\AdministrativeClassStudentTemplate.xlsx", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var workbook = WorkbookFactory.Create(fileStream);

            var query = new ExcelQueryContext(workbook);
            var list = from a in query.Sheet<DataModel>()
                       //where a.Name.Length > 2
                       select a;
        }
    }

    public class DataModel
    {
        public string Name { get; set; }
    }
}
