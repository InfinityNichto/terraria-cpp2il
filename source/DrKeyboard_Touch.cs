using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DrKeyboard_Touch : DrKeyboard_Base
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static bool appGainedFocus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private TouchScreenKeyboard _keyboard;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public override bool active
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x20CDA58", Offset = "0x20CDA58", VA = "0x20CDA58", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x20CDAF8", Offset = "0x20CDAF8", VA = "0x20CDAF8", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override bool done
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x20CDB08", Offset = "0x20CDB08", VA = "0x20CDB08", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public override string text
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x20CDB2C", Offset = "0x20CDB2C", VA = "0x20CDB2C", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x20CDB38", Offset = "0x20CDB38", VA = "0x20CDB38", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public override bool wasCanceled
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x20CDB44", Offset = "0x20CDB44", VA = "0x20CDB44", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x20CD9DC", Offset = "0x20CD9DC", VA = "0x20CD9DC")]
	public static void AppFocusGained()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x20CD4B4", Offset = "0x20CD4B4", VA = "0x20CD4B4")]
	public DrKeyboard_Touch(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt, bool password = false, bool multiline = false)
	{
	}
}
