using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	// Token: 0x0200000D RID: 13
	[global::Cpp2ILInjected.Token(Token = "0x2000012")]
	internal struct NamespaceResolver
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00002197 File Offset: 0x00000397
		[global::Cpp2ILInjected.Token(Token = "0x6000086")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6DAD0", Offset = "0x1D6DAD0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void PushScope()
		{
			throw null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000219A File Offset: 0x0000039A
		[global::Cpp2ILInjected.Token(Token = "0x6000087")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6DB74", Offset = "0x1D6DB74", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "WriteElement", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "WriteEndElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "WriteFullEndElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public void PopScope()
		{
			throw null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000219D File Offset: 0x0000039D
		[global::Cpp2ILInjected.Token(Token = "0x6000088")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6DAE0", Offset = "0x1D6DAE0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "PushElement", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Add(string prefix, XNamespace ns)
		{
			throw null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000021A0 File Offset: 0x000003A0
		[global::Cpp2ILInjected.Token(Token = "0x6000089")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6D984", Offset = "0x1D6D984", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "PushAncestors", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddFirst(string prefix, XNamespace ns)
		{
			throw null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000021A3 File Offset: 0x000003A3
		[global::Cpp2ILInjected.Token(Token = "0x600008A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6D860", Offset = "0x1D6D860", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "GetPrefixOfNamespace", MemberParameters = new object[]
		{
			typeof(XNamespace),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
		{
			throw null;
		}

		// Token: 0x04000013 RID: 19
		[global::Cpp2ILInjected.Token(Token = "0x4000026")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _scope;

		// Token: 0x04000014 RID: 20
		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private NamespaceResolver.NamespaceDeclaration _declaration;

		// Token: 0x04000015 RID: 21
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private NamespaceResolver.NamespaceDeclaration _rover;

		// Token: 0x0200002B RID: 43
		[global::Cpp2ILInjected.Token(Token = "0x2000013")]
		private class NamespaceDeclaration
		{
			// Token: 0x060000DE RID: 222 RVA: 0x000022D8 File Offset: 0x000004D8
			[global::Cpp2ILInjected.Token(Token = "0x600008B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6DBD4", Offset = "0x1D6DBD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NamespaceDeclaration()
			{
				throw null;
			}

			// Token: 0x0400005B RID: 91
			[global::Cpp2ILInjected.Token(Token = "0x4000029")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string prefix;

			// Token: 0x0400005C RID: 92
			[global::Cpp2ILInjected.Token(Token = "0x400002A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public XNamespace ns;

			// Token: 0x0400005D RID: 93
			[global::Cpp2ILInjected.Token(Token = "0x400002B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int scope;

			// Token: 0x0400005E RID: 94
			[global::Cpp2ILInjected.Token(Token = "0x400002C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public NamespaceResolver.NamespaceDeclaration prev;
		}
	}
}
