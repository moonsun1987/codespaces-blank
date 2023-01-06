using System.Linq;
using System;
using System.Text;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
        TestGetPrefCodeFromKey("marketingpreferenceemail_105_0_691031_2_attr", "marketingpreferenceemail");
        TestGetPrefCodeFromKey("marketingpreferencekushalpreferredname_106_0_691032_2_attr", "marketingpreferencekushalpreferredname");
        TestGetPrefCodeFromKey("marketingpreferencephonenumber_110_0_691033_2_attr", "marketingpreferencephonenumber");
        TestGetPrefCodeFromKey("marketingpreferencestoryprompt1_114_0_691038_2_attr", "marketingpreferencestoryprompt1");
        TestGetPrefCodeFromKey("marketingpreferencestoryprompt2_115_0_691039_2_attr", "marketingpreferencestoryprompt2");
        TestGetPrefCodeFromKey("marketingpreferenceyesno_118_0_691041_2_attr", "marketingpreferenceyesno");
        TestGetPrefCodeFromKey("ManuallyCreated20230105ayesno_117_0_691040_2_attr", "ManuallyCreated20230105ayesno");
        TestGetPrefCodeFromKey("marketingpreferencetopicsofinterest_108_67_691034_2_attr", "marketingpreferencetopicsofinterest");
        TestGetPrefCodeFromKey("marketingpreferencetopicsofinterest_108_67_691034_2_attr", "marketingpreferencetopicsofinterest");
        TestGetPrefCodeFromKey("marketingpreferencetopicsofinterest_108_67_691034_2_attr", "marketingpreferencetopicsofinterest");
        TestGetPrefCodeFromKey("costcofrequency_112_80_691035_2_attr", "costcofrequency");
        TestGetPrefCodeFromKey("walmartfrequency_113_85_691036_2_attr", "walmartfrequency");
        TestGetPrefCodeFromKey("marketingpreferenceemailoptin_107_65_691009_2_attr", "marketingpreferenceemailoptin");
        TestGetPrefCodeFromKey("marketingpreferencefrequency_109_74_691011_2_attr", "marketingpreferencefrequency");
        

		TestGetPrefCodeFromKey("marketingpreferenceTest_1_115_0_0_2_attr", "marketingpreferenceTest_1");
	}
	
	private static void TestGetPrefCodeFromKey(string input, string expected) 
	{	
		// string input = "marketingpreferenceTest_1_115_0_0_2_attr";
		string output = GetPrefCodeFromKey(input);
		// string expected = "marketingpreferenceTest_1";
		Console.WriteLine("Input: " + input + " Output: " + output);
		if (expected == output) { Console.WriteLine("Success"); } else { Console.WriteLine("Failure"); }
	}
	
	private static string GetPrefCodeFromKey(string key)
        {
            int count = key.Count(f => f == '_');
            Console.WriteLine(count);
            if (count < 1)
            {
                return key;
            }

            if (count < 6)
            {
                return key.Split('_')[0];
            }

            string[] splits = key.Split('_');
            StringBuilder sb = new StringBuilder();
            count -= 5;
            for (int i = 0; i < count; i++)
            {
                sb.Append(splits[i]);
                if (i < count - 1)
                {
                    sb.Append('_');
                }
            }

            return sb.ToString();
        }
}