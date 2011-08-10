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
    public static class Server
    {
        public static byte ReadDelimiter;
        public static byte ReadEOFDelimiter = 0x1D;
        public static string SendDelimiter = "^^^DONE^^^";

        public static void Write(System.IO.Pipes.NamedPipeClientStream Pipe, byte[] Bytes, bool NoDelim = false)
        {
            foreach (byte B in Bytes)
            {
                Write(Pipe, B, true);
            }
            if (NoDelim) return;
            Write(Pipe, SendDelimiter,true);
            System.Threading.Thread.Sleep(1);
        }
        public static void Write(System.IO.Pipes.NamedPipeClientStream Pipe, byte B, bool NoDelim = false)
        {
            byte[] BB = { B };
            Pipe.Write(BB, 0, 1);
            System.Threading.Thread.Sleep(1);
            if (NoDelim) return;
            Write(Pipe, SendDelimiter, true);
        }
        public static void Write(System.IO.Pipes.NamedPipeClientStream Pipe, string S, bool NoDelim = false)
        {
            Write(Pipe, CommonMethods.String_To_Bytes(S), NoDelim);
        }
        public static void Write(System.IO.Pipes.NamedPipeClientStream Pipe, string[] Strings, bool NoDelim = false)
        {
            Write(Pipe, CommonMethods.String_To_Bytes(Strings), NoDelim);
        }
    }

    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, "Pipe")]
    public class New_Pipe : System.Management.Automation.Cmdlet
    {
        [System.Management.Automation.Parameter(Position = 0, Mandatory = true)]
        public string Name;
        [System.Management.Automation.Parameter]
        public string Server = ".";
        [System.Management.Automation.Parameter]
        public byte Delimiter = 0x1E;

        protected override void ProcessRecord()
        {
            System.IO.Pipes.NamedPipeClientStream Pipe;
            Pipe = new System.IO.Pipes.NamedPipeClientStream(Server, Name);
            Pipe.Connect();
            Test.cmdlets.Server.ReadDelimiter = Delimiter;
            WriteObject(Pipe);
        }
    }

    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommunications.Write, "Pipe", DefaultParameterSetName = "String")]
    public class Write_Pipe : System.Management.Automation.PSCmdlet
    {
        [System.Management.Automation.Parameter(Position = 0, Mandatory = true)]
        public System.IO.Pipes.NamedPipeClientStream Pipe;
        [System.Management.Automation.Parameter(Position = 1, Mandatory = true, ValueFromPipeline = true, ParameterSetName = "String")]
        public string String;
        [System.Management.Automation.Parameter(Position = 1, Mandatory = true, ValueFromPipeline = true, ParameterSetName = "ByteArray")]
        public byte[] ByteArray;
        [System.Management.Automation.Parameter(Position = 1, Mandatory = true, ValueFromPipeline = true, ParameterSetName = "Byte")]
        public byte Byte;
        [System.Management.Automation.Parameter(Position = 1, Mandatory = true, ValueFromPipeline = true, ParameterSetName = "StringArray")]
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
                    Server.Write(Pipe, String, NoDelim);
                    break;
                case "ByteArray":
                    if (ByteArray == null)
                        return;
                    Server.Write(Pipe, ByteArray, NoDelim);
                    break;
                case "Byte":
                    Server.Write(Pipe, Byte, NoDelim);
                    break;
                case "StringArray":
                    if (StringArray == null)
                        return;
                    Server.Write(Pipe, StringArray, NoDelim);
                    break;
                default:
                    break;
            } //end parameter set switch
        }
    }

    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommunications.Read, "Pipe")]
    public class Read_Pipe : System.Management.Automation.Cmdlet
    {
        [System.Management.Automation.Parameter(Position = 0, Mandatory = true)]
        public System.IO.Pipes.NamedPipeClientStream Pipe;
        [System.Management.Automation.Parameter]
        public System.Management.Automation.SwitchParameter AsBytes;

        protected override void ProcessRecord()
        {
            System.Collections.ArrayList ByteArr = new System.Collections.ArrayList();
            byte B;
            B = (byte)Pipe.ReadByte();
            while (B != Server.ReadDelimiter)
            {
                ByteArr.Add(B);
                B = (byte)Pipe.ReadByte();
            }
            
            byte[] Bytes = (byte[]) ByteArr.ToArray(typeof (byte));
            if (AsBytes)
                WriteObject(Bytes);
            else
                WriteObject(CommonMethods.Bytes_To_String(Bytes));
        }
    }

    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.Set, "PipeDelimiter")]
    public class Set_PipeDelimiter : System.Management.Automation.Cmdlet
    {
        [System.Management.Automation.Parameter(Position = 0, Mandatory = true)]
        public byte Delimiter;

        protected override void ProcessRecord()
        {
            Server.ReadDelimiter = Delimiter;
        }
    }

}
