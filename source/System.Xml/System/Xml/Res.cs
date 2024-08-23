using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000089 RID: 137
	[global::Cpp2ILInjected.Token(Token = "0x20000B3")]
	internal static class Res
	{
		// Token: 0x06000734 RID: 1844 RVA: 0x0000443C File Offset: 0x0000263C
		[global::Cpp2ILInjected.Token(Token = "0x60007C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA8420", Offset = "0x1DA8420", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 81)]
		public static string GetString(string name)
		{
			throw null;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0000443F File Offset: 0x0000263F
		[global::Cpp2ILInjected.Token(Token = "0x60007C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA9508", Offset = "0x1DA9508", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 51)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		public static string GetString(string name, params object[] args)
		{
			throw null;
		}
	}
}
