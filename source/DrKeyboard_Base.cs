using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class DrKeyboard_Base
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static bool isSupported
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x20CD5A0", Offset = "0x20CD5A0", VA = "0x20CD5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public abstract bool active
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract bool wasCanceled
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract bool done
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public abstract string text
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x20CCEB0", Offset = "0x20CCEB0", VA = "0x20CCEB0")]
	public static DrKeyboard_Base Create(TouchScreenKeyboardType type, string initialText, int maxChars, string title, string prompt, bool password = false, bool multiline = false, bool filterText = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x20CD66C", Offset = "0x20CD66C", VA = "0x20CD66C", Slot = "10")]
	public virtual void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x20CD670", Offset = "0x20CD670", VA = "0x20CD670")]
	protected DrKeyboard_Base()
	{
	}
}
