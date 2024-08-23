using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Utilities;

namespace Terraria.Audio
{
	// Token: 0x02000480 RID: 1152
	[global::Cpp2ILInjected.Token(Token = "0x2000683")]
	public class ActiveSound
	{
		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06003280 RID: 12928 RVA: 0x0002B097 File Offset: 0x00029297
		// (set) Token: 0x06003281 RID: 12929 RVA: 0x0002B09A File Offset: 0x0002929A
		[global::Cpp2ILInjected.Token(Token = "0x170006BE")]
		public SoundEffectInstance Sound
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60037A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1420C2C", Offset = "0x1420C2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60037AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1420C34", Offset = "0x1420C34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x0002B09D File Offset: 0x0002929D
		// (set) Token: 0x06003283 RID: 12931 RVA: 0x0002B0A0 File Offset: 0x000292A0
		[global::Cpp2ILInjected.Token(Token = "0x170006BF")]
		public SoundStyle Style
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60037AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1420C3C", Offset = "0x1420C3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60037AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1420C44", Offset = "0x1420C44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06003284 RID: 12932 RVA: 0x0002B0A3 File Offset: 0x000292A3
		[global::Cpp2ILInjected.Token(Token = "0x170006C0")]
		public bool IsPlaying
		{
			[global::Cpp2ILInjected.Token(Token = "0x60037AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1420C4C", Offset = "0x1420C4C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x0002B0A6 File Offset: 0x000292A6
		[global::Cpp2ILInjected.Token(Token = "0x60037AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420C70", Offset = "0x1420C70", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "Play", MemberParameters = new object[]
		{
			typeof(SoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ActiveSound(SoundStyle style, Vector2 position)
		{
			throw null;
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x0002B0A9 File Offset: 0x000292A9
		[global::Cpp2ILInjected.Token(Token = "0x60037AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420D84", Offset = "0x1420D84", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "Play", MemberParameters = new object[] { typeof(SoundStyle) }, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActiveSound), Member = "Play", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ActiveSound(SoundStyle style)
		{
			throw null;
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x0002B0AC File Offset: 0x000292AC
		[global::Cpp2ILInjected.Token(Token = "0x60037B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420E4C", Offset = "0x1420E4C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "PlayLooped", MemberParameters = new object[]
		{
			typeof(SoundStyle),
			typeof(Vector2),
			typeof(ActiveSound.LoopedPlayCondition)
		}, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ActiveSound(SoundStyle style, Vector2 position, ActiveSound.LoopedPlayCondition condition)
		{
			throw null;
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x0002B0AF File Offset: 0x000292AF
		[global::Cpp2ILInjected.Token(Token = "0x60037B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420CC4", Offset = "0x1420CC4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActiveSound), Member = ".ctor", MemberParameters = new object[] { typeof(SoundStyle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffect), Member = "CreateInstance", ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundStyle), Member = "GetRandomPitch", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffectInstance), Member = "set_Pitch", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstanceGarbageCollector), Member = "Track", MemberParameters = new object[] { typeof(SoundEffectInstance) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActiveSound), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Play()
		{
			throw null;
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x0002B0B2 File Offset: 0x000292B2
		[global::Cpp2ILInjected.Token(Token = "0x60037B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420EA8", Offset = "0x1420EA8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffect), Member = "CreateInstance", ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundStyle), Member = "GetRandomPitch", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffectInstance), Member = "set_Pitch", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstanceGarbageCollector), Member = "Track", MemberParameters = new object[] { typeof(SoundEffectInstance) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void PlayLooped(ActiveSound.LoopedPlayCondition condition)
		{
			throw null;
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x0002B0B5 File Offset: 0x000292B5
		[global::Cpp2ILInjected.Token(Token = "0x60037B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1421248", Offset = "0x1421248", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HitEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "StopAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Stop()
		{
			throw null;
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x0002B0B8 File Offset: 0x000292B8
		[global::Cpp2ILInjected.Token(Token = "0x60037B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1421264", Offset = "0x1421264", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "PauseAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Pause()
		{
			throw null;
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x0002B0BB File Offset: 0x000292BB
		[global::Cpp2ILInjected.Token(Token = "0x60037B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x14212A0", Offset = "0x14212A0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "ResumeAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Resume()
		{
			throw null;
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x0002B0BE File Offset: 0x000292BE
		[global::Cpp2ILInjected.Token(Token = "0x60037B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420F8C", Offset = "0x1420F8C", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActiveSound), Member = "Play", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffectInstance), Member = "set_Pan", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_soundVolume", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_musicVolume", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ambientVolume", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffectInstance), Member = "set_Volume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffectInstance), Member = "set_Pitch", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x040064A5 RID: 25765
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40078A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SoundEffectInstance <Sound>k__BackingField;

		// Token: 0x040064A6 RID: 25766
		[global::Cpp2ILInjected.Token(Token = "0x40078A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly bool IsGlobal;

		// Token: 0x040064A7 RID: 25767
		[global::Cpp2ILInjected.Token(Token = "0x40078A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public Vector2 Position;

		// Token: 0x040064A8 RID: 25768
		[global::Cpp2ILInjected.Token(Token = "0x40078A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float Volume;

		// Token: 0x040064A9 RID: 25769
		[global::Cpp2ILInjected.Token(Token = "0x40078A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public float Pitch;

		// Token: 0x040064AA RID: 25770
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40078A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private SoundStyle <Style>k__BackingField;

		// Token: 0x040064AB RID: 25771
		[global::Cpp2ILInjected.Token(Token = "0x40078A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public ActiveSound.LoopedPlayCondition Condition;

		// Token: 0x02000938 RID: 2360
		// (Invoke) Token: 0x06004C9F RID: 19615
		[global::Cpp2ILInjected.Token(Token = "0x2000684")]
		public delegate bool LoopedPlayCondition();
	}
}
