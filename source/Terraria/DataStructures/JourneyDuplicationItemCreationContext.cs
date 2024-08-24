using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.DataStructures
{
	// Token: 0x02000438 RID: 1080
	[global::Cpp2ILInjected.Token(Token = "0x2000633")]
	public class JourneyDuplicationItemCreationContext : ItemCreationContext
	{
		// Token: 0x0600310C RID: 12556 RVA: 0x0002AC56 File Offset: 0x00028E56
		[global::Cpp2ILInjected.Token(Token = "0x6003629")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DCB9C", Offset = "0x13DCB9C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "OverrideLeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "PickupItemIntoMouse", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public JourneyDuplicationItemCreationContext()
		{
			throw null;
		}
	}
}
