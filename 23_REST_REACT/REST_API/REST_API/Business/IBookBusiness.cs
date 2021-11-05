using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST_API.Model.Context;
using REST_API.Model;
using REST_API.Data.VO;
using REST_API.Hypermedia.Utils;

namespace REST_API.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        PagedSearchVO<BookVO> FindWithPagedSearch(
           string title, string sortDirection, int pageSize, int page);
        BookVO Update(BookVO book);
        void Delete(long id);

    }
}
