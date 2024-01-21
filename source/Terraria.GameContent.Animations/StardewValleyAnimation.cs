using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Animations;

[Cpp2IlInjected.Token(Token = "0x2000651")]
public class StardewValleyAnimation
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C9C")]
	private List<IAnimationSegment> _segments;

	[Cpp2IlInjected.Token(Token = "0x6003F64")]
	[Cpp2IlInjected.Address(RVA = "0xFB6748", Offset = "0xFB6748", VA = "0xFB6748")]
	public StardewValleyAnimation()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F65")]
	[Cpp2IlInjected.Address(RVA = "0xFB67D8", Offset = "0xFB67D8", VA = "0xFB67D8")]
	private void ComposeAnimation()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F66")]
	[Cpp2IlInjected.Address(RVA = "0xFB76A8", Offset = "0xFB76A8", VA = "0xFB76A8")]
	private Matrix GetMatrixForAnimation()
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x6003F67")]
	[Cpp2IlInjected.Address(RVA = "0xFB7724", Offset = "0xFB7724", VA = "0xFB7724")]
	public void Draw(SpriteBatch spriteBatch, int timeInAnimation, Vector2 positionInScreen)
	{
	}
}
