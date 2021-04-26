using System;
using Kompas6API5;

namespace Sink
{
    public class KompasConnector
    {
        /// <summary>
        /// Интерфейс API Компаса
        /// </summary>
        public KompasObject Kompas { get; set; }

        /// <summary>
        /// Указатель на интерфейс документа трехмерной модели 
        /// </summary>
        public ksDocument3D Doc3D { get; set; }

        /// <summary>
        /// Сборка
        /// </summary>
        public ksPart KsPart { get; set; }

        /// <summary>
        /// Открытие компаса
        /// </summary>
        public void OpenKompas()
        {
            try
            {
                Type t = Type.GetTypeFromProgID("KOMPAS.Application.5");
                Kompas = (KompasObject)Activator.CreateInstance(t);
            }

            catch
            {
                Kompas = null;
                Type t = Type.GetTypeFromProgID("KOMPAS.Application.5");
                Kompas = (KompasObject)Activator.CreateInstance(t);
            }

            Kompas.Visible = true;
            Kompas.ActivateControllerAPI();
        }
    }
}