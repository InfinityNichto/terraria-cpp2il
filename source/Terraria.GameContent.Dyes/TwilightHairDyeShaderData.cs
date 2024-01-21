using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes;

[Cpp2IlInjected.Token(Token = "0x2000588")]
public class TwilightHairDyeShaderData : HairShaderData
{
	[Cpp2IlInjected.Token(Token = "0x6003BD1")]
	[Cpp2IlInjected.Address(RVA = "0xF4E574", Offset = "0xF4E574", VA = "0xF4E574")]
	public TwilightHairDyeShaderData(Ref<Effect> shader, string passName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BD2")]
	[Cpp2IlInjected.Address(RVA = "0xF4E57C", Offset = "0xF4E57C", VA = "0xF4E57C", Slot = "6")]
	public override void Apply(Player player, [Optional] DrawData? drawData)
	{
	}
}
