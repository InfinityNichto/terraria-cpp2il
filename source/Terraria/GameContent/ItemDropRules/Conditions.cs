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
	[global::Cpp2ILInjected.Token(Token = "0x200088F")]
	public class Conditions
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600445F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AB94C", Offset = "0x7AB94C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Conditions()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000890")]
		public class NeverTrue : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004460")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB954", Offset = "0x7AB954", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004461")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB95C", Offset = "0x7AB95C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004462")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB964", Offset = "0x7AB964", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004463")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB96C", Offset = "0x7AB96C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NeverTrue()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000891")]
		public class IsUsingSpecificAIValues : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004464")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB974", Offset = "0x7AB974", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsUsingSpecificAIValues(int aislot, float valueToMatch)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004465")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB9AC", Offset = "0x7AB9AC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004466")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB9D0", Offset = "0x7AB9D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004467")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AB9D8", Offset = "0x7AB9D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40081F6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int aiSlotToCheck;

			[global::Cpp2ILInjected.Token(Token = "0x40081F7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public float valueToMatch;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000892")]
		public class FrostMoonDropGatingChance : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004469")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABB0C", Offset = "0x7ABB0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600446A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABB14", Offset = "0x7ABB14", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600446B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABB58", Offset = "0x7ABB58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FrostMoonDropGatingChance()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000893")]
		public class PumpkinMoonDropGatingChance : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600446D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABC88", Offset = "0x7ABC88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600446E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABC90", Offset = "0x7ABC90", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600446F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABCD4", Offset = "0x7ABCD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PumpkinMoonDropGatingChance()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000894")]
		public class FrostMoonDropGateForTrophies : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004471")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABE08", Offset = "0x7ABE08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004472")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABE10", Offset = "0x7ABE10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004473")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABE18", Offset = "0x7ABE18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FrostMoonDropGateForTrophies()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000895")]
		public class PumpkinMoonDropGateForTrophies : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004475")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABF4C", Offset = "0x7ABF4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004476")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABF54", Offset = "0x7ABF54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004477")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABF5C", Offset = "0x7ABF5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PumpkinMoonDropGateForTrophies()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000896")]
		public class IsPumpkinMoon : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004478")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABF64", Offset = "0x7ABF64", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004479")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABFBC", Offset = "0x7ABFBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600447A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABFC4", Offset = "0x7ABFC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600447B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABFCC", Offset = "0x7ABFCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsPumpkinMoon()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000897")]
		public class FromCertainWaveAndAbove : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x600447C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABFD4", Offset = "0x7ABFD4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FromCertainWaveAndAbove(int neededWave)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600447D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ABFFC", Offset = "0x7ABFFC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600447E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC064", Offset = "0x7AC064", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40081F8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int neededWave;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000898")]
		public class IsBloodMoonAndNotFromStatue : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004480")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC0F0", Offset = "0x7AC0F0", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004481")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC18C", Offset = "0x7AC18C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004482")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC194", Offset = "0x7AC194", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004483")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC19C", Offset = "0x7AC19C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsBloodMoonAndNotFromStatue()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000899")]
		public class DownedAllMechBosses : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004484")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC1A4", Offset = "0x7AC1A4", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004485")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC244", Offset = "0x7AC244", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004486")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC24C", Offset = "0x7AC24C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004487")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC254", Offset = "0x7AC254", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DownedAllMechBosses()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x200089A")]
		public class DownedPlantera : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004488")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC25C", Offset = "0x7AC25C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004489")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC2B4", Offset = "0x7AC2B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600448A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC2BC", Offset = "0x7AC2BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600448B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC2C4", Offset = "0x7AC2C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DownedPlantera()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x200089B")]
		public class IsHardmode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x600448C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC2CC", Offset = "0x7AC2CC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600448D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC324", Offset = "0x7AC324", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600448E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC32C", Offset = "0x7AC32C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600448F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC334", Offset = "0x7AC334", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsHardmode()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x200089C")]
		public class FirstTimeKillingPlantera : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004490")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC33C", Offset = "0x7AC33C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004491")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC39C", Offset = "0x7AC39C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004492")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC3A4", Offset = "0x7AC3A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004493")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC3AC", Offset = "0x7AC3AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FirstTimeKillingPlantera()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x200089D")]
		public class MechanicalBossesDummyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004494")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC3B4", Offset = "0x7AC3B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004495")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC3BC", Offset = "0x7AC3BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004496")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC3C4", Offset = "0x7AC3C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

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

		[global::Cpp2ILInjected.Token(Token = "0x200089E")]
		public class PirateMap : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004499")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC510", Offset = "0x7AC510", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600449A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC518", Offset = "0x7AC518", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600449B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC55C", Offset = "0x7AC55C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PirateMap()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x200089F")]
		public class IsChristmas : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x600449C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC564", Offset = "0x7AC564", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600449D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC5BC", Offset = "0x7AC5BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600449E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC5C4", Offset = "0x7AC5C4", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600449F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC608", Offset = "0x7AC608", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsChristmas()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008A0")]
		public class NotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60044A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC6C8", Offset = "0x7AC6C8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

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

		[global::Cpp2ILInjected.Token(Token = "0x20008A1")]
		public class NotMasterMode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60044A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC7CC", Offset = "0x7AC7CC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

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

		[global::Cpp2ILInjected.Token(Token = "0x20008A2")]
		public class MissingTwin : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60044A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC890", Offset = "0x7AC890", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC898", Offset = "0x7AC898", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC8A0", Offset = "0x7AC8A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public MissingTwin()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008A3")]
		public class EmpressOfLightIsGenuinelyEnraged : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC8A8", Offset = "0x7AC8A8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AI_120_HallowBoss_IsGenuinelyEnraged", ReturnType = typeof(bool))]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC8B4", Offset = "0x7AC8B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC8BC", Offset = "0x7AC8BC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC900", Offset = "0x7AC900", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public EmpressOfLightIsGenuinelyEnraged()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008A4")]
		public class PlayerNeedsHealing : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC908", Offset = "0x7AC908", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC920", Offset = "0x7AC920", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC928", Offset = "0x7AC928", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AC96C", Offset = "0x7AC96C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PlayerNeedsHealing()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008A5")]
		public class MechdusaKill : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60044B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACACC", Offset = "0x7ACACC", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACB50", Offset = "0x7ACB50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACB58", Offset = "0x7ACB58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public MechdusaKill()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40081F9")]
			private static int[] _targetList;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008A6")]
		public class LegacyHack_IsBossAndExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACBF4", Offset = "0x7ACBF4", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACC64", Offset = "0x7ACC64", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACCB4", Offset = "0x7ACCB4", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACCF8", Offset = "0x7ACCF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public LegacyHack_IsBossAndExpert()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008A7")]
		public class LegacyHack_IsBossAndNotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACD00", Offset = "0x7ACD00", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x60044BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACDC8", Offset = "0x7ACDC8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACE0C", Offset = "0x7ACE0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public LegacyHack_IsBossAndNotExpert()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008A8")]
		public class LegacyHack_IsABoss : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACE14", Offset = "0x7ACE14", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACE20", Offset = "0x7ACE20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACE28", Offset = "0x7ACE28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACE30", Offset = "0x7ACE30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public LegacyHack_IsABoss()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008A9")]
		public class IsExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACE38", Offset = "0x7ACE38", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACE88", Offset = "0x7ACE88", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

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

		[global::Cpp2ILInjected.Token(Token = "0x20008AA")]
		public class IsMasterMode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACF6C", Offset = "0x7ACF6C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_masterMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ACFBC", Offset = "0x7ACFBC", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_masterMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD00C", Offset = "0x7AD00C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

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

		[global::Cpp2ILInjected.Token(Token = "0x20008AB")]
		public class IsCrimson : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD058", Offset = "0x7AD058", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD0B0", Offset = "0x7AD0B0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD108", Offset = "0x7AD108", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD14C", Offset = "0x7AD14C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsCrimson()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008AC")]
		public class IsCorruption : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD154", Offset = "0x7AD154", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD1B4", Offset = "0x7AD1B4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD214", Offset = "0x7AD214", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD258", Offset = "0x7AD258", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsCorruption()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008AD")]
		public class IsCrimsonAndNotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD260", Offset = "0x7AD260", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD2F0", Offset = "0x7AD2F0", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD380", Offset = "0x7AD380", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD3C4", Offset = "0x7AD3C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsCrimsonAndNotExpert()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008AE")]
		public class IsCorruptionAndNotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD3CC", Offset = "0x7AD3CC", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD464", Offset = "0x7AD464", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_expertMode", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD4FC", Offset = "0x7AD4FC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD540", Offset = "0x7AD540", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public IsCorruptionAndNotExpert()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008AF")]
		public class HalloweenWeapons : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD548", Offset = "0x7AD548", Length = "0x1A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD6E8", Offset = "0x7AD6E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD6F0", Offset = "0x7AD6F0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD734", Offset = "0x7AD734", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public HalloweenWeapons()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008B0")]
		public class SoulOfNight : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60044E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD798", Offset = "0x7AD798", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD7A0", Offset = "0x7AD7A0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD7E4", Offset = "0x7AD7E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SoulOfNight()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008B1")]
		public class SoulOfLight : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD7EC", Offset = "0x7AD7EC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions), Member = "SoulOfWhateverConditionCanDrop", MemberParameters = new object[] { typeof(DropAttemptInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneHallow", ReturnType = typeof(bool))]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD830", Offset = "0x7AD830", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD838", Offset = "0x7AD838", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD87C", Offset = "0x7AD87C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SoulOfLight()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008B2")]
		public class NotFromStatue : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD884", Offset = "0x7AD884", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD898", Offset = "0x7AD898", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD8A0", Offset = "0x7AD8A0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

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

		[global::Cpp2ILInjected.Token(Token = "0x20008B3")]
		public class HalloweenGoodieBagDrop : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD8EC", Offset = "0x7AD8EC", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD9A8", Offset = "0x7AD9A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD9B0", Offset = "0x7AD9B0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD9F4", Offset = "0x7AD9F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public HalloweenGoodieBagDrop()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008B4")]
		public class XmasPresentDrop : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AD9FC", Offset = "0x7AD9FC", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADAB8", Offset = "0x7ADAB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADAC0", Offset = "0x7ADAC0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADB04", Offset = "0x7ADB04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public XmasPresentDrop()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008B5")]
		public class LivingFlames : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60044F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADBE0", Offset = "0x7ADBE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADBE8", Offset = "0x7ADBE8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADC2C", Offset = "0x7ADC2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public LivingFlames()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008B6")]
		public class NamedNPC : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x60044F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADC34", Offset = "0x7ADC34", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NamedNPC(string neededName)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x60044FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADC84", Offset = "0x7ADC84", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADC8C", Offset = "0x7ADC8C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40081FA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string neededName;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008B7")]
		public class HallowKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60044FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADD60", Offset = "0x7ADD60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60044FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADD68", Offset = "0x7ADD68", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004500")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADDAC", Offset = "0x7ADDAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public HallowKeyCondition()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008B8")]
		public class JungleKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004502")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADE44", Offset = "0x7ADE44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004503")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADE4C", Offset = "0x7ADE4C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004504")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADE90", Offset = "0x7ADE90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public JungleKeyCondition()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008B9")]
		public class CorruptKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004506")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADF28", Offset = "0x7ADF28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004507")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADF30", Offset = "0x7ADF30", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004508")]
			[global::Cpp2ILInjected.Address(RVA = "0x7ADF74", Offset = "0x7ADF74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CorruptKeyCondition()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008BA")]
		public class CrimsonKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600450A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE00C", Offset = "0x7AE00C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600450B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE014", Offset = "0x7AE014", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600450C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE058", Offset = "0x7AE058", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CrimsonKeyCondition()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008BB")]
		public class FrozenKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600450E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE0F0", Offset = "0x7AE0F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600450F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE0F8", Offset = "0x7AE0F8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004510")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE13C", Offset = "0x7AE13C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FrozenKeyCondition()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008BC")]
		public class DesertKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004512")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE1E8", Offset = "0x7AE1E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004513")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE1F0", Offset = "0x7AE1F0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004514")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE234", Offset = "0x7AE234", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DesertKeyCondition()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008BD")]
		public class BeatAnyMechBoss : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004515")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE23C", Offset = "0x7AE23C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004516")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE294", Offset = "0x7AE294", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004517")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE29C", Offset = "0x7AE29C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004518")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE2E0", Offset = "0x7AE2E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public BeatAnyMechBoss()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008BE")]
		public class YoyoCascade : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600451A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE408", Offset = "0x7AE408", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600451B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE410", Offset = "0x7AE410", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600451C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE454", Offset = "0x7AE454", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public YoyoCascade()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008BF")]
		public class YoyosAmarok : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600451E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE514", Offset = "0x7AE514", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600451F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE51C", Offset = "0x7AE51C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004520")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE560", Offset = "0x7AE560", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public YoyosAmarok()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008C0")]
		public class YoyosYelets : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004522")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE654", Offset = "0x7AE654", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004523")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE65C", Offset = "0x7AE65C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004524")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE6A0", Offset = "0x7AE6A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public YoyosYelets()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008C1")]
		public class YoyosKraken : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004526")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE794", Offset = "0x7AE794", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004527")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE79C", Offset = "0x7AE79C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004528")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE7E0", Offset = "0x7AE7E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public YoyosKraken()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008C2")]
		public class YoyosHelFire : IItemDropRuleCondition, IProvideItemConditionDescription
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600452A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE8FC", Offset = "0x7AE8FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600452B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE904", Offset = "0x7AE904", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600452C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE948", Offset = "0x7AE948", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public YoyosHelFire()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008C3")]
		public class WindyEnoughForKiteDrops : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x600452D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE950", Offset = "0x7AE950", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_WindyEnoughForKiteDrops", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600452E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE9A0", Offset = "0x7AE9A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600452F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE9A8", Offset = "0x7AE9A8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004530")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE9EC", Offset = "0x7AE9EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public WindyEnoughForKiteDrops()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008C4")]
		public class RemixSeedEasymode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004531")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AE9F4", Offset = "0x7AE9F4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004532")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEA78", Offset = "0x7AEA78", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004533")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEAFC", Offset = "0x7AEAFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004534")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEB04", Offset = "0x7AEB04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public RemixSeedEasymode()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008C5")]
		public class RemixSeedHardmode : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004535")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEB0C", Offset = "0x7AEB0C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004536")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEB90", Offset = "0x7AEB90", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004537")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEC14", Offset = "0x7AEC14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004538")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEC1C", Offset = "0x7AEC1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public RemixSeedHardmode()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008C6")]
		public class RemixSeed : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004539")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEC24", Offset = "0x7AEC24", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600453A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEC7C", Offset = "0x7AEC7C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600453B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AECD4", Offset = "0x7AECD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600453C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AECDC", Offset = "0x7AECDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public RemixSeed()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008C7")]
		public class NotRemixSeed : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x600453D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AECE4", Offset = "0x7AECE4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600453E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AED44", Offset = "0x7AED44", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600453F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEDA4", Offset = "0x7AEDA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004540")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEDAC", Offset = "0x7AEDAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NotRemixSeed()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008C8")]
		public class TenthAnniversaryIsUp : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004541")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEDB4", Offset = "0x7AEDB4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004542")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEE0C", Offset = "0x7AEE0C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004543")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEE64", Offset = "0x7AEE64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004544")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEE6C", Offset = "0x7AEE6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TenthAnniversaryIsUp()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008C9")]
		public class TenthAnniversaryIsNotUp : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004545")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEE74", Offset = "0x7AEE74", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004546")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEED4", Offset = "0x7AEED4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004547")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEF34", Offset = "0x7AEF34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004548")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEF3C", Offset = "0x7AEF3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TenthAnniversaryIsNotUp()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008CA")]
		public class DontStarveIsUp : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004549")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEF44", Offset = "0x7AEF44", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600454A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEF9C", Offset = "0x7AEF9C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600454B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEFF4", Offset = "0x7AEFF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600454C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AEFFC", Offset = "0x7AEFFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DontStarveIsUp()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008CB")]
		public class DontStarveIsNotUp : IItemDropRuleCondition, IProvideItemConditionDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x600454D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AF004", Offset = "0x7AF004", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanDrop(DropAttemptInfo info)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600454E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AF064", Offset = "0x7AF064", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanShowItemDropInUI()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600454F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AF0C4", Offset = "0x7AF0C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public string GetConditionDescription()
			{
				throw null;
			}

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
