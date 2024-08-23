using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005CE RID: 1486
	[global::Cpp2ILInjected.Token(Token = "0x200087A")]
	public class DropLocalPerClientAndResetsNPCMoneyTo0 : CommonDrop
	{
		// Token: 0x06003C83 RID: 15491 RVA: 0x0002CCD5 File Offset: 0x0002AED5
		[global::Cpp2ILInjected.Token(Token = "0x60043F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6518", Offset = "0x7A6518", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public DropLocalPerClientAndResetsNPCMoneyTo0(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum, IItemDropRuleCondition optionalCondition)
		{
			throw null;
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x0002CCD8 File Offset: 0x0002AED8
		[global::Cpp2ILInjected.Token(Token = "0x60043F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A817C", Offset = "0x7A817C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x0002CCDB File Offset: 0x0002AEDB
		[global::Cpp2ILInjected.Token(Token = "0x60043F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A824C", Offset = "0x7A824C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonCode), Member = "DropItemLocalPerClientAndSetNPCMoneyTo0", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		// Token: 0x04006BA0 RID: 27552
		[global::Cpp2ILInjected.Token(Token = "0x40081C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public IItemDropRuleCondition condition;
	}
}
