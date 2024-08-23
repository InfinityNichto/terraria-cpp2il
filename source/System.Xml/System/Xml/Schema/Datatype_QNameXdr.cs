using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000EC RID: 236
	[global::Cpp2ILInjected.Token(Token = "0x2000118")]
	internal class Datatype_QNameXdr : Datatype_anySimpleType
	{
		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x000049A3 File Offset: 0x00002BA3
		[global::Cpp2ILInjected.Token(Token = "0x170002A6")]
		public override XmlTokenizedType TokenizedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC57B0", Offset = "0x1DC57B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x000049A6 File Offset: 0x00002BA6
		[global::Cpp2ILInjected.Token(Token = "0x60009AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC57B8", Offset = "0x1DC57B8", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IXmlNamespaceResolver),
			typeof(ref string)
		}, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			throw null;
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x000049A9 File Offset: 0x00002BA9
		[global::Cpp2ILInjected.Token(Token = "0x170002A7")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC5A08", Offset = "0x1DC5A08", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x000049AC File Offset: 0x00002BAC
		[global::Cpp2ILInjected.Token(Token = "0x170002A8")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC5A60", Offset = "0x1DC5A60", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000049AF File Offset: 0x00002BAF
		[global::Cpp2ILInjected.Token(Token = "0x60009B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC5AB8", Offset = "0x1DC5AB8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_QNameXdr()
		{
			throw null;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x000049B2 File Offset: 0x00002BB2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60009B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC5B0C", Offset = "0x1DC5B0C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_QNameXdr()
		{
			throw null;
		}

		// Token: 0x0400038D RID: 909
		[global::Cpp2ILInjected.Token(Token = "0x4000507")]
		private static readonly Type atomicValueType;

		// Token: 0x0400038E RID: 910
		[global::Cpp2ILInjected.Token(Token = "0x4000508")]
		private static readonly Type listValueType;
	}
}
