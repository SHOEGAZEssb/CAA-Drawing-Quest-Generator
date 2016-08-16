using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAA_Drawing_Quest_Generator.Trait_Categories
{
  class Category
  {
    #region Properties

    public List<string> Values
    {
      get { return _values; }
      private set { _values = value; }
    }
    private List<string> _values;

    #endregion Properties

    public Category(string pathToValueList)
    {
      Values = new List<string>(File.ReadAllLines(pathToValueList));
    }

    public string GetRandomValue()
    {
      Random rnd = new Random(DateTime.Now.Ticks.GetHashCode());
      return Values[rnd.Next(0, Values.Count - 1)];
    }
  }
}