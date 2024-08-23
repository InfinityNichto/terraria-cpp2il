using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002BD RID: 701
	[global::Cpp2ILInjected.Token(Token = "0x20003BB")]
	public static class SyntaxCheck
	{
		// Token: 0x0600170E RID: 5902 RVA: 0x00006F32 File Offset: 0x00005132
		[global::Cpp2ILInjected.Token(Token = "0x600196F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5DDDC", Offset = "0x1E5DDDC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool CheckMachineName(string value)
		{
			throw null;
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00006F35 File Offset: 0x00005135
		[global::Cpp2ILInjected.Token(Token = "0x6001970")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5DE68", Offset = "0x1E5DE68", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool CheckPath(string value)
		{
			throw null;
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00006F38 File Offset: 0x00005138
		[global::Cpp2ILInjected.Token(Token = "0x6001971")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5DF04", Offset = "0x1E5DF04", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "IsPathRooted", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool CheckRootedPath(string value)
		{
			throw null;
		}
	}
}
