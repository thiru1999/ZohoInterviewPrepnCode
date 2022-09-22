using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMosh
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {

            //return _value != null;
            get
            {
                if (_value != null)
                {
                    return true;
                }
                return false;
            }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                // "Unboxing" the value, which is currently type object
                return (T)_value;
            }

            // in case it is null, we need to find the default value for that tipe.
            // we can do this with the default operator.
            return default(T);
        }
    }
}
