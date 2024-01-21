using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Shaders;

[Cpp2IlInjected.Token(Token = "0x200058D")]
public class SepiaScreenShaderData : ScreenShaderData
{
	[Cpp2IlInjected.Token(Token = "0x6003BDE")]
	[Cpp2IlInjected.Address(RVA = "0x11A6938", Offset = "0x11A6938", VA = "0x11A6938")]
	public SepiaScreenShaderData(string passName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BDF")]
	[Cpp2IlInjected.Address(RVA = "0x11A6940", Offset = "0x11A6940", VA = "0x11A6940", Slot = "6")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BE0")]
	[Cpp2IlInjected.Address(RVA = "0x11A6F40", Offset = "0x11A6F40", VA = "0x11A6F40")]
	private static void GetDaylightPowers(out float nightlightPower, out float daylightPower, out float moonPower, out float dawnPower)
	{
	}
}
