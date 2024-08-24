using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Terraria.ID;
using Terraria.Utilities;

namespace Terraria.Audio
{
	// Token: 0x02000486 RID: 1158
	[global::Cpp2ILInjected.Token(Token = "0x200068A")]
	public class LegacySoundStyle : SoundStyle
	{
		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060032BB RID: 12987 RVA: 0x0002B121 File Offset: 0x00029321
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

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x0002B124 File Offset: 0x00029324
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

		// Token: 0x060032BD RID: 12989 RVA: 0x0002B127 File Offset: 0x00029327
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

		// Token: 0x060032BE RID: 12990 RVA: 0x0002B12A File Offset: 0x0002932A
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

		// Token: 0x060032BF RID: 12991 RVA: 0x0002B12D File Offset: 0x0002932D
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

		// Token: 0x060032C0 RID: 12992 RVA: 0x0002B130 File Offset: 0x00029330
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

		// Token: 0x060032C1 RID: 12993 RVA: 0x0002B133 File Offset: 0x00029333
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

		// Token: 0x060032C2 RID: 12994 RVA: 0x0002B136 File Offset: 0x00029336
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

		// Token: 0x060032C3 RID: 12995 RVA: 0x0002B139 File Offset: 0x00029339
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

		// Token: 0x060032C4 RID: 12996 RVA: 0x0002B13C File Offset: 0x0002933C
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

		// Token: 0x060032C5 RID: 12997 RVA: 0x0002B13F File Offset: 0x0002933F
		[global::Cpp2ILInjected.Token(Token = "0x60037F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x14349BC", Offset = "0x14349BC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Includes(int soundId, int style)
		{
			throw null;
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x0002B142 File Offset: 0x00029342
		[global::Cpp2ILInjected.Token(Token = "0x60037F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x14349F0", Offset = "0x14349F0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = "get_Style", ReturnType = typeof(int))]
		public override SoundEffect GetRandomSound()
		{
			throw null;
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x0002B145 File Offset: 0x00029345
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

		// Token: 0x04006503 RID: 25859
		[global::Cpp2ILInjected.Token(Token = "0x40078FF")]
		private static readonly UnifiedRandom Random;

		// Token: 0x04006504 RID: 25860
		[global::Cpp2ILInjected.Token(Token = "0x4007900")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private readonly int _style;

		// Token: 0x04006505 RID: 25861
		[global::Cpp2ILInjected.Token(Token = "0x4007901")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly int Variations;

		// Token: 0x04006506 RID: 25862
		[global::Cpp2ILInjected.Token(Token = "0x4007902")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public readonly int SoundId;
	}
}
