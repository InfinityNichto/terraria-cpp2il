using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000703 RID: 1795
	[global::Cpp2ILInjected.Token(Token = "0x2000AF1")]
	public abstract class LunarPillarBigProgessBar : IBigProgressBar
	{
		// Token: 0x060045A9 RID: 17833 RVA: 0x0002E778 File Offset: 0x0002C978
		[global::Cpp2ILInjected.Token(Token = "0x600521C")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A628", Offset = "0x93A628", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBossHeadTextureIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x0002E77B File Offset: 0x0002C97B
		[global::Cpp2ILInjected.Token(Token = "0x600521D")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A82C", Offset = "0x93A82C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBossBar), Member = "Draw", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060045AB RID: 17835
		[global::Cpp2ILInjected.Token(Token = "0x600521E")]
		internal abstract float GetCurrentShieldValue();

		// Token: 0x060045AC RID: 17836
		[global::Cpp2ILInjected.Token(Token = "0x600521F")]
		internal abstract float GetMaxShieldValue();

		// Token: 0x060045AD RID: 17837
		[global::Cpp2ILInjected.Token(Token = "0x6005220")]
		internal abstract bool IsPlayerInCombatArea();

		// Token: 0x060045AE RID: 17838 RVA: 0x0002E77E File Offset: 0x0002C97E
		[global::Cpp2ILInjected.Token(Token = "0x6005221")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A928", Offset = "0x93A928", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected LunarPillarBigProgessBar()
		{
			throw null;
		}

		// Token: 0x04007122 RID: 28962
		[global::Cpp2ILInjected.Token(Token = "0x4008A74")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BigProgressBarCache _cache;

		// Token: 0x04007123 RID: 28963
		[global::Cpp2ILInjected.Token(Token = "0x4008A75")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _headIndex;
	}
}
