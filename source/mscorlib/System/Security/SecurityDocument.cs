﻿using System;
using System.Security.Util;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security
{
	[global::Cpp2ILInjected.Token(Token = "0x2000294")]
	[global::System.Serializable]
	internal sealed class SecurityDocument
	{
		[global::Cpp2ILInjected.Token(Token = "0x60016C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9DC4", Offset = "0x1AE9DC4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Parser), Member = "ParseContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SecurityDocument(int numData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9E2C", Offset = "0x1AE9E2C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityDocument), Member = "AddString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityDocument), Member = "AddToken", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Parser), Member = "ParseContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void GuaranteeSize(int size)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9EC4", Offset = "0x1AE9EC4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityDocument), Member = "AppendString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Parser), Member = "ParseContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityDocument), Member = "GuaranteeSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public void AddString(string str, ref int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9FC4", Offset = "0x1AE9FC4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Parser), Member = "ParseContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityDocument), Member = "AddString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSyntaxException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void AppendString(string str, ref int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEA030", Offset = "0x1AEA030", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int EncodedStringSize(string str)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEA040", Offset = "0x1AEA040", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SharedStatics), Member = "GetSharedStringMaker", ReturnType = typeof(global::System.Security.Util.Tokenizer.StringMaker))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Util.Tokenizer.StringMaker), Member = "MakeString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SharedStatics), Member = "ReleaseSharedStringMaker", MemberParameters = new object[] { typeof(ref global::System.Security.Util.Tokenizer.StringMaker) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public string GetString(ref int position, bool bCreate)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEA4BC", Offset = "0x1AEA4BC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityDocument), Member = "GuaranteeSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public void AddToken(byte b, ref int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEA500", Offset = "0x1AEA500", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SecurityElement))]
		public SecurityElement GetRootElement()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEA51C", Offset = "0x1AEA51C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SecurityElement))]
		public SecurityElement GetElement(int position, bool bCreate)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEA538", Offset = "0x1AEA538", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityDocument), Member = "GetRootElement", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityDocument), Member = "GetElement", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Parser), Member = "GetTopElement", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityDocument), Member = "GetString", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "AddChild", MemberParameters = new object[] { typeof(SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSyntaxException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal SecurityElement InternalGetElement(ref int position, bool bCreate)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000B96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal byte[] m_data;
	}
}
