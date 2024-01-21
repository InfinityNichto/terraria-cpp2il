using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Golf;

[Cpp2IlInjected.Token(Token = "0x200067D")]
public class GolfBallTrackRecord
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006DA7")]
	private List<Vector2> _hitLocations;

	[Cpp2IlInjected.Token(Token = "0x600417A")]
	[Cpp2IlInjected.Address(RVA = "0xE6C170", Offset = "0xE6C170", VA = "0xE6C170")]
	public GolfBallTrackRecord()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600417B")]
	[Cpp2IlInjected.Address(RVA = "0xE6C1F4", Offset = "0xE6C1F4", VA = "0xE6C1F4")]
	public void RecordHit(Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600417C")]
	[Cpp2IlInjected.Address(RVA = "0xE6C260", Offset = "0xE6C260", VA = "0xE6C260")]
	public int GetAccumulatedScore()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600417D")]
	[Cpp2IlInjected.Address(RVA = "0xE6C2B8", Offset = "0xE6C2B8", VA = "0xE6C2B8")]
	private void GetTrackInfo(out double totalDistancePassed, out int hitsMade)
	{
	}
}
