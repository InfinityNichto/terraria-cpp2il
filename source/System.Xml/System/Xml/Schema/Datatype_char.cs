using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000EE RID: 238
	[global::Cpp2ILInjected.Token(Token = "0x200011A")]
	internal class Datatype_char : Datatype_anySimpleType
	{
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x000049BB File Offset: 0x00002BBB
		[global::Cpp2ILInjected.Token(Token = "0x170002AA")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC5BD4", Offset = "0x1DC5BD4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x000049BE File Offset: 0x00002BBE
		[global::Cpp2ILInjected.Token(Token = "0x170002AB")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC5C2C", Offset = "0x1DC5C2C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000049C1 File Offset: 0x00002BC1
		[global::Cpp2ILInjected.Token(Token = "0x60009B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC5C84", Offset = "0x1DC5C84", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x000049C4 File Offset: 0x00002BC4
		[global::Cpp2ILInjected.Token(Token = "0x60009B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC5D10", Offset = "0x1DC5D10", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToChar", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(char))]
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

		// Token: 0x06000925 RID: 2341 RVA: 0x000049C7 File Offset: 0x00002BC7
		[global::Cpp2ILInjected.Token(Token = "0x60009BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC5EC8", Offset = "0x1DC5EC8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToChar", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref char)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000049CA File Offset: 0x00002BCA
		[global::Cpp2ILInjected.Token(Token = "0x60009BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC5F74", Offset = "0x1DC5F74", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_char()
		{
			throw null;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x000049CD File Offset: 0x00002BCD
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60009BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC5FC8", Offset = "0x1DC5FC8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_char()
		{
			throw null;
		}

		// Token: 0x0400038F RID: 911
		[global::Cpp2ILInjected.Token(Token = "0x4000509")]
		private static readonly Type atomicValueType;

		// Token: 0x04000390 RID: 912
		[global::Cpp2ILInjected.Token(Token = "0x400050A")]
		private static readonly Type listValueType;
	}
}
