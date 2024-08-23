using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200002C RID: 44
[global::Cpp2ILInjected.Token(Token = "0x200004A")]
public class XBOPlatformEvent
{
	// Token: 0x17000047 RID: 71
	// (get) Token: 0x0600010A RID: 266 RVA: 0x00021E96 File Offset: 0x00020096
	[global::Cpp2ILInjected.Token(Token = "0x1700006C")]
	public static string UserId
	{
		[global::Cpp2ILInjected.Token(Token = "0x600018C")]
		[global::Cpp2ILInjected.Address(RVA = "0x705F08", Offset = "0x705F08", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00021E99 File Offset: 0x00020099
	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x600018D")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F50", Offset = "0x705F50", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendAchievementProgress(string identifier, float progress)
	{
		throw null;
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00021E9C File Offset: 0x0002009C
	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x600018E")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F54", Offset = "0x705F54", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendGameProgress(float progress)
	{
		throw null;
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00021E9F File Offset: 0x0002009F
	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x600018F")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F58", Offset = "0x705F58", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendMedalsUpdated(int Medals)
	{
		throw null;
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00021EA2 File Offset: 0x000200A2
	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000190")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F5C", Offset = "0x705F5C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendRankedMatchesUpdated(int RankedMatches)
	{
		throw null;
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00021EA5 File Offset: 0x000200A5
	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000191")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F60", Offset = "0x705F60", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendRankedVicotriesUpdated(int RankedVictories)
	{
		throw null;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x00021EA8 File Offset: 0x000200A8
	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000192")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F64", Offset = "0x705F64", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendThreeStarVictoriesUpdated(int ThreeStarVictories)
	{
		throw null;
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00021EAB File Offset: 0x000200AB
	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000193")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F68", Offset = "0x705F68", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendUnitsDonatedUpdated(int UnitsDonated)
	{
		throw null;
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00021EAE File Offset: 0x000200AE
	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000194")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F6C", Offset = "0x705F6C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendUnitsUnlockedUpdated(int UnitsUnlocked)
	{
		throw null;
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00021EB1 File Offset: 0x000200B1
	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000195")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F70", Offset = "0x705F70", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendMultiplayerRoundStart(ref Guid sessionGUID, string correlationId)
	{
		throw null;
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00021EB4 File Offset: 0x000200B4
	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000196")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F74", Offset = "0x705F74", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendMultiplayerRoundEnd(ref Guid sessionGUID, string correlationId, float gameTime)
	{
		throw null;
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00021EB7 File Offset: 0x000200B7
	[global::Cpp2ILInjected.Token(Token = "0x6000197")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F78", Offset = "0x705F78", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public XBOPlatformEvent()
	{
		throw null;
	}
}
