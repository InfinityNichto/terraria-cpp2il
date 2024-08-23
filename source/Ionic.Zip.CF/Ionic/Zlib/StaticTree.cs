using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	// Token: 0x02000045 RID: 69
	[global::Cpp2ILInjected.Token(Token = "0x2000054")]
	internal sealed class StaticTree
	{
		// Token: 0x0600038B RID: 907 RVA: 0x0000591A File Offset: 0x00003B1A
		[global::Cpp2ILInjected.Token(Token = "0x60003A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A746E0", Offset = "0x1A746E0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private StaticTree(short[] treeCodes, int[] extraBits, int extraBase, int elems, int maxLength)
		{
			throw null;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000591D File Offset: 0x00003B1D
		[global::Cpp2ILInjected.Token(Token = "0x60003AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74730", Offset = "0x1A74730", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		static StaticTree()
		{
			throw null;
		}

		// Token: 0x0400026E RID: 622
		[global::Cpp2ILInjected.Token(Token = "0x40002DA")]
		internal static readonly short[] lengthAndLiteralsTreeCodes;

		// Token: 0x0400026F RID: 623
		[global::Cpp2ILInjected.Token(Token = "0x40002DB")]
		internal static readonly short[] distTreeCodes;

		// Token: 0x04000270 RID: 624
		[global::Cpp2ILInjected.Token(Token = "0x40002DC")]
		internal static readonly StaticTree Literals;

		// Token: 0x04000271 RID: 625
		[global::Cpp2ILInjected.Token(Token = "0x40002DD")]
		internal static readonly StaticTree Distances;

		// Token: 0x04000272 RID: 626
		[global::Cpp2ILInjected.Token(Token = "0x40002DE")]
		internal static readonly StaticTree BitLengths;

		// Token: 0x04000273 RID: 627
		[global::Cpp2ILInjected.Token(Token = "0x40002DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal short[] treeCodes;

		// Token: 0x04000274 RID: 628
		[global::Cpp2ILInjected.Token(Token = "0x40002E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int[] extraBits;

		// Token: 0x04000275 RID: 629
		[global::Cpp2ILInjected.Token(Token = "0x40002E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int extraBase;

		// Token: 0x04000276 RID: 630
		[global::Cpp2ILInjected.Token(Token = "0x40002E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal int elems;

		// Token: 0x04000277 RID: 631
		[global::Cpp2ILInjected.Token(Token = "0x40002E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int maxLength;
	}
}
