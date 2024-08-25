using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using Terraria.Utilities;

namespace Terraria.Audio
{
	[global::Cpp2ILInjected.Token(Token = "0x2000686")]
	public class CustomSoundStyle : SoundStyle
	{
		[global::Cpp2ILInjected.Token(Token = "0x170006C1")]
		public override bool IsTrackable
		{
			[global::Cpp2ILInjected.Token(Token = "0x60037BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x14214C8", Offset = "0x14214C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x14214D0", Offset = "0x14214D0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundStyle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(SoundType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public CustomSoundStyle(SoundEffect soundEffect, SoundType type = SoundType.Sound, float volume = 1f, float pitchVariance = 0f)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x14215A8", Offset = "0x14215A8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundStyle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(SoundType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CustomSoundStyle(SoundEffect[] soundEffects, SoundType type = SoundType.Sound, float volume = 1f, float pitchVariance = 0f)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1421634", Offset = "0x1421634", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override SoundEffect GetRandomSound()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60037C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x14216B4", Offset = "0x14216B4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static CustomSoundStyle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40078AA")]
		private static readonly UnifiedRandom Random;

		[global::Cpp2ILInjected.Token(Token = "0x40078AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly SoundEffect[] _soundEffects;
	}
}
