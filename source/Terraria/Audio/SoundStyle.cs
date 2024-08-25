using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using Terraria.Utilities;

namespace Terraria.Audio
{
	[global::Cpp2ILInjected.Token(Token = "0x200068E")]
	public abstract class SoundStyle
	{
		[global::Cpp2ILInjected.Token(Token = "0x170006C5")]
		public float Volume
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003816")]
			[global::Cpp2ILInjected.Address(RVA = "0x1436F1C", Offset = "0x1436F1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006C6")]
		public float PitchVariance
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003817")]
			[global::Cpp2ILInjected.Address(RVA = "0x1436F24", Offset = "0x1436F24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006C7")]
		public SoundType Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003818")]
			[global::Cpp2ILInjected.Address(RVA = "0x1436F2C", Offset = "0x1436F2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006C8")]
		public abstract bool IsTrackable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003819")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600381A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14346C0", Offset = "0x14346C0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomSoundStyle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SoundEffect),
			typeof(SoundType),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomSoundStyle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SoundEffect[]),
			typeof(SoundType),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SoundStyle(float volume, float pitchVariance, SoundType type = SoundType.Sound)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600381B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1434564", Offset = "0x1434564", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SoundStyle(SoundType type = SoundType.Sound)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600381C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1435BB4", Offset = "0x1435BB4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActiveSound), Member = "Play", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActiveSound), Member = "PlayLooped", MemberParameters = new object[] { typeof(ActiveSound.LoopedPlayCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LegacySoundStyle),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public float GetRandomPitch()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600381D")]
		public abstract SoundEffect GetRandomSound();

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600381E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1436F34", Offset = "0x1436F34", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static SoundStyle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007909")]
		private static UnifiedRandom _random;

		[global::Cpp2ILInjected.Token(Token = "0x400790A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float _volume;

		[global::Cpp2ILInjected.Token(Token = "0x400790B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float _pitchVariance;

		[global::Cpp2ILInjected.Token(Token = "0x400790C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SoundType _type;
	}
}
