using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.GameContent.Personalities;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000567")]
public class ShopHelper
{
	[Cpp2IlInjected.Token(Token = "0x400693A")]
	public const float LowestPossiblePriceMultiplier = 0.75f;

	[Cpp2IlInjected.Token(Token = "0x400693B")]
	public const float MaxHappinessAchievementPriceMultiplier = 0.82f;

	[Cpp2IlInjected.Token(Token = "0x400693C")]
	public const float HighestPossiblePriceMultiplier = 1.5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400693D")]
	private string _currentHappiness;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400693E")]
	private float _currentPriceAdjustment;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400693F")]
	private NPC _currentNPCBeingTalkedTo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006940")]
	private Player _currentPlayerTalking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006941")]
	private PersonalityDatabase _database;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006942")]
	private AShoppingBiome[] _dangerousBiomes;

	[Cpp2IlInjected.Token(Token = "0x4006943")]
	private const float likeValue = 0.94f;

	[Cpp2IlInjected.Token(Token = "0x4006944")]
	private const float dislikeValue = 1.06f;

	[Cpp2IlInjected.Token(Token = "0x4006945")]
	private const float loveValue = 0.88f;

	[Cpp2IlInjected.Token(Token = "0x4006946")]
	private const float hateValue = 1.12f;

	[Cpp2IlInjected.Token(Token = "0x6003A73")]
	[Cpp2IlInjected.Address(RVA = "0x110F9EC", Offset = "0x110F9EC", VA = "0x110F9EC")]
	public ShopHelper()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A74")]
	[Cpp2IlInjected.Address(RVA = "0x110FBA0", Offset = "0x110FBA0", VA = "0x110FBA0")]
	public ShoppingSettings GetShoppingSettings(Player player, NPC npc)
	{
		return default(ShoppingSettings);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A75")]
	[Cpp2IlInjected.Address(RVA = "0x11101C0", Offset = "0x11101C0", VA = "0x11101C0")]
	private float GetSkeletonMerchantPrices(NPC npc)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A76")]
	[Cpp2IlInjected.Address(RVA = "0x11103E8", Offset = "0x11103E8", VA = "0x11103E8")]
	private float GetTravelingMerchantPrices(NPC npc)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A77")]
	[Cpp2IlInjected.Address(RVA = "0x110FC20", Offset = "0x110FC20", VA = "0x110FC20")]
	private void ProcessMood(Player player, NPC npc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A78")]
	[Cpp2IlInjected.Address(RVA = "0x1110D3C", Offset = "0x1110D3C", VA = "0x1110D3C")]
	private float LimitAndRoundMultiplier(float priceAdjustment)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A79")]
	[Cpp2IlInjected.Address(RVA = "0x1110E7C", Offset = "0x1110E7C", VA = "0x1110E7C")]
	private static string BiomeNameByKey(string biomeNameKey)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A7A")]
	[Cpp2IlInjected.Address(RVA = "0x1110C08", Offset = "0x1110C08", VA = "0x1110C08")]
	private void AddHappinessReportText(string textKeyInCategory, [Optional] object substitutes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A7B")]
	[Cpp2IlInjected.Address(RVA = "0x1110EE4", Offset = "0x1110EE4", VA = "0x1110EE4")]
	public void LikeBiome(string nameKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A7C")]
	[Cpp2IlInjected.Address(RVA = "0x1110F9C", Offset = "0x1110F9C", VA = "0x1110F9C")]
	public void LoveBiome(string nameKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A7D")]
	[Cpp2IlInjected.Address(RVA = "0x1111054", Offset = "0x1111054", VA = "0x1111054")]
	public void DislikeBiome(string nameKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A7E")]
	[Cpp2IlInjected.Address(RVA = "0x111110C", Offset = "0x111110C", VA = "0x111110C")]
	public void HateBiome(string nameKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A7F")]
	[Cpp2IlInjected.Address(RVA = "0x11111C4", Offset = "0x11111C4", VA = "0x11111C4")]
	public void LikeNPC(int npcType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A80")]
	[Cpp2IlInjected.Address(RVA = "0x11112AC", Offset = "0x11112AC", VA = "0x11112AC")]
	public void LoveNPCByTypeName(int npcType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A81")]
	[Cpp2IlInjected.Address(RVA = "0x11113EC", Offset = "0x11113EC", VA = "0x11113EC")]
	public void LikePrincess()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A82")]
	[Cpp2IlInjected.Address(RVA = "0x11114D0", Offset = "0x11114D0", VA = "0x11114D0")]
	public void LoveNPC(int npcType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A83")]
	[Cpp2IlInjected.Address(RVA = "0x11115B8", Offset = "0x11115B8", VA = "0x11115B8")]
	public void DislikeNPC(int npcType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A84")]
	[Cpp2IlInjected.Address(RVA = "0x11116A0", Offset = "0x11116A0", VA = "0x11116A0")]
	public void HateNPC(int npcType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A85")]
	[Cpp2IlInjected.Address(RVA = "0x111086C", Offset = "0x111086C", VA = "0x111086C")]
	private List<NPC> GetNearbyResidentNPCs(NPC npc, out int npcsWithinHouse, out int npcsWithinVillage)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A86")]
	[Cpp2IlInjected.Address(RVA = "0x1110584", Offset = "0x1110584", VA = "0x1110584")]
	private bool RuinMoodIfHomeless(NPC npc)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A87")]
	[Cpp2IlInjected.Address(RVA = "0x1110608", Offset = "0x1110608", VA = "0x1110608")]
	private bool IsFarFromHome(NPC npc)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A88")]
	[Cpp2IlInjected.Address(RVA = "0x111076C", Offset = "0x111076C", VA = "0x111076C")]
	private bool IsPlayerInEvilBiomes(Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A89")]
	[Cpp2IlInjected.Address(RVA = "0x1110558", Offset = "0x1110558", VA = "0x1110558")]
	private bool IsNotReallyTownNPC(NPC npc)
	{
		return default(bool);
	}
}
