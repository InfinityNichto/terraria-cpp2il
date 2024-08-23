using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000EF RID: 239
	[global::Cpp2ILInjected.Token(Token = "0x200011B")]
	internal class Datatype_fixed : Datatype_decimal
	{
		// Token: 0x06000928 RID: 2344 RVA: 0x000049D0 File Offset: 0x00002BD0
		[global::Cpp2ILInjected.Token(Token = "0x60009BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC6084", Offset = "0x1DC6084", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToDecimal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Numeric10FacetsChecker), Member = "CheckTotalAndFractionDigits", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			throw null;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x000049D3 File Offset: 0x00002BD3
		[global::Cpp2ILInjected.Token(Token = "0x60009BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC6534", Offset = "0x1DC6534", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToDecimal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref decimal)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Numeric10FacetsChecker), Member = "CheckTotalAndFractionDigits", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x000049D6 File Offset: 0x00002BD6
		[global::Cpp2ILInjected.Token(Token = "0x60009BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC6650", Offset = "0x1DC6650", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_decimal), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_fixed()
		{
			throw null;
		}
	}
}
