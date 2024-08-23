﻿using System;
using System.IO;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Win32
{
	// Token: 0x0200003D RID: 61
	[global::Cpp2ILInjected.Token(Token = "0x2000058")]
	internal static class Win32Native
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00014ACB File Offset: 0x00012CCB
		[global::Cpp2ILInjected.Token(Token = "0x6000211")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6648", Offset = "0x1AC6648", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.__Error), Member = "WinIOError", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static string GetMessage(int hr)
		{
			throw null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00014ACE File Offset: 0x00012CCE
		[global::Cpp2ILInjected.Token(Token = "0x6000212")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC66A4", Offset = "0x1AC66A4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.__Error), Member = "WinIOError", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int MakeHRFromErrorCode(int errorCode)
		{
			throw null;
		}
	}
}