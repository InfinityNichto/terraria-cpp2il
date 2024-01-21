using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Graphics.Shaders;

[Cpp2IlInjected.Token(Token = "0x20004EF")]
public class GameShaders
{
	[Cpp2IlInjected.Token(Token = "0x400675C")]
	public static ArmorShaderDataSet Armor;

	[Cpp2IlInjected.Token(Token = "0x400675D")]
	public static HairShaderDataSet Hair;

	[Cpp2IlInjected.Token(Token = "0x400675E")]
	public static Dictionary<string, MiscShaderData> Misc;

	[Cpp2IlInjected.Token(Token = "0x600372A")]
	[Cpp2IlInjected.Address(RVA = "0x1247E30", Offset = "0x1247E30", VA = "0x1247E30")]
	public GameShaders()
	{
	}
}
