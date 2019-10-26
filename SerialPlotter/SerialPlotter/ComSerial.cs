using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;

namespace SerialPlotter
{
    class  ComSerial
    {

        public static bool continuar;
        public static SerialPort puertoSerial;
        StringComparer comparador = StringComparer.OrdinalIgnoreCase;
        String mensaje;
        Thread hiloLectura;

        public ComSerial()
        {
            puertoSerial.PortName = "COM7";
            puertoSerial.BaudRate = 5;
            
            puertoSerial.DataBits = 8;
            

            

        }
        public void Leer()
        {
            while (continuar)
            {
                try
                {

                }
                catch (TimeoutException) { };
            }

        }
    }
}
