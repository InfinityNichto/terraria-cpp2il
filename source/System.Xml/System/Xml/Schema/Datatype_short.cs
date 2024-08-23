using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000E2 RID: 226
	[global::Cpp2ILInjected.Token(Token = "0x200010E")]
	internal class Datatype_short : Datatype_int
	{
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x000048EF File Offset: 0x00002AEF
		[global::Cpp2ILInjected.Token(Token = "0x1700028A")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000972")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC3360", Offset = "0x1DC3360", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x000048F2 File Offset: 0x00002AF2
		[global::Cpp2ILInjected.Token(Token = "0x1700028B")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000973")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC33B8", Offset = "0x1DC33B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x000048F5 File Offset: 0x00002AF5
		[global::Cpp2ILInjected.Token(Token = "0x6000974")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC33C0", Offset = "0x1DC33C0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x000048F8 File Offset: 0x00002AF8
		[global::Cpp2ILInjected.Token(Token = "0x1700028C")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000975")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC344C", Offset = "0x1DC344C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x000048FB File Offset: 0x00002AFB
		[global::Cpp2ILInjected.Token(Token = "0x1700028D")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000976")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC34A4", Offset = "0x1DC34A4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x000048FE File Offset: 0x00002AFE
		[global::Cpp2ILInjected.Token(Token = "0x6000977")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC34FC", Offset = "0x1DC34FC", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref short)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00004901 File Offset: 0x00002B01
		[global::Cpp2ILInjected.Token(Token = "0x6000978")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC3630", Offset = "0x1DC3630", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_byte), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_int), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_short()
		{
			throw null;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00004904 File Offset: 0x00002B04
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000979")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC3684", Offset = "0x1DC3684", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static Datatype_short()
		{
			throw null;
		}

		// Token: 0x04000379 RID: 889
		[global::Cpp2ILInjected.Token(Token = "0x40004F3")]
		private static readonly Type atomicValueType;

		// Token: 0x0400037A RID: 890
		[global::Cpp2ILInjected.Token(Token = "0x40004F4")]
		private static readonly Type listValueType;

		// Token: 0x0400037B RID: 891
		[global::Cpp2ILInjected.Token(Token = "0x40004F5")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
