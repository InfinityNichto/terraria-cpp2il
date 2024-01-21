using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class GUIDPad
{
	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x12C75B0", Offset = "0x12C75B0", VA = "0x12C75B0")]
	public static void Draw(DPad_Layout layout, Texture2D arrow)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x12C7EC0", Offset = "0x12C7EC0", VA = "0x12C7EC0")]
	public static bool IsCursorOver(Vector2 position, DPad_Layout layout, out bool left, out bool right, out bool up, out bool down)
	{
		return default(bool);
	}
}
