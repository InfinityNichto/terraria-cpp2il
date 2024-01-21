using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes;

[Cpp2IlInjected.Token(Token = "0x2000584")]
public class LegacyHairShaderData : HairShaderData
{
	[Cpp2IlInjected.Token(Token = "0x200099B")]
	public delegate Color ColorProcessingMethod(Player player, Color color, ref bool lighting);

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4006B09")]
	private ColorProcessingMethod _colorProcessor;

	[Cpp2IlInjected.Token(Token = "0x6003BC7")]
	[Cpp2IlInjected.Address(RVA = "0xF4CFEC", Offset = "0xF4CFEC", VA = "0xF4CFEC")]
	public LegacyHairShaderData()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BC8")]
	[Cpp2IlInjected.Address(RVA = "0xF4D014", Offset = "0xF4D014", VA = "0xF4D014", Slot = "7")]
	public override Color GetColor(Player player, Color lightColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BC9")]
	[Cpp2IlInjected.Address(RVA = "0xF4D634", Offset = "0xF4D634", VA = "0xF4D634")]
	public LegacyHairShaderData UseLegacyMethod(ColorProcessingMethod colorProcessor)
	{
		return null;
	}
}
