using System;
using Kompas6API5;
using System.Runtime.InteropServices;
using Kompas6Constants3D;

namespace KompasAPI
{
    /// <summary>
    /// Класс подключения к Компасу
    /// </summary>
    public class KompasConnector
    {
        /// <summary>
        /// Интерфейс API
        /// </summary>
        private KompasObject _kompasObject;

        /// <summary>
        /// Документ 3D
        /// </summary>
        private ksDocument3D _ksDocument3D;

        /// <summary>
        /// Компонент
        /// </summary>
        public ksPart KsPart { get; set; }

        /// <summary>
        /// Документ 2D
        /// </summary>
        public ksDocument2D KsDocument2D { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public KompasConnector()
        {
            OpenKompas();
        }

        /// <summary>
        /// Создать новую деталь
        /// </summary>
        public void CreateNewDocument()
        {
            _ksDocument3D = (ksDocument3D)_kompasObject.Document3D();
            _ksDocument3D.Create(false, true);
            KsPart = (ksPart)_ksDocument3D.GetPart((short)Part_Type.pTop_Part);
        }

        /// <summary>
        /// Открыть компас
        /// </summary>
        public bool OpenKompas()
        {
            _kompasObject = null;
            try
            {
                try
                {
                    _kompasObject = (KompasObject)Marshal.GetActiveObject("KOMPAS.Application.5");
                    _kompasObject.Visible = true;
                }
                catch
                {
                    Type type = Type.GetTypeFromProgID("KOMPAS.Application.5");
                    _kompasObject = (KompasObject)Activator.CreateInstance(type);
                    _kompasObject.Visible = true;
                }
                _kompasObject.ActivateControllerAPI();
                return true;
            }
            catch
            {
                throw new Exception("Компас не найден");
            }
        }
    }
}