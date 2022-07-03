using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalApp.Entities;

namespace FinalApp.Services.Dto
{
    public class SurgeryDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Дата иссечения
        /// </summary>
        public DateOnly Date { get; set; }

        /// <summary>
        /// Эффективность хирургического иссечения
        /// </summary>
        public double Surgery_efficiency { get; set; }
        public long WorkerId { get; set; }


    }
}
