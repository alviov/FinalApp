using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.Entities
{
    public class ChelationTherapyData
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
        public virtual Worker Worker { get; set; }

    }
}
