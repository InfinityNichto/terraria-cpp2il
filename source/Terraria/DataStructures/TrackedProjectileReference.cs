using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000681")]
	public struct TrackedProjectileReference
	{
		[global::Cpp2ILInjected.Token(Token = "0x170006B9")]
		public int ProjectileLocalIndex
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003791")]
			[global::Cpp2ILInjected.Address(RVA = "0x142078C", Offset = "0x142078C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003792")]
			[global::Cpp2ILInjected.Address(RVA = "0x1420794", Offset = "0x1420794", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006BA")]
		public int ProjectileOwnerIndex
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003793")]
			[global::Cpp2ILInjected.Address(RVA = "0x142079C", Offset = "0x142079C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003794")]
			[global::Cpp2ILInjected.Address(RVA = "0x14207A4", Offset = "0x14207A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006BB")]
		public int ProjectileIdentity
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003795")]
			[global::Cpp2ILInjected.Address(RVA = "0x14207AC", Offset = "0x14207AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003796")]
			[global::Cpp2ILInjected.Address(RVA = "0x14207B4", Offset = "0x14207B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006BC")]
		public int ProjectileType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003797")]
			[global::Cpp2ILInjected.Address(RVA = "0x14207BC", Offset = "0x14207BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003798")]
			[global::Cpp2ILInjected.Address(RVA = "0x14207C4", Offset = "0x14207C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006BD")]
		public bool IsTrackingSomething
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003799")]
			[global::Cpp2ILInjected.Address(RVA = "0x14207CC", Offset = "0x14207CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600379A")]
			[global::Cpp2ILInjected.Address(RVA = "0x14207D4", Offset = "0x14207D4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600379B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14207E0", Offset = "0x14207E0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryInteractingWithVoidLens", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryInteractingWithMoneyTrough", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryInteractingWithMoneyTrough2", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public void Set(Projectile proj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600379C")]
		[global::Cpp2ILInjected.Address(RVA = "0x142080C", Offset = "0x142080C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HandleBeingInChestRange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsUse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600379D")]
		[global::Cpp2ILInjected.Address(RVA = "0x142081C", Offset = "0x142081C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Write(BinaryWriter writer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600379E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420894", Offset = "0x1420894", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Chester_IsAnyPlayerTrackingThisProjectile", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool IsTracking(Projectile proj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600379F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14208A8", Offset = "0x14208A8", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackedProjectileReference), Member = "FindMatchingProjectile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Projectile))]
		public void TryReading(BinaryReader reader)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420968", Offset = "0x1420968", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackedProjectileReference), Member = "TryReading", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private Projectile FindMatchingProjectile(int expectedOwner, int expectedIdentity, int expectedType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420A1C", Offset = "0x1420A1C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420AC4", Offset = "0x1420AC4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(TrackedProjectileReference other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420B10", Offset = "0x1420B10", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420B38", Offset = "0x1420B38", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(TrackedProjectileReference c1, TrackedProjectileReference c2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420B84", Offset = "0x1420B84", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TrySyncingMyPlayer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static bool operator !=(TrackedProjectileReference c1, TrackedProjectileReference c2)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007895")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int <ProjectileLocalIndex>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007896")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int <ProjectileOwnerIndex>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007897")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int <ProjectileIdentity>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007898")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private int <ProjectileType>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007899")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <IsTrackingSomething>k__BackingField;
	}
}
