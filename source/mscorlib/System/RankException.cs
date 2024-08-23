using System;
using System.Collections;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000BF RID: 191
	[global::Cpp2ILInjected.Token(Token = "0x20000F1")]
	[global::System.Serializable]
	public class RankException : global::System.SystemException
	{
		// Token: 0x06000849 RID: 2121 RVA: 0x00015D52 File Offset: 0x00013F52
		[global::Cpp2ILInjected.Token(Token = "0x60008F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45A84", Offset = "0x1C45A84", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public RankException()
		{
			throw null;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00015D55 File Offset: 0x00013F55
		[global::Cpp2ILInjected.Token(Token = "0x60008F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45ADC", Offset = "0x1C45ADC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "BinarySearch", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(object),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "Reverse", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "InternalArray__ICollection_Contains", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "InternalArray__IndexOf", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public RankException(string message)
		{
			throw null;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00015D58 File Offset: 0x00013F58
		[global::Cpp2ILInjected.Token(Token = "0x60008F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45AFC", Offset = "0x1C45AFC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected RankException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
