using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Content;
using ReLogic.Content;
using Terraria.Audio;
using UnityEngine;

namespace Microsoft.Xna.Framework.Audio
{
	// Token: 0x020002F6 RID: 758
	[global::Cpp2ILInjected.Token(Token = "0x20003CF")]
	public sealed class SoundEffect
	{
		// Token: 0x060018E4 RID: 6372 RVA: 0x0002650A File Offset: 0x0002470A
		[global::Cpp2ILInjected.Token(Token = "0x6001A73")]
		[global::Cpp2ILInjected.Address(RVA = "0xB43DC8", Offset = "0xB43DC8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "CreateSoundEffect", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundDefinition), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundDefinition), Member = "AddVariation", MemberParameters = new object[] { typeof(AudioClip) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public SoundEffect(string id, AudioClip clip)
		{
			throw null;
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0002650D File Offset: 0x0002470D
		[global::Cpp2ILInjected.Token(Token = "0x6001A74")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49A7C", Offset = "0xB49A7C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cue), Member = ".ctor", MemberParameters = new object[] { typeof(SoundEffect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundBank), Member = "LoadMusicId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActiveSound), Member = "Play", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActiveSound), Member = "PlayLooped", MemberParameters = new object[] { typeof(ActiveSound.LoopedPlayCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundPlayer), Member = "CreateInstance", MemberParameters = new object[] { typeof(Asset<SoundEffect>) }, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundPlayer), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 63)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SoundEffectInstance CreateInstance()
		{
			throw null;
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00026510 File Offset: 0x00024710
		[global::Cpp2ILInjected.Token(Token = "0x6001A75")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49EF0", Offset = "0xB49EF0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundDefinition), Member = "Play", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(SoundInstance))]
		public bool Play()
		{
			throw null;
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00026513 File Offset: 0x00024713
		[global::Cpp2ILInjected.Token(Token = "0x6001A76")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49F24", Offset = "0xB49F24", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundDefinition), Member = "Play", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(SoundInstance))]
		public bool Play(float volume, float pitch, float pan)
		{
			throw null;
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00026516 File Offset: 0x00024716
		[global::Cpp2ILInjected.Token(Token = "0x17000377")]
		public TimeSpan Duration
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A77")]
			[global::Cpp2ILInjected.Address(RVA = "0xB49F5C", Offset = "0xB49F5C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x00026519 File Offset: 0x00024719
		// (set) Token: 0x060018EA RID: 6378 RVA: 0x0002651C File Offset: 0x0002471C
		[global::Cpp2ILInjected.Token(Token = "0x17000378")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A78")]
			[global::Cpp2ILInjected.Address(RVA = "0xB49FC4", Offset = "0xB49FC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A79")]
			[global::Cpp2ILInjected.Address(RVA = "0xB49FCC", Offset = "0xB49FCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0400216F RID: 8559
		[global::Cpp2ILInjected.Token(Token = "0x40027DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _name;

		// Token: 0x04002170 RID: 8560
		[global::Cpp2ILInjected.Token(Token = "0x40027DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly SoundDefinition Definition;
	}
}
