namespace ORSAPR.Model
{
    /// <summary>
    /// Класс параметров модели
    /// </summary>
    public class ModelParameters
    {
        #region Constants
        /// <summary>
        /// Координата X корпуса
        /// </summary>
        public const double CaseCenterX = 0;

        /// <summary>
        /// Координата Z корпуса
        /// </summary>
        public const double CaseCenterZ = 0;

        /// <summary>
        /// Смещенная координата Z корпуса
        /// </summary>
        public const double CaseCoordZ = -10;

        /// <summary>
        /// Радиус скругления корпуса
        /// </summary>
        public const double CaseFilletRadius = 15;

        /// <summary>
        /// Координата X скругления первой кнопки
        /// </summary>
        public const double CirleFirstButtonFilletX = -0.8;

        /// <summary>
        /// Координата Z скругления первой кнопки
        /// </summary>
        public const double CircleFirstButtonFilletZ = 0.15;

        /// <summary>
        /// Координата X скругления второй кнопки
        /// </summary>
        public const double CircleSecondButtonFilletX = -0.9;

        /// <summary>
        /// Координата Z скругления второй кнопки
        /// </summary>
        public const double CircleSecondButtonFilletZ = 0.30;

        /// <summary>
        /// Координата Y скругления кнопки
        /// </summary>
        public const double CircleButtonFilletY = 15;

        /// <summary>
        /// Радиус скругления кнопки
        /// </summary>
        public const double CircleButtonRadius = 10;

        /// <summary>
        /// Дефолтный радиус кнопки
        /// </summary>
        public const double DefaultButtonRadius = 10;

        /// <summary>
        /// Значение выдавливания круглой кнопки
        /// </summary>
        public const double CircleButtonExtrusionDepth = 15;

        /// <summary>
        /// Значение выдавливания прямоугольной кнопки
        /// </summary>
        public const double RectangleButtonExtrusionDepth = 15;

        /// <summary>
        /// Отступ прямоугольной кнопки по Y
        /// </summary>
        public const double RectangleButtonIndentY = 12.5;

        /// <summary>
        /// Отступ прямоугольной кнопки по X
        /// </summary>
        public const double RectangleButtonIndentX = 25;

        /// <summary>
        /// Смещенная координата Y дверцы
        /// </summary>
        public const double RectangleDoorY = 15;

        /// <summary>
        /// Смещенная координата X дверцы
        /// </summary>
        public const double RectangleDoorX = 25;

        /// <summary>
        /// Координата X дверцы
        /// </summary>
        public const double RectangleDoorCenterX = 0;

        /// <summary>
        /// Значение выдавливания прямоугольной дверцы
        /// </summary>
        public const double RectangleDoorExtrusionDepth = 15;

        /// <summary>
        /// Координата скругления дверцы по X
        /// </summary>
        public const double RectangleDoorFilletX = -25;

        /// <summary>
        /// Координата скругления дверцы по Y
        /// </summary>
        public const double RectangleDoorFilletY = 15;

        /// <summary>
        /// Смещенная координата скругления дверцы по Z
        /// </summary>
        public const double RectangleDoorFilletZ = -100;

        /// <summary>
        /// Координата скругления дверцы по Z
        /// </summary>
        public const double RectangleDoorFilletCoordZ = 15;

        /// <summary>
        /// Значение радиуса скругления дверцы
        /// </summary>
        public const double RectangleDoorFilletRadius = 5;

        /// <summary>
        /// Значение зависимого параметра длины дверцы
        /// </summary>
        public const double DoorLengthDependentValue = 165;

        /// <summary>
        /// Значение зависимого параметра высоты дверцы
        /// </summary>
        public const double DoorHeightDependentValue = 25;

        /// <summary>
        /// Отступ первого элемента ручки от дверцы по Y
        /// </summary>
        public const double DoorHandleIndentY = 20;

        /// <summary>
        /// Отступ второго элемента ручки от дверцы по Y
        /// </summary>
        public const double DoorHandleIndentY2 = 30;

        /// <summary>
        /// Значение выдавливания первого элемента ручки от дверцы
        /// </summary>
        public const double DoorHandleExtrusionDepth = 17;

        /// <summary>
        /// Значение выдавливания второго элемента ручки от дверцы
        /// </summary>
        public const double DoorHandleExtrusionDepth2 = 7;

        /// <summary>
        /// Радиус скругления первого элемента ручки от дверцы
        /// </summary>
        public const double DoorHandleFilletRadius = 3;

        /// <summary>
        /// Радиус скругления второго элемента ручки от дверцы
        /// </summary>
        public const double DoorHandleFilletRadius2 = 7;

        /// <summary>
        /// Радиус скругления первого элемента ручки по Y
        /// </summary>
        public const double DoorHandleFilletY = 32;

        /// <summary>
        /// Радиус скругления второго элемента ручки по Y
        /// </summary>
        public const double DoorHandleFilletY2 = 25;

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
                _caseLength = value;
                DoorLength.Max = value.Value - DoorLengthDependentValue;
                DoorLength.Value = value.Value - DoorLengthDependentValue;
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
                _caseHeight = value;
                DoorHeight.Max = value.Value - DoorHeightDependentValue;
                DoorHeight.Value = value.Value - DoorHeightDependentValue;
            }
        }

        /// <summary>
        /// Пустой контруктор класса параметров
        /// </summary>
        public ModelParameters()
        {
            DoorHeight = new Parameter("Высота дверцы", 200, 200, 225);
            CaseDepth = new Parameter("Глубина корпуса", 300, 300, 450);
            DiameterOfButtons = new Parameter("Диаметр кнопок", 40, 20, 40);
            DoorLength = new Parameter("Длина дверцы", 220, 220, 235);
            CaseLength = new Parameter("Длина корпуса", 400, 400, 500);
            CaseHeight = new Parameter("Высота корпуса", 250, 250, 300);
            ButtonLength = new Parameter("Длина кнопки", 100, 60, 100);
            ButtonHeight = new Parameter("Высота кнопки", 50, 30, 50);
        }

        /// <summary>
        /// Контруктор класса параметров
        /// </summary>
        public ModelParameters(
            int caseDepth,
            int diameterOfButtons,
            int caseLength,
            int caseHeight,
            int buttonLength,
            int buttonHeight)

        {
            DoorHeight = new Parameter("Высота дверцы",
                caseHeight - DoorHeightDependentValue,
                200,
                caseHeight - DoorHeightDependentValue);
            CaseDepth = new Parameter("Глубина корпуса", caseDepth, 300, 450);
            DiameterOfButtons = new Parameter("Диаметр кнопок", diameterOfButtons, 20, 40);
            DoorLength = new Parameter("Длина дверцы",
                caseLength - DoorLengthDependentValue,
                220,
                caseLength - DoorLengthDependentValue);
            CaseLength = new Parameter("Длина корпуса", caseLength, 400, 500);
            CaseHeight = new Parameter("Высота корпуса", caseHeight, 250, 300);
            ButtonLength = new Parameter("Длина кнопки", buttonLength, 60, 100);
            ButtonHeight = new Parameter("Высота кнопки", buttonHeight, 30, 50);
        }
    }
}