using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002E4 RID: 740
	[global::Cpp2ILInjected.Token(Token = "0x20003E4")]
	internal static class IntSecurity
	{
		// Token: 0x060017E9 RID: 6121 RVA: 0x0000715D File Offset: 0x0000535D
		[global::Cpp2ILInjected.Token(Token = "0x6001A52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6708C", Offset = "0x1E6708C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string UnsafeGetFullPath(string fileName)
		{
			throw null;
		}
	}
}
