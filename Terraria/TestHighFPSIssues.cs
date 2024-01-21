using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200032F")]
public class TestHighFPSIssues
{
	[Cpp2IlInjected.Token(Token = "0x4002CE7")]
	private static List<double> _tapUpdates;

	[Cpp2IlInjected.Token(Token = "0x4002CE8")]
	private static List<double> _tapUpdateEnds;

	[Cpp2IlInjected.Token(Token = "0x4002CE9")]
	private static List<double> _tapDraws;

	[Cpp2IlInjected.Token(Token = "0x4002CEA")]
	private static int conU;

	[Cpp2IlInjected.Token(Token = "0x4002CEB")]
	private static int conUH;

	[Cpp2IlInjected.Token(Token = "0x4002CEC")]
	private static int conD;

	[Cpp2IlInjected.Token(Token = "0x4002CED")]
	private static int conDH;

	[Cpp2IlInjected.Token(Token = "0x4002CEE")]
	private static int race;

	[Cpp2IlInjected.Token(Token = "0x6002630")]
	[Cpp2IlInjected.Address(RVA = "0x14E8410", Offset = "0x14E8410", VA = "0x14E8410")]
	public static void TapUpdate(GameTime gt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002631")]
	[Cpp2IlInjected.Address(RVA = "0x14E8544", Offset = "0x14E8544", VA = "0x14E8544")]
	public static void TapUpdateEnd(GameTime gt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002632")]
	[Cpp2IlInjected.Address(RVA = "0x14E8610", Offset = "0x14E8610", VA = "0x14E8610")]
	public static void TapDraw(GameTime gt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002633")]
	[Cpp2IlInjected.Address(RVA = "0x14E8748", Offset = "0x14E8748", VA = "0x14E8748")]
	public static void Update(GameTime gt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002634")]
	[Cpp2IlInjected.Address(RVA = "0x14E8E3C", Offset = "0x14E8E3C", VA = "0x14E8E3C")]
	public TestHighFPSIssues()
	{
	}
}
