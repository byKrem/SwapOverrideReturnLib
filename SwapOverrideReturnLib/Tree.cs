using System.Collections.Generic;
using System.Text;

namespace SwapOverrideReturnLib
{
    public class Tree
    {
        public string Name { get; set; }
        public IEnumerable<Tree> Children { get; set; }
        /// <summary>
        /// Возвращает имена всех веток текущего дерева и имя самого дерева
        /// </summary>
        /// <returns>Поле типа данных string с именами всех веток</returns>
        public string GetAllNames()
        {
            StringBuilder names = new StringBuilder();
            names.Append(this.Name);
            var enumerator = Children?.GetEnumerator();
            while (enumerator?.MoveNext() ?? false)
            {
                Tree child = enumerator.Current;
                names.Append(child.GetAllNames());
            }
            return names.ToString();
        }
    }
}
