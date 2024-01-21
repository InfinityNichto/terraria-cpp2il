using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Shaders;

[Cpp2IlInjected.Token(Token = "0x2000589")]
public class BlizzardShaderData : ScreenShaderData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4006B0C")]
	private Vector2 _texturePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4006B0D")]
	private float windSpeed;

	[Cpp2IlInjected.Token(Token = "0x6003BD3")]
	[Cpp2IlInjected.Address(RVA = "0x11A5B28", Offset = "0x11A5B28", VA = "0x11A5B28")]
	public BlizzardShaderData(string passName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BD4")]
	[Cpp2IlInjected.Address(RVA = "0x11A5C24", Offset = "0x11A5C24", VA = "0x11A5C24", Slot = "6")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BD5")]
	[Cpp2IlInjected.Address(RVA = "0x11A5FA4", Offset = "0x11A5FA4", VA = "0x11A5FA4", Slot = "5")]
	public override void Apply()
	{
	}
}
