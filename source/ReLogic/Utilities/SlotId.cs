using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;

namespace ReLogic.Utilities
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B08")]
	public struct SlotId
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008E0")]
		public bool IsValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x600528B")]
			[global::Cpp2ILInjected.Address(RVA = "0x93ED3C", Offset = "0x93ED3C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008E1")]
		internal bool IsActive
		{
			[global::Cpp2ILInjected.Token(Token = "0x600528C")]
			[global::Cpp2ILInjected.Address(RVA = "0x93ED50", Offset = "0x93ED50", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				"T"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "get_Item", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(SlotId),
				"T"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "Remove", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "Has", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "Has", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008E2")]
		internal uint Index
		{
			[global::Cpp2ILInjected.Token(Token = "0x600528D")]
			[global::Cpp2ILInjected.Address(RVA = "0x93ED70", Offset = "0x93ED70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "get_Item", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(SlotId),
				"T"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(SlotId))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "Remove", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "Has", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008E3")]
		internal uint Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x600528E")]
			[global::Cpp2ILInjected.Address(RVA = "0x93ED78", Offset = "0x93ED78", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600528F")]
		[global::Cpp2ILInjected.Address(RVA = "0x93ED84", Offset = "0x93ED84", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "Remove", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal SlotId ToInactive(uint freeHead)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005290")]
		[global::Cpp2ILInjected.Address(RVA = "0x93ED98", Offset = "0x93ED98", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal SlotId ToActive(uint index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005291")]
		[global::Cpp2ILInjected.Address(RVA = "0x93EDB4", Offset = "0x93EDB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SlotId(uint value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005292")]
		[global::Cpp2ILInjected.Address(RVA = "0x93EDBC", Offset = "0x93EDBC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005293")]
		[global::Cpp2ILInjected.Address(RVA = "0x93EE34", Offset = "0x93EE34", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005294")]
		[global::Cpp2ILInjected.Address(RVA = "0x93EE54", Offset = "0x93EE54", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(SlotId lhs, SlotId rhs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005295")]
		[global::Cpp2ILInjected.Address(RVA = "0x93EE60", Offset = "0x93EE60", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "get_Item", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(SlotId),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlotVector<>), Member = "Has", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static bool operator !=(SlotId lhs, SlotId rhs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005296")]
		[global::Cpp2ILInjected.Address(RVA = "0x93EE6C", Offset = "0x93EE6C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_110_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_108_DivingFlyer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_195_JimsDrone", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_187_ShadowHand", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_177_IceWhipSlicer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_001", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_143_MonkStaffT2Ghast", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_145_BookStaffStorm", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 34)]
		public float ToFloat()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005297")]
		[global::Cpp2ILInjected.Address(RVA = "0x93EE74", Offset = "0x93EE74", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_110_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_108_DivingFlyer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HitEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_195_JimsDrone", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_187_ShadowHand", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_177_IceWhipSlicer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_001", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_143_MonkStaffT2Ghast", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_145_BookStaffStorm", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		public static SlotId FromFloat(float value)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6005298")]
		[global::Cpp2ILInjected.Address(RVA = "0x93EE7C", Offset = "0x93EE7C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static SlotId()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008ACF")]
		public static readonly SlotId Invalid;

		[global::Cpp2ILInjected.Token(Token = "0x4008AD0")]
		private const uint KEY_INC = 65536U;

		[global::Cpp2ILInjected.Token(Token = "0x4008AD1")]
		private const uint INDEX_MASK = 65535U;

		[global::Cpp2ILInjected.Token(Token = "0x4008AD2")]
		private const uint ACTIVE_MASK = 2147483648U;

		[global::Cpp2ILInjected.Token(Token = "0x4008AD3")]
		private const uint KEY_MASK = 2147418112U;

		[global::Cpp2ILInjected.Token(Token = "0x4008AD4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly uint Value;
	}
}
