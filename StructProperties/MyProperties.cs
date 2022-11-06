using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackage
{
    public struct WeatherObservation // класс – является ссылочным типом (reference type), а структуры – значимым типом (value type)
    {
        public DateTime RecordedAt { get; init; }
        public decimal TemperatureInCelsius { get; init; }
        public decimal PressureInMillibars { get; init; }

        public override string ToString() => // override перегрузка от Object
            $"Ar {RecordedAt: h:mm tt} on {RecordedAt: M/d/yyyy}: " +
            $"Temp = {TemperatureInCelsius}, with {PressureInMillibars} pressure";
    }
}
