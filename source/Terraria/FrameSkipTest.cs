using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200032E")]
public class FrameSkipTest
{
	[Cpp2IlInjected.Token(Token = "0x4002CE1")]
	private static int LastRecordedSecondNumber;

	[Cpp2IlInjected.Token(Token = "0x4002CE2")]
	private static float CallsThisSecond;

	[Cpp2IlInjected.Token(Token = "0x4002CE3")]
	private static float DeltasThisSecond;

	[Cpp2IlInjected.Token(Token = "0x4002CE4")]
	private static List<float> DeltaSamples;

	[Cpp2IlInjected.Token(Token = "0x4002CE5")]
	private const int SamplesCount = 5;

	[Cpp2IlInjected.Token(Token = "0x4002CE6")]
	private static MultiTimer serverFramerateTest;

	[Cpp2IlInjected.Token(Token = "0x600262B")]
	[Cpp2IlInjected.Address(RVA = "0x132E998", Offset = "0x132E998", VA = "0x132E998")]
	public static void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600262C")]
	[Cpp2IlInjected.Address(RVA = "0x132EA10", Offset = "0x132EA10", VA = "0x132EA10")]
	public static void CheckReset(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600262D")]
	[Cpp2IlInjected.Address(RVA = "0x132EBC4", Offset = "0x132EBC4", VA = "0x132EBC4")]
	public static void UpdateServerTest()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600262E")]
	[Cpp2IlInjected.Address(RVA = "0x132EC7C", Offset = "0x132EC7C", VA = "0x132EC7C")]
	public FrameSkipTest()
	{
	}
}
