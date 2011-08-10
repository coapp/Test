/*
 * For the record:
 *      Yes, I am using Sleep() statements in the write sequence.
 *      Yes, I realize that that's an increadibly bad way to do this.
 *      After much checking with sources both internal and external,
 *          it was determined that this was the only "sure" way to
 *          avoid a data loss problem that was being encountered.
 *      Yes, I grumbled about it too.  Deal.
 *      
 * -Tim Rogers
 * 
 */

namespace Test.cmdlets
{
    public static class Client
    {
        public static System.IO.Ports.SerialPort Port;
        public static byte SendSingleDelimiter;
        public static string ReadMsgDelimiter = "^^^DONE^^^";
        public static byte EndOfProcessingDelimiter = 0x1D;

        public static void Write(byte[] Bytes, bool NoDelim = false)
        {
            foreach (byte B in Bytes)
            {
                Write(B,true);
            }
            if (NoDelim) return;
            byte[] Delim = { SendSingleDelimiter };
            Port.Write(Delim, 0, 1);
            System.Threading.Thread.Sleep(2);
        }
        public static void Write(byte B, bool NoDelim = false)
        {
            byte[] BB = {B};
            Port.Write(BB,0,1);
            System.Threading.Thread.Sleep(2);
            if (NoDelim) return;
            byte[] Delim = { SendSingleDelimiter };
            Port.Write(Delim, 0, 1);
        }
        public static void Write(string S, bool NoDelim = false)
        {
            Write(CommonMethods.String_To_Bytes(S),NoDelim);
        }
        public static void Write(string[] Strings, bool NoDelim = false)
        {
            Write(CommonMethods.String_To_Bytes(Strings), NoDelim);
        }

    }
    
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsData.Initialize, "Port")]
    public class Initialize_Port : System.Management.Automation.Cmdlet
    {
        [System.Management.Automation.Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true)]
        public string Name;
        [System.Management.Automation.Parameter]
        public int Baud;
        [System.Management.Automation.Parameter]
        public byte Delim = 0x1E; //picked because it's technically the ASCII "End Of Record" character

        protected override void ProcessRecord()
        {
            try {Client.Port.Close();}
            catch (System.Exception) {}
            
            if (Baud > 0)
                Client.Port = new System.IO.Ports.SerialPort(Name,Baud);
            else
                Client.Port = new System.IO.Ports.SerialPort(Name);
            Client.Port.Open();
            Client.SendSingleDelimiter = Delim;
        }
    }

    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommunications.Write, "Port", DefaultParameterSetName = "String")]
    public class Write_Port : System.Management.Automation.PSCmdlet
    {
        [System.Management.Automation.Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ParameterSetName = "String")]
        public string String;
        [System.Management.Automation.Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ParameterSetName = "ByteArray")]
        public byte[] ByteArray;
        [System.Management.Automation.Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ParameterSetName = "Byte")]
        public byte Byte;
        [System.Management.Automation.Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ParameterSetName = "StringArray")]
        public string[] StringArray;
        [System.Management.Automation.Parameter]
        public System.Management.Automation.SwitchParameter NoDelim;

        protected override void ProcessRecord()
        {
            switch (ParameterSetName)
            {
                case "String":
                    if (String == null)
                        return;
                    //Catch the special case of an empty string
                    if (String.Equals(""))
                        Client.Write((byte)10, NoDelim);
                    else
                        Client.Write(String, NoDelim);
                    break;
                case "ByteArray":
                    if (ByteArray == null)
                        return;
                    Client.Write(ByteArray, NoDelim);
                    break;
                case "Byte":
                    Client.Write(Byte, NoDelim);
                    break;
                case "StringArray":
                    if (StringArray == null)
                        return;
                    Client.Write(StringArray, NoDelim);
                    break;
                default:
                    break;
            } //end parameter set switch
        }
    }

    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommunications.Read, "Port")]
    public class Read_Port : System.Management.Automation.Cmdlet
    {
        protected override void  ProcessRecord()
        {
            string s = Client.Port.ReadTo(Client.ReadMsgDelimiter);
            WriteObject(s);
        }
    }

    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.Get, "Port")]
    public class Get_Port : System.Management.Automation.Cmdlet
    {
        protected override void ProcessRecord()
        {
            WriteObject(Client.Port);
        }
    }

    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.Set, "ReadDelimiter")]
    public class Set_ReadDelimiter : System.Management.Automation.Cmdlet
    {
        [System.Management.Automation.Parameter(Mandatory = true)] 
        public string Delim;

        protected override void ProcessRecord()
        {
            Client.ReadMsgDelimiter = Delim;
        }
    }

    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.Set, "EOFDelimiter")]
    public class Set_EOFDelimiter : System.Management.Automation.Cmdlet
    {
        [System.Management.Automation.Parameter(Mandatory = true)]
        public byte Delim;

        protected override void ProcessRecord()
        {
            Client.EndOfProcessingDelimiter = Delim;
        }
    }

    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommunications.Write, "EOF")]
    public class Write_EOF : System.Management.Automation.Cmdlet
    {
        protected override void ProcessRecord()
        {
            Client.Write(Client.EndOfProcessingDelimiter);
        }
    }

}
