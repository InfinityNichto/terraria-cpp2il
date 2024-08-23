using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005DF RID: 1503
	[global::Cpp2ILInjected.Token(Token = "0x200088F")]
	public class Conditions
	{
		// Token: 0x06003CE0 RID: 15584 RVA: 0x0002CDEC File Offset: 0x0002AFEC
		[global::Cpp2ILInjected.Token(Token = "0x600445E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AB7D8", Offset = "0x7AB7D8", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Conditions.SoulOfNight), Member = "CanDrop", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Conditions.SoulOfLight), Member = "CanDrop", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool SoulOfWhateverConditionCanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x0002CDEF File Offset: 0x0002AFEF
		[global::Cpp2ILInjected.Token(Token = "0x600445F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AB94C", Offset = "0x7AB94C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Conditions()
		{
			throw null;
		}

		// Token: 0x020009BA RID: 2490
		[global::Cpp2ILInjected.Token(Token = "0x2000890")]
		public class NeverTrue : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E50 RID: 20048 RVA: 0x0002FD20 File Offset: 0x0002DF20
			[global::Cpp2ILInjected.Token(Token = "0x6004460")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB954", Offset = "0x7AB954", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E51 RID: 20049 RVA: 0x0002FD23 File Offset: 0x0002DF23
			[global::Cpp2ILInjected.Token(Token = "0x6004461")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB95C", Offset = "0x7AB95C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E52 RID: 20050 RVA: 0x0002FD26 File Offset: 0x0002DF26
			[global::Cpp2ILInjected.Token(Token = "0x6004462")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB964", Offset = "0x7AB964", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E53 RID: 20051 RVA: 0x0002FD29 File Offset: 0x0002DF29
			[global::Cpp2ILInjected.Token(Token = "0x6004463")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB96C", Offset = "0x7AB96C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NeverTrue()
			{
				throw null;
			}
		}

		// Token: 0x020009BB RID: 2491
		[global::Cpp2ILInjected.Token(Token = "0x2000891")]
		public class IsUsingSpecificAIValues : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E54 RID: 20052 RVA: 0x0002FD2C File Offset: 0x0002DF2C
			[global::Cpp2ILInjected.Token(Token = "0x6004464")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB974", Offset = "0x7AB974", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsUsingSpecificAIValues(int aislot, float valueToMatch)
			{
				throw null;
			}

			// Token: 0x06004E55 RID: 20053 RVA: 0x0002FD2F File Offset: 0x0002DF2F
			[global::Cpp2ILInjected.Token(Token = "0x6004465")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB9AC", Offset = "0x7AB9AC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E56 RID: 20054 RVA: 0x0002FD32 File Offset: 0x0002DF32
			[global::Cpp2ILInjected.Token(Token = "0x6004466")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB9D0", Offset = "0x7AB9D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E57 RID: 20055 RVA: 0x0002FD35 File Offset: 0x0002DF35
			[global::Cpp2ILInjected.Token(Token = "0x6004467")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB9D8", Offset = "0x7AB9D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x04008CE3 RID: 36067
			[global::Cpp2ILInjected.Token(Token = "0x40081F6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int aiSlotToCheck;

			// Token: 0x04008CE4 RID: 36068
			[global::Cpp2ILInjected.Token(Token = "0x40081F7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public float valueToMatch;
		}

		// Token: 0x020009BC RID: 2492
		[global::Cpp2ILInjected.Token(Token = "0x2000892")]
		public class FrostMoonDropGatingChance : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E58 RID: 20056 RVA: 0x0002FD38 File Offset: 0x0002DF38
			[global::Cpp2ILInjected.Token(Token = "0x6004468")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB9E0", Offset = "0x7AB9E0", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RollLuck", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E59 RID: 20057 RVA: 0x0002FD3B File Offset: 0x0002DF3B
			[global::Cpp2ILInjected.Token(Token = "0x6004469")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABB0C", Offset = "0x7ABB0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E5A RID: 20058 RVA: 0x0002FD3E File Offset: 0x0002DF3E
			[global::Cpp2ILInjected.Token(Token = "0x600446A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABB14", Offset = "0x7ABB14", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E5B RID: 20059 RVA: 0x0002FD41 File Offset: 0x0002DF41
			[global::Cpp2ILInjected.Token(Token = "0x600446B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABB58", Offset = "0x7ABB58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FrostMoonDropGatingChance()
			{
				throw null;
			}
		}

		// Token: 0x020009BD RID: 2493
		[global::Cpp2ILInjected.Token(Token = "0x2000893")]
		public class PumpkinMoonDropGatingChance : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E5C RID: 20060 RVA: 0x0002FD44 File Offset: 0x0002DF44
			[global::Cpp2ILInjected.Token(Token = "0x600446C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABB60", Offset = "0x7ABB60", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RollLuck", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E5D RID: 20061 RVA: 0x0002FD47 File Offset: 0x0002DF47
			[global::Cpp2ILInjected.Token(Token = "0x600446D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABC88", Offset = "0x7ABC88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E5E RID: 20062 RVA: 0x0002FD4A File Offset: 0x0002DF4A
			[global::Cpp2ILInjected.Token(Token = "0x600446E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABC90", Offset = "0x7ABC90", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E5F RID: 20063 RVA: 0x0002FD4D File Offset: 0x0002DF4D
			[global::Cpp2ILInjected.Token(Token = "0x600446F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABCD4", Offset = "0x7ABCD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PumpkinMoonDropGatingChance()
			{
				throw null;
			}
		}

		// Token: 0x020009BE RID: 2494
		[global::Cpp2ILInjected.Token(Token = "0x2000894")]
		public class FrostMoonDropGateForTrophies : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E60 RID: 20064 RVA: 0x0002FD50 File Offset: 0x0002DF50
			[global::Cpp2ILInjected.Token(Token = "0x6004470")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABCDC", Offset = "0x7ABCDC", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E61 RID: 20065 RVA: 0x0002FD53 File Offset: 0x0002DF53
			[global::Cpp2ILInjected.Token(Token = "0x6004471")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABE08", Offset = "0x7ABE08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E62 RID: 20066 RVA: 0x0002FD56 File Offset: 0x0002DF56
			[global::Cpp2ILInjected.Token(Token = "0x6004472")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABE10", Offset = "0x7ABE10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E63 RID: 20067 RVA: 0x0002FD59 File Offset: 0x0002DF59
			[global::Cpp2ILInjected.Token(Token = "0x6004473")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABE18", Offset = "0x7ABE18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FrostMoonDropGateForTrophies()
			{
				throw null;
			}
		}

		// Token: 0x020009BF RID: 2495
		[global::Cpp2ILInjected.Token(Token = "0x2000895")]
		public class PumpkinMoonDropGateForTrophies : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E64 RID: 20068 RVA: 0x0002FD5C File Offset: 0x0002DF5C
			[global::Cpp2ILInjected.Token(Token = "0x6004474")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABE20", Offset = "0x7ABE20", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E65 RID: 20069 RVA: 0x0002FD5F File Offset: 0x0002DF5F
			[global::Cpp2ILInjected.Token(Token = "0x6004475")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABF4C", Offset = "0x7ABF4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E66 RID: 20070 RVA: 0x0002FD62 File Offset: 0x0002DF62
			[global::Cpp2ILInjected.Token(Token = "0x6004476")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABF54", Offset = "0x7ABF54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E67 RID: 20071 RVA: 0x0002FD65 File Offset: 0x0002DF65
			[global::Cpp2ILInjected.Token(Token = "0x6004477")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABF5C", Offset = "0x7ABF5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PumpkinMoonDropGateForTrophies()
			{
				throw null;
			}
		}

		// Token: 0x020009C0 RID: 2496
		[global::Cpp2ILInjected.Token(Token = "0x2000896")]
		public class IsPumpkinMoon : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E68 RID: 20072 RVA: 0x0002FD68 File Offset: 0x0002DF68
			[global::Cpp2ILInjected.Token(Token = "0x6004478")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABF64", Offset = "0x7ABF64", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E69 RID: 20073 RVA: 0x0002FD6B File Offset: 0x0002DF6B
			[global::Cpp2ILInjected.Token(Token = "0x6004479")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABFBC", Offset = "0x7ABFBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E6A RID: 20074 RVA: 0x0002FD6E File Offset: 0x0002DF6E
			[global::Cpp2ILInjected.Token(Token = "0x600447A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABFC4", Offset = "0x7ABFC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E6B RID: 20075 RVA: 0x0002FD71 File Offset: 0x0002DF71
			[global::Cpp2ILInjected.Token(Token = "0x600447B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABFCC", Offset = "0x7ABFCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsPumpkinMoon()
			{
				throw null;
			}
		}

		// Token: 0x020009C1 RID: 2497
		[global::Cpp2ILInjected.Token(Token = "0x2000897")]
		public class FromCertainWaveAndAbove : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E6C RID: 20076 RVA: 0x0002FD74 File Offset: 0x0002DF74
			[global::Cpp2ILInjected.Token(Token = "0x600447C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABFD4", Offset = "0x7ABFD4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FromCertainWaveAndAbove(int neededWave)
			{
				throw null;
			}

			// Token: 0x06004E6D RID: 20077 RVA: 0x0002FD77 File Offset: 0x0002DF77
			[global::Cpp2ILInjected.Token(Token = "0x600447D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABFFC", Offset = "0x7ABFFC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E6E RID: 20078 RVA: 0x0002FD7A File Offset: 0x0002DF7A
			[global::Cpp2ILInjected.Token(Token = "0x600447E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC064", Offset = "0x7AC064", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E6F RID: 20079 RVA: 0x0002FD7D File Offset: 0x0002DF7D
			[global::Cpp2ILInjected.Token(Token = "0x600447F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC06C", Offset = "0x7AC06C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x04008CE5 RID: 36069
			[global::Cpp2ILInjected.Token(Token = "0x40081F8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int neededWave;
		}

		// Token: 0x020009C2 RID: 2498
		[global::Cpp2ILInjected.Token(Token = "0x2000898")]
		public class IsBloodMoonAndNotFromStatue : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E70 RID: 20080 RVA: 0x0002FD80 File Offset: 0x0002DF80
			[global::Cpp2ILInjected.Token(Token = "0x6004480")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC0F0", Offset = "0x7AC0F0", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E71 RID: 20081 RVA: 0x0002FD83 File Offset: 0x0002DF83
			[global::Cpp2ILInjected.Token(Token = "0x6004481")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC18C", Offset = "0x7AC18C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E72 RID: 20082 RVA: 0x0002FD86 File Offset: 0x0002DF86
			[global::Cpp2ILInjected.Token(Token = "0x6004482")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC194", Offset = "0x7AC194", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E73 RID: 20083 RVA: 0x0002FD89 File Offset: 0x0002DF89
			[global::Cpp2ILInjected.Token(Token = "0x6004483")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC19C", Offset = "0x7AC19C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsBloodMoonAndNotFromStatue()
			{
				throw null;
			}
		}

		// Token: 0x020009C3 RID: 2499
		[global::Cpp2ILInjected.Token(Token = "0x2000899")]
		public class DownedAllMechBosses : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E74 RID: 20084 RVA: 0x0002FD8C File Offset: 0x0002DF8C
			[global::Cpp2ILInjected.Token(Token = "0x6004484")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC1A4", Offset = "0x7AC1A4", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E75 RID: 20085 RVA: 0x0002FD8F File Offset: 0x0002DF8F
			[global::Cpp2ILInjected.Token(Token = "0x6004485")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC244", Offset = "0x7AC244", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E76 RID: 20086 RVA: 0x0002FD92 File Offset: 0x0002DF92
			[global::Cpp2ILInjected.Token(Token = "0x6004486")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC24C", Offset = "0x7AC24C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E77 RID: 20087 RVA: 0x0002FD95 File Offset: 0x0002DF95
			[global::Cpp2ILInjected.Token(Token = "0x6004487")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC254", Offset = "0x7AC254", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DownedAllMechBosses()
			{
				throw null;
			}
		}

		// Token: 0x020009C4 RID: 2500
		[global::Cpp2ILInjected.Token(Token = "0x200089A")]
		public class DownedPlantera : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E78 RID: 20088 RVA: 0x0002FD98 File Offset: 0x0002DF98
			[global::Cpp2ILInjected.Token(Token = "0x6004488")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC25C", Offset = "0x7AC25C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E79 RID: 20089 RVA: 0x0002FD9B File Offset: 0x0002DF9B
			[global::Cpp2ILInjected.Token(Token = "0x6004489")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC2B4", Offset = "0x7AC2B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E7A RID: 20090 RVA: 0x0002FD9E File Offset: 0x0002DF9E
			[global::Cpp2ILInjected.Token(Token = "0x600448A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC2BC", Offset = "0x7AC2BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E7B RID: 20091 RVA: 0x0002FDA1 File Offset: 0x0002DFA1
			[global::Cpp2ILInjected.Token(Token = "0x600448B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC2C4", Offset = "0x7AC2C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DownedPlantera()
			{
				throw null;
			}
		}

		// Token: 0x020009C5 RID: 2501
		[global::Cpp2ILInjected.Token(Token = "0x200089B")]
		public class IsHardmode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E7C RID: 20092 RVA: 0x0002FDA4 File Offset: 0x0002DFA4
			[global::Cpp2ILInjected.Token(Token = "0x600448C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC2CC", Offset = "0x7AC2CC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E7D RID: 20093 RVA: 0x0002FDA7 File Offset: 0x0002DFA7
			[global::Cpp2ILInjected.Token(Token = "0x600448D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC324", Offset = "0x7AC324", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E7E RID: 20094 RVA: 0x0002FDAA File Offset: 0x0002DFAA
			[global::Cpp2ILInjected.Token(Token = "0x600448E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC32C", Offset = "0x7AC32C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E7F RID: 20095 RVA: 0x0002FDAD File Offset: 0x0002DFAD
			[global::Cpp2ILInjected.Token(Token = "0x600448F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC334", Offset = "0x7AC334", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsHardmode()
			{
				throw null;
			}
		}

		// Token: 0x020009C6 RID: 2502
		[global::Cpp2ILInjected.Token(Token = "0x200089C")]
		public class FirstTimeKillingPlantera : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E80 RID: 20096 RVA: 0x0002FDB0 File Offset: 0x0002DFB0
			[global::Cpp2ILInjected.Token(Token = "0x6004490")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC33C", Offset = "0x7AC33C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E81 RID: 20097 RVA: 0x0002FDB3 File Offset: 0x0002DFB3
			[global::Cpp2ILInjected.Token(Token = "0x6004491")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC39C", Offset = "0x7AC39C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E82 RID: 20098 RVA: 0x0002FDB6 File Offset: 0x0002DFB6
			[global::Cpp2ILInjected.Token(Token = "0x6004492")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC3A4", Offset = "0x7AC3A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E83 RID: 20099 RVA: 0x0002FDB9 File Offset: 0x0002DFB9
			[global::Cpp2ILInjected.Token(Token = "0x6004493")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC3AC", Offset = "0x7AC3AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FirstTimeKillingPlantera()
			{
				throw null;
			}
		}

		// Token: 0x020009C7 RID: 2503
		[global::Cpp2ILInjected.Token(Token = "0x200089D")]
		public class MechanicalBossesDummyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E84 RID: 20100 RVA: 0x0002FDBC File Offset: 0x0002DFBC
			[global::Cpp2ILInjected.Token(Token = "0x6004494")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC3B4", Offset = "0x7AC3B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E85 RID: 20101 RVA: 0x0002FDBF File Offset: 0x0002DFBF
			[global::Cpp2ILInjected.Token(Token = "0x6004495")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC3BC", Offset = "0x7AC3BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E86 RID: 20102 RVA: 0x0002FDC2 File Offset: 0x0002DFC2
			[global::Cpp2ILInjected.Token(Token = "0x6004496")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC3C4", Offset = "0x7AC3C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E87 RID: 20103 RVA: 0x0002FDC5 File Offset: 0x0002DFC5
			[global::Cpp2ILInjected.Token(Token = "0x6004497")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC3CC", Offset = "0x7AC3CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MechBossSpawnersDropRule), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public MechanicalBossesDummyCondition()
			{
				throw null;
			}
		}

		// Token: 0x020009C8 RID: 2504
		[global::Cpp2ILInjected.Token(Token = "0x200089E")]
		public class PirateMap : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E88 RID: 20104 RVA: 0x0002FDC8 File Offset: 0x0002DFC8
			[global::Cpp2ILInjected.Token(Token = "0x6004498")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC3D4", Offset = "0x7AC3D4", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E89 RID: 20105 RVA: 0x0002FDCB File Offset: 0x0002DFCB
			[global::Cpp2ILInjected.Token(Token = "0x6004499")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC510", Offset = "0x7AC510", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E8A RID: 20106 RVA: 0x0002FDCE File Offset: 0x0002DFCE
			[global::Cpp2ILInjected.Token(Token = "0x600449A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC518", Offset = "0x7AC518", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E8B RID: 20107 RVA: 0x0002FDD1 File Offset: 0x0002DFD1
			[global::Cpp2ILInjected.Token(Token = "0x600449B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC55C", Offset = "0x7AC55C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PirateMap()
			{
				throw null;
			}
		}

		// Token: 0x020009C9 RID: 2505
		[global::Cpp2ILInjected.Token(Token = "0x200089F")]
		public class IsChristmas : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E8C RID: 20108 RVA: 0x0002FDD4 File Offset: 0x0002DFD4
			[global::Cpp2ILInjected.Token(Token = "0x600449C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC564", Offset = "0x7AC564", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E8D RID: 20109 RVA: 0x0002FDD7 File Offset: 0x0002DFD7
			[global::Cpp2ILInjected.Token(Token = "0x600449D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC5BC", Offset = "0x7AC5BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E8E RID: 20110 RVA: 0x0002FDDA File Offset: 0x0002DFDA
			[global::Cpp2ILInjected.Token(Token = "0x600449E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC5C4", Offset = "0x7AC5C4", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E8F RID: 20111 RVA: 0x0002FDDD File Offset: 0x0002DFDD
			[global::Cpp2ILInjected.Token(Token = "0x600449F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC608", Offset = "0x7AC608", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsChristmas()
			{
				throw null;
			}
		}

		// Token: 0x020009CA RID: 2506
		[global::Cpp2ILInjected.Token(Token = "0x20008A0")]
		public class NotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E90 RID: 20112 RVA: 0x0002FDE0 File Offset: 0x0002DFE0
			[global::Cpp2ILInjected.Token(Token = "0x60044A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC610", Offset = "0x7AC610", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E91 RID: 20113 RVA: 0x0002FDE3 File Offset: 0x0002DFE3
			[global::Cpp2ILInjected.Token(Token = "0x60044A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC66C", Offset = "0x7AC66C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E92 RID: 20114 RVA: 0x0002FDE6 File Offset: 0x0002DFE6
			[global::Cpp2ILInjected.Token(Token = "0x60044A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC6C8", Offset = "0x7AC6C8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E93 RID: 20115 RVA: 0x0002FDE9 File Offset: 0x0002DFE9
			[global::Cpp2ILInjected.Token(Token = "0x60044A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC70C", Offset = "0x7AC70C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropBasedOnExpertMode), Member = "ReportDroprates", MemberParameters = new object[]
			{
				typeof(List<DropRateInfo>),
				typeof(DropRateInfoChainFeed)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropBasedOnMasterAndExpertMode), Member = "ReportDroprates", MemberParameters = new object[]
			{
				typeof(List<DropRateInfo>),
				typeof(DropRateInfoChainFeed)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NotExpert()
			{
				throw null;
			}
		}

		// Token: 0x020009CB RID: 2507
		[global::Cpp2ILInjected.Token(Token = "0x20008A1")]
		public class NotMasterMode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E94 RID: 20116 RVA: 0x0002FDEC File Offset: 0x0002DFEC
			[global::Cpp2ILInjected.Token(Token = "0x60044A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC714", Offset = "0x7AC714", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_masterMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E95 RID: 20117 RVA: 0x0002FDEF File Offset: 0x0002DFEF
			[global::Cpp2ILInjected.Token(Token = "0x60044A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC770", Offset = "0x7AC770", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_masterMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E96 RID: 20118 RVA: 0x0002FDF2 File Offset: 0x0002DFF2
			[global::Cpp2ILInjected.Token(Token = "0x60044A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC7CC", Offset = "0x7AC7CC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E97 RID: 20119 RVA: 0x0002FDF5 File Offset: 0x0002DFF5
			[global::Cpp2ILInjected.Token(Token = "0x60044A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC810", Offset = "0x7AC810", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropBasedOnMasterMode), Member = "ReportDroprates", MemberParameters = new object[]
			{
				typeof(List<DropRateInfo>),
				typeof(DropRateInfoChainFeed)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropBasedOnMasterAndExpertMode), Member = "ReportDroprates", MemberParameters = new object[]
			{
				typeof(List<DropRateInfo>),
				typeof(DropRateInfoChainFeed)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NotMasterMode()
			{
				throw null;
			}
		}

		// Token: 0x020009CC RID: 2508
		[global::Cpp2ILInjected.Token(Token = "0x20008A2")]
		public class MissingTwin : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E98 RID: 20120 RVA: 0x0002FDF8 File Offset: 0x0002DFF8
			[global::Cpp2ILInjected.Token(Token = "0x60044A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC818", Offset = "0x7AC818", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AnyNPCs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E99 RID: 20121 RVA: 0x0002FDFB File Offset: 0x0002DFFB
			[global::Cpp2ILInjected.Token(Token = "0x60044A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC890", Offset = "0x7AC890", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E9A RID: 20122 RVA: 0x0002FDFE File Offset: 0x0002DFFE
			[global::Cpp2ILInjected.Token(Token = "0x60044AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC898", Offset = "0x7AC898", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E9B RID: 20123 RVA: 0x0002FE01 File Offset: 0x0002E001
			[global::Cpp2ILInjected.Token(Token = "0x60044AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC8A0", Offset = "0x7AC8A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public MissingTwin()
			{
				throw null;
			}
		}

		// Token: 0x020009CD RID: 2509
		[global::Cpp2ILInjected.Token(Token = "0x20008A3")]
		public class EmpressOfLightIsGenuinelyEnraged : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004E9C RID: 20124 RVA: 0x0002FE04 File Offset: 0x0002E004
			[global::Cpp2ILInjected.Token(Token = "0x60044AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC8A8", Offset = "0x7AC8A8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AI_120_HallowBoss_IsGenuinelyEnraged", ReturnType = typeof(bool))]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004E9D RID: 20125 RVA: 0x0002FE07 File Offset: 0x0002E007
			[global::Cpp2ILInjected.Token(Token = "0x60044AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC8B4", Offset = "0x7AC8B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004E9E RID: 20126 RVA: 0x0002FE0A File Offset: 0x0002E00A
			[global::Cpp2ILInjected.Token(Token = "0x60044AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC8BC", Offset = "0x7AC8BC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004E9F RID: 20127 RVA: 0x0002FE0D File Offset: 0x0002E00D
			[global::Cpp2ILInjected.Token(Token = "0x60044AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC900", Offset = "0x7AC900", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public EmpressOfLightIsGenuinelyEnraged()
			{
				throw null;
			}
		}

		// Token: 0x020009CE RID: 2510
		[global::Cpp2ILInjected.Token(Token = "0x20008A4")]
		public class PlayerNeedsHealing : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EA0 RID: 20128 RVA: 0x0002FE10 File Offset: 0x0002E010
			[global::Cpp2ILInjected.Token(Token = "0x60044B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC908", Offset = "0x7AC908", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EA1 RID: 20129 RVA: 0x0002FE13 File Offset: 0x0002E013
			[global::Cpp2ILInjected.Token(Token = "0x60044B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC920", Offset = "0x7AC920", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EA2 RID: 20130 RVA: 0x0002FE16 File Offset: 0x0002E016
			[global::Cpp2ILInjected.Token(Token = "0x60044B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC928", Offset = "0x7AC928", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EA3 RID: 20131 RVA: 0x0002FE19 File Offset: 0x0002E019
			[global::Cpp2ILInjected.Token(Token = "0x60044B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC96C", Offset = "0x7AC96C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PlayerNeedsHealing()
			{
				throw null;
			}
		}

		// Token: 0x020009CF RID: 2511
		[global::Cpp2ILInjected.Token(Token = "0x20008A5")]
		public class MechdusaKill : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EA4 RID: 20132 RVA: 0x0002FE1C File Offset: 0x0002E01C
			[global::Cpp2ILInjected.Token(Token = "0x60044B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC974", Offset = "0x7AC974", Length = "0x158")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AnyNPCs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EA5 RID: 20133 RVA: 0x0002FE1F File Offset: 0x0002E01F
			[global::Cpp2ILInjected.Token(Token = "0x60044B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACACC", Offset = "0x7ACACC", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EA6 RID: 20134 RVA: 0x0002FE22 File Offset: 0x0002E022
			[global::Cpp2ILInjected.Token(Token = "0x60044B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACB50", Offset = "0x7ACB50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EA7 RID: 20135 RVA: 0x0002FE25 File Offset: 0x0002E025
			[global::Cpp2ILInjected.Token(Token = "0x60044B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACB58", Offset = "0x7ACB58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public MechdusaKill()
			{
				throw null;
			}

			// Token: 0x06004EA8 RID: 20136 RVA: 0x0002FE28 File Offset: 0x0002E028
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60044B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACB60", Offset = "0x7ACB60", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			static MechdusaKill()
			{
				throw null;
			}

			// Token: 0x04008CE6 RID: 36070
			[global::Cpp2ILInjected.Token(Token = "0x40081F9")]
			private static int[] _targetList;
		}

		// Token: 0x020009D0 RID: 2512
		[global::Cpp2ILInjected.Token(Token = "0x20008A6")]
		public class LegacyHack_IsBossAndExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EA9 RID: 20137 RVA: 0x0002FE2B File Offset: 0x0002E02B
			[global::Cpp2ILInjected.Token(Token = "0x60044B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACBF4", Offset = "0x7ACBF4", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EAA RID: 20138 RVA: 0x0002FE2E File Offset: 0x0002E02E
			[global::Cpp2ILInjected.Token(Token = "0x60044BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACC64", Offset = "0x7ACC64", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EAB RID: 20139 RVA: 0x0002FE31 File Offset: 0x0002E031
			[global::Cpp2ILInjected.Token(Token = "0x60044BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACCB4", Offset = "0x7ACCB4", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EAC RID: 20140 RVA: 0x0002FE34 File Offset: 0x0002E034
			[global::Cpp2ILInjected.Token(Token = "0x60044BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACCF8", Offset = "0x7ACCF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public LegacyHack_IsBossAndExpert()
			{
				throw null;
			}
		}

		// Token: 0x020009D1 RID: 2513
		[global::Cpp2ILInjected.Token(Token = "0x20008A7")]
		public class LegacyHack_IsBossAndNotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EAD RID: 20141 RVA: 0x0002FE37 File Offset: 0x0002E037
			[global::Cpp2ILInjected.Token(Token = "0x60044BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACD00", Offset = "0x7ACD00", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EAE RID: 20142 RVA: 0x0002FE3A File Offset: 0x0002E03A
			[global::Cpp2ILInjected.Token(Token = "0x60044BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACD6C", Offset = "0x7ACD6C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EAF RID: 20143 RVA: 0x0002FE3D File Offset: 0x0002E03D
			[global::Cpp2ILInjected.Token(Token = "0x60044BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACDC8", Offset = "0x7ACDC8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EB0 RID: 20144 RVA: 0x0002FE40 File Offset: 0x0002E040
			[global::Cpp2ILInjected.Token(Token = "0x60044C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACE0C", Offset = "0x7ACE0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public LegacyHack_IsBossAndNotExpert()
			{
				throw null;
			}
		}

		// Token: 0x020009D2 RID: 2514
		[global::Cpp2ILInjected.Token(Token = "0x20008A8")]
		public class LegacyHack_IsABoss : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EB1 RID: 20145 RVA: 0x0002FE43 File Offset: 0x0002E043
			[global::Cpp2ILInjected.Token(Token = "0x60044C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACE14", Offset = "0x7ACE14", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EB2 RID: 20146 RVA: 0x0002FE46 File Offset: 0x0002E046
			[global::Cpp2ILInjected.Token(Token = "0x60044C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACE20", Offset = "0x7ACE20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EB3 RID: 20147 RVA: 0x0002FE49 File Offset: 0x0002E049
			[global::Cpp2ILInjected.Token(Token = "0x60044C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACE28", Offset = "0x7ACE28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EB4 RID: 20148 RVA: 0x0002FE4C File Offset: 0x0002E04C
			[global::Cpp2ILInjected.Token(Token = "0x60044C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACE30", Offset = "0x7ACE30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public LegacyHack_IsABoss()
			{
				throw null;
			}
		}

		// Token: 0x020009D3 RID: 2515
		[global::Cpp2ILInjected.Token(Token = "0x20008A9")]
		public class IsExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EB5 RID: 20149 RVA: 0x0002FE4F File Offset: 0x0002E04F
			[global::Cpp2ILInjected.Token(Token = "0x60044C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACE38", Offset = "0x7ACE38", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EB6 RID: 20150 RVA: 0x0002FE52 File Offset: 0x0002E052
			[global::Cpp2ILInjected.Token(Token = "0x60044C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACE88", Offset = "0x7ACE88", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EB7 RID: 20151 RVA: 0x0002FE55 File Offset: 0x0002E055
			[global::Cpp2ILInjected.Token(Token = "0x60044C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACED8", Offset = "0x7ACED8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_masterMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EB8 RID: 20152 RVA: 0x0002FE58 File Offset: 0x0002E058
			[global::Cpp2ILInjected.Token(Token = "0x60044C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACF64", Offset = "0x7ACF64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropBasedOnExpertMode), Member = "ReportDroprates", MemberParameters = new object[]
			{
				typeof(List<DropRateInfo>),
				typeof(DropRateInfoChainFeed)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropBasedOnMasterAndExpertMode), Member = "ReportDroprates", MemberParameters = new object[]
			{
				typeof(List<DropRateInfo>),
				typeof(DropRateInfoChainFeed)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsExpert()
			{
				throw null;
			}
		}

		// Token: 0x020009D4 RID: 2516
		[global::Cpp2ILInjected.Token(Token = "0x20008AA")]
		public class IsMasterMode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EB9 RID: 20153 RVA: 0x0002FE5B File Offset: 0x0002E05B
			[global::Cpp2ILInjected.Token(Token = "0x60044C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACF6C", Offset = "0x7ACF6C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_masterMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EBA RID: 20154 RVA: 0x0002FE5E File Offset: 0x0002E05E
			[global::Cpp2ILInjected.Token(Token = "0x60044CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACFBC", Offset = "0x7ACFBC", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_masterMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EBB RID: 20155 RVA: 0x0002FE61 File Offset: 0x0002E061
			[global::Cpp2ILInjected.Token(Token = "0x60044CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD00C", Offset = "0x7AD00C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EBC RID: 20156 RVA: 0x0002FE64 File Offset: 0x0002E064
			[global::Cpp2ILInjected.Token(Token = "0x60044CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD050", Offset = "0x7AD050", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "MasterModeCommonDrop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(IItemDropRule))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropBasedOnMasterMode), Member = "ReportDroprates", MemberParameters = new object[]
			{
				typeof(List<DropRateInfo>),
				typeof(DropRateInfoChainFeed)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DropBasedOnMasterAndExpertMode), Member = "ReportDroprates", MemberParameters = new object[]
			{
				typeof(List<DropRateInfo>),
				typeof(DropRateInfoChainFeed)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsMasterMode()
			{
				throw null;
			}
		}

		// Token: 0x020009D5 RID: 2517
		[global::Cpp2ILInjected.Token(Token = "0x20008AB")]
		public class IsCrimson : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EBD RID: 20157 RVA: 0x0002FE67 File Offset: 0x0002E067
			[global::Cpp2ILInjected.Token(Token = "0x60044CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD058", Offset = "0x7AD058", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EBE RID: 20158 RVA: 0x0002FE6A File Offset: 0x0002E06A
			[global::Cpp2ILInjected.Token(Token = "0x60044CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD0B0", Offset = "0x7AD0B0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EBF RID: 20159 RVA: 0x0002FE6D File Offset: 0x0002E06D
			[global::Cpp2ILInjected.Token(Token = "0x60044CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD108", Offset = "0x7AD108", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EC0 RID: 20160 RVA: 0x0002FE70 File Offset: 0x0002E070
			[global::Cpp2ILInjected.Token(Token = "0x60044D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD14C", Offset = "0x7AD14C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsCrimson()
			{
				throw null;
			}
		}

		// Token: 0x020009D6 RID: 2518
		[global::Cpp2ILInjected.Token(Token = "0x20008AC")]
		public class IsCorruption : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EC1 RID: 20161 RVA: 0x0002FE73 File Offset: 0x0002E073
			[global::Cpp2ILInjected.Token(Token = "0x60044D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD154", Offset = "0x7AD154", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EC2 RID: 20162 RVA: 0x0002FE76 File Offset: 0x0002E076
			[global::Cpp2ILInjected.Token(Token = "0x60044D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD1B4", Offset = "0x7AD1B4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EC3 RID: 20163 RVA: 0x0002FE79 File Offset: 0x0002E079
			[global::Cpp2ILInjected.Token(Token = "0x60044D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD214", Offset = "0x7AD214", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EC4 RID: 20164 RVA: 0x0002FE7C File Offset: 0x0002E07C
			[global::Cpp2ILInjected.Token(Token = "0x60044D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD258", Offset = "0x7AD258", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsCorruption()
			{
				throw null;
			}
		}

		// Token: 0x020009D7 RID: 2519
		[global::Cpp2ILInjected.Token(Token = "0x20008AD")]
		public class IsCrimsonAndNotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EC5 RID: 20165 RVA: 0x0002FE7F File Offset: 0x0002E07F
			[global::Cpp2ILInjected.Token(Token = "0x60044D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD260", Offset = "0x7AD260", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EC6 RID: 20166 RVA: 0x0002FE82 File Offset: 0x0002E082
			[global::Cpp2ILInjected.Token(Token = "0x60044D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD2F0", Offset = "0x7AD2F0", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EC7 RID: 20167 RVA: 0x0002FE85 File Offset: 0x0002E085
			[global::Cpp2ILInjected.Token(Token = "0x60044D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD380", Offset = "0x7AD380", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EC8 RID: 20168 RVA: 0x0002FE88 File Offset: 0x0002E088
			[global::Cpp2ILInjected.Token(Token = "0x60044D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD3C4", Offset = "0x7AD3C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsCrimsonAndNotExpert()
			{
				throw null;
			}
		}

		// Token: 0x020009D8 RID: 2520
		[global::Cpp2ILInjected.Token(Token = "0x20008AE")]
		public class IsCorruptionAndNotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EC9 RID: 20169 RVA: 0x0002FE8B File Offset: 0x0002E08B
			[global::Cpp2ILInjected.Token(Token = "0x60044D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD3CC", Offset = "0x7AD3CC", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004ECA RID: 20170 RVA: 0x0002FE8E File Offset: 0x0002E08E
			[global::Cpp2ILInjected.Token(Token = "0x60044DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD464", Offset = "0x7AD464", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004ECB RID: 20171 RVA: 0x0002FE91 File Offset: 0x0002E091
			[global::Cpp2ILInjected.Token(Token = "0x60044DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD4FC", Offset = "0x7AD4FC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004ECC RID: 20172 RVA: 0x0002FE94 File Offset: 0x0002E094
			[global::Cpp2ILInjected.Token(Token = "0x60044DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD540", Offset = "0x7AD540", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsCorruptionAndNotExpert()
			{
				throw null;
			}
		}

		// Token: 0x020009D9 RID: 2521
		[global::Cpp2ILInjected.Token(Token = "0x20008AF")]
		public class HalloweenWeapons : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004ECD RID: 20173 RVA: 0x0002FE97 File Offset: 0x0002E097
			[global::Cpp2ILInjected.Token(Token = "0x60044DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD548", Offset = "0x7AD548", Length = "0x1A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004ECE RID: 20174 RVA: 0x0002FE9A File Offset: 0x0002E09A
			[global::Cpp2ILInjected.Token(Token = "0x60044DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD6E8", Offset = "0x7AD6E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004ECF RID: 20175 RVA: 0x0002FE9D File Offset: 0x0002E09D
			[global::Cpp2ILInjected.Token(Token = "0x60044DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD6F0", Offset = "0x7AD6F0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004ED0 RID: 20176 RVA: 0x0002FEA0 File Offset: 0x0002E0A0
			[global::Cpp2ILInjected.Token(Token = "0x60044E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD734", Offset = "0x7AD734", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public HalloweenWeapons()
			{
				throw null;
			}
		}

		// Token: 0x020009DA RID: 2522
		[global::Cpp2ILInjected.Token(Token = "0x20008B0")]
		public class SoulOfNight : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004ED1 RID: 20177 RVA: 0x0002FEA3 File Offset: 0x0002E0A3
			[global::Cpp2ILInjected.Token(Token = "0x60044E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD73C", Offset = "0x7AD73C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions), Member = "SoulOfWhateverConditionCanDrop", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCorrupt", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCrimson", ReturnType = typeof(bool))]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004ED2 RID: 20178 RVA: 0x0002FEA6 File Offset: 0x0002E0A6
			[global::Cpp2ILInjected.Token(Token = "0x60044E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD798", Offset = "0x7AD798", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004ED3 RID: 20179 RVA: 0x0002FEA9 File Offset: 0x0002E0A9
			[global::Cpp2ILInjected.Token(Token = "0x60044E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD7A0", Offset = "0x7AD7A0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004ED4 RID: 20180 RVA: 0x0002FEAC File Offset: 0x0002E0AC
			[global::Cpp2ILInjected.Token(Token = "0x60044E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD7E4", Offset = "0x7AD7E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SoulOfNight()
			{
				throw null;
			}
		}

		// Token: 0x020009DB RID: 2523
		[global::Cpp2ILInjected.Token(Token = "0x20008B1")]
		public class SoulOfLight : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004ED5 RID: 20181 RVA: 0x0002FEAF File Offset: 0x0002E0AF
			[global::Cpp2ILInjected.Token(Token = "0x60044E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD7EC", Offset = "0x7AD7EC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions), Member = "SoulOfWhateverConditionCanDrop", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneHallow", ReturnType = typeof(bool))]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004ED6 RID: 20182 RVA: 0x0002FEB2 File Offset: 0x0002E0B2
			[global::Cpp2ILInjected.Token(Token = "0x60044E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD830", Offset = "0x7AD830", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004ED7 RID: 20183 RVA: 0x0002FEB5 File Offset: 0x0002E0B5
			[global::Cpp2ILInjected.Token(Token = "0x60044E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD838", Offset = "0x7AD838", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004ED8 RID: 20184 RVA: 0x0002FEB8 File Offset: 0x0002E0B8
			[global::Cpp2ILInjected.Token(Token = "0x60044E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD87C", Offset = "0x7AD87C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SoulOfLight()
			{
				throw null;
			}
		}

		// Token: 0x020009DC RID: 2524
		[global::Cpp2ILInjected.Token(Token = "0x20008B2")]
		public class NotFromStatue : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004ED9 RID: 20185 RVA: 0x0002FEBB File Offset: 0x0002E0BB
			[global::Cpp2ILInjected.Token(Token = "0x60044E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD884", Offset = "0x7AD884", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EDA RID: 20186 RVA: 0x0002FEBE File Offset: 0x0002E0BE
			[global::Cpp2ILInjected.Token(Token = "0x60044EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD898", Offset = "0x7AD898", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EDB RID: 20187 RVA: 0x0002FEC1 File Offset: 0x0002E0C1
			[global::Cpp2ILInjected.Token(Token = "0x60044EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD8A0", Offset = "0x7AD8A0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EDC RID: 20188 RVA: 0x0002FEC4 File Offset: 0x0002E0C4
			[global::Cpp2ILInjected.Token(Token = "0x60044EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD8E4", Offset = "0x7AD8E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "Food", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(IItemDropRule))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NotFromStatue()
			{
				throw null;
			}
		}

		// Token: 0x020009DD RID: 2525
		[global::Cpp2ILInjected.Token(Token = "0x20008B3")]
		public class HalloweenGoodieBagDrop : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EDD RID: 20189 RVA: 0x0002FEC7 File Offset: 0x0002E0C7
			[global::Cpp2ILInjected.Token(Token = "0x60044ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD8EC", Offset = "0x7AD8EC", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EDE RID: 20190 RVA: 0x0002FECA File Offset: 0x0002E0CA
			[global::Cpp2ILInjected.Token(Token = "0x60044EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD9A8", Offset = "0x7AD9A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EDF RID: 20191 RVA: 0x0002FECD File Offset: 0x0002E0CD
			[global::Cpp2ILInjected.Token(Token = "0x60044EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD9B0", Offset = "0x7AD9B0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EE0 RID: 20192 RVA: 0x0002FED0 File Offset: 0x0002E0D0
			[global::Cpp2ILInjected.Token(Token = "0x60044F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD9F4", Offset = "0x7AD9F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public HalloweenGoodieBagDrop()
			{
				throw null;
			}
		}

		// Token: 0x020009DE RID: 2526
		[global::Cpp2ILInjected.Token(Token = "0x20008B4")]
		public class XmasPresentDrop : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EE1 RID: 20193 RVA: 0x0002FED3 File Offset: 0x0002E0D3
			[global::Cpp2ILInjected.Token(Token = "0x60044F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD9FC", Offset = "0x7AD9FC", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EE2 RID: 20194 RVA: 0x0002FED6 File Offset: 0x0002E0D6
			[global::Cpp2ILInjected.Token(Token = "0x60044F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADAB8", Offset = "0x7ADAB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EE3 RID: 20195 RVA: 0x0002FED9 File Offset: 0x0002E0D9
			[global::Cpp2ILInjected.Token(Token = "0x60044F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADAC0", Offset = "0x7ADAC0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EE4 RID: 20196 RVA: 0x0002FEDC File Offset: 0x0002E0DC
			[global::Cpp2ILInjected.Token(Token = "0x60044F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADB04", Offset = "0x7ADB04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public XmasPresentDrop()
			{
				throw null;
			}
		}

		// Token: 0x020009DF RID: 2527
		[global::Cpp2ILInjected.Token(Token = "0x20008B5")]
		public class LivingFlames : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EE5 RID: 20197 RVA: 0x0002FEDF File Offset: 0x0002E0DF
			[global::Cpp2ILInjected.Token(Token = "0x60044F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADB0C", Offset = "0x7ADB0C", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_UnderworldLayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EE6 RID: 20198 RVA: 0x0002FEE2 File Offset: 0x0002E0E2
			[global::Cpp2ILInjected.Token(Token = "0x60044F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADBE0", Offset = "0x7ADBE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EE7 RID: 20199 RVA: 0x0002FEE5 File Offset: 0x0002E0E5
			[global::Cpp2ILInjected.Token(Token = "0x60044F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADBE8", Offset = "0x7ADBE8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EE8 RID: 20200 RVA: 0x0002FEE8 File Offset: 0x0002E0E8
			[global::Cpp2ILInjected.Token(Token = "0x60044F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADC2C", Offset = "0x7ADC2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public LivingFlames()
			{
				throw null;
			}
		}

		// Token: 0x020009E0 RID: 2528
		[global::Cpp2ILInjected.Token(Token = "0x20008B6")]
		public class NamedNPC : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EE9 RID: 20201 RVA: 0x0002FEEB File Offset: 0x0002E0EB
			[global::Cpp2ILInjected.Token(Token = "0x60044F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADC34", Offset = "0x7ADC34", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NamedNPC(string neededName)
			{
				throw null;
			}

			// Token: 0x06004EEA RID: 20202 RVA: 0x0002FEEE File Offset: 0x0002E0EE
			[global::Cpp2ILInjected.Token(Token = "0x60044FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADC5C", Offset = "0x7ADC5C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_GivenOrTypeName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EEB RID: 20203 RVA: 0x0002FEF1 File Offset: 0x0002E0F1
			[global::Cpp2ILInjected.Token(Token = "0x60044FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADC84", Offset = "0x7ADC84", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EEC RID: 20204 RVA: 0x0002FEF4 File Offset: 0x0002E0F4
			[global::Cpp2ILInjected.Token(Token = "0x60044FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADC8C", Offset = "0x7ADC8C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x04008CE7 RID: 36071
			[global::Cpp2ILInjected.Token(Token = "0x40081FA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string neededName;
		}

		// Token: 0x020009E1 RID: 2529
		[global::Cpp2ILInjected.Token(Token = "0x20008B7")]
		public class HallowKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EED RID: 20205 RVA: 0x0002FEF7 File Offset: 0x0002E0F7
			[global::Cpp2ILInjected.Token(Token = "0x60044FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADCD0", Offset = "0x7ADCD0", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneHallow", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EEE RID: 20206 RVA: 0x0002FEFA File Offset: 0x0002E0FA
			[global::Cpp2ILInjected.Token(Token = "0x60044FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADD60", Offset = "0x7ADD60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EEF RID: 20207 RVA: 0x0002FEFD File Offset: 0x0002E0FD
			[global::Cpp2ILInjected.Token(Token = "0x60044FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADD68", Offset = "0x7ADD68", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EF0 RID: 20208 RVA: 0x0002FF00 File Offset: 0x0002E100
			[global::Cpp2ILInjected.Token(Token = "0x6004500")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADDAC", Offset = "0x7ADDAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public HallowKeyCondition()
			{
				throw null;
			}
		}

		// Token: 0x020009E2 RID: 2530
		[global::Cpp2ILInjected.Token(Token = "0x20008B8")]
		public class JungleKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EF1 RID: 20209 RVA: 0x0002FF03 File Offset: 0x0002E103
			[global::Cpp2ILInjected.Token(Token = "0x6004501")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADDB4", Offset = "0x7ADDB4", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneJungle", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EF2 RID: 20210 RVA: 0x0002FF06 File Offset: 0x0002E106
			[global::Cpp2ILInjected.Token(Token = "0x6004502")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADE44", Offset = "0x7ADE44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EF3 RID: 20211 RVA: 0x0002FF09 File Offset: 0x0002E109
			[global::Cpp2ILInjected.Token(Token = "0x6004503")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADE4C", Offset = "0x7ADE4C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EF4 RID: 20212 RVA: 0x0002FF0C File Offset: 0x0002E10C
			[global::Cpp2ILInjected.Token(Token = "0x6004504")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADE90", Offset = "0x7ADE90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public JungleKeyCondition()
			{
				throw null;
			}
		}

		// Token: 0x020009E3 RID: 2531
		[global::Cpp2ILInjected.Token(Token = "0x20008B9")]
		public class CorruptKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EF5 RID: 20213 RVA: 0x0002FF0F File Offset: 0x0002E10F
			[global::Cpp2ILInjected.Token(Token = "0x6004505")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADE98", Offset = "0x7ADE98", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCorrupt", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EF6 RID: 20214 RVA: 0x0002FF12 File Offset: 0x0002E112
			[global::Cpp2ILInjected.Token(Token = "0x6004506")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADF28", Offset = "0x7ADF28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EF7 RID: 20215 RVA: 0x0002FF15 File Offset: 0x0002E115
			[global::Cpp2ILInjected.Token(Token = "0x6004507")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADF30", Offset = "0x7ADF30", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EF8 RID: 20216 RVA: 0x0002FF18 File Offset: 0x0002E118
			[global::Cpp2ILInjected.Token(Token = "0x6004508")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADF74", Offset = "0x7ADF74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CorruptKeyCondition()
			{
				throw null;
			}
		}

		// Token: 0x020009E4 RID: 2532
		[global::Cpp2ILInjected.Token(Token = "0x20008BA")]
		public class CrimsonKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EF9 RID: 20217 RVA: 0x0002FF1B File Offset: 0x0002E11B
			[global::Cpp2ILInjected.Token(Token = "0x6004509")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADF7C", Offset = "0x7ADF7C", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCrimson", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EFA RID: 20218 RVA: 0x0002FF1E File Offset: 0x0002E11E
			[global::Cpp2ILInjected.Token(Token = "0x600450A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE00C", Offset = "0x7AE00C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EFB RID: 20219 RVA: 0x0002FF21 File Offset: 0x0002E121
			[global::Cpp2ILInjected.Token(Token = "0x600450B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE014", Offset = "0x7AE014", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004EFC RID: 20220 RVA: 0x0002FF24 File Offset: 0x0002E124
			[global::Cpp2ILInjected.Token(Token = "0x600450C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE058", Offset = "0x7AE058", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CrimsonKeyCondition()
			{
				throw null;
			}
		}

		// Token: 0x020009E5 RID: 2533
		[global::Cpp2ILInjected.Token(Token = "0x20008BB")]
		public class FrozenKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004EFD RID: 20221 RVA: 0x0002FF27 File Offset: 0x0002E127
			[global::Cpp2ILInjected.Token(Token = "0x600450D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE060", Offset = "0x7AE060", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneSnow", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004EFE RID: 20222 RVA: 0x0002FF2A File Offset: 0x0002E12A
			[global::Cpp2ILInjected.Token(Token = "0x600450E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE0F0", Offset = "0x7AE0F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004EFF RID: 20223 RVA: 0x0002FF2D File Offset: 0x0002E12D
			[global::Cpp2ILInjected.Token(Token = "0x600450F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE0F8", Offset = "0x7AE0F8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F00 RID: 20224 RVA: 0x0002FF30 File Offset: 0x0002E130
			[global::Cpp2ILInjected.Token(Token = "0x6004510")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE13C", Offset = "0x7AE13C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FrozenKeyCondition()
			{
				throw null;
			}
		}

		// Token: 0x020009E6 RID: 2534
		[global::Cpp2ILInjected.Token(Token = "0x20008BC")]
		public class DesertKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F01 RID: 20225 RVA: 0x0002FF33 File Offset: 0x0002E133
			[global::Cpp2ILInjected.Token(Token = "0x6004511")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE144", Offset = "0x7AE144", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneDesert", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneBeach", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F02 RID: 20226 RVA: 0x0002FF36 File Offset: 0x0002E136
			[global::Cpp2ILInjected.Token(Token = "0x6004512")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE1E8", Offset = "0x7AE1E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F03 RID: 20227 RVA: 0x0002FF39 File Offset: 0x0002E139
			[global::Cpp2ILInjected.Token(Token = "0x6004513")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE1F0", Offset = "0x7AE1F0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F04 RID: 20228 RVA: 0x0002FF3C File Offset: 0x0002E13C
			[global::Cpp2ILInjected.Token(Token = "0x6004514")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE234", Offset = "0x7AE234", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DesertKeyCondition()
			{
				throw null;
			}
		}

		// Token: 0x020009E7 RID: 2535
		[global::Cpp2ILInjected.Token(Token = "0x20008BD")]
		public class BeatAnyMechBoss : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F05 RID: 20229 RVA: 0x0002FF3F File Offset: 0x0002E13F
			[global::Cpp2ILInjected.Token(Token = "0x6004515")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE23C", Offset = "0x7AE23C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F06 RID: 20230 RVA: 0x0002FF42 File Offset: 0x0002E142
			[global::Cpp2ILInjected.Token(Token = "0x6004516")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE294", Offset = "0x7AE294", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F07 RID: 20231 RVA: 0x0002FF45 File Offset: 0x0002E145
			[global::Cpp2ILInjected.Token(Token = "0x6004517")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE29C", Offset = "0x7AE29C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F08 RID: 20232 RVA: 0x0002FF48 File Offset: 0x0002E148
			[global::Cpp2ILInjected.Token(Token = "0x6004518")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE2E0", Offset = "0x7AE2E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public BeatAnyMechBoss()
			{
				throw null;
			}
		}

		// Token: 0x020009E8 RID: 2536
		[global::Cpp2ILInjected.Token(Token = "0x20008BE")]
		public class YoyoCascade : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F09 RID: 20233 RVA: 0x0002FF4B File Offset: 0x0002E14B
			[global::Cpp2ILInjected.Token(Token = "0x6004519")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE2E8", Offset = "0x7AE2E8", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_HasPlayerTarget", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F0A RID: 20234 RVA: 0x0002FF4E File Offset: 0x0002E14E
			[global::Cpp2ILInjected.Token(Token = "0x600451A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE408", Offset = "0x7AE408", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F0B RID: 20235 RVA: 0x0002FF51 File Offset: 0x0002E151
			[global::Cpp2ILInjected.Token(Token = "0x600451B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE410", Offset = "0x7AE410", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F0C RID: 20236 RVA: 0x0002FF54 File Offset: 0x0002E154
			[global::Cpp2ILInjected.Token(Token = "0x600451C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE454", Offset = "0x7AE454", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public YoyoCascade()
			{
				throw null;
			}
		}

		// Token: 0x020009E9 RID: 2537
		[global::Cpp2ILInjected.Token(Token = "0x20008BF")]
		public class YoyosAmarok : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F0D RID: 20237 RVA: 0x0002FF57 File Offset: 0x0002E157
			[global::Cpp2ILInjected.Token(Token = "0x600451D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE45C", Offset = "0x7AE45C", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_HasPlayerTarget", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneSnow", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F0E RID: 20238 RVA: 0x0002FF5A File Offset: 0x0002E15A
			[global::Cpp2ILInjected.Token(Token = "0x600451E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE514", Offset = "0x7AE514", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F0F RID: 20239 RVA: 0x0002FF5D File Offset: 0x0002E15D
			[global::Cpp2ILInjected.Token(Token = "0x600451F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE51C", Offset = "0x7AE51C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F10 RID: 20240 RVA: 0x0002FF60 File Offset: 0x0002E160
			[global::Cpp2ILInjected.Token(Token = "0x6004520")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE560", Offset = "0x7AE560", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public YoyosAmarok()
			{
				throw null;
			}
		}

		// Token: 0x020009EA RID: 2538
		[global::Cpp2ILInjected.Token(Token = "0x20008C0")]
		public class YoyosYelets : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F11 RID: 20241 RVA: 0x0002FF63 File Offset: 0x0002E163
			[global::Cpp2ILInjected.Token(Token = "0x6004521")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE568", Offset = "0x7AE568", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneJungle", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_HasPlayerTarget", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F12 RID: 20242 RVA: 0x0002FF66 File Offset: 0x0002E166
			[global::Cpp2ILInjected.Token(Token = "0x6004522")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE654", Offset = "0x7AE654", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F13 RID: 20243 RVA: 0x0002FF69 File Offset: 0x0002E169
			[global::Cpp2ILInjected.Token(Token = "0x6004523")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE65C", Offset = "0x7AE65C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F14 RID: 20244 RVA: 0x0002FF6C File Offset: 0x0002E16C
			[global::Cpp2ILInjected.Token(Token = "0x6004524")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE6A0", Offset = "0x7AE6A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public YoyosYelets()
			{
				throw null;
			}
		}

		// Token: 0x020009EB RID: 2539
		[global::Cpp2ILInjected.Token(Token = "0x20008C1")]
		public class YoyosKraken : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F15 RID: 20245 RVA: 0x0002FF6F File Offset: 0x0002E16F
			[global::Cpp2ILInjected.Token(Token = "0x6004525")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE6A8", Offset = "0x7AE6A8", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneDungeon", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_HasPlayerTarget", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F16 RID: 20246 RVA: 0x0002FF72 File Offset: 0x0002E172
			[global::Cpp2ILInjected.Token(Token = "0x6004526")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE794", Offset = "0x7AE794", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F17 RID: 20247 RVA: 0x0002FF75 File Offset: 0x0002E175
			[global::Cpp2ILInjected.Token(Token = "0x6004527")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE79C", Offset = "0x7AE79C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F18 RID: 20248 RVA: 0x0002FF78 File Offset: 0x0002E178
			[global::Cpp2ILInjected.Token(Token = "0x6004528")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE7E0", Offset = "0x7AE7E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public YoyosKraken()
			{
				throw null;
			}
		}

		// Token: 0x020009EC RID: 2540
		[global::Cpp2ILInjected.Token(Token = "0x20008C2")]
		public class YoyosHelFire : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F19 RID: 20249 RVA: 0x0002FF7B File Offset: 0x0002E17B
			[global::Cpp2ILInjected.Token(Token = "0x6004529")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE7E8", Offset = "0x7AE7E8", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneDungeon", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_HasPlayerTarget", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F1A RID: 20250 RVA: 0x0002FF7E File Offset: 0x0002E17E
			[global::Cpp2ILInjected.Token(Token = "0x600452A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE8FC", Offset = "0x7AE8FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F1B RID: 20251 RVA: 0x0002FF81 File Offset: 0x0002E181
			[global::Cpp2ILInjected.Token(Token = "0x600452B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE904", Offset = "0x7AE904", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F1C RID: 20252 RVA: 0x0002FF84 File Offset: 0x0002E184
			[global::Cpp2ILInjected.Token(Token = "0x600452C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE948", Offset = "0x7AE948", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public YoyosHelFire()
			{
				throw null;
			}
		}

		// Token: 0x020009ED RID: 2541
		[global::Cpp2ILInjected.Token(Token = "0x20008C3")]
		public class WindyEnoughForKiteDrops : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F1D RID: 20253 RVA: 0x0002FF87 File Offset: 0x0002E187
			[global::Cpp2ILInjected.Token(Token = "0x600452D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE950", Offset = "0x7AE950", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_WindyEnoughForKiteDrops", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F1E RID: 20254 RVA: 0x0002FF8A File Offset: 0x0002E18A
			[global::Cpp2ILInjected.Token(Token = "0x600452E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE9A0", Offset = "0x7AE9A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F1F RID: 20255 RVA: 0x0002FF8D File Offset: 0x0002E18D
			[global::Cpp2ILInjected.Token(Token = "0x600452F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE9A8", Offset = "0x7AE9A8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F20 RID: 20256 RVA: 0x0002FF90 File Offset: 0x0002E190
			[global::Cpp2ILInjected.Token(Token = "0x6004530")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE9EC", Offset = "0x7AE9EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public WindyEnoughForKiteDrops()
			{
				throw null;
			}
		}

		// Token: 0x020009EE RID: 2542
		[global::Cpp2ILInjected.Token(Token = "0x20008C4")]
		public class RemixSeedEasymode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F21 RID: 20257 RVA: 0x0002FF93 File Offset: 0x0002E193
			[global::Cpp2ILInjected.Token(Token = "0x6004531")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE9F4", Offset = "0x7AE9F4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F22 RID: 20258 RVA: 0x0002FF96 File Offset: 0x0002E196
			[global::Cpp2ILInjected.Token(Token = "0x6004532")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEA78", Offset = "0x7AEA78", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F23 RID: 20259 RVA: 0x0002FF99 File Offset: 0x0002E199
			[global::Cpp2ILInjected.Token(Token = "0x6004533")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEAFC", Offset = "0x7AEAFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F24 RID: 20260 RVA: 0x0002FF9C File Offset: 0x0002E19C
			[global::Cpp2ILInjected.Token(Token = "0x6004534")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEB04", Offset = "0x7AEB04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public RemixSeedEasymode()
			{
				throw null;
			}
		}

		// Token: 0x020009EF RID: 2543
		[global::Cpp2ILInjected.Token(Token = "0x20008C5")]
		public class RemixSeedHardmode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F25 RID: 20261 RVA: 0x0002FF9F File Offset: 0x0002E19F
			[global::Cpp2ILInjected.Token(Token = "0x6004535")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEB0C", Offset = "0x7AEB0C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F26 RID: 20262 RVA: 0x0002FFA2 File Offset: 0x0002E1A2
			[global::Cpp2ILInjected.Token(Token = "0x6004536")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEB90", Offset = "0x7AEB90", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F27 RID: 20263 RVA: 0x0002FFA5 File Offset: 0x0002E1A5
			[global::Cpp2ILInjected.Token(Token = "0x6004537")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEC14", Offset = "0x7AEC14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F28 RID: 20264 RVA: 0x0002FFA8 File Offset: 0x0002E1A8
			[global::Cpp2ILInjected.Token(Token = "0x6004538")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEC1C", Offset = "0x7AEC1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public RemixSeedHardmode()
			{
				throw null;
			}
		}

		// Token: 0x020009F0 RID: 2544
		[global::Cpp2ILInjected.Token(Token = "0x20008C6")]
		public class RemixSeed : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F29 RID: 20265 RVA: 0x0002FFAB File Offset: 0x0002E1AB
			[global::Cpp2ILInjected.Token(Token = "0x6004539")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEC24", Offset = "0x7AEC24", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F2A RID: 20266 RVA: 0x0002FFAE File Offset: 0x0002E1AE
			[global::Cpp2ILInjected.Token(Token = "0x600453A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEC7C", Offset = "0x7AEC7C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F2B RID: 20267 RVA: 0x0002FFB1 File Offset: 0x0002E1B1
			[global::Cpp2ILInjected.Token(Token = "0x600453B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AECD4", Offset = "0x7AECD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F2C RID: 20268 RVA: 0x0002FFB4 File Offset: 0x0002E1B4
			[global::Cpp2ILInjected.Token(Token = "0x600453C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AECDC", Offset = "0x7AECDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public RemixSeed()
			{
				throw null;
			}
		}

		// Token: 0x020009F1 RID: 2545
		[global::Cpp2ILInjected.Token(Token = "0x20008C7")]
		public class NotRemixSeed : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F2D RID: 20269 RVA: 0x0002FFB7 File Offset: 0x0002E1B7
			[global::Cpp2ILInjected.Token(Token = "0x600453D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AECE4", Offset = "0x7AECE4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F2E RID: 20270 RVA: 0x0002FFBA File Offset: 0x0002E1BA
			[global::Cpp2ILInjected.Token(Token = "0x600453E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AED44", Offset = "0x7AED44", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F2F RID: 20271 RVA: 0x0002FFBD File Offset: 0x0002E1BD
			[global::Cpp2ILInjected.Token(Token = "0x600453F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEDA4", Offset = "0x7AEDA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F30 RID: 20272 RVA: 0x0002FFC0 File Offset: 0x0002E1C0
			[global::Cpp2ILInjected.Token(Token = "0x6004540")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEDAC", Offset = "0x7AEDAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NotRemixSeed()
			{
				throw null;
			}
		}

		// Token: 0x020009F2 RID: 2546
		[global::Cpp2ILInjected.Token(Token = "0x20008C8")]
		public class TenthAnniversaryIsUp : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F31 RID: 20273 RVA: 0x0002FFC3 File Offset: 0x0002E1C3
			[global::Cpp2ILInjected.Token(Token = "0x6004541")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEDB4", Offset = "0x7AEDB4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F32 RID: 20274 RVA: 0x0002FFC6 File Offset: 0x0002E1C6
			[global::Cpp2ILInjected.Token(Token = "0x6004542")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEE0C", Offset = "0x7AEE0C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F33 RID: 20275 RVA: 0x0002FFC9 File Offset: 0x0002E1C9
			[global::Cpp2ILInjected.Token(Token = "0x6004543")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEE64", Offset = "0x7AEE64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F34 RID: 20276 RVA: 0x0002FFCC File Offset: 0x0002E1CC
			[global::Cpp2ILInjected.Token(Token = "0x6004544")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEE6C", Offset = "0x7AEE6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TenthAnniversaryIsUp()
			{
				throw null;
			}
		}

		// Token: 0x020009F3 RID: 2547
		[global::Cpp2ILInjected.Token(Token = "0x20008C9")]
		public class TenthAnniversaryIsNotUp : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F35 RID: 20277 RVA: 0x0002FFCF File Offset: 0x0002E1CF
			[global::Cpp2ILInjected.Token(Token = "0x6004545")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEE74", Offset = "0x7AEE74", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F36 RID: 20278 RVA: 0x0002FFD2 File Offset: 0x0002E1D2
			[global::Cpp2ILInjected.Token(Token = "0x6004546")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEED4", Offset = "0x7AEED4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F37 RID: 20279 RVA: 0x0002FFD5 File Offset: 0x0002E1D5
			[global::Cpp2ILInjected.Token(Token = "0x6004547")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEF34", Offset = "0x7AEF34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F38 RID: 20280 RVA: 0x0002FFD8 File Offset: 0x0002E1D8
			[global::Cpp2ILInjected.Token(Token = "0x6004548")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEF3C", Offset = "0x7AEF3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TenthAnniversaryIsNotUp()
			{
				throw null;
			}
		}

		// Token: 0x020009F4 RID: 2548
		[global::Cpp2ILInjected.Token(Token = "0x20008CA")]
		public class DontStarveIsUp : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F39 RID: 20281 RVA: 0x0002FFDB File Offset: 0x0002E1DB
			[global::Cpp2ILInjected.Token(Token = "0x6004549")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEF44", Offset = "0x7AEF44", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F3A RID: 20282 RVA: 0x0002FFDE File Offset: 0x0002E1DE
			[global::Cpp2ILInjected.Token(Token = "0x600454A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEF9C", Offset = "0x7AEF9C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F3B RID: 20283 RVA: 0x0002FFE1 File Offset: 0x0002E1E1
			[global::Cpp2ILInjected.Token(Token = "0x600454B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEFF4", Offset = "0x7AEFF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F3C RID: 20284 RVA: 0x0002FFE4 File Offset: 0x0002E1E4
			[global::Cpp2ILInjected.Token(Token = "0x600454C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEFFC", Offset = "0x7AEFFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DontStarveIsUp()
			{
				throw null;
			}
		}

		// Token: 0x020009F5 RID: 2549
		[global::Cpp2ILInjected.Token(Token = "0x20008CB")]
		public class DontStarveIsNotUp : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			// Token: 0x06004F3D RID: 20285 RVA: 0x0002FFE7 File Offset: 0x0002E1E7
			[global::Cpp2ILInjected.Token(Token = "0x600454D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AF004", Offset = "0x7AF004", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			// Token: 0x06004F3E RID: 20286 RVA: 0x0002FFEA File Offset: 0x0002E1EA
			[global::Cpp2ILInjected.Token(Token = "0x600454E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AF064", Offset = "0x7AF064", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			// Token: 0x06004F3F RID: 20287 RVA: 0x0002FFED File Offset: 0x0002E1ED
			[global::Cpp2ILInjected.Token(Token = "0x600454F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AF0C4", Offset = "0x7AF0C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			// Token: 0x06004F40 RID: 20288 RVA: 0x0002FFF0 File Offset: 0x0002E1F0
			[global::Cpp2ILInjected.Token(Token = "0x6004550")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AF0CC", Offset = "0x7AF0CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DontStarveIsNotUp()
			{
				throw null;
			}
		}
	}
}
