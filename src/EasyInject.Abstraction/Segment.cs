using System;
using System.Collections.Generic;
using System.Reflection;

namespace EasyInject.Abstraction
{
    public abstract class Segment
    {
      public  Dictionary<Type,Type> _types=new Dictionary<Type, Type>();
        protected Segment()
        {
            this.Assembly = this.GetType().Assembly;
        }

        public Assembly Assembly { get; set; }

        public void AddSingleton<TImplementation, TInterface>()
        {
            this._types.Add(typeof(TImplementation), typeof(TInterface));
        }
    }
}
