using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileStreamObject
{
    [Serializable]  //在需要做串行化的类定义处需要加[Serializable]属性标记，否则会抛出SerializationException类异常
    public class IFormatterExample
    {
        public long Id;
        public string Name;
        public double Price;

        [NonSerialized]  //不需要串行化的类中成员需要在定义处加[NonSerialized]属性标记，将已串行化的对象并行化后未串行化的对象成员值为空
        string Notes;

        public IFormatterExample(long id, string name, double price, string notes)
        {
            Id = id;
            Name = name;
            Price = price;
            Notes = notes;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}(${2:F2}){3}", Id, Name, Price, Notes);
        }
    }
}