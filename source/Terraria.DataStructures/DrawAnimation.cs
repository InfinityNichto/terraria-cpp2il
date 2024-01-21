using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000427")]
public class DrawAnimation
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40062C4")]
	public int Frame;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40062C5")]
	public int FrameCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40062C6")]
	public int TicksPerFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40062C7")]
	public int FrameCounter;

	[Cpp2IlInjected.Token(Token = "0x60030F8")]
	[Cpp2IlInjected.Address(RVA = "0x1012B20", Offset = "0x1012B20", VA = "0x1012B20", Slot = "4")]
	public virtual void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030F9")]
	[Cpp2IlInjected.Address(RVA = "0x1012B24", Offset = "0x1012B24", VA = "0x1012B24", Slot = "5")]
	public virtual Rectangle GetFrame(Texture2D texture, int frameCounterOverride = -1)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60030FA")]
	[Cpp2IlInjected.Address(RVA = "0x1012BCC", Offset = "0x1012BCC", VA = "0x1012BCC")]
	public DrawAnimation()
	{
	}
}
