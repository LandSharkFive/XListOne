
namespace XListOne
{

    public class XNode
    {
        public XNode Next;
        public List<int> List;

        public XNode()
        {
            Next = null;
            List = new List<int>();
        }

        public int Count()
        {
            return List.Count;
        }

        /// <summary>
        /// Add to list.
        /// </summary>
        /// <param name="value">int</param>
        public void Add(int value)
        {
            List.Add(value);
        }

        /// <summary>
        /// Insert into list.
        /// </summary>
        /// <param name="value">int</param>
        public void Insert(int value)
        {
            List.Add(value);
            List.Sort();
        }

        /// <summary>
        /// Is the value in this node?
        /// </summary>
        /// <param name="value">int</param>
        /// <returns>bool</returns>
        public bool Inside(int value)
        {
            return List.Count > 0 && value <= List[List.Count - 1];
        }

        public bool Contains(int value)
        {
            return List.Contains(value);
        }

        public bool Delete(int value)
        {
            return List.Remove(value);
        }

    }
}
