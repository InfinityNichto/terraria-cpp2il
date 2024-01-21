using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000171")]
public class LoadBackup_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000E51")]
	public static LoadBackup_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000E52")]
	public LoadWorld LoadWorld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000E53")]
	public WorldNoBackup WorldNoBackup;

	[Cpp2IlInjected.Token(Token = "0x6000B91")]
	[Cpp2IlInjected.Address(RVA = "0x12DB6C4", Offset = "0x12DB6C4", VA = "0x12DB6C4")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B92")]
	[Cpp2IlInjected.Address(RVA = "0x12DB720", Offset = "0x12DB720", VA = "0x12DB720")]
	public LoadBackup_Layout()
	{
	}
}
