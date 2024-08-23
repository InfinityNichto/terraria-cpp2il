using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Graphics.Effects;
using Terraria.Localization;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000692 RID: 1682
	[global::Cpp2ILInjected.Token(Token = "0x2000A54")]
	public class CreditsRollEvent
	{
		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x0600421E RID: 16926 RVA: 0x0002DD10 File Offset: 0x0002BF10
		[global::Cpp2ILInjected.Token(Token = "0x1700089E")]
		public static bool IsEventOngoing
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004E16")]
			[global::Cpp2ILInjected.Address(RVA = "0x8D118C", Offset = "0x8D118C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "CanPlayCreditsRoll", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateAudio_DecideOnTOWMusic", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateAudio_DecideOnNewMusic", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x0002DD13 File Offset: 0x0002BF13
		[global::Cpp2ILInjected.Token(Token = "0x6004E17")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D11DC", Offset = "0x8D11DC", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "OnGameEventClearedForTheFirstTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void TryStartingCreditsRoll()
		{
			throw null;
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x0002DD16 File Offset: 0x0002BF16
		[global::Cpp2ILInjected.Token(Token = "0x6004E18")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D1384", Offset = "0x8D1384", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SyncConnectedPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void SendCreditsRollRemainingTimeToPlayer(int playerIndex)
		{
			throw null;
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x0002DD19 File Offset: 0x0002BF19
		[global::Cpp2ILInjected.Token(Token = "0x6004E19")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D1470", Offset = "0x8D1470", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void UpdateTime()
		{
			throw null;
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x0002DD1C File Offset: 0x0002BF1C
		[global::Cpp2ILInjected.Token(Token = "0x6004E1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D1510", Offset = "0x8D1510", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClearVisualPostProcessEffects", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void Reset()
		{
			throw null;
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x0002DD1F File Offset: 0x0002BF1F
		[global::Cpp2ILInjected.Token(Token = "0x6004E1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D1558", Offset = "0x8D1558", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void SetRemainingTimeDirect(int time)
		{
			throw null;
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x0002DD22 File Offset: 0x0002BF22
		[global::Cpp2ILInjected.Token(Token = "0x6004E1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8D15F0", Offset = "0x8D15F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CreditsRollEvent()
		{
			throw null;
		}

		// Token: 0x04006E02 RID: 28162
		[global::Cpp2ILInjected.Token(Token = "0x40086D4")]
		private const int MAX_TIME_FOR_CREDITS_ROLL_IN_FRAMES = 28800;

		// Token: 0x04006E03 RID: 28163
		[global::Cpp2ILInjected.Token(Token = "0x40086D5")]
		private static int _creditsRollRemainingTime;
	}
}
