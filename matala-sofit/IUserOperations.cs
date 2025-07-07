using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matala_sofit
{
    public interface IUserOperations
    {
        void BorrowBook(Book book, int id);
        void ReturnBook(Book book, int id);
        //browse
    }
}
