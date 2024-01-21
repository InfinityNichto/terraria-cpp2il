using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000562")]
public struct PlayerSleepingHelper
{
	[Cpp2IlInjected.Token(Token = "0x400692E")]
	public const int BedSleepingMaxDistance = 96;

	[Cpp2IlInjected.Token(Token = "0x400692F")]
	public const int TimeToFullyFallAsleep = 120;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006930")]
	public bool isSleeping;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006931")]
	public int sleepingIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006932")]
	public int timeSleeping;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006933")]
	public Vector2 visualOffsetOfBedBase;

	[Cpp2IlInjected.Token(Token = "0x17000720")]
	public bool FullyFallenAsleep
	{
		[Cpp2IlInjected.Token(Token = "0x6003A58")]
		[Cpp2IlInjected.Address(RVA = "0x39D0E8", Offset = "0x39D0E8", VA = "0x39D0E8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003A59")]
	[Cpp2IlInjected.Address(RVA = "0x39D10C", Offset = "0x39D10C", VA = "0x39D10C")]
	public void GetSleepingOffsetInfo(Player player, out Vector2 posOffset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A5A")]
	[Cpp2IlInjected.Address(RVA = "0x39D114", Offset = "0x39D114", VA = "0x39D114")]
	private bool DoesPlayerHaveReasonToActUpInBed(Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A5B")]
	[Cpp2IlInjected.Address(RVA = "0x39D118", Offset = "0x39D118", VA = "0x39D118")]
	public void SetIsSleepingAndAdjustPlayerRotation(Player player, bool state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A5C")]
	[Cpp2IlInjected.Address(RVA = "0x39D178", Offset = "0x39D178", VA = "0x39D178")]
	public void UpdateState(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A5D")]
	[Cpp2IlInjected.Address(RVA = "0x39D180", Offset = "0x39D180", VA = "0x39D180")]
	public void StopSleeping(Player player, bool multiplayerBroadcast = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A5E")]
	[Cpp2IlInjected.Address(RVA = "0x39D188", Offset = "0x39D188", VA = "0x39D188")]
	public void StartSleeping(Player player, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A5F")]
	[Cpp2IlInjected.Address(RVA = "0x119B000", Offset = "0x119B000", VA = "0x119B000")]
	public static bool GetSleepingTargetInfo(int x, int y, out int targetDirection, out Vector2 anchorPosition, out Vector2 visualoffset)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A60")]
	[Cpp2IlInjected.Address(RVA = "0x119B854", Offset = "0x119B854", VA = "0x119B854")]
	private static Vector2 SetOffsetbyBed(int bedStyle)
	{
		return default(Vector2);
	}
}
