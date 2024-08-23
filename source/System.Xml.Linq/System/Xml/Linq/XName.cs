using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	// Token: 0x02000010 RID: 16
	[global::Cpp2ILInjected.Token(Token = "0x2000016")]
	[Serializable]
	public sealed class XName : IEquatable<XName>, ISerializable
	{
		// Token: 0x06000073 RID: 115 RVA: 0x000021A6 File Offset: 0x000003A6
		[global::Cpp2ILInjected.Token(Token = "0x600008C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6DBDC", Offset = "0x1D6DBDC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "VerifyNCName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal XName(XNamespace ns, string localName)
		{
			throw null;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000021A9 File Offset: 0x000003A9
		[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
		public string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6DC88", Offset = "0x1D6DC88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000021AC File Offset: 0x000003AC
		[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
		public XNamespace Namespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6DC90", Offset = "0x1D6DC90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000021AF File Offset: 0x000003AF
		[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
		public string NamespaceName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D690DC", Offset = "0x1D690DC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XAttributeWrapper", Member = "get_NamespaceUri", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XElementWrapper", Member = "get_NamespaceUri", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000021B2 File Offset: 0x000003B2
		[global::Cpp2ILInjected.Token(Token = "0x6000090")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6DC98", Offset = "0x1D6DC98", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000021B5 File Offset: 0x000003B5
		[global::Cpp2ILInjected.Token(Token = "0x6000091")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6DD18", Offset = "0x1D6DD18", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XName), Member = "op_Implicit", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "Get", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "get_None", ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static XName Get(string expandedName)
		{
			throw null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000021B8 File Offset: 0x000003B8
		[global::Cpp2ILInjected.Token(Token = "0x6000092")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E2DC", Offset = "0x1D6E2DC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "Get", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XName))]
		public static XName Get(string localName, string namespaceName)
		{
			throw null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000021BB File Offset: 0x000003BB
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000093")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E2F8", Offset = "0x1D6E2F8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateElement", MemberParameters = new object[] { typeof(string) }, ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XElementWrapper", Member = "get_Attributes", ReturnType = "System.Collections.Generic.List`1<IXmlNode>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XName), Member = "Get", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XName))]
		public static implicit operator XName(string expandedName)
		{
			throw null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000021BE File Offset: 0x000003BE
		[global::Cpp2ILInjected.Token(Token = "0x6000094")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E304", Offset = "0x1D6E304", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000021C1 File Offset: 0x000003C1
		[global::Cpp2ILInjected.Token(Token = "0x6000095")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E310", Offset = "0x1D6E310", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000021C4 File Offset: 0x000003C4
		[global::Cpp2ILInjected.Token(Token = "0x6000096")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D689D8", Offset = "0x1D689D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(XName left, XName right)
		{
			throw null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000021C7 File Offset: 0x000003C7
		[global::Cpp2ILInjected.Token(Token = "0x6000097")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E318", Offset = "0x1D6E318", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other)
		{
			throw null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000021CA File Offset: 0x000003CA
		[global::Cpp2ILInjected.Token(Token = "0x6000098")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E324", Offset = "0x1D6E324", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000021CD File Offset: 0x000003CD
		[global::Cpp2ILInjected.Token(Token = "0x6000099")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E35C", Offset = "0x1D6E35C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal XName()
		{
			throw null;
		}

		// Token: 0x0400001F RID: 31
		[global::Cpp2ILInjected.Token(Token = "0x4000036")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XNamespace _ns;

		// Token: 0x04000020 RID: 32
		[global::Cpp2ILInjected.Token(Token = "0x4000037")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _localName;

		// Token: 0x04000021 RID: 33
		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _hashCode;
	}
}
