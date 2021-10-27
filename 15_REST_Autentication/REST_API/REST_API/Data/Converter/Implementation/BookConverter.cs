using REST_API.Data.VO;
using REST_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Data.Converter.Implementation
{
    public class BookConverter
    {
        public Book Parse(BookVO origin)
        {
            if (origin == null)
            {
                return null;
            }
            else
            {
                return new Book
                {
                    Id = origin.Id,
                    Title = origin.Title,
                    Author = origin.Author,
                    Price = origin.Price,
                    Launch_Date = origin.Launch_Date
                };
            }
        }

        public BookVO Parse(Book origin)
        {
            if (origin == null)
            {
                return null;
            }
            else
            {
                return new BookVO
                {
                    Id = origin.Id,
                    Title = origin.Title,
                    Author = origin.Author,
                    Price = origin.Price,
                    Launch_Date = origin.Launch_Date
                };
            }
        }

        public List<Book> Parse(List<BookVO> origin)
        {
            if (origin == null)
            {
                return null;
            }
            else
            {
                return origin.Select(item => Parse(item)).ToList();
            }
        }
        public List<BookVO> Parse(List<Book> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    
    }
}
