using System;
using Cpp2ILInjected;

namespace UnityEngine.Playables
{
	// Token: 0x02000123 RID: 291
	[global::Cpp2ILInjected.Token(Token = "0x2000148")]
	public struct FrameData
	{
		// Token: 0x040005C7 RID: 1479
		[global::Cpp2ILInjected.Token(Token = "0x4000616")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal ulong m_FrameID;

		// Token: 0x040005C8 RID: 1480
		[global::Cpp2ILInjected.Token(Token = "0x4000617")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal double m_DeltaTime;

		// Token: 0x040005C9 RID: 1481
		[global::Cpp2ILInjected.Token(Token = "0x4000618")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal float m_Weight;

		// Token: 0x040005CA RID: 1482
		[global::Cpp2ILInjected.Token(Token = "0x4000619")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal float m_EffectiveWeight;

		// Token: 0x040005CB RID: 1483
		[global::Cpp2ILInjected.Token(Token = "0x400061A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal double m_EffectiveParentDelay;

		// Token: 0x040005CC RID: 1484
		[global::Cpp2ILInjected.Token(Token = "0x400061B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal float m_EffectiveParentSpeed;

		// Token: 0x040005CD RID: 1485
		[global::Cpp2ILInjected.Token(Token = "0x400061C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal float m_EffectiveSpeed;

		// Token: 0x040005CE RID: 1486
		[global::Cpp2ILInjected.Token(Token = "0x400061D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal FrameData.Flags m_Flags;

		// Token: 0x040005CF RID: 1487
		[global::Cpp2ILInjected.Token(Token = "0x400061E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal PlayableOutput m_Output;

		// Token: 0x02000185 RID: 389
		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000149")]
		internal enum Flags
		{
			// Token: 0x04000680 RID: 1664
			[global::Cpp2ILInjected.Token(Token = "0x4000620")]
			Evaluate = 1,
			// Token: 0x04000681 RID: 1665
			[global::Cpp2ILInjected.Token(Token = "0x4000621")]
			SeekOccured = 2,
			// Token: 0x04000682 RID: 1666
			[global::Cpp2ILInjected.Token(Token = "0x4000622")]
			Loop = 4,
			// Token: 0x04000683 RID: 1667
			[global::Cpp2ILInjected.Token(Token = "0x4000623")]
			Hold = 8,
			// Token: 0x04000684 RID: 1668
			[global::Cpp2ILInjected.Token(Token = "0x4000624")]
			EffectivePlayStateDelayed = 16,
			// Token: 0x04000685 RID: 1669
			[global::Cpp2ILInjected.Token(Token = "0x4000625")]
			EffectivePlayStatePlaying = 32
		}
	}
}
