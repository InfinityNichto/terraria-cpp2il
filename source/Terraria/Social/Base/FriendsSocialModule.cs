using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Base
{
	[global::Cpp2ILInjected.Token(Token = "0x200052A")]
	public abstract class FriendsSocialModule : ISocialModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60031D0")]
		public abstract string GetUsername();

		[global::Cpp2ILInjected.Token(Token = "0x60031D1")]
		public abstract void OpenJoinInterface();

		[global::Cpp2ILInjected.Token(Token = "0x60031D2")]
		public abstract void Initialize();

		[global::Cpp2ILInjected.Token(Token = "0x60031D3")]
		public abstract void Shutdown();

		[global::Cpp2ILInjected.Token(Token = "0x60031D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x132ADC8", Offset = "0x132ADC8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected FriendsSocialModule()
		{
			throw null;
		}
	}
}
