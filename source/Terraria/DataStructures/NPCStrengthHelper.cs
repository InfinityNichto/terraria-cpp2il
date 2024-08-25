using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200062C")]
	public struct NPCStrengthHelper
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x40076E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float _strengthOverride;

		[global::Cpp2ILInjected.Token(Token = "0x40076E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private float _gameModeDifficulty;

		[global::Cpp2ILInjected.Token(Token = "0x40076E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private GameModeData _gameModeData;
	}
}
