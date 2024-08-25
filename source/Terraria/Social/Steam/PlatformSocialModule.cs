using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Base;

namespace Terraria.Social.Steam
{
	[global::Cpp2ILInjected.Token(Token = "0x2000512")]
	public class PlatformSocialModule : PlatformSocialModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003157")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304838", Offset = "0x1304838", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Initialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003158")]
		[global::Cpp2ILInjected.Address(RVA = "0x130483C", Offset = "0x130483C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Shutdown()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003159")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304840", Offset = "0x1304840", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformSocialModule), Member = ".ctor", ReturnType = typeof(void))]
		public PlatformSocialModule()
		{
			throw null;
		}
	}
}
