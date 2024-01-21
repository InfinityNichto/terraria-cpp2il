using Cpp2IlInjected;

namespace Terraria.ID;

[Cpp2IlInjected.Token(Token = "0x200040F")]
public static class TorchID
{
	[Cpp2IlInjected.Token(Token = "0x2000921")]
	private interface ITorchLightProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6004CC2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GetRGB(out float r, out float g, out float b);
	}

	[Cpp2IlInjected.Token(Token = "0x2000922")]
	private struct ConstantTorchLight : ITorchLightProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008AA7")]
		public float R;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008AA8")]
		public float G;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008AA9")]
		public float B;

		[Cpp2IlInjected.Token(Token = "0x6004CC3")]
		[Cpp2IlInjected.Address(RVA = "0x39F358", Offset = "0x39F358", VA = "0x39F358")]
		public ConstantTorchLight(float Red, float Green, float Blue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004CC4")]
		[Cpp2IlInjected.Address(RVA = "0x39F364", Offset = "0x39F364", VA = "0x39F364", Slot = "4")]
		public void GetRGB(out float r, out float g, out float b)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000923")]
	private struct DemonTorchLight : ITorchLightProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6004CC5")]
		[Cpp2IlInjected.Address(RVA = "0x39F380", Offset = "0x39F380", VA = "0x39F380", Slot = "4")]
		public void GetRGB(out float r, out float g, out float b)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000924")]
	private struct ShimmerTorchLight : ITorchLightProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6004CC6")]
		[Cpp2IlInjected.Address(RVA = "0x39F3B0", Offset = "0x39F3B0", VA = "0x39F3B0", Slot = "4")]
		public void GetRGB(out float r, out float g, out float b)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000925")]
	private struct DiscoTorchLight : ITorchLightProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6004CC7")]
		[Cpp2IlInjected.Address(RVA = "0x39F398", Offset = "0x39F398", VA = "0x39F398", Slot = "4")]
		public void GetRGB(out float r, out float g, out float b)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4005F63")]
	public static int[] Dust;

	[Cpp2IlInjected.Token(Token = "0x4005F64")]
	private static ITorchLightProvider[] _lights;

	[Cpp2IlInjected.Token(Token = "0x4005F65")]
	public const short Torch = 0;

	[Cpp2IlInjected.Token(Token = "0x4005F66")]
	public const short Blue = 1;

	[Cpp2IlInjected.Token(Token = "0x4005F67")]
	public const short Red = 2;

	[Cpp2IlInjected.Token(Token = "0x4005F68")]
	public const short Green = 3;

	[Cpp2IlInjected.Token(Token = "0x4005F69")]
	public const short Purple = 4;

	[Cpp2IlInjected.Token(Token = "0x4005F6A")]
	public const short White = 5;

	[Cpp2IlInjected.Token(Token = "0x4005F6B")]
	public const short Yellow = 6;

	[Cpp2IlInjected.Token(Token = "0x4005F6C")]
	public const short Demon = 7;

	[Cpp2IlInjected.Token(Token = "0x4005F6D")]
	public const short Cursed = 8;

	[Cpp2IlInjected.Token(Token = "0x4005F6E")]
	public const short Ice = 9;

	[Cpp2IlInjected.Token(Token = "0x4005F6F")]
	public const short Orange = 10;

	[Cpp2IlInjected.Token(Token = "0x4005F70")]
	public const short Ichor = 11;

	[Cpp2IlInjected.Token(Token = "0x4005F71")]
	public const short UltraBright = 12;

	[Cpp2IlInjected.Token(Token = "0x4005F72")]
	public const short Bone = 13;

	[Cpp2IlInjected.Token(Token = "0x4005F73")]
	public const short Rainbow = 14;

	[Cpp2IlInjected.Token(Token = "0x4005F74")]
	public const short Pink = 15;

	[Cpp2IlInjected.Token(Token = "0x4005F75")]
	public const short Desert = 16;

	[Cpp2IlInjected.Token(Token = "0x4005F76")]
	public const short Coral = 17;

	[Cpp2IlInjected.Token(Token = "0x4005F77")]
	public const short Corrupt = 18;

	[Cpp2IlInjected.Token(Token = "0x4005F78")]
	public const short Crimson = 19;

	[Cpp2IlInjected.Token(Token = "0x4005F79")]
	public const short Hallowed = 20;

	[Cpp2IlInjected.Token(Token = "0x4005F7A")]
	public const short Jungle = 21;

	[Cpp2IlInjected.Token(Token = "0x4005F7B")]
	public const short Mushroom = 22;

	[Cpp2IlInjected.Token(Token = "0x4005F7C")]
	public const short Shimmer = 23;

	[Cpp2IlInjected.Token(Token = "0x4005F7D")]
	public static readonly short Count;

	[Cpp2IlInjected.Token(Token = "0x60030CB")]
	[Cpp2IlInjected.Address(RVA = "0x147B964", Offset = "0x147B964", VA = "0x147B964")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030CC")]
	[Cpp2IlInjected.Address(RVA = "0x147C260", Offset = "0x147C260", VA = "0x147C260")]
	public static void TorchColor(int torchID, out float R, out float G, out float B)
	{
	}
}
