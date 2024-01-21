using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000428")]
public class DrawAnimationVertical : DrawAnimation
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40062C8")]
	public bool PingPong;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x40062C9")]
	public bool NotActuallyAnimating;

	[Cpp2IlInjected.Token(Token = "0x60030FB")]
	[Cpp2IlInjected.Address(RVA = "0x1012BD4", Offset = "0x1012BD4", VA = "0x1012BD4")]
	public DrawAnimationVertical(int ticksperframe, int frameCount, bool pingPong = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030FC")]
	[Cpp2IlInjected.Address(RVA = "0x1012C0C", Offset = "0x1012C0C", VA = "0x1012C0C", Slot = "4")]
	public override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030FD")]
	[Cpp2IlInjected.Address(RVA = "0x1012C6C", Offset = "0x1012C6C", VA = "0x1012C6C", Slot = "5")]
	public override Rectangle GetFrame(Texture2D texture, int frameCounterOverride = -1)
	{
		return default(Rectangle);
	}
}
