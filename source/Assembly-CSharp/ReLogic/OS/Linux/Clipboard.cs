using System;
using System.Diagnostics;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.OS.Base;

namespace ReLogic.OS.Linux
{
	// Token: 0x0200072B RID: 1835
	[global::Cpp2ILInjected.Token(Token = "0x2000B2A")]
	internal class Clipboard : Clipboard
	{
		// Token: 0x060046B1 RID: 18097 RVA: 0x0002EA51 File Offset: 0x0002CC51
		[global::Cpp2ILInjected.Token(Token = "0x6005366")]
		[global::Cpp2ILInjected.Address(RVA = "0x943BEC", Offset = "0x943BEC", Length = "0x2DC")]
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

		// Token: 0x060046B2 RID: 18098 RVA: 0x0002EA54 File Offset: 0x0002CC54
		[global::Cpp2ILInjected.Token(Token = "0x6005367")]
		[global::Cpp2ILInjected.Address(RVA = "0x943EC8", Offset = "0x943EC8", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Clipboard), Member = "SetClipboard", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProcessStartInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "set_StartInfo", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "WaitForExit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void ClearClipboard()
		{
			throw null;
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x0002EA57 File Offset: 0x0002CC57
		[global::Cpp2ILInjected.Token(Token = "0x6005368")]
		[global::Cpp2ILInjected.Address(RVA = "0x944158", Offset = "0x944158", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipboard), Member = "ClearClipboard", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		protected override void SetClipboard(string text)
		{
			throw null;
		}

		// Token: 0x060046B4 RID: 18100 RVA: 0x0002EA5A File Offset: 0x0002CC5A
		[global::Cpp2ILInjected.Token(Token = "0x6005369")]
		[global::Cpp2ILInjected.Address(RVA = "0x944468", Offset = "0x944468", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Clipboard()
		{
			throw null;
		}
	}
}
