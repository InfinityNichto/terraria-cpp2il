using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Terraria.ID;
using Terraria.Utilities;

namespace Terraria.Audio
{
	[global::Cpp2ILInjected.Token(Token = "0x200068A")]
	public class LegacySoundStyle : SoundStyle
	{
		[global::Cpp2ILInjected.Token(Token = "0x170006C2")]
		public int Style
		{
			[global::Cpp2ILInjected.Token(Token = "0x60037E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x143443C", Offset = "0x143443C", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UseAbility", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(Vector2),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundStyle), Member = "GetRandomSound", ReturnType = typeof(SoundEffect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(LegacySoundStyle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006C3")]
		public override bool IsTrackable
		{
			[global::Cpp2ILInjected.Token(Token = "0x60037E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x14344C4", Offset = "0x14344C4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x14344D4", Offset = "0x14344D4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundID), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 302)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LegacySoundStyle(int soundId, int style, SoundType type = SoundType.Sound)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1434598", Offset = "0x1434598", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundID), Member = "CreateTrackable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(SoundType)
		}, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LegacySoundStyle(int soundId, int style, int variations, SoundType type = SoundType.Sound)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1434628", Offset = "0x1434628", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundStyle), Member = "WithVolume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundStyle), Member = "WithPitchVariance", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundStyle), Member = "AsMusic", ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundStyle), Member = "AsAmbient", ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundStyle), Member = "AsSound", ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private LegacySoundStyle(int soundId, int style, int variations, SoundType type, float volume, float pitchVariance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x14346FC", Offset = "0x14346FC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundID), Member = "CreateTrackable", MemberParameters = new object[]
		{
			typeof(string),
			"Terraria.ID.SoundID.SoundStyleDefaults"
		}, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundID), Member = "CreateTrackable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			"Terraria.ID.SoundID.SoundStyleDefaults"
		}, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundID), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(SoundType),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LegacySoundStyle WithVolume(float volume)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1434790", Offset = "0x1434790", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundID), Member = "CreateTrackable", MemberParameters = new object[]
		{
			typeof(string),
			"Terraria.ID.SoundID.SoundStyleDefaults"
		}, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundID), Member = "CreateTrackable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			"Terraria.ID.SoundID.SoundStyleDefaults"
		}, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundID), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(SoundType),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LegacySoundStyle WithPitchVariance(float pitchVariance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1434824", Offset = "0x1434824", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(SoundType),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LegacySoundStyle AsMusic()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x14348AC", Offset = "0x14348AC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(SoundType),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LegacySoundStyle AsAmbient()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1434934", Offset = "0x1434934", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(SoundType),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LegacySoundStyle AsSound()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x14349BC", Offset = "0x14349BC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Includes(int soundId, int style)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x14349F0", Offset = "0x14349F0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = "get_Style", ReturnType = typeof(int))]
		public override SoundEffect GetRandomSound()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60037F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1434AE4", Offset = "0x1434AE4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static LegacySoundStyle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40078FF")]
		private static readonly UnifiedRandom Random;

		[global::Cpp2ILInjected.Token(Token = "0x4007900")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private readonly int _style;

		[global::Cpp2ILInjected.Token(Token = "0x4007901")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly int Variations;

		[global::Cpp2ILInjected.Token(Token = "0x4007902")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public readonly int SoundId;
	}
}
