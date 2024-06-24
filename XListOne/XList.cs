namespace XListOne
{
    public class XList
    {
        // A Segmented list.  Handles duplicate values.  Sorted.
        public int MaxSize;
        public XNode Start;

        public XList(int n)
        {
            MaxSize = n;
            Start = null;
        }

        /// <summary>
        /// Search for the value.
        /// </summary>
        /// <param name="value">int</param>
        /// <returns>XNode</returns>
        public XNode Search(int value)
        {
            XNode a = Start;
            while (a != null)
            {
                if (a.Inside(value))
                {
                    break;
                }
                a = a.Next;
            }
            return a;
        }

        /// <summary>
        /// Does list contain value?
        /// </summary>
        /// <param name="value">int</param>
        /// <returns>bool</returns>
        public bool Contains(int value)
        {
            XNode a = Start;
            while (a != null)
            {
                if (a.Contains(value))
                {
                    return true;
                }
                a = a.Next;
            }
            return false;
        }

        /// <summary>
        /// Insert value. 
        /// </summary>
        /// <param name="value">int</param>
        public void Insert(int value)
        {
            if (Start == null)
            {
                Start = new XNode();
                Start.Add(value);
                return;
            }

            XNode a = Search(value);
            if (a == null)
            {
                a = GetLast();
            }
            a.Insert(value);

            if (a.List.Count > MaxSize)
            {
                Split(a);
            }
        }

        public void AddRange(List<int> a)
        {
            foreach (var x in a)
            {
                Insert(x);
            }
        }

        /// <summary>
        /// Get Last Node.
        /// </summary>
        /// <returns>XNode</returns>
        public XNode GetLast()
        {
            XNode a = Start;
            XNode b = Start;
            while (a != null)
            {
                b = a;
                a = a.Next;
            }
            return b;
        }

        /// <summary>
        /// Split node into two nodes.
        /// </summary>
        /// <param name="a">XNode</param>
        public void Split(XNode a)
        {
            List<int> temp = new List<int>(a.List);
            a.List.Clear();
            int mid = temp.Count / 2;
            for (int i = 0; i <= mid; i++)
            {
                a.Add(temp[i]);
            }
            XNode b = new XNode();
            for (int i = mid + 1; i < temp.Count; i++)
            {
                b.Add(temp[i]);
            }
            b.Next = a.Next;
            a.Next = b;
            temp.Clear();
        }

        public int Count()
        {
            int result = 0;
            XNode a = Start;
            while (a != null)
            {
                result += a.List.Count;
                a = a.Next;
            }
            return result;
        }

        public void Clear()
        {
            Start = null;
        }

        /// <summary>
        /// Delete value in list.
        /// </summary>
        /// <param name="value">int</param>
        public void Delete(int value)
        {
            XNode a = Start;
            while (a != null)
            {
                if (a.Delete(value))
                {
                    break;
                }
                a = a.Next;
            }
            Clean();
        }


        /// <summary>
        /// Clean
        /// </summary>
        public void Clean()
        {
            // Remove empty nodes.
            while (Start != null && Start.List.Count == 0)
            {
                Start = Start.Next;
            }

            // Remove empty nodes.
            XNode a = Start;
            while (a != null)
            {
                XNode b = a.Next;
                if (b != null && b.List.Count == 0)
                {
                    a.Next = b.Next;
                }
                a = a.Next;
            }
        }

        /// <summary>
        /// Print List
        /// </summary>
        public void Print()
        {
            XNode a = Start;
            while (a != null)
            {
                foreach (var x in a.List)
                {
                    Console.Write(x);
                    Console.Write(" ");
                }
                a = a.Next;
            }
        }

        /// <summary>
        /// Get List.
        /// </summary>
        /// <returns>List</returns>
        public List<int> GetList()
        {
            List<int> list = new List<int>();
            XNode a = Start;
            while (a != null)
            {
                if (a.List.Count > 0)
                {
                    list.AddRange(a.List);
                }
                a = a.Next;
            }
            return list;
        }


    }
}

