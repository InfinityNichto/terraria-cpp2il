using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;

// Token: 0x0200022C RID: 556
[global::Cpp2ILInjected.Token(Token = "0x20002DC")]
public class BlowFish
{
	// Token: 0x06000F87 RID: 3975 RVA: 0x00024992 File Offset: 0x00022B92
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

	// Token: 0x06000F88 RID: 3976 RVA: 0x00024995 File Offset: 0x00022B95
	[global::Cpp2ILInjected.Token(Token = "0x60010D1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4F308", Offset = "0xA4F308", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void ROUND(ref BlowFish.aword a, ref BlowFish.aword b, int n)
	{
		throw null;
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x00024998 File Offset: 0x00022B98
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

	// Token: 0x06000F8A RID: 3978 RVA: 0x0002499B File Offset: 0x00022B9B
	[global::Cpp2ILInjected.Token(Token = "0x60010D3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4F7B8", Offset = "0xA4F7B8", Length = "0x464")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlowFish), Member = "Initialize", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	private unsafe void Encipher(uint* xl, uint* xr)
	{
		throw null;
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x0002499E File Offset: 0x00022B9E
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

	// Token: 0x06000F8C RID: 3980 RVA: 0x000249A1 File Offset: 0x00022BA1
	[global::Cpp2ILInjected.Token(Token = "0x60010D5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4FE1C", Offset = "0xA4FE1C", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private uint GetOutputLength(uint lInputLong)
	{
		throw null;
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x000249A4 File Offset: 0x00022BA4
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

	// Token: 0x06000F8E RID: 3982 RVA: 0x000249A7 File Offset: 0x00022BA7
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

	// Token: 0x04001B2A RID: 6954
	[global::Cpp2ILInjected.Token(Token = "0x40020B0")]
	private const int NPASS = 16;

	// Token: 0x04001B2B RID: 6955
	[global::Cpp2ILInjected.Token(Token = "0x40020B1")]
	private static uint[] bf_P;

	// Token: 0x04001B2C RID: 6956
	[global::Cpp2ILInjected.Token(Token = "0x40020B2")]
	private static uint[] bf_S;

	// Token: 0x04001B2D RID: 6957
	[global::Cpp2ILInjected.Token(Token = "0x40020B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private uint[] PArray;

	// Token: 0x04001B2E RID: 6958
	[global::Cpp2ILInjected.Token(Token = "0x40020B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private uint[] SBoxes;

	// Token: 0x04001B2F RID: 6959
	[global::Cpp2ILInjected.Token(Token = "0x40020B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool isInitialized;

	// Token: 0x02000810 RID: 2064
	[global::Cpp2ILInjected.Token(Token = "0x20002DD")]
	[StructLayout(2)]
	private struct aword
	{
		// Token: 0x04007D45 RID: 32069
		[global::Cpp2ILInjected.Token(Token = "0x40020B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public uint dword;

		// Token: 0x04007D46 RID: 32070
		[FixedBuffer(typeof(byte), 4)]
		[global::Cpp2ILInjected.Token(Token = "0x40020B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public BlowFish.aword.<integer>e__FixedBuffer integer;

		// Token: 0x04007D47 RID: 32071
		[global::Cpp2ILInjected.Token(Token = "0x40020B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public byte byte3;

		// Token: 0x04007D48 RID: 32072
		[global::Cpp2ILInjected.Token(Token = "0x40020B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		[global::System.Runtime.InteropServices.FieldOffset(1)]
		public byte byte2;

		// Token: 0x04007D49 RID: 32073
		[global::Cpp2ILInjected.Token(Token = "0x40020BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		[global::System.Runtime.InteropServices.FieldOffset(2)]
		public byte byte1;

		// Token: 0x04007D4A RID: 32074
		[global::Cpp2ILInjected.Token(Token = "0x40020BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3")]
		[global::System.Runtime.InteropServices.FieldOffset(3)]
		public byte byte0;

		// Token: 0x02000B56 RID: 2902
		[UnsafeValueType]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20002DE")]
		[StructLayout(0, Size = 4)]
		public struct <integer>e__FixedBuffer
		{
			// Token: 0x04008FF9 RID: 36857
			[global::Cpp2ILInjected.Token(Token = "0x40020BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
