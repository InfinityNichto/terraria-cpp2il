using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x020005CD RID: 1485
	[global::Cpp2ILInjected.Token(Token = "0x2000879")]
	public class CommonDropNotScalingWithLuck : CommonDrop
	{
		// Token: 0x06003C81 RID: 15489 RVA: 0x0002CCCF File Offset: 0x0002AECF
		[global::Cpp2ILInjected.Token(Token = "0x60043EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6B10", Offset = "0x7A6B10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterDD2EventDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public CommonDropNotScalingWithLuck(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum)
		{
			throw null;
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x0002CCD2 File Offset: 0x0002AED2
		[global::Cpp2ILInjected.Token(Token = "0x60043F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A8100", Offset = "0x7A8100", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonCode), Member = "DropItemFromNPC", MemberParameters = new object[]
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
	}
}
