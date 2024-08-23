using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200062C RID: 1580
	[global::Cpp2ILInjected.Token(Token = "0x200094F")]
	public class TownNPCUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
	{
		// Token: 0x06003EA3 RID: 16035 RVA: 0x0002D2ED File Offset: 0x0002B4ED
		[global::Cpp2ILInjected.Token(Token = "0x60047B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x81A260", Offset = "0x81A260", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TownNPCUICollectionInfoProvider(string persistentId)
		{
			throw null;
		}

		// Token: 0x06003EA4 RID: 16036 RVA: 0x0002D2F0 File Offset: 0x0002B4F0
		[global::Cpp2ILInjected.Token(Token = "0x60047B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x81BCD8", Offset = "0x81BCD8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasChatWithTracker), Member = "GetWasChatWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			throw null;
		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x0002D2F3 File Offset: 0x0002B4F3
		[global::Cpp2ILInjected.Token(Token = "0x60047B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x81BD64", Offset = "0x81BD64", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x04006C63 RID: 27747
		[global::Cpp2ILInjected.Token(Token = "0x4008382")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _persistentIdentifierToCheck;
	}
}
