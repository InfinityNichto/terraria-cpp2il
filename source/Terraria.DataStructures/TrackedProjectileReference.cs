using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000481")]
public struct TrackedProjectileReference
{
	[Cpp2IlInjected.Token(Token = "0x17000639")]
	public int ProjectileLocalIndex
	{
		[Cpp2IlInjected.Token(Token = "0x60032A4")]
		[Cpp2IlInjected.Address(RVA = "0x39DC7C", Offset = "0x39DC7C", VA = "0x39DC7C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60032A5")]
		[Cpp2IlInjected.Address(RVA = "0x39DC84", Offset = "0x39DC84", VA = "0x39DC84")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700063A")]
	public int ProjectileOwnerIndex
	{
		[Cpp2IlInjected.Token(Token = "0x60032A6")]
		[Cpp2IlInjected.Address(RVA = "0x39DC8C", Offset = "0x39DC8C", VA = "0x39DC8C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60032A7")]
		[Cpp2IlInjected.Address(RVA = "0x39DC94", Offset = "0x39DC94", VA = "0x39DC94")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700063B")]
	public int ProjectileIdentity
	{
		[Cpp2IlInjected.Token(Token = "0x60032A8")]
		[Cpp2IlInjected.Address(RVA = "0x39DC9C", Offset = "0x39DC9C", VA = "0x39DC9C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60032A9")]
		[Cpp2IlInjected.Address(RVA = "0x39DCA4", Offset = "0x39DCA4", VA = "0x39DCA4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700063C")]
	public int ProjectileType
	{
		[Cpp2IlInjected.Token(Token = "0x60032AA")]
		[Cpp2IlInjected.Address(RVA = "0x39DCAC", Offset = "0x39DCAC", VA = "0x39DCAC")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60032AB")]
		[Cpp2IlInjected.Address(RVA = "0x39DCB4", Offset = "0x39DCB4", VA = "0x39DCB4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700063D")]
	public bool IsTrackingSomething
	{
		[Cpp2IlInjected.Token(Token = "0x60032AC")]
		[Cpp2IlInjected.Address(RVA = "0x39DCBC", Offset = "0x39DCBC", VA = "0x39DCBC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60032AD")]
		[Cpp2IlInjected.Address(RVA = "0x39DCC4", Offset = "0x39DCC4", VA = "0x39DCC4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60032AE")]
	[Cpp2IlInjected.Address(RVA = "0x39DCCC", Offset = "0x39DCCC", VA = "0x39DCCC")]
	public void Set(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032AF")]
	[Cpp2IlInjected.Address(RVA = "0x39DCF8", Offset = "0x39DCF8", VA = "0x39DCF8")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032B0")]
	[Cpp2IlInjected.Address(RVA = "0x39DD18", Offset = "0x39DD18", VA = "0x39DD18")]
	public void Write(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032B1")]
	[Cpp2IlInjected.Address(RVA = "0x39DD20", Offset = "0x39DD20", VA = "0x39DD20")]
	public bool IsTracking(Projectile proj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60032B2")]
	[Cpp2IlInjected.Address(RVA = "0x39DD38", Offset = "0x39DD38", VA = "0x39DD38")]
	public void TryReading(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032B3")]
	[Cpp2IlInjected.Address(RVA = "0x39DD40", Offset = "0x39DD40", VA = "0x39DD40")]
	private Projectile FindMatchingProjectile(int expectedOwner, int expectedIdentity, int expectedType)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60032B4")]
	[Cpp2IlInjected.Address(RVA = "0x39DD58", Offset = "0x39DD58", VA = "0x39DD58", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60032B5")]
	[Cpp2IlInjected.Address(RVA = "0x39DD60", Offset = "0x39DD60", VA = "0x39DD60")]
	public bool Equals(TrackedProjectileReference other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60032B6")]
	[Cpp2IlInjected.Address(RVA = "0x39DDAC", Offset = "0x39DDAC", VA = "0x39DDAC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60032B7")]
	[Cpp2IlInjected.Address(RVA = "0x1231F20", Offset = "0x1231F20", VA = "0x1231F20")]
	public static bool operator ==(TrackedProjectileReference c1, TrackedProjectileReference c2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60032B8")]
	[Cpp2IlInjected.Address(RVA = "0x1231F64", Offset = "0x1231F64", VA = "0x1231F64")]
	public static bool operator !=(TrackedProjectileReference c1, TrackedProjectileReference c2)
	{
		return default(bool);
	}
}
