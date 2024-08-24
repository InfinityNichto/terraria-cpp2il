using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Audio
{
	// Token: 0x02000481 RID: 1153
	[global::Cpp2ILInjected.Token(Token = "0x2000685")]
	public class ProjectileAudioTracker
	{
		// Token: 0x0600328E RID: 12942 RVA: 0x0002B0C1 File Offset: 0x000292C1
		[global::Cpp2ILInjected.Token(Token = "0x60037BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x14213F0", Offset = "0x14213F0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_195_JimsDrone", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ProjectileAudioTracker(Projectile proj)
		{
			throw null;
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x0002B0C4 File Offset: 0x000292C4
		[global::Cpp2ILInjected.Token(Token = "0x60037BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1421424", Offset = "0x1421424", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool IsActiveAndInGame()
		{
			throw null;
		}

		// Token: 0x040064AC RID: 25772
		[global::Cpp2ILInjected.Token(Token = "0x40078A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _expectedType;

		// Token: 0x040064AD RID: 25773
		[global::Cpp2ILInjected.Token(Token = "0x40078A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _expectedIndex;
	}
}
