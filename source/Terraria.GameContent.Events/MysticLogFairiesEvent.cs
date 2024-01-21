using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Events;

[Cpp2IlInjected.Token(Token = "0x2000696")]
public class MysticLogFairiesEvent
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006E05")]
	private bool _canSpawnFairies;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006E06")]
	private int _delayUntilNextAttempt;

	[Cpp2IlInjected.Token(Token = "0x4006E07")]
	private const int DELAY_BETWEEN_ATTEMPTS = 60;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006E08")]
	private List<Point> _stumpCoords;

	[Cpp2IlInjected.Token(Token = "0x6004263")]
	[Cpp2IlInjected.Address(RVA = "0xF606DC", Offset = "0xF606DC", VA = "0xF606DC")]
	public void WorldClear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004264")]
	[Cpp2IlInjected.Address(RVA = "0xF60744", Offset = "0xF60744", VA = "0xF60744")]
	public void StartWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004265")]
	[Cpp2IlInjected.Address(RVA = "0xF60B98", Offset = "0xF60B98", VA = "0xF60B98")]
	public void StartNight()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004266")]
	[Cpp2IlInjected.Address(RVA = "0xF60C30", Offset = "0xF60C30", VA = "0xF60C30")]
	public void UpdateTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004267")]
	[Cpp2IlInjected.Address(RVA = "0xF60D58", Offset = "0xF60D58", VA = "0xF60D58")]
	private bool IsAGoodTime()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004268")]
	[Cpp2IlInjected.Address(RVA = "0xF60E9C", Offset = "0xF60E9C", VA = "0xF60E9C")]
	private void TrySpawningFairies()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004269")]
	[Cpp2IlInjected.Address(RVA = "0xF6161C", Offset = "0xF6161C", VA = "0xF6161C")]
	public void FallenLogDestroyed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600426A")]
	[Cpp2IlInjected.Address(RVA = "0xF607CC", Offset = "0xF607CC", VA = "0xF607CC")]
	private void ScanWholeOverworldForLogs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600426B")]
	[Cpp2IlInjected.Address(RVA = "0xF616A4", Offset = "0xF616A4", VA = "0xF616A4")]
	private Point GetStumpTopLeft(Point stumpRandomPoint)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x600426C")]
	[Cpp2IlInjected.Address(RVA = "0xF61534", Offset = "0xF61534", VA = "0xF61534")]
	private int GetOneOverSpawnChance()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600426D")]
	[Cpp2IlInjected.Address(RVA = "0xF617A0", Offset = "0xF617A0", VA = "0xF617A0")]
	public MysticLogFairiesEvent()
	{
	}
}
