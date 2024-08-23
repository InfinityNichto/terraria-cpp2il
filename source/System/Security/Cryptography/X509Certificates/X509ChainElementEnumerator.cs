using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000B3 RID: 179
	[global::Cpp2ILInjected.Token(Token = "0x2000111")]
	public sealed class X509ChainElementEnumerator : IEnumerator
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x00003E3F File Offset: 0x0000203F
		[global::Cpp2ILInjected.Token(Token = "0x6000649")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED891C", Offset = "0x1ED891C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainElementCollection), Member = "GetEnumerator", ReturnType = typeof(X509ChainElementEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainElementCollection), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal X509ChainElementEnumerator(IEnumerable enumerable)
		{
			throw null;
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00003E42 File Offset: 0x00002042
		[global::Cpp2ILInjected.Token(Token = "0x17000156")]
		public X509ChainElement Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x600064A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED8BA0", Offset = "0x1ED8BA0", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00003E45 File Offset: 0x00002045
		[global::Cpp2ILInjected.Token(Token = "0x17000157")]
		private object System.Collections.IEnumerator.Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x600064B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED8C88", Offset = "0x1ED8C88", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00003E48 File Offset: 0x00002048
		[global::Cpp2ILInjected.Token(Token = "0x600064C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8D24", Offset = "0x1ED8D24", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool MoveNext()
		{
			throw null;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00003E4B File Offset: 0x0000204B
		[global::Cpp2ILInjected.Token(Token = "0x600064D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8DBC", Offset = "0x1ED8DBC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x040003A3 RID: 931
		[global::Cpp2ILInjected.Token(Token = "0x400050D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IEnumerator enumerator;
	}
}
