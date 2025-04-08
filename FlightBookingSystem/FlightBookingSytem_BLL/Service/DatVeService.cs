using DataTransferObject.DTO;
using FlightBookingSystem_DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSytem_BLL.Service
{
    public class DatVeService
    {
        private SanBayRepo sanBayRepo;
        public DatVeService()
        {
            sanBayRepo = new SanBayRepo();
        }
        public List<string> diaDiemDiVaDen()
        {
            return sanBayRepo.loadSanBay();
        }
        

    }
}
