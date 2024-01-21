using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000C0")]
public static class GUIProgressBar
{
	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0xE2DC08", Offset = "0xE2DC08", VA = "0xE2DC08")]
	public static void Draw(ProgressBar_Layout layout, ref float value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0xE2DFD0", Offset = "0xE2DFD0", VA = "0xE2DFD0")]
	private static void DrawFilling2(SpriteBatch spritebatch, Vector2 topLeft, int height, int completedWidth, int totalWidth, Color filled, Color separator, Color empty)
	{
	}
}
