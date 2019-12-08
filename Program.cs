using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAc4y
{
    class Program
    {
        static void Main(string[] args)
        {
            CSSerializerLibrary.Serialize _serialize = new CSSerializerLibrary.Serialize();

            _serialize.SerializeMethod("d:\\Server\\Visual_studio\\output_Xmls\\", typeof(Program));
        }
    }
}
