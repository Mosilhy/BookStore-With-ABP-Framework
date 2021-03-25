using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    class BookStoreDataSeederContributer : IDataSeedContributor, ITransientDependency
    {
        private IRepository<Book, int> bookRepository;

        public BookStoreDataSeederContributer(IRepository<Book,int> bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await bookRepository.GetCountAsync()<= 0)
            {
                await bookRepository.InsertAsync(
                    new Book
                    {
                        Name="1984",
                        Type=BookType.Adventure,
                        PublishDate=new DateTime(1949,6,8),
                        Price=19.84f
                    },
                    autoSave:true
                    );

            }
        }
    }
}
