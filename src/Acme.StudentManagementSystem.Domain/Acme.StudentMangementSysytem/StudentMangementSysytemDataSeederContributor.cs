using Acme.StudentManagementSystem.Grades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.StudentManagementSystem.Acme.StudentMangementSysytem
{
    public class StudentMangementSysytemDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Grade, int> _bookRepository;

        public StudentMangementSysytemDataSeederContributor(IRepository<Grade, int> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _bookRepository.GetCountAsync() <= 0)
            {
                //await _bookRepository.InsertAsync(
                //    new Grade
                //    {
                //        Name = "1984",
                //    },
                //    autoSave: true
                //);

                await _bookRepository.InsertManyAsync(
                    new List<Grade>
                    {
                        new Grade()
                        {
                        Name = "Grade 1",
                        },
                        new Grade()
                        {
                        Name = "Grade 2",
                        },
                        new Grade()
                        {
                        Name = "Grade 3",
                        },

                    },

                    autoSave: true
                );
            }
        }
    }
}
