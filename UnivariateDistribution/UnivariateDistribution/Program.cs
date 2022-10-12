
namespace UnivariateDistribution
{
    class Program
    {
        public Dictionary<string, int> univarDistr(string filePath, string fieldName)
        {
            string[] csvData = System.IO.File.ReadAllLines(filePath);
            int len = csvData.Length;
            string[] headers = csvData[0].Split(',');
            Dictionary<string, int> distribution = new Dictionary<string, int>();
            if (!Array.Exists(headers, el => el.Trim(' ', '\"') == fieldName))
            {
                Console.WriteLine("Unknown field name!");
                return distribution;
            }
            else
            {
                int index = Array.FindIndex(headers, el => el.Trim(' ', '\"') == fieldName);
                for (int i = 1; i < len; i++)
                {
                    string[] row = csvData[i].Split(',');
                    if (row.Length - 1 >= index)
                    {
                        if (distribution.ContainsKey(row[index]))
                        {
                            distribution[row[index]] += 1;
                        }
                        else
                        {
                            distribution.Add(row[index], 1);
                        }
                    }
                }
                return distribution;
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Dictionary<string, int> freq = p.univarDistr("C:\\Users\\VM\\Documents\\cities.csv", "City");
            string res = "Value | Frequency + \n";
            foreach (var pair in freq)
            {
                res += pair.Key + ": " + pair.Value + "\n";
            }
            Console.WriteLine(res);
        }
    }
}
