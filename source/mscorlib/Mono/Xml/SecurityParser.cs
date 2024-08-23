using System;
using System.Collections;
using System.IO;
using System.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace Mono.Xml
{
	// Token: 0x0200001C RID: 28
	[global::Cpp2ILInjected.Token(Token = "0x2000029")]
	internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00014699 File Offset: 0x00012899
		[global::Cpp2ILInjected.Token(Token = "0x600006C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB86C", Offset = "0x1AAB86C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "FromXml", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Stack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SecurityParser()
		{
			throw null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0001469C File Offset: 0x0001289C
		[global::Cpp2ILInjected.Token(Token = "0x600006D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB9D8", Offset = "0x1AAB9D8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "FromXml", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.StringReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void LoadXml(string xml)
		{
			throw null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0001469F File Offset: 0x0001289F
		[global::Cpp2ILInjected.Token(Token = "0x600006E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AABC0C", Offset = "0x1AABC0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.Security.SecurityElement ToXml()
		{
			throw null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000146A2 File Offset: 0x000128A2
		[global::Cpp2ILInjected.Token(Token = "0x600006F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AABC14", Offset = "0x1AABC14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OnStartParsing(SmallXmlParser parser)
		{
			throw null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000146A5 File Offset: 0x000128A5
		[global::Cpp2ILInjected.Token(Token = "0x6000070")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AABC18", Offset = "0x1AABC18", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OnProcessingInstruction(string name, string text)
		{
			throw null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000146A8 File Offset: 0x000128A8
		[global::Cpp2ILInjected.Token(Token = "0x6000071")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AABC1C", Offset = "0x1AABC1C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OnIgnorableWhitespace(string s)
		{
			throw null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000146AB File Offset: 0x000128AB
		[global::Cpp2ILInjected.Token(Token = "0x6000072")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AABC20", Offset = "0x1AABC20", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecurityElement), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecurityElement), Member = "AddChild", MemberParameters = new object[] { typeof(global::System.Security.SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecurityElement), Member = "Escape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecurityElement), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void OnStartElement(string name, SmallXmlParser.IAttrList attrs)
		{
			throw null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000146AE File Offset: 0x000128AE
		[global::Cpp2ILInjected.Token(Token = "0x6000073")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AABE84", Offset = "0x1AABE84", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void OnEndElement(string name)
		{
			throw null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000146B1 File Offset: 0x000128B1
		[global::Cpp2ILInjected.Token(Token = "0x6000074")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AABF04", Offset = "0x1AABF04", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecurityElement), Member = "Escape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecurityElement), Member = "set_Text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void OnChars(string ch)
		{
			throw null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000146B4 File Offset: 0x000128B4
		[global::Cpp2ILInjected.Token(Token = "0x6000075")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AABF7C", Offset = "0x1AABF7C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OnEndParsing(SmallXmlParser parser)
		{
			throw null;
		}

		// Token: 0x0400002D RID: 45
		[global::Cpp2ILInjected.Token(Token = "0x40000BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private global::System.Security.SecurityElement root;

		// Token: 0x0400002E RID: 46
		[global::Cpp2ILInjected.Token(Token = "0x40000BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private global::System.Security.SecurityElement current;

		// Token: 0x0400002F RID: 47
		[global::Cpp2ILInjected.Token(Token = "0x40000BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private global::System.Collections.Stack stack;
	}
}
