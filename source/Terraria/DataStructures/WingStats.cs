using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Initializers;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000682")]
	public struct WingStats
	{
		[global::Cpp2ILInjected.Token(Token = "0x60037A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420BD0", Offset = "0x1420BD0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WingStatsInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
		public WingStats(int flyTime = 100, float flySpeedOverride = -1f, float accelerationMultiplier = 1f, bool hasHoldDownHoverFeatures = false, float hoverFlySpeedOverride = -1f, float hoverAccelerationMultiplier = 1f)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420BE8", Offset = "0x1420BE8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public WingStats WithSpeedBoost(float multiplier)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60037A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420C28", Offset = "0x1420C28", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		static WingStats()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400789A")]
		public static readonly WingStats Default;

		[global::Cpp2ILInjected.Token(Token = "0x400789B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int FlyTime;

		[global::Cpp2ILInjected.Token(Token = "0x400789C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float AccRunSpeedOverride;

		[global::Cpp2ILInjected.Token(Token = "0x400789D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float AccRunAccelerationMult;

		[global::Cpp2ILInjected.Token(Token = "0x400789E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public bool HasDownHoverStats;

		[global::Cpp2ILInjected.Token(Token = "0x400789F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public float DownHoverSpeedOverride;

		[global::Cpp2ILInjected.Token(Token = "0x40078A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public float DownHoverAccelerationMult;
	}
}
