using System;
using System.Collections;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000FE RID: 254
	[global::Cpp2ILInjected.Token(Token = "0x200012B")]
	internal class NamespaceList
	{
		// Token: 0x06000980 RID: 2432 RVA: 0x00004AC3 File Offset: 0x00002CC3
		[global::Cpp2ILInjected.Token(Token = "0x6000A17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9E60", Offset = "0x1DC9E60", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NamespaceList()
		{
			throw null;
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00004AC6 File Offset: 0x00002CC6
		[global::Cpp2ILInjected.Token(Token = "0x6000A18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC9E68", Offset = "0x1DC9E68", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaAny), Member = "BuildNamespaceList", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaAnyAttribute), Member = "BuildNamespaceList", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "SplitString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public NamespaceList(string namespaces, string targetNamespace)
		{
			throw null;
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00004AC9 File Offset: 0x00002CC9
		[global::Cpp2ILInjected.Token(Token = "0x170002B6")]
		public NamespaceList.ListType Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A19")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCA0AC", Offset = "0x1DCA0AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00004ACC File Offset: 0x00002CCC
		[global::Cpp2ILInjected.Token(Token = "0x170002B7")]
		public string Excluded
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCA0B4", Offset = "0x1DCA0B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00004ACF File Offset: 0x00002CCF
		[global::Cpp2ILInjected.Token(Token = "0x170002B8")]
		public ICollection Enumerate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCA0BC", Offset = "0x1DCA0BC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymbolsDictionary), Member = "AddNamespaceList", MemberParameters = new object[]
			{
				typeof(NamespaceList),
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00004AD2 File Offset: 0x00002CD2
		[global::Cpp2ILInjected.Token(Token = "0x6000A1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCA118", Offset = "0x1DCA118", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public virtual bool Allows(string ns)
		{
			throw null;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00004AD5 File Offset: 0x00002CD5
		[global::Cpp2ILInjected.Token(Token = "0x6000A1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCA190", Offset = "0x1DCA190", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymbolsDictionary), Member = "GetNamespaceListSymbols", MemberParameters = new object[] { typeof(NamespaceList) }, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Allows(XmlQualifiedName qname)
		{
			throw null;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00004AD8 File Offset: 0x00002CD8
		[global::Cpp2ILInjected.Token(Token = "0x6000A1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCA1A0", Offset = "0x1DCA1A0", Length = "0x4A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000398 RID: 920
		[global::Cpp2ILInjected.Token(Token = "0x4000512")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private NamespaceList.ListType type;

		// Token: 0x04000399 RID: 921
		[global::Cpp2ILInjected.Token(Token = "0x4000513")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Hashtable set;

		// Token: 0x0400039A RID: 922
		[global::Cpp2ILInjected.Token(Token = "0x4000514")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string targetNamespace;

		// Token: 0x02000173 RID: 371
		[global::Cpp2ILInjected.Token(Token = "0x200012C")]
		public enum ListType
		{
			// Token: 0x04000669 RID: 1641
			[global::Cpp2ILInjected.Token(Token = "0x4000516")]
			Any,
			// Token: 0x0400066A RID: 1642
			[global::Cpp2ILInjected.Token(Token = "0x4000517")]
			Other,
			// Token: 0x0400066B RID: 1643
			[global::Cpp2ILInjected.Token(Token = "0x4000518")]
			Set
		}
	}
}
