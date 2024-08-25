using System;
using System.Diagnostics;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.OS.Base;

namespace ReLogic.OS.OSX
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B27")]
	internal class Clipboard : Clipboard
	{
		[global::Cpp2ILInjected.Token(Token = "0x600535B")]
		[global::Cpp2ILInjected.Address(RVA = "0x943558", Offset = "0x943558", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProcessStartInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "set_StartInfo", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "get_StandardOutput", ReturnType = typeof(StreamReader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "WaitForExit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		protected override string GetClipboard()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600535C")]
		[global::Cpp2ILInjected.Address(RVA = "0x943834", Offset = "0x943834", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProcessStartInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "set_StartInfo", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "get_StandardInput", ReturnType = typeof(StreamWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "WaitForExit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		protected override void SetClipboard(string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600535D")]
		[global::Cpp2ILInjected.Address(RVA = "0x943B0C", Offset = "0x943B0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Clipboard()
		{
			throw null;
		}
	}
}
