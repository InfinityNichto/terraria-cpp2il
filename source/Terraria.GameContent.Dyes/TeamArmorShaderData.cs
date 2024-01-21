using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes;

[Cpp2IlInjected.Token(Token = "0x2000586")]
public class TeamArmorShaderData : ArmorShaderData
{
	[Cpp2IlInjected.Token(Token = "0x4006B0A")]
	private static bool isInitialized;

	[Cpp2IlInjected.Token(Token = "0x4006B0B")]
	private static ArmorShaderData[] dustShaderData;

	[Cpp2IlInjected.Token(Token = "0x6003BCC")]
	[Cpp2IlInjected.Address(RVA = "0xF4DDC4", Offset = "0xF4DDC4", VA = "0xF4DDC4")]
	public TeamArmorShaderData(Ref<Effect> shader, string passName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BCD")]
	[Cpp2IlInjected.Address(RVA = "0xF4E008", Offset = "0xF4E008", VA = "0xF4E008", Slot = "4")]
	public override void Apply(Entity entity, DrawData? drawData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BCE")]
	[Cpp2IlInjected.Address(RVA = "0xF4E268", Offset = "0xF4E268", VA = "0xF4E268", Slot = "6")]
	public override ArmorShaderData GetSecondaryShader(Entity entity)
	{
		return null;
	}
}
