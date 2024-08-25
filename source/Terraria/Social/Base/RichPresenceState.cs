using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Discord;

namespace Terraria.Social.Base
{
	[global::Cpp2ILInjected.Token(Token = "0x200052E")]
	public class RichPresenceState : IEquatable<RichPresenceState>
	{
		[global::Cpp2ILInjected.Token(Token = "0x60031EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A6C4", Offset = "0x132A6C4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(RichPresenceState other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A608", Offset = "0x132A608", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RichPresenceSocialModule), Member = "UpdatePresence", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static RichPresenceState GetCurrentState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60031F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x132ADE8", Offset = "0x132ADE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public RichPresenceState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003B5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public RichPresenceState.GameModeState GameMode;

		[global::Cpp2ILInjected.Token(Token = "0x200052F")]
		public enum GameModeState
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003B61")]
			InMainMenu,
			[global::Cpp2ILInjected.Token(Token = "0x4003B62")]
			CreatingPlayer,
			[global::Cpp2ILInjected.Token(Token = "0x4003B63")]
			CreatingWorld,
			[global::Cpp2ILInjected.Token(Token = "0x4003B64")]
			PlayingSingle,
			[global::Cpp2ILInjected.Token(Token = "0x4003B65")]
			PlayingMulti
		}
	}
}
