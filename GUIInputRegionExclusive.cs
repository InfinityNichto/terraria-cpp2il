using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200010C")]
public class GUIInputRegionExclusive
{
	[Cpp2IlInjected.Token(Token = "0x20007C9")]
	public delegate bool IsOverHandler(Vector2 cursorPosition);

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400085B")]
	public readonly IsOverHandler isOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400085C")]
	public bool Active;

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0xDDE0F0", Offset = "0xDDE0F0", VA = "0xDDE0F0")]
	public GUIInputRegionExclusive(IsOverHandler handler)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0xDDE110", Offset = "0xDDE110", VA = "0xDDE110")]
	public bool Over(int x, int y)
	{
		return default(bool);
	}
}
