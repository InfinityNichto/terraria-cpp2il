using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AF1")]
	public abstract class LunarPillarBigProgessBar : IBigProgressBar
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600521E")]
		internal abstract float GetCurrentShieldValue();

		[global::Cpp2ILInjected.Token(Token = "0x600521F")]
		internal abstract float GetMaxShieldValue();

		[global::Cpp2ILInjected.Token(Token = "0x6005220")]
		internal abstract bool IsPlayerInCombatArea();

		[global::Cpp2ILInjected.Token(Token = "0x6005221")]
		[global::Cpp2ILInjected.Address(RVA = "0x93A928", Offset = "0x93A928", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected LunarPillarBigProgessBar()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008A74")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BigProgressBarCache _cache;

		[global::Cpp2ILInjected.Token(Token = "0x4008A75")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _headIndex;
	}
}
