using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200004A")]
public class XBOPlatformEvent
{
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

	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x600018D")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F50", Offset = "0x705F50", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendAchievementProgress(string identifier, float progress)
	{
		throw null;
	}

	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x600018E")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F54", Offset = "0x705F54", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendGameProgress(float progress)
	{
		throw null;
	}

	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x600018F")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F58", Offset = "0x705F58", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendMedalsUpdated(int Medals)
	{
		throw null;
	}

	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000190")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F5C", Offset = "0x705F5C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendRankedMatchesUpdated(int RankedMatches)
	{
		throw null;
	}

	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000191")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F60", Offset = "0x705F60", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendRankedVicotriesUpdated(int RankedVictories)
	{
		throw null;
	}

	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000192")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F64", Offset = "0x705F64", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendThreeStarVictoriesUpdated(int ThreeStarVictories)
	{
		throw null;
	}

	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000193")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F68", Offset = "0x705F68", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendUnitsDonatedUpdated(int UnitsDonated)
	{
		throw null;
	}

	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000194")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F6C", Offset = "0x705F6C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendUnitsUnlockedUpdated(int UnitsUnlocked)
	{
		throw null;
	}

	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000195")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F70", Offset = "0x705F70", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendMultiplayerRoundStart(ref Guid sessionGUID, string correlationId)
	{
		throw null;
	}

	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000196")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F74", Offset = "0x705F74", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SendMultiplayerRoundEnd(ref Guid sessionGUID, string correlationId, float gameTime)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000197")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F78", Offset = "0x705F78", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public XBOPlatformEvent()
	{
		throw null;
	}
}
