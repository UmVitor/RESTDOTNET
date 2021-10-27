using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST_API.Model.Context;
using REST_API.Model;
using REST_API.Data.VO;

namespace REST_API.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);

    }
}
