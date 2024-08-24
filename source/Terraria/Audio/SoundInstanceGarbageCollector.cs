using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;

namespace Terraria.Audio
{
	// Token: 0x02000488 RID: 1160
	[global::Cpp2ILInjected.Token(Token = "0x200068C")]
	public static class SoundInstanceGarbageCollector
	{
		// Token: 0x060032DB RID: 13019 RVA: 0x0002B181 File Offset: 0x00029381
		[global::Cpp2ILInjected.Token(Token = "0x6003808")]
		[global::Cpp2ILInjected.Address(RVA = "0x1436D94", Offset = "0x1436D94", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActiveSound), Member = "Play", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActiveSound), Member = "PlayLooped", MemberParameters = new object[] { typeof(ActiveSound.LoopedPlayCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundPlayer), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Track(SoundEffectInstance sound)
		{
			throw null;
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x0002B184 File Offset: 0x00029384
		[global::Cpp2ILInjected.Token(Token = "0x6003809")]
		[global::Cpp2ILInjected.Address(RVA = "0x1434EEC", Offset = "0x1434EEC", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void Update()
		{
			throw null;
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x0002B187 File Offset: 0x00029387
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600380A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1436E8C", Offset = "0x1436E8C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static SoundInstanceGarbageCollector()
		{
			throw null;
		}

		// Token: 0x0400650B RID: 25867
		[global::Cpp2ILInjected.Token(Token = "0x4007907")]
		private static readonly List<SoundEffectInstance> _activeSounds;
	}
}
