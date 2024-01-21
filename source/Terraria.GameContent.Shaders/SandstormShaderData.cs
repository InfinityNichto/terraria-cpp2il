using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Shaders;

[Cpp2IlInjected.Token(Token = "0x200058C")]
public class SandstormShaderData : ScreenShaderData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4006B10")]
	private Vector2 _texturePosition;

	[Cpp2IlInjected.Token(Token = "0x6003BDB")]
	[Cpp2IlInjected.Address(RVA = "0x11A654C", Offset = "0x11A654C", VA = "0x11A654C")]
	public SandstormShaderData(string passName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BDC")]
	[Cpp2IlInjected.Address(RVA = "0x11A663C", Offset = "0x11A663C", VA = "0x11A663C", Slot = "6")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BDD")]
	[Cpp2IlInjected.Address(RVA = "0x11A690C", Offset = "0x11A690C", VA = "0x11A690C", Slot = "5")]
	public override void Apply()
	{
	}
}
