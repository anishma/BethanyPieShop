using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Models
{
    public interface IPieRepository
    {
         IEnumerable<Pie> Pies { get; }
        IEnumerable<Pie> PiesoftheWeek { get; }
        Pie GetPieById(int pieId);
    }
}
