using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;

[global::Cpp2ILInjected.Token(Token = "0x20002DC")]
public class BlowFish
{
	[global::Cpp2ILInjected.Token(Token = "0x60010D0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4F29C", Offset = "0xA4F29C", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = ".cctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = ".cctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public BlowFish()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010D1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4F308", Offset = "0xA4F308", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void ROUND(ref BlowFish.aword a, ref BlowFish.aword b, int n)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010D2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4F370", Offset = "0xA4F370", Length = "0x448")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlowFish), Member = "Decode", MemberParameters = new object[]
	{
		typeof(byte*),
		typeof(byte*),
		typeof(uint)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	private unsafe void Decipher(uint* xl, uint* xr)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010D3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4F7B8", Offset = "0xA4F7B8", Length = "0x464")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlowFish), Member = "Initialize", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	private unsafe void Encipher(uint* xl, uint* xr)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010D4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4FC1C", Offset = "0xA4FC1C", Length = "0x200")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = "DecryptPlayerData", MemberParameters = new object[]
	{
		typeof(long),
		typeof(long)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "DecryptWorldData", MemberParameters = new object[]
	{
		typeof(long),
		typeof(long)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlowFish), Member = "Encipher", MemberParameters = new object[]
	{
		typeof(uint*),
		typeof(uint*)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public unsafe void Initialize(byte[] key)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010D5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4FE1C", Offset = "0xA4FE1C", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private uint GetOutputLength(uint lInputLong)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010D6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4FE34", Offset = "0xA4FE34", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = "DecryptPlayerData", MemberParameters = new object[]
	{
		typeof(long),
		typeof(long)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "DecryptWorldData", MemberParameters = new object[]
	{
		typeof(long),
		typeof(long)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlowFish), Member = "Decipher", MemberParameters = new object[]
	{
		typeof(uint*),
		typeof(uint*)
	}, ReturnType = typeof(void))]
	public unsafe void Decode(byte* pInput, byte* pOutput, uint lSize)
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60010D7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4FED4", Offset = "0xA4FED4", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(RuntimeFieldHandle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	static BlowFish()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40020B0")]
	private const int NPASS = 16;

	[global::Cpp2ILInjected.Token(Token = "0x40020B1")]
	private static uint[] bf_P;

	[global::Cpp2ILInjected.Token(Token = "0x40020B2")]
	private static uint[] bf_S;

	[global::Cpp2ILInjected.Token(Token = "0x40020B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private uint[] PArray;

	[global::Cpp2ILInjected.Token(Token = "0x40020B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private uint[] SBoxes;

	[global::Cpp2ILInjected.Token(Token = "0x40020B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool isInitialized;

	[global::Cpp2ILInjected.Token(Token = "0x20002DD")]
	[StructLayout(2)]
	private struct aword
	{
		[global::Cpp2ILInjected.Token(Token = "0x40020B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public uint dword;

		[FixedBuffer(typeof(byte), 4)]
		[global::Cpp2ILInjected.Token(Token = "0x40020B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public BlowFish.aword.<integer>e__FixedBuffer integer;

		[global::Cpp2ILInjected.Token(Token = "0x40020B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public byte byte3;

		[global::Cpp2ILInjected.Token(Token = "0x40020B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		[global::System.Runtime.InteropServices.FieldOffset(1)]
		public byte byte2;

		[global::Cpp2ILInjected.Token(Token = "0x40020BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		[global::System.Runtime.InteropServices.FieldOffset(2)]
		public byte byte1;

		[global::Cpp2ILInjected.Token(Token = "0x40020BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3")]
		[global::System.Runtime.InteropServices.FieldOffset(3)]
		public byte byte0;

		[UnsafeValueType]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20002DE")]
		[StructLayout(0, Size = 4)]
		public struct <integer>e__FixedBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x40020BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
