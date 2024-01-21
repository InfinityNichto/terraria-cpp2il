using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001CD")]
public class GUILowMemorySetttings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001467")]
	public bool WarningDisplayed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001468")]
	private Action ContinueCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001469")]
	private float scale0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400146A")]
	private float scale1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400146B")]
	private float scale2;

	[Cpp2IlInjected.Token(Token = "0x6000CAC")]
	[Cpp2IlInjected.Address(RVA = "0xDF2E24", Offset = "0xDF2E24", VA = "0xDF2E24")]
	public void CheckMemorySettings(Action continueAction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAD")]
	[Cpp2IlInjected.Address(RVA = "0xDF2F10", Offset = "0xDF2F10", VA = "0xDF2F10")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAE")]
	[Cpp2IlInjected.Address(RVA = "0xDF3250", Offset = "0xDF3250", VA = "0xDF3250")]
	public GUILowMemorySetttings()
	{
	}
}
