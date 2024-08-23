using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Discord;

namespace Terraria.Social.Base
{
	// Token: 0x02000393 RID: 915
	[global::Cpp2ILInjected.Token(Token = "0x200052E")]
	public class RichPresenceState : IEquatable<RichPresenceState>
	{
		// Token: 0x06002D95 RID: 11669 RVA: 0x0002A248 File Offset: 0x00028448
		[global::Cpp2ILInjected.Token(Token = "0x60031EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A6C4", Offset = "0x132A6C4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(RichPresenceState other)
		{
			throw null;
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x0002A24B File Offset: 0x0002844B
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

		// Token: 0x06002D97 RID: 11671 RVA: 0x0002A24E File Offset: 0x0002844E
		[global::Cpp2ILInjected.Token(Token = "0x60031F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x132ADE8", Offset = "0x132ADE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public RichPresenceState()
		{
			throw null;
		}

		// Token: 0x040031D4 RID: 12756
		[global::Cpp2ILInjected.Token(Token = "0x4003B5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public RichPresenceState.GameModeState GameMode;

		// Token: 0x020008EB RID: 2283
		[global::Cpp2ILInjected.Token(Token = "0x200052F")]
		public enum GameModeState
		{
			// Token: 0x0400812F RID: 33071
			[global::Cpp2ILInjected.Token(Token = "0x4003B61")]
			InMainMenu,
			// Token: 0x04008130 RID: 33072
			[global::Cpp2ILInjected.Token(Token = "0x4003B62")]
			CreatingPlayer,
			// Token: 0x04008131 RID: 33073
			[global::Cpp2ILInjected.Token(Token = "0x4003B63")]
			CreatingWorld,
			// Token: 0x04008132 RID: 33074
			[global::Cpp2ILInjected.Token(Token = "0x4003B64")]
			PlayingSingle,
			// Token: 0x04008133 RID: 33075
			[global::Cpp2ILInjected.Token(Token = "0x4003B65")]
			PlayingMulti
		}
	}
}
