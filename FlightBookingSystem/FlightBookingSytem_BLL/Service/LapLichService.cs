using DataTransferObject.DTO;
using FlightBookingSystem_DAL.Model;
using FlightBookingSystem_DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSytem_BLL.Service
{
    public class LapLichService
    {
        private TuyenBayRepo tuyenBayRepo;
        private MayBayRepo mayBayRepo;
        public LapLichService()
        {
            tuyenBayRepo = new TuyenBayRepo();
            mayBayRepo = new MayBayRepo();
        }
        public List<TuyenBayDTO> loadTuyenBayService()
        {
            return tuyenBayRepo.loadTuyenBay();
        }
        public List<string> loadMayBay()
        {
            return mayBayRepo.loadMayBay(); 
        }
    }
}
