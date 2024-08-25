using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Steam;

namespace Terraria.Social.Base
{
	[global::Cpp2ILInjected.Token(Token = "0x200052D")]
	public abstract class PlatformSocialModule : ISocialModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60031EB")]
		public abstract void Initialize();

		[global::Cpp2ILInjected.Token(Token = "0x60031EC")]
		public abstract void Shutdown();

		[global::Cpp2ILInjected.Token(Token = "0x60031ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x132ADE0", Offset = "0x132ADE0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlatformSocialModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected PlatformSocialModule()
		{
			throw null;
		}
	}
}
