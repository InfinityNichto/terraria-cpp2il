using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200056B")]
public class TeleportPylonsSystem : IOnPlayerJoining
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006955")]
	private List<TeleportPylonInfo> _pylons;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006956")]
	private List<TeleportPylonInfo> _pylonsOld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006957")]
	private int _cooldownForUpdatingPylonsList;

	[Cpp2IlInjected.Token(Token = "0x4006958")]
	private const int CooldownTimePerPylonsListUpdate = int.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006959")]
	private SceneMetrics _sceneMetrics;

	[Cpp2IlInjected.Token(Token = "0x17000723")]
	public List<TeleportPylonInfo> Pylons
	{
		[Cpp2IlInjected.Token(Token = "0x6003AB9")]
		[Cpp2IlInjected.Address(RVA = "0x1277274", Offset = "0x1277274", VA = "0x1277274")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003ABA")]
	[Cpp2IlInjected.Address(RVA = "0x127727C", Offset = "0x127727C", VA = "0x127727C")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003ABB")]
	[Cpp2IlInjected.Address(RVA = "0x1277BC0", Offset = "0x1277BC0", VA = "0x1277BC0")]
	public bool HasPylonOfType(TeleportPylonType pylonType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003ABC")]
	[Cpp2IlInjected.Address(RVA = "0x1277C98", Offset = "0x1277C98", VA = "0x1277C98")]
	public bool HasAnyPylon()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003ABD")]
	[Cpp2IlInjected.Address(RVA = "0x1277CF0", Offset = "0x1277CF0", VA = "0x1277CF0")]
	public void RequestImmediateUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003ABE")]
	[Cpp2IlInjected.Address(RVA = "0x1277324", Offset = "0x1277324", VA = "0x1277324")]
	private void UpdatePylonsListAndBroadcastChanges()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003ABF")]
	[Cpp2IlInjected.Address(RVA = "0x1277DA4", Offset = "0x1277DA4", VA = "0x1277DA4")]
	public void AddForClient(TeleportPylonInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AC0")]
	[Cpp2IlInjected.Address(RVA = "0x1277E40", Offset = "0x1277E40", VA = "0x1277E40")]
	public void RemoveForClient(TeleportPylonInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AC1")]
	[Cpp2IlInjected.Address(RVA = "0x1277F20", Offset = "0x1277F20", VA = "0x1277F20")]
	public void HandleTeleportRequest(TeleportPylonInfo info, int playerIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AC2")]
	[Cpp2IlInjected.Address(RVA = "0x12787AC", Offset = "0x12787AC", VA = "0x12787AC")]
	public static bool IsPlayerNearAPylon(Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AC3")]
	[Cpp2IlInjected.Address(RVA = "0x1278AA8", Offset = "0x1278AA8", VA = "0x1278AA8")]
	private bool DoesPylonHaveEnoughNPCsAroundIt(TeleportPylonInfo info, int necessaryNPCCount)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AC4")]
	[Cpp2IlInjected.Address(RVA = "0x1279144", Offset = "0x1279144", VA = "0x1279144")]
	public static bool DoesPositionHaveEnoughNPCs(int necessaryNPCCount, Point16 centerPoint)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AC5")]
	[Cpp2IlInjected.Address(RVA = "0x12793A0", Offset = "0x12793A0", VA = "0x12793A0")]
	public void RequestTeleportation(TeleportPylonInfo info, Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AC6")]
	[Cpp2IlInjected.Address(RVA = "0x1278AC0", Offset = "0x1278AC0", VA = "0x1278AC0")]
	private bool DoesPylonAcceptTeleportation(TeleportPylonInfo info, Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AC7")]
	[Cpp2IlInjected.Address(RVA = "0x1278A90", Offset = "0x1278A90", VA = "0x1278A90")]
	private int HowManyNPCsDoesPylonNeed(TeleportPylonInfo info, Player player)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AC8")]
	[Cpp2IlInjected.Address(RVA = "0x1279450", Offset = "0x1279450", VA = "0x1279450")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AC9")]
	[Cpp2IlInjected.Address(RVA = "0x12794B4", Offset = "0x12794B4", VA = "0x12794B4", Slot = "4")]
	public void OnPlayerJoining(int playerIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003ACA")]
	[Cpp2IlInjected.Address(RVA = "0x127965C", Offset = "0x127965C", VA = "0x127965C")]
	public static void SpawnInWorldDust(int tileStyle, Rectangle dustBox)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003ACB")]
	[Cpp2IlInjected.Address(RVA = "0x12798C0", Offset = "0x12798C0", VA = "0x12798C0")]
	public TeleportPylonsSystem()
	{
	}
}
