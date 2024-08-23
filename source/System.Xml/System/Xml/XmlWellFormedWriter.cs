using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200003D RID: 61
	[global::Cpp2ILInjected.Token(Token = "0x200004E")]
	internal class XmlWellFormedWriter : XmlWriter
	{
		// Token: 0x0600036C RID: 876 RVA: 0x00003959 File Offset: 0x00001B59
		[global::Cpp2ILInjected.Token(Token = "0x60003C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D831B0", Offset = "0x1D831B0", Length = "0x3B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecureStringHasher), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		internal XmlWellFormedWriter(XmlWriter writer, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000395C File Offset: 0x00001B5C
		[global::Cpp2ILInjected.Token(Token = "0x170000C2")]
		public override WriteState WriteState
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D835BC", Offset = "0x1D835BC", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000395F File Offset: 0x00001B5F
		[global::Cpp2ILInjected.Token(Token = "0x60003C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D83638", Offset = "0x1D83638", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteStartDocument()
		{
			throw null;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00003962 File Offset: 0x00001B62
		[global::Cpp2ILInjected.Token(Token = "0x60003CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D837E0", Offset = "0x1D837E0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "WriteStartDocumentImpl", MemberParameters = new object[] { typeof(XmlStandalone) }, ReturnType = typeof(void))]
		public override void WriteStartDocument(bool standalone)
		{
			throw null;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00003965 File Offset: 0x00001B65
		[global::Cpp2ILInjected.Token(Token = "0x60003CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D837F0", Offset = "0x1D837F0", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override void WriteEndDocument()
		{
			throw null;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00003968 File Offset: 0x00001B68
		[global::Cpp2ILInjected.Token(Token = "0x60003CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D83C04", Offset = "0x1D83C04", Length = "0x4A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "VerifyQName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ExceptionType)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsPublicId", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsOnlyCharData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			throw null;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000396B File Offset: 0x00001B6B
		[global::Cpp2ILInjected.Token(Token = "0x60003CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D840AC", Offset = "0x1D840AC", Length = "0x364")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "CheckNCName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "LookupNamespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceImplicit", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000396E File Offset: 0x00001B6E
		[global::Cpp2ILInjected.Token(Token = "0x60003CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D84974", Offset = "0x1D84974", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "PopNamespaces", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override void WriteEndElement()
		{
			throw null;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00003971 File Offset: 0x00001B71
		[global::Cpp2ILInjected.Token(Token = "0x60003CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D84BFC", Offset = "0x1D84BFC", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "PopNamespaces", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override void WriteFullEndElement()
		{
			throw null;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00003974 File Offset: 0x00001B74
		[global::Cpp2ILInjected.Token(Token = "0x60003D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D84DCC", Offset = "0x1D84DCC", Length = "0x638")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "CheckNCName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "LookupNamespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "SetSpecialAttribute", MemberParameters = new object[] { typeof(XmlWellFormedWriter.SpecialAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "GeneratePrefix", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "LookupLocalNamespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceImplicit", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public override void WriteStartAttribute(string prefix, string localName, string namespaceName)
		{
			throw null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00003977 File Offset: 0x00001B77
		[global::Cpp2ILInjected.Token(Token = "0x60003D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D85894", Offset = "0x1D85894", Length = "0x704")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "Replay", MemberParameters = new object[] { typeof(XmlWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceExplicit", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "Trim", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		public override void WriteEndAttribute()
		{
			throw null;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000397A File Offset: 0x00001B7A
		[global::Cpp2ILInjected.Token(Token = "0x60003D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D86ADC", Offset = "0x1D86ADC", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void WriteCData(string text)
		{
			throw null;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000397D File Offset: 0x00001B7D
		[global::Cpp2ILInjected.Token(Token = "0x60003D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D86BD8", Offset = "0x1D86BD8", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00003980 File Offset: 0x00001B80
		[global::Cpp2ILInjected.Token(Token = "0x60003D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D86CD4", Offset = "0x1D86CD4", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "CheckNCName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override void WriteProcessingInstruction(string name, string text)
		{
			throw null;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00003983 File Offset: 0x00001B83
		[global::Cpp2ILInjected.Token(Token = "0x60003D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D86F68", Offset = "0x1D86F68", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "CheckNCName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteEntityRef", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override void WriteEntityRef(string name)
		{
			throw null;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00003986 File Offset: 0x00001B86
		[global::Cpp2ILInjected.Token(Token = "0x60003D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D87250", Offset = "0x1D87250", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteCharEntity", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override void WriteCharEntity(char ch)
		{
			throw null;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00003989 File Offset: 0x00001B89
		[global::Cpp2ILInjected.Token(Token = "0x60003D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8746C", Offset = "0x1D8746C", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsSurrogatePair", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteSurrogateCharEntity", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "CreateInvalidSurrogatePairException", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			throw null;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000398C File Offset: 0x00001B8C
		[global::Cpp2ILInjected.Token(Token = "0x60003D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D876A0", Offset = "0x1D876A0", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000398F File Offset: 0x00001B8F
		[global::Cpp2ILInjected.Token(Token = "0x60003D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8788C", Offset = "0x1D8788C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void WriteString(string text)
		{
			throw null;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00003992 File Offset: 0x00001B92
		[global::Cpp2ILInjected.Token(Token = "0x60003DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D879D4", Offset = "0x1D879D4", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public override void WriteChars(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00003995 File Offset: 0x00001B95
		[global::Cpp2ILInjected.Token(Token = "0x60003DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D87CC4", Offset = "0x1D87CC4", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteRaw", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00003998 File Offset: 0x00001B98
		[global::Cpp2ILInjected.Token(Token = "0x60003DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D87FB4", Offset = "0x1D87FB4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void WriteRaw(string data)
		{
			throw null;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000399B File Offset: 0x00001B9B
		[global::Cpp2ILInjected.Token(Token = "0x60003DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D880DC", Offset = "0x1D880DC", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000399E File Offset: 0x00001B9E
		[global::Cpp2ILInjected.Token(Token = "0x60003DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D88304", Offset = "0x1D88304", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x000039A1 File Offset: 0x00001BA1
		[global::Cpp2ILInjected.Token(Token = "0x60003DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D884E4", Offset = "0x1D884E4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000039A4 File Offset: 0x00001BA4
		[global::Cpp2ILInjected.Token(Token = "0x60003E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D88590", Offset = "0x1D88590", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override string LookupPrefix(string ns)
		{
			throw null;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000039A7 File Offset: 0x00001BA7
		[global::Cpp2ILInjected.Token(Token = "0x60003E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D887AC", Offset = "0x1D887AC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void WriteValue(string value)
		{
			throw null;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000039AA File Offset: 0x00001BAA
		[global::Cpp2ILInjected.Token(Token = "0x60003E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D888E4", Offset = "0x1D888E4", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinHexEncoder), Member = "Encode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(XmlWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000388 RID: 904 RVA: 0x000039AD File Offset: 0x00001BAD
		[global::Cpp2ILInjected.Token(Token = "0x170000C3")]
		internal XmlRawWriter RawWriter
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D88A3C", Offset = "0x1D88A3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000389 RID: 905 RVA: 0x000039B0 File Offset: 0x00001BB0
		[global::Cpp2ILInjected.Token(Token = "0x170000C4")]
		private bool SaveAttrValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D870B8", Offset = "0x1D870B8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600038A RID: 906 RVA: 0x000039B3 File Offset: 0x00001BB3
		[global::Cpp2ILInjected.Token(Token = "0x170000C5")]
		private bool InBase64
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D884B8", Offset = "0x1D884B8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000039B6 File Offset: 0x00001BB6
		[global::Cpp2ILInjected.Token(Token = "0x60003E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D85404", Offset = "0x1D85404", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special)
		{
			throw null;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x000039B9 File Offset: 0x00001BB9
		[global::Cpp2ILInjected.Token(Token = "0x60003E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D83640", Offset = "0x1D83640", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartDocument", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void WriteStartDocumentImpl(XmlStandalone standalone)
		{
			throw null;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000039BC File Offset: 0x00001BBC
		[global::Cpp2ILInjected.Token(Token = "0x60003E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D88AAC", Offset = "0x1D88AAC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void StartFragment()
		{
			throw null;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000039BF File Offset: 0x00001BBF
		[global::Cpp2ILInjected.Token(Token = "0x60003E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D845F4", Offset = "0x1D845F4", Length = "0x380")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "LookupNamespaceIndex", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AddNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(XmlWellFormedWriter.NamespaceKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private void PushNamespaceImplicit(string prefix, string ns)
		{
			throw null;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x000039C2 File Offset: 0x00001BC2
		[global::Cpp2ILInjected.Token(Token = "0x60003EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D85FB8", Offset = "0x1D85FB8", Length = "0x438")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEndAttribute", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "LookupNamespaceIndex", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AddNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(XmlWellFormedWriter.NamespaceKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "DupAttrException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private bool PushNamespaceExplicit(string prefix, string ns)
		{
			throw null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x000039C5 File Offset: 0x00001BC5
		[global::Cpp2ILInjected.Token(Token = "0x60003EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D88B8C", Offset = "0x1D88B8C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceImplicit", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceExplicit", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AddToNamespaceHashtable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind)
		{
			throw null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x000039C8 File Offset: 0x00001BC8
		[global::Cpp2ILInjected.Token(Token = "0x60003EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D88DEC", Offset = "0x1D88DEC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "AddNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(XmlWellFormedWriter.NamespaceKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddToNamespaceHashtable(int namespaceIndex)
		{
			throw null;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000039CB File Offset: 0x00001BCB
		[global::Cpp2ILInjected.Token(Token = "0x60003ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D88AB8", Offset = "0x1D88AB8", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceImplicit", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceExplicit", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int LookupNamespaceIndex(string prefix)
		{
			throw null;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000039CE File Offset: 0x00001BCE
		[global::Cpp2ILInjected.Token(Token = "0x60003EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D84B44", Offset = "0x1D84B44", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEndElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteFullEndElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void PopNamespaces(int indexFrom, int indexTo)
		{
			throw null;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000039D1 File Offset: 0x00001BD1
		[global::Cpp2ILInjected.Token(Token = "0x60003EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D88CF0", Offset = "0x1D88CF0", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceExplicit", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static XmlException DupAttrException(string prefix, string localName)
		{
			throw null;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000039D4 File Offset: 0x00001BD4
		[global::Cpp2ILInjected.Token(Token = "0x60003F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D83938", Offset = "0x1D83938", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "StartElementContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "GetStateName", MemberParameters = new object[] { typeof(XmlWellFormedWriter.State) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "ThrowInvalidStateTransition", MemberParameters = new object[]
		{
			typeof(XmlWellFormedWriter.Token),
			typeof(XmlWellFormedWriter.State)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void AdvanceState(XmlWellFormedWriter.Token token)
		{
			throw null;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000039D7 File Offset: 0x00001BD7
		[global::Cpp2ILInjected.Token(Token = "0x60003F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D890C4", Offset = "0x1D890C4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.Namespace), Member = "WriteDecl", MemberParameters = new object[]
		{
			typeof(XmlWriter),
			typeof(XmlRawWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void StartElementContent()
		{
			throw null;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000039DA File Offset: 0x00001BDA
		[global::Cpp2ILInjected.Token(Token = "0x60003F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D88EA8", Offset = "0x1D88EA8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "ThrowInvalidStateTransition", MemberParameters = new object[]
		{
			typeof(XmlWellFormedWriter.Token),
			typeof(XmlWellFormedWriter.State)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static string GetStateName(XmlWellFormedWriter.State state)
		{
			throw null;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000039DD File Offset: 0x00001BDD
		[global::Cpp2ILInjected.Token(Token = "0x60003F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D844E4", Offset = "0x1D844E4", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.NamespaceResolverProxy), Member = "System.Xml.IXmlNamespaceResolver.LookupNamespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "GeneratePrefix", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal string LookupNamespace(string prefix)
		{
			throw null;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000039E0 File Offset: 0x00001BE0
		[global::Cpp2ILInjected.Token(Token = "0x60003F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D855C0", Offset = "0x1D855C0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		private string LookupLocalNamespace(string prefix)
		{
			throw null;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000039E3 File Offset: 0x00001BE3
		[global::Cpp2ILInjected.Token(Token = "0x60003F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8548C", Offset = "0x1D8548C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "LookupNamespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private string GeneratePrefix()
		{
			throw null;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000039E6 File Offset: 0x00001BE6
		[global::Cpp2ILInjected.Token(Token = "0x60003F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D84410", Offset = "0x1D84410", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEntityRef", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "InvalidCharsException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void CheckNCName(string ncname)
		{
			throw null;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000039E9 File Offset: 0x00001BE9
		[global::Cpp2ILInjected.Token(Token = "0x60003F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D89280", Offset = "0x1D89280", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "CheckNCName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static Exception InvalidCharsException(string name, int badCharIndex)
		{
			throw null;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000039EC File Offset: 0x00001BEC
		[global::Cpp2ILInjected.Token(Token = "0x60003F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D88F30", Offset = "0x1D88F30", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new object[] { typeof(XmlWellFormedWriter.Token) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "GetStateName", MemberParameters = new object[] { typeof(XmlWellFormedWriter.State) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState)
		{
			throw null;
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600039E RID: 926 RVA: 0x000039EF File Offset: 0x00001BEF
		[global::Cpp2ILInjected.Token(Token = "0x170000C6")]
		private bool IsClosedOrErrorState
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D88A10", Offset = "0x1D88A10", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000039F2 File Offset: 0x00001BF2
		[global::Cpp2ILInjected.Token(Token = "0x60003FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D85668", Offset = "0x1D85668", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "AddToAttrHashTable", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttrName), Member = "IsDuplicate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "DupAttrException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void AddAttribute(string prefix, string localName, string namespaceName)
		{
			throw null;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000039F5 File Offset: 0x00001BF5
		[global::Cpp2ILInjected.Token(Token = "0x60003FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D89434", Offset = "0x1D89434", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddToAttrHashTable(int attributeIndex)
		{
			throw null;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000039F8 File Offset: 0x00001BF8
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60003FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D89528", Offset = "0x1D89528", Length = "0x7E0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 76)]
		static XmlWellFormedWriter()
		{
			throw null;
		}

		// Token: 0x04000144 RID: 324
		[global::Cpp2ILInjected.Token(Token = "0x40001DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlWriter writer;

		// Token: 0x04000145 RID: 325
		[global::Cpp2ILInjected.Token(Token = "0x40001DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlRawWriter rawWriter;

		// Token: 0x04000146 RID: 326
		[global::Cpp2ILInjected.Token(Token = "0x40001E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IXmlNamespaceResolver predefinedNamespaces;

		// Token: 0x04000147 RID: 327
		[global::Cpp2ILInjected.Token(Token = "0x40001E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XmlWellFormedWriter.Namespace[] nsStack;

		// Token: 0x04000148 RID: 328
		[global::Cpp2ILInjected.Token(Token = "0x40001E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int nsTop;

		// Token: 0x04000149 RID: 329
		[global::Cpp2ILInjected.Token(Token = "0x40001E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Dictionary<string, int> nsHashtable;

		// Token: 0x0400014A RID: 330
		[global::Cpp2ILInjected.Token(Token = "0x40001E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool useNsHashtable;

		// Token: 0x0400014B RID: 331
		[global::Cpp2ILInjected.Token(Token = "0x40001E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private XmlWellFormedWriter.ElementScope[] elemScopeStack;

		// Token: 0x0400014C RID: 332
		[global::Cpp2ILInjected.Token(Token = "0x40001E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int elemTop;

		// Token: 0x0400014D RID: 333
		[global::Cpp2ILInjected.Token(Token = "0x40001E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private XmlWellFormedWriter.AttrName[] attrStack;

		// Token: 0x0400014E RID: 334
		[global::Cpp2ILInjected.Token(Token = "0x40001E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int attrCount;

		// Token: 0x0400014F RID: 335
		[global::Cpp2ILInjected.Token(Token = "0x40001E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Dictionary<string, int> attrHashTable;

		// Token: 0x04000150 RID: 336
		[global::Cpp2ILInjected.Token(Token = "0x40001EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private XmlWellFormedWriter.SpecialAttribute specAttr;

		// Token: 0x04000151 RID: 337
		[global::Cpp2ILInjected.Token(Token = "0x40001EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private XmlWellFormedWriter.AttributeValueCache attrValueCache;

		// Token: 0x04000152 RID: 338
		[global::Cpp2ILInjected.Token(Token = "0x40001EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private string curDeclPrefix;

		// Token: 0x04000153 RID: 339
		[global::Cpp2ILInjected.Token(Token = "0x40001ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private XmlWellFormedWriter.State[] stateTable;

		// Token: 0x04000154 RID: 340
		[global::Cpp2ILInjected.Token(Token = "0x40001EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private XmlWellFormedWriter.State currentState;

		// Token: 0x04000155 RID: 341
		[global::Cpp2ILInjected.Token(Token = "0x40001EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		private bool checkCharacters;

		// Token: 0x04000156 RID: 342
		[global::Cpp2ILInjected.Token(Token = "0x40001F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x95")]
		private bool omitDuplNamespaces;

		// Token: 0x04000157 RID: 343
		[global::Cpp2ILInjected.Token(Token = "0x40001F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x96")]
		private bool writeEndDocumentOnClose;

		// Token: 0x04000158 RID: 344
		[global::Cpp2ILInjected.Token(Token = "0x40001F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private ConformanceLevel conformanceLevel;

		// Token: 0x04000159 RID: 345
		[global::Cpp2ILInjected.Token(Token = "0x40001F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		private bool dtdWritten;

		// Token: 0x0400015A RID: 346
		[global::Cpp2ILInjected.Token(Token = "0x40001F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9D")]
		private bool xmlDeclFollows;

		// Token: 0x0400015B RID: 347
		[global::Cpp2ILInjected.Token(Token = "0x40001F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private XmlCharType xmlCharType;

		// Token: 0x0400015C RID: 348
		[global::Cpp2ILInjected.Token(Token = "0x40001F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private SecureStringHasher hasher;

		// Token: 0x0400015D RID: 349
		[global::Cpp2ILInjected.Token(Token = "0x40001F7")]
		internal static readonly string[] stateName;

		// Token: 0x0400015E RID: 350
		[global::Cpp2ILInjected.Token(Token = "0x40001F8")]
		internal static readonly string[] tokenName;

		// Token: 0x0400015F RID: 351
		[global::Cpp2ILInjected.Token(Token = "0x40001F9")]
		private static WriteState[] state2WriteState;

		// Token: 0x04000160 RID: 352
		[global::Cpp2ILInjected.Token(Token = "0x40001FA")]
		private static readonly XmlWellFormedWriter.State[] StateTableDocument;

		// Token: 0x04000161 RID: 353
		[global::Cpp2ILInjected.Token(Token = "0x40001FB")]
		private static readonly XmlWellFormedWriter.State[] StateTableAuto;

		// Token: 0x0200015B RID: 347
		[global::Cpp2ILInjected.Token(Token = "0x200004F")]
		private enum State
		{
			// Token: 0x0400059A RID: 1434
			[global::Cpp2ILInjected.Token(Token = "0x40001FD")]
			Start,
			// Token: 0x0400059B RID: 1435
			[global::Cpp2ILInjected.Token(Token = "0x40001FE")]
			TopLevel,
			// Token: 0x0400059C RID: 1436
			[global::Cpp2ILInjected.Token(Token = "0x40001FF")]
			Document,
			// Token: 0x0400059D RID: 1437
			[global::Cpp2ILInjected.Token(Token = "0x4000200")]
			Element,
			// Token: 0x0400059E RID: 1438
			[global::Cpp2ILInjected.Token(Token = "0x4000201")]
			Content,
			// Token: 0x0400059F RID: 1439
			[global::Cpp2ILInjected.Token(Token = "0x4000202")]
			B64Content,
			// Token: 0x040005A0 RID: 1440
			[global::Cpp2ILInjected.Token(Token = "0x4000203")]
			B64Attribute,
			// Token: 0x040005A1 RID: 1441
			[global::Cpp2ILInjected.Token(Token = "0x4000204")]
			AfterRootEle,
			// Token: 0x040005A2 RID: 1442
			[global::Cpp2ILInjected.Token(Token = "0x4000205")]
			Attribute,
			// Token: 0x040005A3 RID: 1443
			[global::Cpp2ILInjected.Token(Token = "0x4000206")]
			SpecialAttr,
			// Token: 0x040005A4 RID: 1444
			[global::Cpp2ILInjected.Token(Token = "0x4000207")]
			EndDocument,
			// Token: 0x040005A5 RID: 1445
			[global::Cpp2ILInjected.Token(Token = "0x4000208")]
			RootLevelAttr,
			// Token: 0x040005A6 RID: 1446
			[global::Cpp2ILInjected.Token(Token = "0x4000209")]
			RootLevelSpecAttr,
			// Token: 0x040005A7 RID: 1447
			[global::Cpp2ILInjected.Token(Token = "0x400020A")]
			RootLevelB64Attr,
			// Token: 0x040005A8 RID: 1448
			[global::Cpp2ILInjected.Token(Token = "0x400020B")]
			AfterRootLevelAttr,
			// Token: 0x040005A9 RID: 1449
			[global::Cpp2ILInjected.Token(Token = "0x400020C")]
			Closed,
			// Token: 0x040005AA RID: 1450
			[global::Cpp2ILInjected.Token(Token = "0x400020D")]
			Error,
			// Token: 0x040005AB RID: 1451
			[global::Cpp2ILInjected.Token(Token = "0x400020E")]
			StartContent = 101,
			// Token: 0x040005AC RID: 1452
			[global::Cpp2ILInjected.Token(Token = "0x400020F")]
			StartContentEle,
			// Token: 0x040005AD RID: 1453
			[global::Cpp2ILInjected.Token(Token = "0x4000210")]
			StartContentB64,
			// Token: 0x040005AE RID: 1454
			[global::Cpp2ILInjected.Token(Token = "0x4000211")]
			StartDoc,
			// Token: 0x040005AF RID: 1455
			[global::Cpp2ILInjected.Token(Token = "0x4000212")]
			StartDocEle = 106,
			// Token: 0x040005B0 RID: 1456
			[global::Cpp2ILInjected.Token(Token = "0x4000213")]
			EndAttrSEle,
			// Token: 0x040005B1 RID: 1457
			[global::Cpp2ILInjected.Token(Token = "0x4000214")]
			EndAttrEEle,
			// Token: 0x040005B2 RID: 1458
			[global::Cpp2ILInjected.Token(Token = "0x4000215")]
			EndAttrSCont,
			// Token: 0x040005B3 RID: 1459
			[global::Cpp2ILInjected.Token(Token = "0x4000216")]
			EndAttrSAttr = 111,
			// Token: 0x040005B4 RID: 1460
			[global::Cpp2ILInjected.Token(Token = "0x4000217")]
			PostB64Cont,
			// Token: 0x040005B5 RID: 1461
			[global::Cpp2ILInjected.Token(Token = "0x4000218")]
			PostB64Attr,
			// Token: 0x040005B6 RID: 1462
			[global::Cpp2ILInjected.Token(Token = "0x4000219")]
			PostB64RootAttr,
			// Token: 0x040005B7 RID: 1463
			[global::Cpp2ILInjected.Token(Token = "0x400021A")]
			StartFragEle,
			// Token: 0x040005B8 RID: 1464
			[global::Cpp2ILInjected.Token(Token = "0x400021B")]
			StartFragCont,
			// Token: 0x040005B9 RID: 1465
			[global::Cpp2ILInjected.Token(Token = "0x400021C")]
			StartFragB64,
			// Token: 0x040005BA RID: 1466
			[global::Cpp2ILInjected.Token(Token = "0x400021D")]
			StartRootLevelAttr
		}

		// Token: 0x0200015C RID: 348
		[global::Cpp2ILInjected.Token(Token = "0x2000050")]
		private enum Token
		{
			// Token: 0x040005BC RID: 1468
			[global::Cpp2ILInjected.Token(Token = "0x400021F")]
			StartDocument,
			// Token: 0x040005BD RID: 1469
			[global::Cpp2ILInjected.Token(Token = "0x4000220")]
			EndDocument,
			// Token: 0x040005BE RID: 1470
			[global::Cpp2ILInjected.Token(Token = "0x4000221")]
			PI,
			// Token: 0x040005BF RID: 1471
			[global::Cpp2ILInjected.Token(Token = "0x4000222")]
			Comment,
			// Token: 0x040005C0 RID: 1472
			[global::Cpp2ILInjected.Token(Token = "0x4000223")]
			Dtd,
			// Token: 0x040005C1 RID: 1473
			[global::Cpp2ILInjected.Token(Token = "0x4000224")]
			StartElement,
			// Token: 0x040005C2 RID: 1474
			[global::Cpp2ILInjected.Token(Token = "0x4000225")]
			EndElement,
			// Token: 0x040005C3 RID: 1475
			[global::Cpp2ILInjected.Token(Token = "0x4000226")]
			StartAttribute,
			// Token: 0x040005C4 RID: 1476
			[global::Cpp2ILInjected.Token(Token = "0x4000227")]
			EndAttribute,
			// Token: 0x040005C5 RID: 1477
			[global::Cpp2ILInjected.Token(Token = "0x4000228")]
			Text,
			// Token: 0x040005C6 RID: 1478
			[global::Cpp2ILInjected.Token(Token = "0x4000229")]
			CData,
			// Token: 0x040005C7 RID: 1479
			[global::Cpp2ILInjected.Token(Token = "0x400022A")]
			AtomicValue,
			// Token: 0x040005C8 RID: 1480
			[global::Cpp2ILInjected.Token(Token = "0x400022B")]
			Base64,
			// Token: 0x040005C9 RID: 1481
			[global::Cpp2ILInjected.Token(Token = "0x400022C")]
			RawData,
			// Token: 0x040005CA RID: 1482
			[global::Cpp2ILInjected.Token(Token = "0x400022D")]
			Whitespace
		}

		// Token: 0x0200015D RID: 349
		[global::Cpp2ILInjected.Token(Token = "0x2000051")]
		private class NamespaceResolverProxy : IXmlNamespaceResolver
		{
			// Token: 0x06000C95 RID: 3221 RVA: 0x00005321 File Offset: 0x00003521
			[global::Cpp2ILInjected.Token(Token = "0x60003FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D83568", Offset = "0x1D83568", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal NamespaceResolverProxy(XmlWellFormedWriter wfWriter)
			{
				throw null;
			}

			// Token: 0x06000C96 RID: 3222 RVA: 0x00005324 File Offset: 0x00003524
			[global::Cpp2ILInjected.Token(Token = "0x60003FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D89D08", Offset = "0x1D89D08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter), Member = "LookupNamespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix)
			{
				throw null;
			}

			// Token: 0x06000C97 RID: 3223 RVA: 0x00005327 File Offset: 0x00003527
			[global::Cpp2ILInjected.Token(Token = "0x60003FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D89D10", Offset = "0x1D89D10", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName)
			{
				throw null;
			}

			// Token: 0x040005CB RID: 1483
			[global::Cpp2ILInjected.Token(Token = "0x400022E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private XmlWellFormedWriter wfWriter;
		}

		// Token: 0x0200015E RID: 350
		[global::Cpp2ILInjected.Token(Token = "0x2000052")]
		private struct ElementScope
		{
			// Token: 0x06000C98 RID: 3224 RVA: 0x0000532A File Offset: 0x0000352A
			[global::Cpp2ILInjected.Token(Token = "0x6000400")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D835A0", Offset = "0x1D835A0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop)
			{
				throw null;
			}

			// Token: 0x06000C99 RID: 3225 RVA: 0x0000532D File Offset: 0x0000352D
			[global::Cpp2ILInjected.Token(Token = "0x6000401")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D84B24", Offset = "0x1D84B24", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void WriteEndElement(XmlRawWriter rawWriter)
			{
				throw null;
			}

			// Token: 0x06000C9A RID: 3226 RVA: 0x00005330 File Offset: 0x00003530
			[global::Cpp2ILInjected.Token(Token = "0x6000402")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D84DAC", Offset = "0x1D84DAC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void WriteFullEndElement(XmlRawWriter rawWriter)
			{
				throw null;
			}

			// Token: 0x040005CC RID: 1484
			[global::Cpp2ILInjected.Token(Token = "0x400022F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal int prevNSTop;

			// Token: 0x040005CD RID: 1485
			[global::Cpp2ILInjected.Token(Token = "0x4000230")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal string prefix;

			// Token: 0x040005CE RID: 1486
			[global::Cpp2ILInjected.Token(Token = "0x4000231")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal string localName;

			// Token: 0x040005CF RID: 1487
			[global::Cpp2ILInjected.Token(Token = "0x4000232")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal string namespaceUri;

			// Token: 0x040005D0 RID: 1488
			[global::Cpp2ILInjected.Token(Token = "0x4000233")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal XmlSpace xmlSpace;

			// Token: 0x040005D1 RID: 1489
			[global::Cpp2ILInjected.Token(Token = "0x4000234")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal string xmlLang;
		}

		// Token: 0x0200015F RID: 351
		[global::Cpp2ILInjected.Token(Token = "0x2000053")]
		private enum NamespaceKind
		{
			// Token: 0x040005D3 RID: 1491
			[global::Cpp2ILInjected.Token(Token = "0x4000236")]
			Written,
			// Token: 0x040005D4 RID: 1492
			[global::Cpp2ILInjected.Token(Token = "0x4000237")]
			NeedToWrite,
			// Token: 0x040005D5 RID: 1493
			[global::Cpp2ILInjected.Token(Token = "0x4000238")]
			Implied,
			// Token: 0x040005D6 RID: 1494
			[global::Cpp2ILInjected.Token(Token = "0x4000239")]
			Special
		}

		// Token: 0x02000160 RID: 352
		[global::Cpp2ILInjected.Token(Token = "0x2000054")]
		private struct Namespace
		{
			// Token: 0x06000C9B RID: 3227 RVA: 0x00005333 File Offset: 0x00003533
			[global::Cpp2ILInjected.Token(Token = "0x6000403")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D83590", Offset = "0x1D83590", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void Set(string prefix, string namespaceUri, XmlWellFormedWriter.NamespaceKind kind)
			{
				throw null;
			}

			// Token: 0x06000C9C RID: 3228 RVA: 0x00005336 File Offset: 0x00003536
			[global::Cpp2ILInjected.Token(Token = "0x6000404")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D89164", Offset = "0x1D89164", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "StartElementContent", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter)
			{
				throw null;
			}

			// Token: 0x040005D7 RID: 1495
			[global::Cpp2ILInjected.Token(Token = "0x400023A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal string prefix;

			// Token: 0x040005D8 RID: 1496
			[global::Cpp2ILInjected.Token(Token = "0x400023B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal string namespaceUri;

			// Token: 0x040005D9 RID: 1497
			[global::Cpp2ILInjected.Token(Token = "0x400023C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal XmlWellFormedWriter.NamespaceKind kind;

			// Token: 0x040005DA RID: 1498
			[global::Cpp2ILInjected.Token(Token = "0x400023D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			internal int prevNsIndex;
		}

		// Token: 0x02000161 RID: 353
		[global::Cpp2ILInjected.Token(Token = "0x2000055")]
		private struct AttrName
		{
			// Token: 0x06000C9D RID: 3229 RVA: 0x00005339 File Offset: 0x00003539
			[global::Cpp2ILInjected.Token(Token = "0x6000405")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D893B8", Offset = "0x1D893B8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void Set(string prefix, string localName, string namespaceUri)
			{
				throw null;
			}

			// Token: 0x06000C9E RID: 3230 RVA: 0x0000533C File Offset: 0x0000353C
			[global::Cpp2ILInjected.Token(Token = "0x6000406")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D893C8", Offset = "0x1D893C8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "AddAttribute", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			internal bool IsDuplicate(string prefix, string localName, string namespaceUri)
			{
				throw null;
			}

			// Token: 0x040005DB RID: 1499
			[global::Cpp2ILInjected.Token(Token = "0x400023E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal string prefix;

			// Token: 0x040005DC RID: 1500
			[global::Cpp2ILInjected.Token(Token = "0x400023F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal string namespaceUri;

			// Token: 0x040005DD RID: 1501
			[global::Cpp2ILInjected.Token(Token = "0x4000240")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal string localName;

			// Token: 0x040005DE RID: 1502
			[global::Cpp2ILInjected.Token(Token = "0x4000241")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal int prev;
		}

		// Token: 0x02000162 RID: 354
		[global::Cpp2ILInjected.Token(Token = "0x2000056")]
		private enum SpecialAttribute
		{
			// Token: 0x040005E0 RID: 1504
			[global::Cpp2ILInjected.Token(Token = "0x4000243")]
			No,
			// Token: 0x040005E1 RID: 1505
			[global::Cpp2ILInjected.Token(Token = "0x4000244")]
			DefaultXmlns,
			// Token: 0x040005E2 RID: 1506
			[global::Cpp2ILInjected.Token(Token = "0x4000245")]
			PrefixedXmlns,
			// Token: 0x040005E3 RID: 1507
			[global::Cpp2ILInjected.Token(Token = "0x4000246")]
			XmlSpace,
			// Token: 0x040005E4 RID: 1508
			[global::Cpp2ILInjected.Token(Token = "0x4000247")]
			XmlLang
		}

		// Token: 0x02000163 RID: 355
		[global::Cpp2ILInjected.Token(Token = "0x2000057")]
		private class AttributeValueCache
		{
			// Token: 0x17000366 RID: 870
			// (get) Token: 0x06000C9F RID: 3231 RVA: 0x0000533F File Offset: 0x0000353F
			[global::Cpp2ILInjected.Token(Token = "0x170000C7")]
			internal string StringValue
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000407")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D85F98", Offset = "0x1D85F98", Length = "0x20")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000CA0 RID: 3232 RVA: 0x00005342 File Offset: 0x00003542
			[global::Cpp2ILInjected.Token(Token = "0x6000408")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D870C8", Offset = "0x1D870C8", Length = "0x188")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEntityRef", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "StartComplexValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "AddItem", MemberParameters = new object[]
			{
				"System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType",
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal void WriteEntityRef(string name)
			{
				throw null;
			}

			// Token: 0x06000CA1 RID: 3233 RVA: 0x00005345 File Offset: 0x00003545
			[global::Cpp2ILInjected.Token(Token = "0x6000409")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D873E0", Offset = "0x1D873E0", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteCharEntity", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "StartComplexValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "AddItem", MemberParameters = new object[]
			{
				"System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType",
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void WriteCharEntity(char ch)
			{
				throw null;
			}

			// Token: 0x06000CA2 RID: 3234 RVA: 0x00005348 File Offset: 0x00003548
			[global::Cpp2ILInjected.Token(Token = "0x600040A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D87600", Offset = "0x1D87600", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteSurrogateCharEntity", MemberParameters = new object[]
			{
				typeof(char),
				typeof(char)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "StartComplexValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "AddItem", MemberParameters = new object[]
			{
				"System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType",
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void WriteSurrogateCharEntity(char lowChar, char highChar)
			{
				throw null;
			}

			// Token: 0x06000CA3 RID: 3235 RVA: 0x0000534B File Offset: 0x0000354B
			[global::Cpp2ILInjected.Token(Token = "0x600040B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D87844", Offset = "0x1D87844", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "StartComplexValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "AddItem", MemberParameters = new object[]
			{
				"System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType",
				typeof(object)
			}, ReturnType = typeof(void))]
			internal void WriteWhitespace(string ws)
			{
				throw null;
			}

			// Token: 0x06000CA4 RID: 3236 RVA: 0x0000534E File Offset: 0x0000354E
			[global::Cpp2ILInjected.Token(Token = "0x600040C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8796C", Offset = "0x1D8796C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "StartComplexValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "AddItem", MemberParameters = new object[]
			{
				"System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType",
				typeof(object)
			}, ReturnType = typeof(void))]
			internal void WriteString(string text)
			{
				throw null;
			}

			// Token: 0x06000CA5 RID: 3237 RVA: 0x00005351 File Offset: 0x00003551
			[global::Cpp2ILInjected.Token(Token = "0x600040D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D87C20", Offset = "0x1D87C20", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteChars", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "StartComplexValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "AddItem", MemberParameters = new object[]
			{
				"System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType",
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void WriteChars(char[] buffer, int index, int count)
			{
				throw null;
			}

			// Token: 0x06000CA6 RID: 3238 RVA: 0x00005354 File Offset: 0x00003554
			[global::Cpp2ILInjected.Token(Token = "0x600040E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D87F10", Offset = "0x1D87F10", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteRaw", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "StartComplexValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "AddItem", MemberParameters = new object[]
			{
				"System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType",
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void WriteRaw(char[] buffer, int index, int count)
			{
				throw null;
			}

			// Token: 0x06000CA7 RID: 3239 RVA: 0x00005357 File Offset: 0x00003557
			[global::Cpp2ILInjected.Token(Token = "0x600040F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D88094", Offset = "0x1D88094", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "StartComplexValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "AddItem", MemberParameters = new object[]
			{
				"System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType",
				typeof(object)
			}, ReturnType = typeof(void))]
			internal void WriteRaw(string data)
			{
				throw null;
			}

			// Token: 0x06000CA8 RID: 3240 RVA: 0x0000535A File Offset: 0x0000355A
			[global::Cpp2ILInjected.Token(Token = "0x6000410")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8889C", Offset = "0x1D8889C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "StartComplexValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "AddItem", MemberParameters = new object[]
			{
				"System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType",
				typeof(object)
			}, ReturnType = typeof(void))]
			internal void WriteValue(string value)
			{
				throw null;
			}

			// Token: 0x06000CA9 RID: 3241 RVA: 0x0000535D File Offset: 0x0000355D
			[global::Cpp2ILInjected.Token(Token = "0x6000411")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D863F0", Offset = "0x1D863F0", Length = "0x2D0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEndAttribute", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			internal void Replay(XmlWriter writer)
			{
				throw null;
			}

			// Token: 0x06000CAA RID: 3242 RVA: 0x00005360 File Offset: 0x00003560
			[global::Cpp2ILInjected.Token(Token = "0x6000412")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D866C0", Offset = "0x1D866C0", Length = "0x3FC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEndAttribute", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TrimString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TrimStringStart", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TrimStringEnd", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			internal void Trim()
			{
				throw null;
			}

			// Token: 0x06000CAB RID: 3243 RVA: 0x00005363 File Offset: 0x00003563
			[global::Cpp2ILInjected.Token(Token = "0x6000413")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D86ABC", Offset = "0x1D86ABC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			internal void Clear()
			{
				throw null;
			}

			// Token: 0x06000CAC RID: 3244 RVA: 0x00005366 File Offset: 0x00003566
			[global::Cpp2ILInjected.Token(Token = "0x6000414")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D89D24", Offset = "0x1D89D24", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteEntityRef", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteCharEntity", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteSurrogateCharEntity", MemberParameters = new object[]
			{
				typeof(char),
				typeof(char)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteChars", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteRaw", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "AddItem", MemberParameters = new object[]
			{
				"System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType",
				typeof(object)
			}, ReturnType = typeof(void))]
			private void StartComplexValue()
			{
				throw null;
			}

			// Token: 0x06000CAD RID: 3245 RVA: 0x00005369 File Offset: 0x00003569
			[global::Cpp2ILInjected.Token(Token = "0x6000415")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D89D58", Offset = "0x1D89D58", Length = "0x130")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteEntityRef", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteCharEntity", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteSurrogateCharEntity", MemberParameters = new object[]
			{
				typeof(char),
				typeof(char)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteChars", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteRaw", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "WriteValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter.AttributeValueCache), Member = "StartComplexValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			private void AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data)
			{
				throw null;
			}

			// Token: 0x06000CAE RID: 3246 RVA: 0x0000536C File Offset: 0x0000356C
			[global::Cpp2ILInjected.Token(Token = "0x6000416")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D88A44", Offset = "0x1D88A44", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWellFormedWriter), Member = "SetSpecialAttribute", MemberParameters = new object[] { "System.Xml.XmlWellFormedWriter.SpecialAttribute" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public AttributeValueCache()
			{
				throw null;
			}

			// Token: 0x040005E5 RID: 1509
			[global::Cpp2ILInjected.Token(Token = "0x4000248")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private StringBuilder stringValue;

			// Token: 0x040005E6 RID: 1510
			[global::Cpp2ILInjected.Token(Token = "0x4000249")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string singleStringValue;

			// Token: 0x040005E7 RID: 1511
			[global::Cpp2ILInjected.Token(Token = "0x400024A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private XmlWellFormedWriter.AttributeValueCache.Item[] items;

			// Token: 0x040005E8 RID: 1512
			[global::Cpp2ILInjected.Token(Token = "0x400024B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int firstItem;

			// Token: 0x040005E9 RID: 1513
			[global::Cpp2ILInjected.Token(Token = "0x400024C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			private int lastItem;

			// Token: 0x02000189 RID: 393
			[global::Cpp2ILInjected.Token(Token = "0x2000058")]
			private enum ItemType
			{
				// Token: 0x040006AB RID: 1707
				[global::Cpp2ILInjected.Token(Token = "0x400024E")]
				EntityRef,
				// Token: 0x040006AC RID: 1708
				[global::Cpp2ILInjected.Token(Token = "0x400024F")]
				CharEntity,
				// Token: 0x040006AD RID: 1709
				[global::Cpp2ILInjected.Token(Token = "0x4000250")]
				SurrogateCharEntity,
				// Token: 0x040006AE RID: 1710
				[global::Cpp2ILInjected.Token(Token = "0x4000251")]
				Whitespace,
				// Token: 0x040006AF RID: 1711
				[global::Cpp2ILInjected.Token(Token = "0x4000252")]
				String,
				// Token: 0x040006B0 RID: 1712
				[global::Cpp2ILInjected.Token(Token = "0x4000253")]
				StringChars,
				// Token: 0x040006B1 RID: 1713
				[global::Cpp2ILInjected.Token(Token = "0x4000254")]
				Raw,
				// Token: 0x040006B2 RID: 1714
				[global::Cpp2ILInjected.Token(Token = "0x4000255")]
				RawChars,
				// Token: 0x040006B3 RID: 1715
				[global::Cpp2ILInjected.Token(Token = "0x4000256")]
				ValueString
			}

			// Token: 0x0200018A RID: 394
			[global::Cpp2ILInjected.Token(Token = "0x2000059")]
			private class Item
			{
				// Token: 0x06000CD9 RID: 3289 RVA: 0x000053E7 File Offset: 0x000035E7
				[global::Cpp2ILInjected.Token(Token = "0x6000417")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D89EC4", Offset = "0x1D89EC4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				internal Item()
				{
					throw null;
				}

				// Token: 0x06000CDA RID: 3290 RVA: 0x000053EA File Offset: 0x000035EA
				[global::Cpp2ILInjected.Token(Token = "0x6000418")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D89ECC", Offset = "0x1D89ECC", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				internal void Set(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data)
				{
					throw null;
				}

				// Token: 0x040006B4 RID: 1716
				[global::Cpp2ILInjected.Token(Token = "0x4000257")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				internal XmlWellFormedWriter.AttributeValueCache.ItemType type;

				// Token: 0x040006B5 RID: 1717
				[global::Cpp2ILInjected.Token(Token = "0x4000258")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				internal object data;
			}

			// Token: 0x0200018B RID: 395
			[global::Cpp2ILInjected.Token(Token = "0x200005A")]
			private class BufferChunk
			{
				// Token: 0x06000CDB RID: 3291 RVA: 0x000053ED File Offset: 0x000035ED
				[global::Cpp2ILInjected.Token(Token = "0x6000419")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D89E88", Offset = "0x1D89E88", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				internal BufferChunk(char[] buffer, int index, int count)
				{
					throw null;
				}

				// Token: 0x040006B6 RID: 1718
				[global::Cpp2ILInjected.Token(Token = "0x4000259")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				internal char[] buffer;

				// Token: 0x040006B7 RID: 1719
				[global::Cpp2ILInjected.Token(Token = "0x400025A")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				internal int index;

				// Token: 0x040006B8 RID: 1720
				[global::Cpp2ILInjected.Token(Token = "0x400025B")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
				internal int count;
			}
		}
	}
}
