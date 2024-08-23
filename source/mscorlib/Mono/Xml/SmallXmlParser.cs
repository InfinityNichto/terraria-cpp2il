using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Remoting;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Xml
{
	// Token: 0x0200001D RID: 29
	[global::Cpp2ILInjected.Token(Token = "0x200002A")]
	internal class SmallXmlParser
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000146B7 File Offset: 0x000128B7
		[global::Cpp2ILInjected.Token(Token = "0x6000076")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB8CC", Offset = "0x1AAB8CC", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityParser), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingConfiguration), Member = "LoadDefaultDelayedChannels", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Stack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser.AttrListImpl), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public SmallXmlParser()
		{
			throw null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000146BA File Offset: 0x000128BA
		[global::Cpp2ILInjected.Token(Token = "0x6000077")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAC014", Offset = "0x1AAC014", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.IO.TextReader),
			typeof(SmallXmlParser.IContentHandler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new object[] { typeof(SmallXmlParser.AttrListImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadComment", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParserException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private global::System.Exception Error(string msg)
		{
			throw null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000146BD File Offset: 0x000128BD
		[global::Cpp2ILInjected.Token(Token = "0x6000078")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAC150", Offset = "0x1AAC150", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadUntil", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadCDATASection", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private global::System.Exception UnexpectedEndError()
		{
			throw null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000146C0 File Offset: 0x000128C0
		[global::Cpp2ILInjected.Token(Token = "0x6000079")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAC230", Offset = "0x1AAC230", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool IsNameChar(char c, bool start)
		{
			throw null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000146C3 File Offset: 0x000128C3
		[global::Cpp2ILInjected.Token(Token = "0x600007A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAC32C", Offset = "0x1AAC32C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsWhitespace(int c)
		{
			throw null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000146C6 File Offset: 0x000128C6
		[global::Cpp2ILInjected.Token(Token = "0x600007B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAC35C", Offset = "0x1AAC35C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new object[] { typeof(SmallXmlParser.AttrListImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
		public void SkipWhitespaces()
		{
			throw null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000146C9 File Offset: 0x000128C9
		[global::Cpp2ILInjected.Token(Token = "0x600007C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAC454", Offset = "0x1AAC454", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		private void HandleWhitespaces()
		{
			throw null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000146CC File Offset: 0x000128CC
		[global::Cpp2ILInjected.Token(Token = "0x600007D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAC3B4", Offset = "0x1AAC3B4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new object[] { typeof(SmallXmlParser.AttrListImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SkipWhitespaces(bool expected)
		{
			throw null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000146CF File Offset: 0x000128CF
		[global::Cpp2ILInjected.Token(Token = "0x600007E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAC558", Offset = "0x1AAC558", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int Peek()
		{
			throw null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000146D2 File Offset: 0x000128D2
		[global::Cpp2ILInjected.Token(Token = "0x600007F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAC4F8", Offset = "0x1AAC4F8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "HandleWhitespaces", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadUntil", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadCharacters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadCharacterReference", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new object[] { typeof(SmallXmlParser.AttrListImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadCDATASection", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadComment", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		private int Read()
		{
			throw null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000146D5 File Offset: 0x000128D5
		[global::Cpp2ILInjected.Token(Token = "0x6000080")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAC568", Offset = "0x1AAC568", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new object[] { typeof(SmallXmlParser.AttrListImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadComment", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Expect(int c)
		{
			throw null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000146D8 File Offset: 0x000128D8
		[global::Cpp2ILInjected.Token(Token = "0x6000081")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAC628", Offset = "0x1AAC628", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new object[] { typeof(SmallXmlParser.AttrListImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private string ReadUntil(char until, bool handleReferences)
		{
			throw null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000146DB File Offset: 0x000128DB
		[global::Cpp2ILInjected.Token(Token = "0x6000082")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAC8A8", Offset = "0x1AAC8A8", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new object[] { typeof(SmallXmlParser.AttrListImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "IsNameChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public string ReadName()
		{
			throw null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000146DE File Offset: 0x000128DE
		[global::Cpp2ILInjected.Token(Token = "0x6000083")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AABA60", Offset = "0x1AABA60", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingConfiguration), Member = "LoadDefaultDelayedChannels", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "HandleBufferedContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Cleanup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Parse(global::System.IO.TextReader input, SmallXmlParser.IContentHandler handler)
		{
			throw null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000146E1 File Offset: 0x000128E1
		[global::Cpp2ILInjected.Token(Token = "0x6000084")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAD184", Offset = "0x1AAD184", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.IO.TextReader),
			typeof(SmallXmlParser.IContentHandler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser.AttrListImpl), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		private void Cleanup()
		{
			throw null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000146E4 File Offset: 0x000128E4
		[global::Cpp2ILInjected.Token(Token = "0x6000085")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AACA2C", Offset = "0x1AACA2C", Length = "0x634")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.IO.TextReader),
			typeof(SmallXmlParser.IContentHandler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "HandleWhitespaces", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "ReadCDATASection", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "ReadCharacters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "HandleBufferedContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "ReadUntil", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new object[] { typeof(SmallXmlParser.AttrListImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "ReadComment", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser.AttrListImpl), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void ReadContent()
		{
			throw null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000146E7 File Offset: 0x000128E7
		[global::Cpp2ILInjected.Token(Token = "0x6000086")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAD060", Offset = "0x1AAD060", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.IO.TextReader),
			typeof(SmallXmlParser.IContentHandler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void HandleBufferedContent()
		{
			throw null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000146EA File Offset: 0x000128EA
		[global::Cpp2ILInjected.Token(Token = "0x6000087")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAD544", Offset = "0x1AAD544", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
		private void ReadCharacters()
		{
			throw null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000146ED File Offset: 0x000128ED
		[global::Cpp2ILInjected.Token(Token = "0x6000088")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAC6FC", Offset = "0x1AAC6FC", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadUntil", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadCharacters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "ReadCharacterReference", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void ReadReference()
		{
			throw null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000146F0 File Offset: 0x000128F0
		[global::Cpp2ILInjected.Token(Token = "0x6000089")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAD5BC", Offset = "0x1AAD5BC", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
		private int ReadCharacterReference()
		{
			throw null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000146F3 File Offset: 0x000128F3
		[global::Cpp2ILInjected.Token(Token = "0x600008A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAD3F8", Offset = "0x1AAD3F8", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "ReadUntil", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser.AttrListImpl), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ReadAttribute(SmallXmlParser.AttrListImpl a)
		{
			throw null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000146F6 File Offset: 0x000128F6
		[global::Cpp2ILInjected.Token(Token = "0x600008B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAD27C", Offset = "0x1AAD27C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ReadCDATASection()
		{
			throw null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000146F9 File Offset: 0x000128F9
		[global::Cpp2ILInjected.Token(Token = "0x600008C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAD370", Offset = "0x1AAD370", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void ReadComment()
		{
			throw null;
		}

		// Token: 0x04000030 RID: 48
		[global::Cpp2ILInjected.Token(Token = "0x40000C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SmallXmlParser.IContentHandler handler;

		// Token: 0x04000031 RID: 49
		[global::Cpp2ILInjected.Token(Token = "0x40000C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.IO.TextReader reader;

		// Token: 0x04000032 RID: 50
		[global::Cpp2ILInjected.Token(Token = "0x40000C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Collections.Stack elementNames;

		// Token: 0x04000033 RID: 51
		[global::Cpp2ILInjected.Token(Token = "0x40000C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Collections.Stack xmlSpaces;

		// Token: 0x04000034 RID: 52
		[global::Cpp2ILInjected.Token(Token = "0x40000C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string xmlSpace;

		// Token: 0x04000035 RID: 53
		[global::Cpp2ILInjected.Token(Token = "0x40000C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.Text.StringBuilder buffer;

		// Token: 0x04000036 RID: 54
		[global::Cpp2ILInjected.Token(Token = "0x40000C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private char[] nameBuffer;

		// Token: 0x04000037 RID: 55
		[global::Cpp2ILInjected.Token(Token = "0x40000C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool isWhitespace;

		// Token: 0x04000038 RID: 56
		[global::Cpp2ILInjected.Token(Token = "0x40000C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private SmallXmlParser.AttrListImpl attributes;

		// Token: 0x04000039 RID: 57
		[global::Cpp2ILInjected.Token(Token = "0x40000C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int line;

		// Token: 0x0400003A RID: 58
		[global::Cpp2ILInjected.Token(Token = "0x40000CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private int column;

		// Token: 0x0400003B RID: 59
		[global::Cpp2ILInjected.Token(Token = "0x40000CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool resetColumn;

		// Token: 0x02000562 RID: 1378
		[global::Cpp2ILInjected.Token(Token = "0x200002B")]
		public interface IContentHandler
		{
			// Token: 0x06003F15 RID: 16149
			[global::Cpp2ILInjected.Token(Token = "0x600008D")]
			void OnStartParsing(SmallXmlParser parser);

			// Token: 0x06003F16 RID: 16150
			[global::Cpp2ILInjected.Token(Token = "0x600008E")]
			void OnEndParsing(SmallXmlParser parser);

			// Token: 0x06003F17 RID: 16151
			[global::Cpp2ILInjected.Token(Token = "0x600008F")]
			void OnStartElement(string name, SmallXmlParser.IAttrList attrs);

			// Token: 0x06003F18 RID: 16152
			[global::Cpp2ILInjected.Token(Token = "0x6000090")]
			void OnEndElement(string name);

			// Token: 0x06003F19 RID: 16153
			[global::Cpp2ILInjected.Token(Token = "0x6000091")]
			void OnProcessingInstruction(string name, string text);

			// Token: 0x06003F1A RID: 16154
			[global::Cpp2ILInjected.Token(Token = "0x6000092")]
			void OnChars(string text);

			// Token: 0x06003F1B RID: 16155
			[global::Cpp2ILInjected.Token(Token = "0x6000093")]
			void OnIgnorableWhitespace(string text);
		}

		// Token: 0x02000563 RID: 1379
		[global::Cpp2ILInjected.Token(Token = "0x200002C")]
		public interface IAttrList
		{
			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x06003F1C RID: 16156
			[global::Cpp2ILInjected.Token(Token = "0x17000010")]
			int Length
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000094")]
				get;
			}

			// Token: 0x06003F1D RID: 16157
			[global::Cpp2ILInjected.Token(Token = "0x6000095")]
			string GetName(int i);

			// Token: 0x06003F1E RID: 16158
			[global::Cpp2ILInjected.Token(Token = "0x6000096")]
			string GetValue(int i);

			// Token: 0x06003F1F RID: 16159
			[global::Cpp2ILInjected.Token(Token = "0x6000097")]
			string GetValue(string name);

			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x06003F20 RID: 16160
			[global::Cpp2ILInjected.Token(Token = "0x17000011")]
			string[] Names
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000098")]
				get;
			}

			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x06003F21 RID: 16161
			[global::Cpp2ILInjected.Token(Token = "0x17000012")]
			string[] Values
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000099")]
				get;
			}
		}

		// Token: 0x02000564 RID: 1380
		[global::Cpp2ILInjected.Token(Token = "0x200002D")]
		private class AttrListImpl : SmallXmlParser.IAttrList
		{
			// Token: 0x17000707 RID: 1799
			// (get) Token: 0x06003F22 RID: 16162 RVA: 0x0001F838 File Offset: 0x0001DA38
			[global::Cpp2ILInjected.Token(Token = "0x17000013")]
			public int Length
			{
				[global::Cpp2ILInjected.Token(Token = "0x600009A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AAD7C4", Offset = "0x1AAD7C4", Length = "0x40")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06003F23 RID: 16163 RVA: 0x0001F83B File Offset: 0x0001DA3B
			[global::Cpp2ILInjected.Token(Token = "0x600009B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAD804", Offset = "0x1AAD804", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetName(int i)
			{
				throw null;
			}

			// Token: 0x06003F24 RID: 16164 RVA: 0x0001F83E File Offset: 0x0001DA3E
			[global::Cpp2ILInjected.Token(Token = "0x600009C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAD85C", Offset = "0x1AAD85C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetValue(int i)
			{
				throw null;
			}

			// Token: 0x06003F25 RID: 16165 RVA: 0x0001F841 File Offset: 0x0001DA41
			[global::Cpp2ILInjected.Token(Token = "0x600009D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAD8B4", Offset = "0x1AAD8B4", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public string GetValue(string name)
			{
				throw null;
			}

			// Token: 0x17000708 RID: 1800
			// (get) Token: 0x06003F26 RID: 16166 RVA: 0x0001F844 File Offset: 0x0001DA44
			[global::Cpp2ILInjected.Token(Token = "0x17000014")]
			public string[] Names
			{
				[global::Cpp2ILInjected.Token(Token = "0x600009E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AAD970", Offset = "0x1AAD970", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "ToArray", ReturnType = "T[]")]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000709 RID: 1801
			// (get) Token: 0x06003F27 RID: 16167 RVA: 0x0001F847 File Offset: 0x0001DA47
			[global::Cpp2ILInjected.Token(Token = "0x17000015")]
			public string[] Values
			{
				[global::Cpp2ILInjected.Token(Token = "0x600009F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AAD9B8", Offset = "0x1AAD9B8", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "ToArray", ReturnType = "T[]")]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06003F28 RID: 16168 RVA: 0x0001F84A File Offset: 0x0001DA4A
			[global::Cpp2ILInjected.Token(Token = "0x60000A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAD1EC", Offset = "0x1AAD1EC", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "Cleanup", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void Clear()
			{
				throw null;
			}

			// Token: 0x06003F29 RID: 16169 RVA: 0x0001F84D File Offset: 0x0001DA4D
			[global::Cpp2ILInjected.Token(Token = "0x60000A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAD6C4", Offset = "0x1AAD6C4", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new object[] { typeof(SmallXmlParser.AttrListImpl) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void Add(string name, string value)
			{
				throw null;
			}

			// Token: 0x06003F2A RID: 16170 RVA: 0x0001F850 File Offset: 0x0001DA50
			[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AABF80", Offset = "0x1AABF80", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmallXmlParser), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public AttrListImpl()
			{
				throw null;
			}

			// Token: 0x04001737 RID: 5943
			[global::Cpp2ILInjected.Token(Token = "0x40000CC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private global::System.Collections.Generic.List<string> attrNames;

			// Token: 0x04001738 RID: 5944
			[global::Cpp2ILInjected.Token(Token = "0x40000CD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private global::System.Collections.Generic.List<string> attrValues;
		}
	}
}
