
namespace Test.cmdlets
{
    public static class CommonMethods
    {
        public static byte[] String_To_Bytes(string S)
        {
            return System.Text.Encoding.ASCII.GetBytes(S);
        }
        public static byte[] String_To_Bytes(string[] S)
        {
            System.Collections.ArrayList BB = new System.Collections.ArrayList();
            foreach (string s in S)
            {
                // check for empty strings
                if (!(s.Equals("")))
                    BB.AddRange(String_To_Bytes(s));
                BB.Add((byte) 10); // Adds the newline character at the end of each string.
            }
            return (byte[]) BB.ToArray(typeof (byte));
        }
        public static byte[] Array_To_Bytes(System.Array Arr)
        {
            System.Collections.ArrayList BB = new System.Collections.ArrayList();
            foreach (var V in Arr)
            {
                string S = V.ToString();
                // check for empty strings
                if (!(S.Equals("")))
                    BB.AddRange(String_To_Bytes(S));
                BB.Add((byte)10); // Adds the newline character at the end of each array item.
            }
            return (byte[]) BB.ToArray(typeof (byte));
        }
        public static string Bytes_To_String(byte[] Bytes)
        {
            return System.Text.Encoding.ASCII.GetString(Bytes);
        }
    }

    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsData.ConvertTo, "String")]
    public class ConvertTo_String : System.Management.Automation.Cmdlet
    {
        [System.Management.Automation.Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true)]
        public byte[] Bytes;

        protected override void ProcessRecord()
        {
            string S = CommonMethods.Bytes_To_String(Bytes);
            WriteObject(S);
        }

    }

    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsData.ConvertTo, "Bytes",DefaultParameterSetName="Single")]
    public class ConvertTo_Bytes : System.Management.Automation.PSCmdlet
    {
        [System.Management.Automation.Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true,ParameterSetName="Single")]
        public string String;
        [System.Management.Automation.Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ParameterSetName = "Array")]
        public System.Array MiscArray;


        protected override void ProcessRecord()
        {
            byte[] B;
            switch(ParameterSetName)
            {
                case "Single":
                    B = CommonMethods.String_To_Bytes(String);
                    break;
               case "Array":
                    B = CommonMethods.Array_To_Bytes(MiscArray);
                    break;
                default:
                    return;
            }
            WriteObject(B, true);
        }
    }

}
