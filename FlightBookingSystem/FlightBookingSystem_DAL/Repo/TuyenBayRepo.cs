using DataTransferObject.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class TuyenBayRepo
    {
        private Context.DatabaseContext _context;
        public TuyenBayRepo()
        {
            _context = new Context.DatabaseContext();
        }
        
        public List<TuyenBayDTO> loadTuyenBay()
        {
            var result = _context.TuyenBays
                        .Join(_context.SanBays,
                              tb => tb.MaSanBayDi,
                              sb => sb.MaSanBay,
                              (tb, sb) => new { TuyenBay = tb, SanBayDi = sb })
                        .Join(_context.SanBays,
                              x => x.TuyenBay.MaSanBayDen,
                              sb => sb.MaSanBay,
                              (x, sbDen) => new TuyenBayDTO
                              {
                                  maDiaDiemDi = x.SanBayDi.MaSanBay,
                                  maDiaDiemDen = sbDen.MaSanBay,
                                  diaDiemDi = x.SanBayDi.DiaDiem,
                                  diaDiemDen = sbDen.DiaDiem
                              });

            return result.ToList();
        }

        public string loadMaTuyenBay(string maSanBayDi, string maSanBayDen)
        {
            var result = _context.TuyenBays
                .Where(tb => tb.MaSanBayDi == maSanBayDi && tb.MaSanBayDen == maSanBayDen)
                .Select(tb => tb.MaTuyenBay)
                .FirstOrDefault();
            return result.ToString();
        }

    }
}
