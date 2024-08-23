using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security
{
	// Token: 0x0200020A RID: 522
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200029D")]
	public static class SecurityManager
	{
		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x00018059 File Offset: 0x00016259
		[global::System.Obsolete("The security manager cannot be turned off on MS runtime")]
		[global::Cpp2ILInjected.Token(Token = "0x17000258")]
		public static bool SecurityEnabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001720")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AEA980", Offset = "0x1AEA980", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0001805C File Offset: 0x0001625C
		[global::Cpp2ILInjected.Token(Token = "0x6001721")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEE814", Offset = "0x1AEE814", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "GetFolderPath", MemberParameters = new object[]
		{
			typeof(global::System.Environment.SpecialFolder),
			typeof(global::System.Environment.SpecialFolderOption)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.FileMode),
			typeof(global::System.IO.FileAccess),
			typeof(global::System.IO.FileShare),
			typeof(int),
			typeof(bool),
			typeof(global::System.IO.FileOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "GetTempPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		internal static void EnsureElevatedPermissions()
		{
			throw null;
		}
	}
}
