using System;
using System.Security.Principal;

namespace KompasAPI.Model
{
    /// <summary>
    /// Класс параметров модели
    /// </summary>
    public class ModelParameters
    {
        #region Constants
         //TODO: RSDN
        /// <summary>
        /// Координата X корпуса
        /// </summary>
        public const double caseCenterX = 0;

        /// <summary>
        /// Координата Z корпуса
        /// </summary>
        public const double caseCenterZ = 0;

        /// <summary>
        /// Смещенная координата Z корпуса
        /// </summary>
        public const double caseCoordZ = -10;

        /// <summary>
        /// Радиус скругления корпуса
        /// </summary>
        public const double caseFilletRadius = 15;

        /// <summary>
        /// Координата X скругления первой кнопки
        /// </summary>
        public const double cirleFirstButtonFilletX = -0.8;

        /// <summary>
        /// Координата Z скругления первой кнопки
        /// </summary>
        public const double circleFirstButtonFilletZ = 0.15;

        /// <summary>
        /// Координата X скругления второй кнопки
        /// </summary>
        public const double circleSecondButtonFilletX = -0.9;

        /// <summary>
        /// Координата Z скругления второй кнопки
        /// </summary>
        public const double circleSecondButtonFilletZ = 0.30;

        /// <summary>
        /// Координата Y скругления кнопки
        /// </summary>
        public const double circleButtonFilletY = 15;

        /// <summary>
        /// Радиус скругления кнопки
        /// </summary>
        public const double circleButtonRadius = 10;

        /// <summary>
        /// Дефолтный радиус кнопки
        /// </summary>
        public const double defaultButtonRadius = 10;

        /// <summary>
        /// Значение выдавливания круглой кнопки
        /// </summary>
        public const double circleButtonExtrusionDepth = 15;

        /// <summary>
        /// Значение выдавливания прямоугольной кнопки
        /// </summary>
        public const double rectangleButtonExtrusionDepth = 15;

        /// <summary>
        /// Отступ прямоугольной кнопки по Y
        /// </summary>
        public const double rectangleButtonIndentY = 12.5;

        /// <summary>
        /// Отступ прямоугольной кнопки по X
        /// </summary>
        public const double rectangleButtonIndentX = 25;

        /// <summary>
        /// Смещенная координата Y дверцы
        /// </summary>
        public const double rectangleDoorY = 15;

        /// <summary>
        /// Смещенная координата X дверцы
        /// </summary>
        public const double rectangleDoorX = 25;

        /// <summary>
        /// Координата X дверцы
        /// </summary>
        public const double rectangleDoorCenterX = 0;

        /// <summary>
        /// Значение выдавливания прямоугольной дверцы
        /// </summary>
        public const double rectangleDoorExtrusionDepth = 15;

        #endregion

        /// <summary>
        /// Длина корпуса
        /// </summary>
        private Parameter _caseLength;

        /// <summary>
        /// Высота корпуса
        /// </summary>
        private Parameter _caseHeight;

        /// <summary>
        /// Глубина корпуса
        /// </summary>
        public Parameter CaseDepth { get; set; }

        /// <summary>
        /// Длина дверцы
        /// </summary>
        public Parameter DoorLength { get; set; }

        /// <summary>
        /// Высота дверцы
        /// </summary>
        public Parameter DoorHeight { get; set; }

        /// <summary>
        /// Диаметр кнопок
        /// </summary>
        public Parameter DiameterOfButtons { get; set; }

        /// <summary>
        /// Длина кнопки
        /// </summary>
        public Parameter ButtonLength { get; set; }

        /// <summary>
        /// Высота кнопки
        /// </summary>
        public Parameter ButtonHeight { get; set; }

        /// <summary>
        /// Длина корпуса
        /// </summary>
        public Parameter CaseLength
        {
            get
            {
                return _caseLength;
            }
            set
            {
                //TODO: Duplication
                //TODO:const
                _caseLength = value;
                DoorLength.Max = value.Value - 165;
                DoorLength.Value = value.Value - 165;
            }
        }

        /// <summary>
        /// Высота корпуса
        /// </summary>
        public Parameter CaseHeight
        {
            get
            {
                return _caseHeight;
            }
            set
            {
                //TODO: Duplication
                //TODO:const
                _caseHeight = value;
                DoorHeight.Max = value.Value - 25;
                DoorHeight.Value = value.Value - 25;
            }
        }

        /// <summary>
        /// Пустой контруктор класса параметров
        /// </summary>
        public ModelParameters()
        {
            DoorHeight = new Parameter("Высота дверцы", 200, 200, 220);
            CaseDepth = new Parameter("Глубина корпуса", 300, 300, 450);
            DiameterOfButtons = new Parameter("Диаметр кнопок", 40, 20, 40);
            DoorLength = new Parameter("Длина дверцы", 220, 220, 235);
            CaseLength = new Parameter("Длина корпуса", 400, 400, 500);
            CaseHeight = new Parameter("Высота корпуса", 250, 250, 300);
            ButtonLength = new Parameter("Длина кнопки", 100, 60, 100);
            ButtonHeight = new Parameter("Высота кнопки", 50, 30, 50);
        }

         //TODO: RSDN
        /// <summary>
        /// Контруктор класса параметров
        /// </summary>
        public ModelParameters(int caseDepth, int diameterOfButtons, int caseLength, int caseHeight, int buttonLength, int buttonHeight)

        {
            //TODO: Duplication
            DoorHeight = new Parameter("Высота дверцы", caseHeight - 25, 200, caseHeight - 25);
            CaseDepth = new Parameter("Глубина корпуса", caseDepth, 300, 450);
            DiameterOfButtons = new Parameter("Диаметр кнопок", diameterOfButtons, 20, 40);
            DoorLength = new Parameter("Длина дверцы", caseLength - 165, 220, caseLength - 165);
            CaseLength = new Parameter("Длина корпуса", caseLength, 400, 500);
            CaseHeight = new Parameter("Высота корпуса", caseHeight, 250, 300);
            ButtonLength = new Parameter("Длина кнопки", buttonLength, 60, 100);
            ButtonHeight = new Parameter("Высота кнопки", buttonHeight, 30, 50);
        }
    }
}