using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x020006FD RID: 1789
	[global::Cpp2ILInjected.Token(Token = "0x2000AEB")]
	public class BrainOfCthuluBigProgressBar : IBigProgressBar
	{
		// Token: 0x06004595 RID: 17813 RVA: 0x0002E73C File Offset: 0x0002C93C
		[global::Cpp2ILInjected.Token(Token = "0x6005208")]
		[global::Cpp2ILInjected.Address(RVA = "0x93959C", Offset = "0x93959C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BrainOfCthuluBigProgressBar()
		{
			throw null;
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x0002E73F File Offset: 0x0002C93F
		[global::Cpp2ILInjected.Token(Token = "0x6005209")]
		[global::Cpp2ILInjected.Address(RVA = "0x939600", Offset = "0x939600", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBrainOfCthuluCreepersCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetMatchingSpawnParams", ReturnType = typeof(NPCSpawnParams))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
		{
			throw null;
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x0002E742 File Offset: 0x0002C942
		[global::Cpp2ILInjected.Token(Token = "0x600520A")]
		[global::Cpp2ILInjected.Address(RVA = "0x93978C", Offset = "0x93978C", Length = "0x138")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x04007114 RID: 28948
		[global::Cpp2ILInjected.Token(Token = "0x4008A66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BigProgressBarCache _cache;

		// Token: 0x04007115 RID: 28949
		[global::Cpp2ILInjected.Token(Token = "0x4008A67")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private NPC _creeperForReference;
	}
}
