using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000D8 RID: 216
	[global::Cpp2ILInjected.Token(Token = "0x2000104")]
	internal class Datatype_NCName : Datatype_Name
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0000485C File Offset: 0x00002A5C
		[global::Cpp2ILInjected.Token(Token = "0x17000270")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000941")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2058", Offset = "0x1DC2058", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0000485F File Offset: 0x00002A5F
		[global::Cpp2ILInjected.Token(Token = "0x6000942")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC2060", Offset = "0x1DC2060", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00004862 File Offset: 0x00002A62
		[global::Cpp2ILInjected.Token(Token = "0x6000943")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC214C", Offset = "0x1DC214C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_string), Member = ".ctor", ReturnType = typeof(void))]
		public Datatype_NCName()
		{
			throw null;
		}
	}
}
