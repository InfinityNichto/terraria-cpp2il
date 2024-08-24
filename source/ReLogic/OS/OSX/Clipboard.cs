using System;
using System.Diagnostics;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.OS.Base;

namespace ReLogic.OS.OSX
{
	// Token: 0x02000728 RID: 1832
	[global::Cpp2ILInjected.Token(Token = "0x2000B27")]
	internal class Clipboard : Clipboard
	{
		// Token: 0x060046A6 RID: 18086 RVA: 0x0002EA30 File Offset: 0x0002CC30
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

		// Token: 0x060046A7 RID: 18087 RVA: 0x0002EA33 File Offset: 0x0002CC33
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

		// Token: 0x060046A8 RID: 18088 RVA: 0x0002EA36 File Offset: 0x0002CC36
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
