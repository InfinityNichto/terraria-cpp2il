using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000064 RID: 100
	[global::Cpp2ILInjected.Token(Token = "0x2000083")]
	internal sealed class EmptyEnumerator : IEnumerator
	{
		// Token: 0x060005B1 RID: 1457 RVA: 0x00003FC8 File Offset: 0x000021C8
		[global::Cpp2ILInjected.Token(Token = "0x6000633")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9AF40", Offset = "0x1D9AF40", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool System.Collections.IEnumerator.MoveNext()
		{
			throw null;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00003FCB File Offset: 0x000021CB
		[global::Cpp2ILInjected.Token(Token = "0x6000634")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9AF48", Offset = "0x1D9AF48", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.Collections.IEnumerator.Reset()
		{
			throw null;
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00003FCE File Offset: 0x000021CE
		[global::Cpp2ILInjected.Token(Token = "0x170001AD")]
		private object System.Collections.IEnumerator.Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000635")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9AF4C", Offset = "0x1D9AF4C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00003FD1 File Offset: 0x000021D1
		[global::Cpp2ILInjected.Token(Token = "0x6000636")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9AFA4", Offset = "0x1D9AFA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EmptyEnumerator()
		{
			throw null;
		}
	}
}
