using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.RGB;

[Cpp2IlInjected.Token(Token = "0x2000590")]
public static class NoiseHelper
{
	[Cpp2IlInjected.Token(Token = "0x4006B2D")]
	private const int RANDOM_SEED = 1;

	[Cpp2IlInjected.Token(Token = "0x4006B2E")]
	private const int NOISE_2D_SIZE = 32;

	[Cpp2IlInjected.Token(Token = "0x4006B2F")]
	private const int NOISE_2D_SIZE_MASK = 31;

	[Cpp2IlInjected.Token(Token = "0x4006B30")]
	private const int NOISE_SIZE_MASK = 1023;

	[Cpp2IlInjected.Token(Token = "0x4006B31")]
	private static readonly float[] StaticNoise;

	[Cpp2IlInjected.Token(Token = "0x6003BEF")]
	[Cpp2IlInjected.Address(RVA = "0x11A5200", Offset = "0x11A5200", VA = "0x11A5200")]
	private static float[] CreateStaticNoise(int length)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003BF0")]
	[Cpp2IlInjected.Address(RVA = "0x11A52E8", Offset = "0x11A52E8", VA = "0x11A52E8")]
	public static float GetDynamicNoise(int index, float currentTime)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BF1")]
	[Cpp2IlInjected.Address(RVA = "0x11A53D8", Offset = "0x11A53D8", VA = "0x11A53D8")]
	public static float GetStaticNoise(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BF2")]
	[Cpp2IlInjected.Address(RVA = "0x11A5460", Offset = "0x11A5460", VA = "0x11A5460")]
	public static float GetDynamicNoise(int x, int y, float currentTime)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BF3")]
	[Cpp2IlInjected.Address(RVA = "0x11A54F4", Offset = "0x11A54F4", VA = "0x11A54F4")]
	private static float GetDynamicNoiseInternal(int x, int y, float wrappedTime)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BF4")]
	[Cpp2IlInjected.Address(RVA = "0x11A55DC", Offset = "0x11A55DC", VA = "0x11A55DC")]
	public static float GetStaticNoise(int x, int y)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BF5")]
	[Cpp2IlInjected.Address(RVA = "0x11A566C", Offset = "0x11A566C", VA = "0x11A566C")]
	public static float GetDynamicNoise(Vector2 position, float currentTime)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003BF6")]
	[Cpp2IlInjected.Address(RVA = "0x11A58AC", Offset = "0x11A58AC", VA = "0x11A58AC")]
	public static float GetStaticNoise(Vector2 position)
	{
		return default(float);
	}
}
