using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200062B RID: 1579
	[global::Cpp2ILInjected.Token(Token = "0x200094E")]
	public class CritterUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
	{
		// Token: 0x06003EA0 RID: 16032 RVA: 0x0002D2E4 File Offset: 0x0002B4E4
		[global::Cpp2ILInjected.Token(Token = "0x60047B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x81A7BC", Offset = "0x81A7BC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CritterUICollectionInfoProvider(string persistentId)
		{
			throw null;
		}

		// Token: 0x06003EA1 RID: 16033 RVA: 0x0002D2E7 File Offset: 0x0002B4E7
		[global::Cpp2ILInjected.Token(Token = "0x60047B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x81BC44", Offset = "0x81BC44", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCWasNearPlayerTracker), Member = "GetWasNearbyBefore", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BestiaryUICollectionInfo GetEntryUICollectionInfo()
		{
			throw null;
		}

		// Token: 0x06003EA2 RID: 16034 RVA: 0x0002D2EA File Offset: 0x0002B4EA
		[global::Cpp2ILInjected.Token(Token = "0x60047B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x81BCD0", Offset = "0x81BCD0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x04006C62 RID: 27746
		[global::Cpp2ILInjected.Token(Token = "0x4008381")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _persistentIdentifierToCheck;
	}
}
