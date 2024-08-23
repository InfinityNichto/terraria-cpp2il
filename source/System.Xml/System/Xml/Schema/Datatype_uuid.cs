using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000F0 RID: 240
	[global::Cpp2ILInjected.Token(Token = "0x200011C")]
	internal class Datatype_uuid : Datatype_anySimpleType
	{
		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x000049D9 File Offset: 0x00002BD9
		[global::Cpp2ILInjected.Token(Token = "0x170002AC")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC66A4", Offset = "0x1DC66A4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x000049DC File Offset: 0x00002BDC
		[global::Cpp2ILInjected.Token(Token = "0x170002AD")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC66FC", Offset = "0x1DC66FC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x000049DF File Offset: 0x00002BDF
		[global::Cpp2ILInjected.Token(Token = "0x60009C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC6754", Offset = "0x1DC6754", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000049E2 File Offset: 0x00002BE2
		[global::Cpp2ILInjected.Token(Token = "0x60009C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC67F0", Offset = "0x1DC67F0", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToGuid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Guid))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			throw null;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000049E5 File Offset: 0x00002BE5
		[global::Cpp2ILInjected.Token(Token = "0x60009C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC69A8", Offset = "0x1DC69A8", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToGuid", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref Guid)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000049E8 File Offset: 0x00002BE8
		[global::Cpp2ILInjected.Token(Token = "0x60009C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC6A5C", Offset = "0x1DC6A5C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_uuid()
		{
			throw null;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000049EB File Offset: 0x00002BEB
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60009C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC6AB0", Offset = "0x1DC6AB0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_uuid()
		{
			throw null;
		}

		// Token: 0x04000391 RID: 913
		[global::Cpp2ILInjected.Token(Token = "0x400050B")]
		private static readonly Type atomicValueType;

		// Token: 0x04000392 RID: 914
		[global::Cpp2ILInjected.Token(Token = "0x400050C")]
		private static readonly Type listValueType;
	}
}
