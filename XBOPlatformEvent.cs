using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200002B")]
public class XBOPlatformEvent
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static string UserId
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x14FD054", Offset = "0x14FD054", VA = "0x14FD054")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x14FD0AC", Offset = "0x14FD0AC", VA = "0x14FD0AC")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38CE44", Offset = "0x38CE44")]
	public static void SendAchievementProgress(string identifier, float progress)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x14FD0B0", Offset = "0x14FD0B0", VA = "0x14FD0B0")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38CE78", Offset = "0x38CE78")]
	public static void SendGameProgress(float progress)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x14FD0B4", Offset = "0x14FD0B4", VA = "0x14FD0B4")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38CEAC", Offset = "0x38CEAC")]
	public static void SendMedalsUpdated(int Medals)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x14FD0B8", Offset = "0x14FD0B8", VA = "0x14FD0B8")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38CEE0", Offset = "0x38CEE0")]
	public static void SendRankedMatchesUpdated(int RankedMatches)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x14FD0BC", Offset = "0x14FD0BC", VA = "0x14FD0BC")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38CF14", Offset = "0x38CF14")]
	public static void SendRankedVicotriesUpdated(int RankedVictories)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x14FD0C0", Offset = "0x14FD0C0", VA = "0x14FD0C0")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38CF48", Offset = "0x38CF48")]
	public static void SendThreeStarVictoriesUpdated(int ThreeStarVictories)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x14FD0C4", Offset = "0x14FD0C4", VA = "0x14FD0C4")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38CF7C", Offset = "0x38CF7C")]
	public static void SendUnitsDonatedUpdated(int UnitsDonated)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x14FD0C8", Offset = "0x14FD0C8", VA = "0x14FD0C8")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38CFB0", Offset = "0x38CFB0")]
	public static void SendUnitsUnlockedUpdated(int UnitsUnlocked)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x14FD0CC", Offset = "0x14FD0CC", VA = "0x14FD0CC")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38CFE4", Offset = "0x38CFE4")]
	public static void SendMultiplayerRoundStart(ref Guid sessionGUID, string correlationId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x14FD0D0", Offset = "0x14FD0D0", VA = "0x14FD0D0")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D018", Offset = "0x38D018")]
	public static void SendMultiplayerRoundEnd(ref Guid sessionGUID, string correlationId, float gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x14FD0D4", Offset = "0x14FD0D4", VA = "0x14FD0D4")]
	public XBOPlatformEvent()
	{
	}
}
