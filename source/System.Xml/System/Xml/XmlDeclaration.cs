using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200004C RID: 76
	[global::Cpp2ILInjected.Token(Token = "0x2000069")]
	public class XmlDeclaration : XmlLinkedNode
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x00003B7B File Offset: 0x00001D7B
		[global::Cpp2ILInjected.Token(Token = "0x60004B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8D7C4", Offset = "0x1D8D7C4", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateXmlDeclaration", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlDeclaration))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLinkedNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDeclaration), Member = "IsValidXmlVersion", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDeclaration), Member = "set_Standalone", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		protected internal XmlDeclaration(string version, string encoding, string standalone, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00003B7E File Offset: 0x00001D7E
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00003B81 File Offset: 0x00001D81
		[global::Cpp2ILInjected.Token(Token = "0x17000104")]
		public string Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8DB64", Offset = "0x1D8DB64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8DB6C", Offset = "0x1D8DB6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00003B84 File Offset: 0x00001D84
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00003B87 File Offset: 0x00001D87
		[global::Cpp2ILInjected.Token(Token = "0x17000105")]
		public string Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8DB74", Offset = "0x1D8DB74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8D9DC", Offset = "0x1D8D9DC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDeclaration), Member = "set_InnerText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlDeclarationWrapper", Member = "set_Encoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00003B8A File Offset: 0x00001D8A
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x00003B8D File Offset: 0x00001D8D
		[global::Cpp2ILInjected.Token(Token = "0x17000106")]
		public string Standalone
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8DB7C", Offset = "0x1D8DB7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8DA34", Offset = "0x1D8DA34", Length = "0x130")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDeclaration), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(XmlDocument)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDeclaration), Member = "set_InnerText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlDeclarationWrapper", Member = "set_Standalone", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00003B90 File Offset: 0x00001D90
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x00003B93 File Offset: 0x00001D93
		[global::Cpp2ILInjected.Token(Token = "0x17000107")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8DB84", Offset = "0x1D8DB84", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8DB94", Offset = "0x1D8DB94", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00003B96 File Offset: 0x00001D96
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x00003B99 File Offset: 0x00001D99
		[global::Cpp2ILInjected.Token(Token = "0x17000108")]
		public override string InnerText
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8DBA4", Offset = "0x1D8DBA4", Length = "0x158")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8DCFC", Offset = "0x1D8DCFC", Length = "0x19C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "ParseXmlDeclarationValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref string),
				typeof(ref string),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDeclaration), Member = "IsValidXmlVersion", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDeclaration), Member = "set_Standalone", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDeclaration), Member = "set_Encoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00003B9C File Offset: 0x00001D9C
		[global::Cpp2ILInjected.Token(Token = "0x17000109")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8DE98", Offset = "0x1D8DE98", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00003B9F File Offset: 0x00001D9F
		[global::Cpp2ILInjected.Token(Token = "0x1700010A")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8DED8", Offset = "0x1D8DED8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00003BA2 File Offset: 0x00001DA2
		[global::Cpp2ILInjected.Token(Token = "0x1700010B")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8DEE4", Offset = "0x1D8DEE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00003BA5 File Offset: 0x00001DA5
		[global::Cpp2ILInjected.Token(Token = "0x60004C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8DEEC", Offset = "0x1D8DEEC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00003BA8 File Offset: 0x00001DA8
		[global::Cpp2ILInjected.Token(Token = "0x60004C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8D968", Offset = "0x1D8D968", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDeclaration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDeclaration), Member = "set_InnerText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsOnlyDigits", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		private bool IsValidXmlVersion(string ver)
		{
			throw null;
		}

		// Token: 0x0400019A RID: 410
		[global::Cpp2ILInjected.Token(Token = "0x4000294")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string version;

		// Token: 0x0400019B RID: 411
		[global::Cpp2ILInjected.Token(Token = "0x4000295")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string encoding;

		// Token: 0x0400019C RID: 412
		[global::Cpp2ILInjected.Token(Token = "0x4000296")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string standalone;
	}
}
