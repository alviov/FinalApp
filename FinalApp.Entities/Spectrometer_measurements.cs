using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.Entities
{
    public class SpectrometerMeasurements
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// дата измерения
        /// </summary>
        public DateOnly Date { get; set; }
        /// <summary>
        /// результат измерения
        /// </summary>
        public double Measurement_Result { get; set; }
        /// <summary>
        /// погрешность измерения
        /// </summary>
        public double Measurement_Error { get; set; }
        /// <summary>
        /// единицы измерения
        /// </summary>
        public string Measurement_units { get; set; }
        public long WorkerId { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
