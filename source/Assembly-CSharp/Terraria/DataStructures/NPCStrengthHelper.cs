using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x02000431 RID: 1073
	[global::Cpp2ILInjected.Token(Token = "0x200062C")]
	public struct NPCStrengthHelper
	{
		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06003100 RID: 12544 RVA: 0x0002AC38 File Offset: 0x00028E38
		[global::Cpp2ILInjected.Token(Token = "0x17000698")]
		public bool IsExpertMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600361D")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DC8D0", Offset = "0x13DC8D0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "ScaleStats", MemberParameters = new object[]
			{
				typeof(int?),
				typeof(GameModeData),
				typeof(float?)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06003101 RID: 12545 RVA: 0x0002AC3B File Offset: 0x00028E3B
		[global::Cpp2ILInjected.Token(Token = "0x17000699")]
		public bool IsMasterMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600361E")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DC8F8", Offset = "0x13DC8F8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "ScaleStats", MemberParameters = new object[]
			{
				typeof(int?),
				typeof(GameModeData),
				typeof(float?)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "OpenBossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x0002AC3E File Offset: 0x00028E3E
		[global::Cpp2ILInjected.Token(Token = "0x1700069A")]
		public bool ExtraDamageForGetGoodWorld
		{
			[global::Cpp2ILInjected.Token(Token = "0x600361F")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DC920", Offset = "0x13DC920", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "ScaleStats", MemberParameters = new object[]
			{
				typeof(int?),
				typeof(GameModeData),
				typeof(float?)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x0002AC41 File Offset: 0x00028E41
		[global::Cpp2ILInjected.Token(Token = "0x6003620")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC948", Offset = "0x13DC948", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "ScaleStats", MemberParameters = new object[]
		{
			typeof(int?),
			typeof(GameModeData),
			typeof(float?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "OpenBossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public NPCStrengthHelper(GameModeData data, float strength, bool isGetGoodWorld)
		{
			throw null;
		}

		// Token: 0x040062F9 RID: 25337
		[global::Cpp2ILInjected.Token(Token = "0x40076E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float _strengthOverride;

		// Token: 0x040062FA RID: 25338
		[global::Cpp2ILInjected.Token(Token = "0x40076E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private float _gameModeDifficulty;

		// Token: 0x040062FB RID: 25339
		[global::Cpp2ILInjected.Token(Token = "0x40076E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private GameModeData _gameModeData;
	}
}
