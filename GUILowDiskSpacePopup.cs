using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001CB")]
public class GUILowDiskSpacePopup
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400145A")]
	public bool DisableWarnings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400145B")]
	public bool WarningDisplayed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400145C")]
	private Action ContinueCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400145D")]
	private float scale0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400145E")]
	private float scale1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400145F")]
	private float scale2;

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0xDF2154", Offset = "0xDF2154", VA = "0xDF2154")]
	private long DiskSpace()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0xDF2518", Offset = "0xDF2518", VA = "0xDF2518")]
	public void CheckDiskSpace(Action continueAction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0xDF2560", Offset = "0xDF2560", VA = "0xDF2560")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0xDF28E4", Offset = "0xDF28E4", VA = "0xDF28E4")]
	public GUILowDiskSpacePopup()
	{
	}
}
