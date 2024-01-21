using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000173")]
public class WorldNoBackup
{
	[Cpp2IlInjected.Token(Token = "0x4000E58")]
	public static WorldNoBackup Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000E59")]
	public StringButton_Layout Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000E5A")]
	public StringButton_Layout Description;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000E5B")]
	public TransactionButton_Layout Back;

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x14FB238", Offset = "0x14FB238", VA = "0x14FB238")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x14FB294", Offset = "0x14FB294", VA = "0x14FB294")]
	public WorldNoBackup()
	{
	}
}
