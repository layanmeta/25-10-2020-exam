using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_question_3_exam
{

    class MyUniqueList
    {
        List<int> list = new List<int>();

        public MyUniqueList()
        {

        }

        public bool Add(int item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }

            throw new ItemAlreadyExistException("Item already exist in the list!!");
        }

        public bool Remove(int item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                return true;
            }
            throw new ItemNotFoundException("Item wasnt found in the list, cant be removed");
        }

        public int Peek(int index)
        { 
            if (list[index] < 0)
            {
                throw new IndexOutOfRangeException("index is out of range");
            }
            return list[index];
        }

        public int this[int index]
        {
            get
            {
                return this.list[index];
            }
            set
            {
                if (list[index] == value)
                    return;
                if (list.Contains(value))
                    return;
                list[index] = value;
                throw new IndexOutOfRangeException("index is out of range");
                

            }
        }

    }
}
