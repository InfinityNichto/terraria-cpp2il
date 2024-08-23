﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	// Token: 0x0200003B RID: 59
	[global::Cpp2ILInjected.Token(Token = "0x2000049")]
	internal sealed class InflateManager
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000369 RID: 873 RVA: 0x000058B4 File Offset: 0x00003AB4
		// (set) Token: 0x0600036A RID: 874 RVA: 0x000058B7 File Offset: 0x00003AB7
		[global::Cpp2ILInjected.Token(Token = "0x170000E1")]
		internal bool HandleRfc1950HeaderBytes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000387")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A72538", Offset = "0x1A72538", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000388")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A72540", Offset = "0x1A72540", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x000058BA File Offset: 0x00003ABA
		[global::Cpp2ILInjected.Token(Token = "0x6000389")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7254C", Offset = "0x1A7254C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public InflateManager()
		{
			throw null;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000058BD File Offset: 0x00003ABD
		[global::Cpp2ILInjected.Token(Token = "0x600038A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7255C", Offset = "0x1A7255C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public InflateManager(bool expectRfc1950HeaderBytes)
		{
			throw null;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000058C0 File Offset: 0x00003AC0
		[global::Cpp2ILInjected.Token(Token = "0x600038B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7258C", Offset = "0x1A7258C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateBlocks), Member = "Reset", ReturnType = typeof(uint))]
		internal int Reset()
		{
			throw null;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000058C3 File Offset: 0x00003AC3
		[global::Cpp2ILInjected.Token(Token = "0x600038C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A725C8", Offset = "0x1A725C8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateManager), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ZlibCodec),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateBlocks), Member = "Reset", ReturnType = typeof(uint))]
		internal int End()
		{
			throw null;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000058C6 File Offset: 0x00003AC6
		[global::Cpp2ILInjected.Token(Token = "0x600038D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A725FC", Offset = "0x1A725FC", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "InitializeInflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateBlocks), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ZlibCodec),
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateBlocks), Member = "Reset", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateManager), Member = "End", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal int Initialize(ZlibCodec codec, int w)
		{
			throw null;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000058C9 File Offset: 0x00003AC9
		[global::Cpp2ILInjected.Token(Token = "0x600038E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A72710", Offset = "0x1A72710", Length = "0x730")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "Inflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateBlocks), Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateBlocks), Member = "Reset", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal int Inflate(FlushType flush)
		{
			throw null;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000058CC File Offset: 0x00003ACC
		[global::Cpp2ILInjected.Token(Token = "0x600038F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A72E40", Offset = "0x1A72E40", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "SetDictionary", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Adler), Member = "Adler32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal int SetDictionary(byte[] dictionary)
		{
			throw null;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000058CF File Offset: 0x00003ACF
		[global::Cpp2ILInjected.Token(Token = "0x6000390")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A72FA8", Offset = "0x1A72FA8", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "SyncInflate", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateBlocks), Member = "Reset", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int Sync()
		{
			throw null;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000058D2 File Offset: 0x00003AD2
		[global::Cpp2ILInjected.Token(Token = "0x6000391")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7312C", Offset = "0x1A7312C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal int SyncPoint(ZlibCodec z)
		{
			throw null;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000058D5 File Offset: 0x00003AD5
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000392")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A73140", Offset = "0x1A73140", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static InflateManager()
		{
			throw null;
		}

		// Token: 0x04000216 RID: 534
		[global::Cpp2ILInjected.Token(Token = "0x4000273")]
		private const int PRESET_DICT = 32;

		// Token: 0x04000217 RID: 535
		[global::Cpp2ILInjected.Token(Token = "0x4000274")]
		private const int Z_DEFLATED = 8;

		// Token: 0x04000218 RID: 536
		[global::Cpp2ILInjected.Token(Token = "0x4000275")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private InflateManager.InflateManagerMode mode;

		// Token: 0x04000219 RID: 537
		[global::Cpp2ILInjected.Token(Token = "0x4000276")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal ZlibCodec _codec;

		// Token: 0x0400021A RID: 538
		[global::Cpp2ILInjected.Token(Token = "0x4000277")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int method;

		// Token: 0x0400021B RID: 539
		[global::Cpp2ILInjected.Token(Token = "0x4000278")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal uint computedCheck;

		// Token: 0x0400021C RID: 540
		[global::Cpp2ILInjected.Token(Token = "0x4000279")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal uint expectedCheck;

		// Token: 0x0400021D RID: 541
		[global::Cpp2ILInjected.Token(Token = "0x400027A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		internal int marker;

		// Token: 0x0400021E RID: 542
		[global::Cpp2ILInjected.Token(Token = "0x400027B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _handleRfc1950HeaderBytes;

		// Token: 0x0400021F RID: 543
		[global::Cpp2ILInjected.Token(Token = "0x400027C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal int wbits;

		// Token: 0x04000220 RID: 544
		[global::Cpp2ILInjected.Token(Token = "0x400027D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal InflateBlocks blocks;

		// Token: 0x04000221 RID: 545
		[global::Cpp2ILInjected.Token(Token = "0x400027E")]
		private static readonly byte[] mark;

		// Token: 0x02000069 RID: 105
		[global::Cpp2ILInjected.Token(Token = "0x200004A")]
		private enum InflateManagerMode
		{
			// Token: 0x0400033C RID: 828
			[global::Cpp2ILInjected.Token(Token = "0x4000280")]
			METHOD,
			// Token: 0x0400033D RID: 829
			[global::Cpp2ILInjected.Token(Token = "0x4000281")]
			FLAG,
			// Token: 0x0400033E RID: 830
			[global::Cpp2ILInjected.Token(Token = "0x4000282")]
			DICT4,
			// Token: 0x0400033F RID: 831
			[global::Cpp2ILInjected.Token(Token = "0x4000283")]
			DICT3,
			// Token: 0x04000340 RID: 832
			[global::Cpp2ILInjected.Token(Token = "0x4000284")]
			DICT2,
			// Token: 0x04000341 RID: 833
			[global::Cpp2ILInjected.Token(Token = "0x4000285")]
			DICT1,
			// Token: 0x04000342 RID: 834
			[global::Cpp2ILInjected.Token(Token = "0x4000286")]
			DICT0,
			// Token: 0x04000343 RID: 835
			[global::Cpp2ILInjected.Token(Token = "0x4000287")]
			BLOCKS,
			// Token: 0x04000344 RID: 836
			[global::Cpp2ILInjected.Token(Token = "0x4000288")]
			CHECK4,
			// Token: 0x04000345 RID: 837
			[global::Cpp2ILInjected.Token(Token = "0x4000289")]
			CHECK3,
			// Token: 0x04000346 RID: 838
			[global::Cpp2ILInjected.Token(Token = "0x400028A")]
			CHECK2,
			// Token: 0x04000347 RID: 839
			[global::Cpp2ILInjected.Token(Token = "0x400028B")]
			CHECK1,
			// Token: 0x04000348 RID: 840
			[global::Cpp2ILInjected.Token(Token = "0x400028C")]
			DONE,
			// Token: 0x04000349 RID: 841
			[global::Cpp2ILInjected.Token(Token = "0x400028D")]
			BAD
		}
	}
}