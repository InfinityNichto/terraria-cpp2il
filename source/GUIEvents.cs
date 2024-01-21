using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000E0")]
public class GUIEvents
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private float testProgress;

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x1385290", Offset = "0x1385290", VA = "0x1385290")]
	public void DrawInvasionInfo(Color panel, string title, string waveProgressString, Texture2D icon, float progressScale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x1385AC0", Offset = "0x1385AC0", VA = "0x1385AC0")]
	private void DrawProgressBar(float progress)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x1385D34", Offset = "0x1385D34", VA = "0x1385D34")]
	private void DrawInfiniteProgressBar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0x1385F78", Offset = "0x1385F78", VA = "0x1385F78")]
	public GUIEvents()
	{
	}
}
