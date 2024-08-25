using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.OS.Base
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B2D")]
	internal abstract class Clipboard : IClipboard
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008FA")]
		public string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005372")]
			[global::Cpp2ILInjected.Address(RVA = "0x944574", Offset = "0x944574", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6005373")]
			[global::Cpp2ILInjected.Address(RVA = "0x94469C", Offset = "0x94469C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008FB")]
		public string MultiLineValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005374")]
			[global::Cpp2ILInjected.Address(RVA = "0x9446A8", Offset = "0x9446A8", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipboard), Member = "SanitizeClipboardText", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005375")]
		[global::Cpp2ILInjected.Address(RVA = "0x944590", Offset = "0x944590", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Clipboard), Member = "get_MultiLineValue", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static string SanitizeClipboardText(string clipboardText, bool allowNewLine)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005376")]
		protected abstract string GetClipboard();

		[global::Cpp2ILInjected.Token(Token = "0x6005377")]
		protected abstract void SetClipboard(string text);

		[global::Cpp2ILInjected.Token(Token = "0x6005378")]
		[global::Cpp2ILInjected.Address(RVA = "0x943B14", Offset = "0x943B14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected Clipboard()
		{
			throw null;
		}
	}
}
