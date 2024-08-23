using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x0200005B RID: 91
	[global::Cpp2ILInjected.Token(Token = "0x20000AE")]
	internal sealed class ExclusiveReference
	{
		// Token: 0x060002BB RID: 699 RVA: 0x000035E7 File Offset: 0x000017E7
		[global::Cpp2ILInjected.Token(Token = "0x6000350")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAB470", Offset = "0x1EAB470", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Run", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RegexRunner Get()
		{
			throw null;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000035EA File Offset: 0x000017EA
		[global::Cpp2ILInjected.Token(Token = "0x6000351")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAB4C8", Offset = "0x1EAB4C8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Run", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Release(RegexRunner obj)
		{
			throw null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000035ED File Offset: 0x000017ED
		[global::Cpp2ILInjected.Token(Token = "0x6000352")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAB580", Offset = "0x1EAB580", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ExclusiveReference()
		{
			throw null;
		}

		// Token: 0x04000178 RID: 376
		[global::Cpp2ILInjected.Token(Token = "0x40002A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RegexRunner _ref;

		// Token: 0x04000179 RID: 377
		[global::Cpp2ILInjected.Token(Token = "0x40002A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private RegexRunner _obj;

		// Token: 0x0400017A RID: 378
		[global::Cpp2ILInjected.Token(Token = "0x40002A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _locked;
	}
}
