using System;
using System.Collections.Generic;
using System.Text;

namespace zd1
{
    /// <summary>
    /// Написать класс Cycler, принимающий список объектов при создании.
    /// </summary>
    class Cycler
    {
        List<int> ls;
        int curent = 0;
        public Cycler(List<int> list)
        {
            ls = list;
        }

        /// <summary>
        /// возвращает следующий объект из списка по порядку. Если достигли последнего элемента и ещё раз вызвали эту функцию, то вернуться в начало и снова пойти по кругу.
        /// </summary>
        /// <returns></returns>
        public object GetNext()
        {
            if (curent >= ls.Count || curent < 0) curent = 0;
            return ls[curent++];
        }
    }
}
