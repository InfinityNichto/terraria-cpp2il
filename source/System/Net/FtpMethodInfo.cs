using System;
using System.Globalization;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000150")]
	internal class FtpMethodInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000840")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF21EC", Offset = "0x1EF21EC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal FtpMethodInfo(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000841")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF2230", Offset = "0x1EF2230", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(CommandStream.PipelineEntry[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		internal bool HasFlag(FtpMethodFlags flags)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B7")]
		internal bool IsCommandOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000842")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2240", Offset = "0x1EF2240", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(CommandStream.PipelineEntry[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B8")]
		internal bool IsUpload
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000843")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2250", Offset = "0x1EF2250", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "IsFtpDataStreamWriteable", ReturnType = typeof(TriState))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B9")]
		internal bool IsDownload
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000844")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF225C", Offset = "0x1EF225C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "IsFtpDataStreamWriteable", ReturnType = typeof(TriState))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001BA")]
		internal bool ShouldParseForResponseUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000845")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF2268", Offset = "0x1EF2268", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
			{
				typeof(CommandStream.PipelineEntry),
				typeof(ResponseDescription),
				typeof(bool),
				typeof(ref Stream)
			}, ReturnType = typeof(CommandStream.PipelineInstruction))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000846")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF2274", Offset = "0x1EF2274", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "set_Method", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static FtpMethodInfo GetMethodInfo(string method)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000847")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF23B8", Offset = "0x1EF23B8", Length = "0x558")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
		static FtpMethodInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40006B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string Method;

		[global::Cpp2ILInjected.Token(Token = "0x40006B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal FtpOperation Operation;

		[global::Cpp2ILInjected.Token(Token = "0x40006BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal FtpMethodFlags Flags;

		[global::Cpp2ILInjected.Token(Token = "0x40006BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal string HttpCommand;

		[global::Cpp2ILInjected.Token(Token = "0x40006BC")]
		private static readonly FtpMethodInfo[] s_knownMethodInfo;
	}
}
