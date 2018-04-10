using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBookshelf.Data
{
    public interface IBooksRepository
    {
        List<Book> GetBooks();
       

    }
}
