using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200042B")]
public class DroneCameraTracker
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40062D7")]
	private Projectile _trackedProjectile;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40062D8")]
	private int _lastTrackedType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40062D9")]
	private bool _inUse;

	[Cpp2IlInjected.Token(Token = "0x6003107")]
	[Cpp2IlInjected.Address(RVA = "0x1013478", Offset = "0x1013478", VA = "0x1013478")]
	public void Track(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003108")]
	[Cpp2IlInjected.Address(RVA = "0x1013488", Offset = "0x1013488", VA = "0x1013488")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003109")]
	[Cpp2IlInjected.Address(RVA = "0x1013494", Offset = "0x1013494", VA = "0x1013494")]
	public void WorldClear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600310A")]
	[Cpp2IlInjected.Address(RVA = "0x10134A8", Offset = "0x10134A8", VA = "0x10134A8")]
	private void ValidateTrackedProjectile()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600310B")]
	[Cpp2IlInjected.Address(RVA = "0x1013590", Offset = "0x1013590", VA = "0x1013590")]
	public bool IsInUse()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600310C")]
	[Cpp2IlInjected.Address(RVA = "0x1013598", Offset = "0x1013598", VA = "0x1013598")]
	public bool TryTracking(out Vector2 cameraPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600310D")]
	[Cpp2IlInjected.Address(RVA = "0x10135EC", Offset = "0x10135EC", VA = "0x10135EC")]
	public DroneCameraTracker()
	{
	}
}
