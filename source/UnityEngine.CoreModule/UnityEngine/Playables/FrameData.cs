using System;
using Cpp2ILInjected;

namespace UnityEngine.Playables
{
	[global::Cpp2ILInjected.Token(Token = "0x2000148")]
	public struct FrameData
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000616")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal ulong m_FrameID;

		[global::Cpp2ILInjected.Token(Token = "0x4000617")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal double m_DeltaTime;

		[global::Cpp2ILInjected.Token(Token = "0x4000618")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal float m_Weight;

		[global::Cpp2ILInjected.Token(Token = "0x4000619")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal float m_EffectiveWeight;

		[global::Cpp2ILInjected.Token(Token = "0x400061A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal double m_EffectiveParentDelay;

		[global::Cpp2ILInjected.Token(Token = "0x400061B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal float m_EffectiveParentSpeed;

		[global::Cpp2ILInjected.Token(Token = "0x400061C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal float m_EffectiveSpeed;

		[global::Cpp2ILInjected.Token(Token = "0x400061D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal FrameData.Flags m_Flags;

		[global::Cpp2ILInjected.Token(Token = "0x400061E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal PlayableOutput m_Output;

		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000149")]
		internal enum Flags
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000620")]
			Evaluate = 1,
			[global::Cpp2ILInjected.Token(Token = "0x4000621")]
			SeekOccured = 2,
			[global::Cpp2ILInjected.Token(Token = "0x4000622")]
			Loop = 4,
			[global::Cpp2ILInjected.Token(Token = "0x4000623")]
			Hold = 8,
			[global::Cpp2ILInjected.Token(Token = "0x4000624")]
			EffectivePlayStateDelayed = 16,
			[global::Cpp2ILInjected.Token(Token = "0x4000625")]
			EffectivePlayStatePlaying = 32
		}
	}
}
