
namespace CSVParser
{
    class Program
    {
        public Dictionary<string, string>[] parse(string filePath)
        {
            string[] csvData = System.IO.File.ReadAllLines(filePath);
            int len = csvData.Length;
            string[] headers = csvData[0].Split(',');
            Dictionary<string, string>[] parsedData = new Dictionary<string, string>[len - 1];

            int n = 0;
            for (int i = 1; i < csvData.Length; i++)
            {
                string[] row = csvData[i].Split(',');
                parsedData[n] = new Dictionary<string, string>();
                for (int j = 0; j < row.Length; j++)
                {
                    string value = row[j];
                    if (string.IsNullOrEmpty(value))
                    {
                        value = "-1";
                    }

                    parsedData[n].Add(headers[j], value);
                }
                n++;
            }

            return parsedData;
        }
        
        static void Main(string[] args)
        {
            Program p = new Program();
            string currDir = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(currDir);
            int len = p.parse("..\\..\\..\\..\\..\\cities.csv").Length;
            string res = "";
            for (int a = 0; a < len; a++)
            {   
                res += "Dictionary for entry number " + (a + 1).ToString() + ":\n";
                Dictionary<string, string> data = p.parse("..\\..\\..\\..\\..\\cities.csv")[a];
                foreach (var pair in data)
                {
                    res += pair.Key + ": " + pair.Value + "\n";
                }
            }
            Console.WriteLine(res);
        }
    }
}
