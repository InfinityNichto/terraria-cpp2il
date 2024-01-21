using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace ReLogic.Utilities;

[Cpp2IlInjected.Token(Token = "0x2000713")]
public static class ReinterpretCast
{
	[StructLayout(2)]
	[Cpp2IlInjected.Token(Token = "0x2000AC8")]
	private struct IntFloat
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008F77")]
		public readonly int IntValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008F78")]
		public readonly float FloatValue;

		[Cpp2IlInjected.Token(Token = "0x60052FF")]
		[Cpp2IlInjected.Address(RVA = "0x39A8A0", Offset = "0x39A8A0", VA = "0x39A8A0")]
		public IntFloat(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005300")]
		[Cpp2IlInjected.Address(RVA = "0x39A8A8", Offset = "0x39A8A8", VA = "0x39A8A8")]
		public IntFloat(float value)
		{
		}
	}

	[StructLayout(2)]
	[Cpp2IlInjected.Token(Token = "0x2000AC9")]
	private struct UIntFloat
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008F79")]
		public readonly uint UIntValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008F7A")]
		public readonly float FloatValue;

		[Cpp2IlInjected.Token(Token = "0x6005301")]
		[Cpp2IlInjected.Address(RVA = "0x39A8B0", Offset = "0x39A8B0", VA = "0x39A8B0")]
		public UIntFloat(uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005302")]
		[Cpp2IlInjected.Address(RVA = "0x39A8B8", Offset = "0x39A8B8", VA = "0x39A8B8")]
		public UIntFloat(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004626")]
	[Cpp2IlInjected.Address(RVA = "0xF96CCC", Offset = "0xF96CCC", VA = "0xF96CCC")]
	public static float UIntAsFloat(uint value)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6004627")]
	[Cpp2IlInjected.Address(RVA = "0xF96CD8", Offset = "0xF96CD8", VA = "0xF96CD8")]
	public static float IntAsFloat(int value)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6004628")]
	[Cpp2IlInjected.Address(RVA = "0xF96CE4", Offset = "0xF96CE4", VA = "0xF96CE4")]
	public static uint FloatAsUInt(float value)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6004629")]
	[Cpp2IlInjected.Address(RVA = "0xF96CF0", Offset = "0xF96CF0", VA = "0xF96CF0")]
	public static int FloatAsInt(float value)
	{
		return default(int);
	}
}
