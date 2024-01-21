using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements;

[Cpp2IlInjected.Token(Token = "0x2000659")]
public class ProgressionEventCondition : AchievementCondition
{
	[Cpp2IlInjected.Token(Token = "0x4006CBA")]
	private const string Identifier = "PROGRESSION_EVENT";

	[Cpp2IlInjected.Token(Token = "0x4006CBB")]
	private static Dictionary<int, List<ProgressionEventCondition>> _listeners;

	[Cpp2IlInjected.Token(Token = "0x4006CBC")]
	private static bool _isListenerHooked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CBD")]
	private int[] _eventIDs;

	[Cpp2IlInjected.Token(Token = "0x6003FB3")]
	[Cpp2IlInjected.Address(RVA = "0xFABFDC", Offset = "0xFABFDC", VA = "0xFABFDC")]
	private ProgressionEventCondition(int eventID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FB4")]
	[Cpp2IlInjected.Address(RVA = "0xFAC340", Offset = "0xFAC340", VA = "0xFAC340")]
	private ProgressionEventCondition(int[] eventIDs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FB5")]
	[Cpp2IlInjected.Address(RVA = "0xFAC414", Offset = "0xFAC414", VA = "0xFAC414", Slot = "5")]
	public override void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FB6")]
	[Cpp2IlInjected.Address(RVA = "0xFAC0C8", Offset = "0xFAC0C8", VA = "0xFAC0C8")]
	private static void ListenForPickup(ProgressionEventCondition condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FB7")]
	[Cpp2IlInjected.Address(RVA = "0xFAC4F0", Offset = "0xFAC4F0", VA = "0xFAC4F0")]
	private static void ProgressionEventListener(int eventID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FB8")]
	[Cpp2IlInjected.Address(RVA = "0xFAC6A0", Offset = "0xFAC6A0", VA = "0xFAC6A0")]
	public static ProgressionEventCondition Create(params int[] eventIDs)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003FB9")]
	[Cpp2IlInjected.Address(RVA = "0xFAC708", Offset = "0xFAC708", VA = "0xFAC708")]
	public static ProgressionEventCondition Create(int eventID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003FBA")]
	[Cpp2IlInjected.Address(RVA = "0xFAC770", Offset = "0xFAC770", VA = "0xFAC770")]
	public static ProgressionEventCondition[] CreateMany(params int[] eventIDs)
	{
		return null;
	}
}
