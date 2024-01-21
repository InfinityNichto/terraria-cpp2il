using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes;

[Cpp2IlInjected.Token(Token = "0x2000585")]
public class ReflectiveArmorShaderData : ArmorShaderData
{
	[Cpp2IlInjected.Token(Token = "0x6003BCA")]
	[Cpp2IlInjected.Address(RVA = "0xF4D738", Offset = "0xF4D738", VA = "0xF4D738")]
	public ReflectiveArmorShaderData(Ref<Effect> shader, string passName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BCB")]
	[Cpp2IlInjected.Address(RVA = "0xF4D740", Offset = "0xF4D740", VA = "0xF4D740", Slot = "4")]
	public override void Apply(Entity entity, DrawData? drawData)
	{
	}
}
