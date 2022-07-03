using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalApp.Entities;

namespace FinalApp.Services.Dto
{
    public class ChelationTherapyDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Дата введения хелата
        /// </summary>
        public DateOnly Date { get; set; }
        public long WorkerId { get; set; }
    }
}
