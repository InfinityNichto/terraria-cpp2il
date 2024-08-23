using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000049 RID: 73
	[global::Cpp2ILInjected.Token(Token = "0x2000066")]
	internal sealed class XmlChildEnumerator : IEnumerator
	{
		// Token: 0x0600042C RID: 1068 RVA: 0x00003B51 File Offset: 0x00001D51
		[global::Cpp2ILInjected.Token(Token = "0x60004A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8D474", Offset = "0x1D8D474", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNode), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal XmlChildEnumerator(XmlNode container)
		{
			throw null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00003B54 File Offset: 0x00001D54
		[global::Cpp2ILInjected.Token(Token = "0x60004A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8D4BC", Offset = "0x1D8D4BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool System.Collections.IEnumerator.MoveNext()
		{
			throw null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00003B57 File Offset: 0x00001D57
		[global::Cpp2ILInjected.Token(Token = "0x60004A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8D4C0", Offset = "0x1D8D4C0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal bool MoveNext()
		{
			throw null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00003B5A File Offset: 0x00001D5A
		[global::Cpp2ILInjected.Token(Token = "0x60004A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8D51C", Offset = "0x1D8D51C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.Collections.IEnumerator.Reset()
		{
			throw null;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00003B5D File Offset: 0x00001D5D
		[global::Cpp2ILInjected.Token(Token = "0x170000FE")]
		private object System.Collections.IEnumerator.Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8D54C", Offset = "0x1D8D54C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00003B60 File Offset: 0x00001D60
		[global::Cpp2ILInjected.Token(Token = "0x170000FF")]
		internal XmlNode Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8D550", Offset = "0x1D8D550", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000196 RID: 406
		[global::Cpp2ILInjected.Token(Token = "0x4000290")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal XmlNode container;

		// Token: 0x04000197 RID: 407
		[global::Cpp2ILInjected.Token(Token = "0x4000291")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal XmlNode child;

		// Token: 0x04000198 RID: 408
		[global::Cpp2ILInjected.Token(Token = "0x4000292")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal bool isFirst;
	}
}
