using System;

namespace ORSAPR.Model
{
    /// <summary>
    /// Класс параметра
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Название параметра
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Минимальное значение параметра
        /// </summary>
        public double Min { get; set; }

        /// <summary>
        /// Максимальное значение параметра
        /// </summary>
        public double Max { get; set; }
        
        /// <summary>
        /// Значение параметра
        /// </summary>
        private double _value;

        /// <summary>
        /// Значение параметра
        /// </summary>
        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value < Min || value > Max)
                {
                    throw new ArgumentException($"{Name}" + $" не входит в диапазон {Min} - {Max} мм.");
                }
                _value = value;
            }
        }

        /// <summary>
        /// Конструктор параметра
        /// </summary>
        /// <param name="name">Название параметра</param>
        /// <param name="value">Значение параметра</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        public Parameter(string name,
            double value, double min, double max)
        {
            Name = name;
            Max = max;
            Min = min;
            Value = value;
        }
    }
}