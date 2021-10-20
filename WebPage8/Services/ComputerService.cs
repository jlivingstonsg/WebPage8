using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Data;
using WebPage8.Models;
using WebPage8.ViewModels;

namespace WebPage8.Services
{
    public class ComputerService : IComputerService
    {
        private readonly IComputerRepo _computerRepo;
        public ComputerService(IComputerRepo computerRepo)
        {
            _computerRepo = computerRepo;
        }
        public Computer Add(CreateComputerViewModel person)
        {
            throw new NotImplementedException();
        }

        public ComputerViewModel All()
        {
            ComputerViewModel computerViewModel = new ComputerViewModel {
                Computers = _computerRepo.Read()
            };

            return computerViewModel;
        }

        public Computer Edit(int id, Computer person)
        {
            throw new NotImplementedException();
        }

        public ComputerViewModel FindBy(ComputerViewModel search)
        {
            throw new NotImplementedException();
        }

        public Computer FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
