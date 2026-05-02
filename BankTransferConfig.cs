using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Modul9_103022400038;
using System.Runtime.CompilerServices;

public class BankTransferConfig
{

    public Config Config { get; set; }
    private string filepath;

}

public BankTranserConfig()
{
   this.filepath = Path.GetFullPath
}

public class ReadConfigFile()
{

}

public class WriteConfigFile()
{
    public Config Config { get; set; }
}

public class Setdefault()
{
    public string filepath { get; set; }
}
