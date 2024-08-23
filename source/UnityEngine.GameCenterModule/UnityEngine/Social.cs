using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.SocialPlatforms;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	public static class Social
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public static ISocialPlatform Active
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000001")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9283C", Offset = "0x1F9283C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public static ILocalUser localUser
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000002")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F928A8", Offset = "0x1F928A8", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "iOS_UserManager", Member = "UpdateUser", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "iOS_UserManager", Member = "AttemptSignIn", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActivePlatform), Member = "get_Instance", ReturnType = typeof(ISocialPlatform))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}
	}
}
