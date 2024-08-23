using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005CF RID: 1487
	[global::Cpp2ILInjected.Token(Token = "0x200087B")]
	public class DropPerPlayerOnThePlayer : CommonDrop
	{
		// Token: 0x06003C86 RID: 15494 RVA: 0x0002CCDE File Offset: 0x0002AEDE
		[global::Cpp2ILInjected.Token(Token = "0x60043F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A69A4", Offset = "0x7A69A4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public DropPerPlayerOnThePlayer(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum, IItemDropRuleCondition optionalCondition)
		{
			throw null;
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x0002CCE1 File Offset: 0x0002AEE1
		[global::Cpp2ILInjected.Token(Token = "0x60043F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A82C8", Offset = "0x7A82C8", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x0002CCE4 File Offset: 0x0002AEE4
		[global::Cpp2ILInjected.Token(Token = "0x60043F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A8398", Offset = "0x7A8398", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonCode), Member = "DropItemForEachInteractingPlayerOnThePlayer", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(UnifiedRandom),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x04006BA1 RID: 27553
		[global::Cpp2ILInjected.Token(Token = "0x40081C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public IItemDropRuleCondition condition;
	}
}
