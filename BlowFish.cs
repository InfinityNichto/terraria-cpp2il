using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200022E")]
public class BlowFish
{
	[StructLayout(2)]
	[Cpp2IlInjected.Token(Token = "0x2000807")]
	private struct aword
	{
		[Cpp2IlInjected.Token(Token = "0x2000B4D")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _003Cinteger_003Ee__FixedBuffer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4008FE6")]
			public byte FixedElementField;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007D32")]
		public uint dword;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007D33")]
		[Cpp2IlInjected.Attribute(Name = "FixedBufferAttribute", RVA = "0x38C3D0", Offset = "0x38C3D0")]
		public _003Cinteger_003Ee__FixedBuffer integer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007D34")]
		public byte byte3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4007D35")]
		public byte byte2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4007D36")]
		public byte byte1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4007D37")]
		public byte byte0;
	}

	[Cpp2IlInjected.Token(Token = "0x4001B33")]
	private const int NPASS = 16;

	[Cpp2IlInjected.Token(Token = "0x4001B34")]
	private static uint[] bf_P;

	[Cpp2IlInjected.Token(Token = "0x4001B35")]
	private static uint[] bf_S;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001B36")]
	private uint[] PArray;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001B37")]
	private uint[] SBoxes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001B38")]
	public bool isInitialized;

	[Cpp2IlInjected.Token(Token = "0x6000FA0")]
	[Cpp2IlInjected.Address(RVA = "0x11FFD4C", Offset = "0x11FFD4C", VA = "0x11FFD4C")]
	public BlowFish()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FA1")]
	[Cpp2IlInjected.Address(RVA = "0x11FFDC8", Offset = "0x11FFDC8", VA = "0x11FFDC8")]
	private void ROUND(ref aword a, ref aword b, int n)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FA2")]
	[Cpp2IlInjected.Address(RVA = "0x11FFE30", Offset = "0x11FFE30", VA = "0x11FFE30")]
	private unsafe void Decipher(uint* xl, uint* xr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FA3")]
	[Cpp2IlInjected.Address(RVA = "0x120038C", Offset = "0x120038C", VA = "0x120038C")]
	private unsafe void Encipher(uint* xl, uint* xr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FA4")]
	[Cpp2IlInjected.Address(RVA = "0x12008DC", Offset = "0x12008DC", VA = "0x12008DC")]
	public void Initialize(byte[] key)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FA5")]
	[Cpp2IlInjected.Address(RVA = "0x1200B4C", Offset = "0x1200B4C", VA = "0x1200B4C")]
	private uint GetOutputLength(uint lInputLong)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FA6")]
	[Cpp2IlInjected.Address(RVA = "0x1200B60", Offset = "0x1200B60", VA = "0x1200B60")]
	public unsafe void Decode(byte* pInput, byte* pOutput, uint lSize)
	{
	}
}
