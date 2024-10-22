﻿using System;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Util
{
	[global::Cpp2ILInjected.Token(Token = "0x200029E")]
	internal sealed class Parser
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001722")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEE818", Offset = "0x1AEE818", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSA), Member = "FromXmlString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "FromXmlString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SecurityElement))]
		internal SecurityElement GetTopElement()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001723")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEE838", Offset = "0x1AEE838", Length = "0x730")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TokenizerStream), Member = "TagLastToken", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void GetRequiredSizes(TokenizerStream stream, ref int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001724")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEF064", Offset = "0x1AEF064", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new object[]
		{
			typeof(TokenizerStream),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TokenizerStream), Member = "GoToPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tokenizer), Member = "ChangeFormat", MemberParameters = new object[] { typeof(global::System.Text.Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private int DetermineFormat(TokenizerStream stream)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001725")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEFCB4", Offset = "0x1AEFCB4", Length = "0x448")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Parser), Member = ".ctor", MemberParameters = new object[] { typeof(Tokenizer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TokenizerStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new object[]
		{
			typeof(TokenizerStream),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new object[] { typeof(TokenizerStream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TokenizerStream), Member = "GoToPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Parser), Member = "GetRequiredSizes", MemberParameters = new object[]
		{
			typeof(TokenizerStream),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityDocument), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityDocument), Member = "AppendString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityDocument), Member = "GuaranteeSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityDocument), Member = "AddString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSyntaxException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void ParseContents()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001726")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0200", Offset = "0x1AF0200", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Parser), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tokenizer), Member = "Recycle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private Parser(Tokenizer t)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001727")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF029C", Offset = "0x1AF029C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSA), Member = "FromXmlString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "FromXmlString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tokenizer), Member = "BasicInitialization", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Parser), Member = ".ctor", MemberParameters = new object[] { typeof(Tokenizer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Parser(string input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000BB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SecurityDocument _doc;

		[global::Cpp2ILInjected.Token(Token = "0x4000BB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Tokenizer _t;
	}
}
