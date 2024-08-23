using System;
using System.IO;
using System.Numerics.Hashing;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000BE RID: 190
	[global::Cpp2ILInjected.Token(Token = "0x20000F0")]
	public class Random
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x00015D2E File Offset: 0x00013F2E
		[global::Cpp2ILInjected.Token(Token = "0x60008E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45318", Offset = "0x1C45318", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Numerics.Hashing.HashHelpers), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "GenerateRandomStringImpl", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "WriteSecurityMetadata", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Random), Member = "GenerateSeed", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Random), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Random()
		{
			throw null;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00015D31 File Offset: 0x00013F31
		[global::Cpp2ILInjected.Token(Token = "0x60008E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45520", Offset = "0x1C45520", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Random), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Random), Member = "GenerateSeed", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Random), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ThreadPoolWorkQueueThreadLocals), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Threading.ThreadPoolWorkQueue) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Random(int Seed)
		{
			throw null;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00015D34 File Offset: 0x00013F34
		[global::Cpp2ILInjected.Token(Token = "0x60008E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45690", Offset = "0x1C45690", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Random), Member = "InternalSample", ReturnType = typeof(int))]
		protected virtual double Sample()
		{
			throw null;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00015D37 File Offset: 0x00013F37
		[global::Cpp2ILInjected.Token(Token = "0x60008E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C456B0", Offset = "0x1C456B0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Random), Member = "Sample", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Random), Member = "Next", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Random), Member = "GetSampleForLargeRange", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Random), Member = "NextBytes", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		private int InternalSample()
		{
			throw null;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00015D3A File Offset: 0x00013F3A
		[global::Cpp2ILInjected.Token(Token = "0x60008E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45374", Offset = "0x1C45374", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Random), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Random), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static int GenerateSeed()
		{
			throw null;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00015D3D File Offset: 0x00013F3D
		[global::Cpp2ILInjected.Token(Token = "0x60008EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45718", Offset = "0x1C45718", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop), Member = "GetRandomBytes", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		private unsafe static int GenerateGlobalSeed()
		{
			throw null;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00015D40 File Offset: 0x00013F40
		[global::Cpp2ILInjected.Token(Token = "0x60008EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4573C", Offset = "0x1C4573C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Random), Member = "InternalSample", ReturnType = typeof(int))]
		public virtual int Next()
		{
			throw null;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00015D43 File Offset: 0x00013F43
		[global::Cpp2ILInjected.Token(Token = "0x60008EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45740", Offset = "0x1C45740", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Random), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Random), Member = "InternalSample", ReturnType = typeof(int))]
		private double GetSampleForLargeRange()
		{
			throw null;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00015D46 File Offset: 0x00013F46
		[global::Cpp2ILInjected.Token(Token = "0x60008ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4578C", Offset = "0x1C4578C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Random), Member = "GetSampleForLargeRange", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public virtual int Next(int minValue, int maxValue)
		{
			throw null;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00015D49 File Offset: 0x00013F49
		[global::Cpp2ILInjected.Token(Token = "0x60008EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C458A4", Offset = "0x1C458A4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual int Next(int maxValue)
		{
			throw null;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00015D4C File Offset: 0x00013F4C
		[global::Cpp2ILInjected.Token(Token = "0x60008EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45968", Offset = "0x1C45968", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Random), Member = "InternalSample", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual void NextBytes(byte[] buffer)
		{
			throw null;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00015D4F File Offset: 0x00013F4F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60008F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45A08", Offset = "0x1C45A08", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop), Member = "GetRandomBytes", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Random), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static unsafe Random()
		{
			throw null;
		}

		// Token: 0x04000237 RID: 567
		[global::Cpp2ILInjected.Token(Token = "0x4000389")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _inext;

		// Token: 0x04000238 RID: 568
		[global::Cpp2ILInjected.Token(Token = "0x400038A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _inextp;

		// Token: 0x04000239 RID: 569
		[global::Cpp2ILInjected.Token(Token = "0x400038B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int[] _seedArray;

		// Token: 0x0400023A RID: 570
		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x400038C")]
		private static global::System.Random t_threadRandom;

		// Token: 0x0400023B RID: 571
		[global::Cpp2ILInjected.Token(Token = "0x400038D")]
		private static readonly global::System.Random s_globalRandom;
	}
}
