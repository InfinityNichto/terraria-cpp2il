using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes;

[Cpp2IlInjected.Token(Token = "0x2000587")]
public class TwilightDyeShaderData : ArmorShaderData
{
	[Cpp2IlInjected.Token(Token = "0x6003BCF")]
	[Cpp2IlInjected.Address(RVA = "0xF4E2FC", Offset = "0xF4E2FC", VA = "0xF4E2FC")]
	public TwilightDyeShaderData(Ref<Effect> shader, string passName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BD0")]
	[Cpp2IlInjected.Address(RVA = "0xF4E304", Offset = "0xF4E304", VA = "0xF4E304", Slot = "4")]
	public override void Apply(Entity entity, DrawData? drawData)
	{
	}
}
