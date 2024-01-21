using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000D4")]
public class GUIControllerDisconnected
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private float statusScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private float loadScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private float backScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private float titleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private float buttonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private bool wasDown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private GUIInputRegionExclusive _optionsBlocker;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private static bool showingReassign;

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x1294AD0", Offset = "0x1294AD0", VA = "0x1294AD0")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x1294AD8", Offset = "0x1294AD8", VA = "0x1294AD8")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x1295198", Offset = "0x1295198", VA = "0x1295198")]
	private void DisplayNpadConnectionPromptAndReassignNpads()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x129521C", Offset = "0x129521C", VA = "0x129521C")]
	public GUIControllerDisconnected()
	{
	}
}
