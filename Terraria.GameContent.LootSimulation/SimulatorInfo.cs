using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.LootSimulation;

[Cpp2IlInjected.Token(Token = "0x20005B8")]
public class SimulatorInfo
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B5D")]
	public Player player;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006B5E")]
	private double _originalDayTimeCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006B5F")]
	private bool _originalDayTimeFlag;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006B60")]
	private Vector2 _originalPlayerPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006B61")]
	public bool runningExpertMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006B62")]
	public LootSimulationItemCounter itemCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006B63")]
	public NPC npcVictim;

	[Cpp2IlInjected.Token(Token = "0x6003C66")]
	[Cpp2IlInjected.Address(RVA = "0x10564F0", Offset = "0x10564F0", VA = "0x10564F0")]
	public SimulatorInfo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C67")]
	[Cpp2IlInjected.Address(RVA = "0x1058218", Offset = "0x1058218", VA = "0x1058218")]
	public void ReturnToOriginalDaytime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C68")]
	[Cpp2IlInjected.Address(RVA = "0x1058434", Offset = "0x1058434", VA = "0x1058434")]
	public void AddItem(int itemId, int amount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C69")]
	[Cpp2IlInjected.Address(RVA = "0x105846C", Offset = "0x105846C", VA = "0x105846C")]
	public void ReturnToOriginalPlayerPosition()
	{
	}
}
