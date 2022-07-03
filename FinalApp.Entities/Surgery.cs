using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.Entities
{
    public class SurgeryData
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
        public virtual Worker Worker { get; set; }

    }
}
