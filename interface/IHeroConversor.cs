using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace @interface
{
    public interface IHeroConversor
    {
        T crearPj<T>() where T : Hero, new();
    }
}
