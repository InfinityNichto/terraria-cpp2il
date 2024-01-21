using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001CC")]
public class GUILowMemoryPopup
{
	[Cpp2IlInjected.Token(Token = "0x20007F0")]
	public enum MemoryAction
	{
		[Cpp2IlInjected.Token(Token = "0x4007CAD")]
		Host,
		[Cpp2IlInjected.Token(Token = "0x4007CAE")]
		PlayLarge,
		[Cpp2IlInjected.Token(Token = "0x4007CAF")]
		GenerateLarge
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001460")]
	public bool WarningDisplayed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4001461")]
	public bool DisableWarnings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001462")]
	private MemoryAction CurrentWarning;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001463")]
	private Action ContinueCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001464")]
	private float scale0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001465")]
	private float scale1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001466")]
	private float scale2;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public static long DeviceMemory
	{
		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0xDF2934", Offset = "0xDF2934", VA = "0xDF2934")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0xDF28EC", Offset = "0xDF28EC", VA = "0xDF28EC")]
	public void CheckMemoryAction(MemoryAction action, Action continueAction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAA")]
	[Cpp2IlInjected.Address(RVA = "0xDF294C", Offset = "0xDF294C", VA = "0xDF294C")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAB")]
	[Cpp2IlInjected.Address(RVA = "0xDF2E1C", Offset = "0xDF2E1C", VA = "0xDF2E1C")]
	public GUILowMemoryPopup()
	{
	}
}
