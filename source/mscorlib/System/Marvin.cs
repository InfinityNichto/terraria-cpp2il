using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000A5 RID: 165
	[global::Cpp2ILInjected.Token(Token = "0x20000D5")]
	internal static class Marvin
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x00015A55 File Offset: 0x00013C55
		[global::Cpp2ILInjected.Token(Token = "0x60007E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C355CC", Offset = "0x1C355CC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlySpan`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[MethodImpl(256)]
		public static int ComputeHash32(global::System.ReadOnlySpan<byte> data, ulong seed)
		{
			throw null;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00015A58 File Offset: 0x00013C58
		[global::Cpp2ILInjected.Token(Token = "0x60007E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35678", Offset = "0x1C35678", Length = "0x3D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "GetIgnoreCaseHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddress", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public static int ComputeHash32(ref byte data, int count, ulong seed)
		{
			throw null;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00015A5B File Offset: 0x00013C5B
		[global::Cpp2ILInjected.Token(Token = "0x60007E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35A48", Offset = "0x1C35A48", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		private static void Block(ref uint rp0, ref uint rp1)
		{
			throw null;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00015A5E File Offset: 0x00013C5E
		[global::Cpp2ILInjected.Token(Token = "0x60007E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35AD0", Offset = "0x1C35AD0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private static uint _rotl(uint value, int shift)
		{
			throw null;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00015A61 File Offset: 0x00013C61
		[global::Cpp2ILInjected.Token(Token = "0x1700008F")]
		public static ulong DefaultSeed
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60007E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C35ADC", Offset = "0x1C35ADC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00015A64 File Offset: 0x00013C64
		[global::Cpp2ILInjected.Token(Token = "0x60007E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35B34", Offset = "0x1C35B34", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ulong GenerateSeed()
		{
			throw null;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00015A67 File Offset: 0x00013C67
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60007E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35B40", Offset = "0x1C35B40", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Marvin()
		{
			throw null;
		}

		// Token: 0x04000217 RID: 535
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000364")]
		private static readonly ulong <DefaultSeed>k__BackingField;
	}
}
