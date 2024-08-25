using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.UI.BigProgressBar
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AEF")]
	public struct BigProgressBarCache
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005217")]
		[global::Cpp2ILInjected.Address(RVA = "0x938EE8", Offset = "0x938EE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetLife(float current, float max)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005218")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A3F4", Offset = "0x93A3F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetShield(float current, float max)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008A6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float LifeCurrent;

		[global::Cpp2ILInjected.Token(Token = "0x4008A6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float LifeMax;

		[global::Cpp2ILInjected.Token(Token = "0x4008A70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float ShieldCurrent;

		[global::Cpp2ILInjected.Token(Token = "0x4008A71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float ShieldMax;
	}
}
