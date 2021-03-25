﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
   public  class BookAppService : CrudAppService<Book, BookDto, int, PagedAndSortedResultRequestDto, CreateUpdateBookDto>,IBookAppService
    {
        public BookAppService(IRepository<Book,int> repository):base(repository)
        {

        }
    }
}
