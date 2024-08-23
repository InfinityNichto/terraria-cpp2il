using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria.Audio
{
	// Token: 0x02000489 RID: 1161
	[global::Cpp2ILInjected.Token(Token = "0x200068D")]
	public class SoundPlayer
	{
		// Token: 0x060032DE RID: 13022 RVA: 0x0002B18A File Offset: 0x0002938A
		[global::Cpp2ILInjected.Token(Token = "0x600380B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1435EAC", Offset = "0x1435EAC", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "PlayTrackedSound", MemberParameters = new object[]
		{
			typeof(SoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "DistanceSquared", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActiveSound), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public SlotId Play(SoundStyle style, Vector2 position)
		{
			throw null;
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x0002B18D File Offset: 0x0002938D
		[global::Cpp2ILInjected.Token(Token = "0x600380C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14361AC", Offset = "0x14361AC", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "PlayTrackedLoopedSound", MemberParameters = new object[]
		{
			typeof(SoundStyle),
			typeof(Vector2),
			typeof(ActiveSound.LoopedPlayCondition)
		}, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "DistanceSquared", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActiveSound), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SoundStyle),
			typeof(Vector2),
			typeof(ActiveSound.LoopedPlayCondition)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public SlotId PlayLooped(SoundStyle style, Vector2 position, ActiveSound.LoopedPlayCondition loopingCondition)
		{
			throw null;
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x0002B190 File Offset: 0x00029390
		[global::Cpp2ILInjected.Token(Token = "0x600380D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14359E0", Offset = "0x14359E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundPlayer), Member = "StopAll", ReturnType = typeof(void))]
		public void Reload()
		{
			throw null;
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x0002B193 File Offset: 0x00029393
		[global::Cpp2ILInjected.Token(Token = "0x600380E")]
		[global::Cpp2ILInjected.Address(RVA = "0x143648C", Offset = "0x143648C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "PlayTrackedSound", MemberParameters = new object[] { typeof(SoundStyle) }, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActiveSound), Member = ".ctor", MemberParameters = new object[] { typeof(SoundStyle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public SlotId Play(SoundStyle style)
		{
			throw null;
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x0002B196 File Offset: 0x00029396
		[global::Cpp2ILInjected.Token(Token = "0x600380F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1435D14", Offset = "0x1435D14", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>), Member = "Has", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>), Member = "get_Item", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ActiveSound GetActiveSound(SlotId id)
		{
			throw null;
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x0002B199 File Offset: 0x00029399
		[global::Cpp2ILInjected.Token(Token = "0x6003810")]
		[global::Cpp2ILInjected.Address(RVA = "0x1435030", Offset = "0x1435030", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActiveSound), Member = "Pause", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void PauseAll()
		{
			throw null;
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x0002B19C File Offset: 0x0002939C
		[global::Cpp2ILInjected.Token(Token = "0x6003811")]
		[global::Cpp2ILInjected.Address(RVA = "0x14352E8", Offset = "0x14352E8", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActiveSound), Member = "Resume", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void ResumeAll()
		{
			throw null;
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x0002B19F File Offset: 0x0002939F
		[global::Cpp2ILInjected.Token(Token = "0x6003812")]
		[global::Cpp2ILInjected.Address(RVA = "0x1436650", Offset = "0x1436650", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "Reload", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundPlayer), Member = "Reload", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActiveSound), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void StopAll()
		{
			throw null;
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x0002B1A2 File Offset: 0x000293A2
		[global::Cpp2ILInjected.Token(Token = "0x6003813")]
		[global::Cpp2ILInjected.Address(RVA = "0x14355A0", Offset = "0x14355A0", Length = "0x3A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActiveSound), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ActiveSound), Member = "get_IsPlaying", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>), Member = "Remove", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x0002B1A5 File Offset: 0x000293A5
		[global::Cpp2ILInjected.Token(Token = "0x6003814")]
		[global::Cpp2ILInjected.Address(RVA = "0x1436AA0", Offset = "0x1436AA0", Length = "0x2F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public ActiveSound FindActiveSound(SoundStyle style)
		{
			throw null;
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x0002B1A8 File Offset: 0x000293A8
		[global::Cpp2ILInjected.Token(Token = "0x6003815")]
		[global::Cpp2ILInjected.Address(RVA = "0x1434D14", Offset = "0x1434D14", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "Load", MemberParameters = new object[] { typeof(IServiceProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public SoundPlayer()
		{
			throw null;
		}

		// Token: 0x0400650C RID: 25868
		[global::Cpp2ILInjected.Token(Token = "0x4007908")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly SlotVector<ActiveSound> _trackedSounds;
	}
}
