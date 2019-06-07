using ELibraryProject.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.Commands
{
    public class BaseCommand
    {
        public IUnitOfWork UnitOfWork { get; set; }
    }
}
