using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.SocialPlatforms.Impl;

namespace UnityEngine.SocialPlatforms
{
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	internal static class ActivePlatform
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		internal static ISocialPlatform Instance
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000008")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F92840", Offset = "0x1F92840", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Social), Member = "get_localUser", ReturnType = typeof(ILocalUser))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "Authenticate", MemberParameters = new object[] { typeof(Action<bool>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActivePlatform), Member = "SelectSocialPlatform", ReturnType = typeof(ISocialPlatform))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000009")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F93BA0", Offset = "0x1F93BA0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActivePlatform), Member = "get_Instance", ReturnType = typeof(ISocialPlatform))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Local), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static ISocialPlatform SelectSocialPlatform()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		private static ISocialPlatform _active;
	}
}
