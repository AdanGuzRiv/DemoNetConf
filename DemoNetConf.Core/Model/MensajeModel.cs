using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNetConf.Core.Model
{
    public class MensajeModel
    {
        public string MensajeGlobal { get; set; }
    }

    public enum Panels
    {
        Login,
        Email,
        Registrar,
    }
}
