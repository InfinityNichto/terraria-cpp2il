using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000027 RID: 39
	[global::Cpp2ILInjected.Token(Token = "0x2000039")]
	internal class NormalizationTableUtil
	{
		// Token: 0x06000087 RID: 135 RVA: 0x0001475C File Offset: 0x0001295C
		[global::Cpp2ILInjected.Token(Token = "0x60000C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAFE3C", Offset = "0x1AAFE3C", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePointIndexer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(int[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		static NormalizationTableUtil()
		{
			throw null;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0001475F File Offset: 0x0001295F
		[global::Cpp2ILInjected.Token(Token = "0x60000C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB0184", Offset = "0x1AB0184", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Normalization), Member = "PropValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int PropIdx(int cp)
		{
			throw null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00014762 File Offset: 0x00012962
		[global::Cpp2ILInjected.Token(Token = "0x60000C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB01E4", Offset = "0x1AB01E4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Normalization), Member = "CharMapIdx", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int MapIdx(int cp)
		{
			throw null;
		}

		// Token: 0x04000067 RID: 103
		[global::Cpp2ILInjected.Token(Token = "0x4000100")]
		public static readonly CodePointIndexer Prop;

		// Token: 0x04000068 RID: 104
		[global::Cpp2ILInjected.Token(Token = "0x4000101")]
		public static readonly CodePointIndexer Map;

		// Token: 0x04000069 RID: 105
		[global::Cpp2ILInjected.Token(Token = "0x4000102")]
		public static readonly CodePointIndexer Combining;

		// Token: 0x0400006A RID: 106
		[global::Cpp2ILInjected.Token(Token = "0x4000103")]
		public static readonly CodePointIndexer Composite;

		// Token: 0x0400006B RID: 107
		[global::Cpp2ILInjected.Token(Token = "0x4000104")]
		public static readonly CodePointIndexer Helper;
	}
}
