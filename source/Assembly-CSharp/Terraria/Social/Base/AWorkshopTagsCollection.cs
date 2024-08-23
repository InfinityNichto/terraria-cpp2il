using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Steam;

namespace Terraria.Social.Base
{
	// Token: 0x0200038D RID: 909
	[global::Cpp2ILInjected.Token(Token = "0x2000528")]
	public abstract class AWorkshopTagsCollection
	{
		// Token: 0x06002D65 RID: 11621 RVA: 0x0002A21E File Offset: 0x0002841E
		[global::Cpp2ILInjected.Token(Token = "0x60031BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A868", Offset = "0x132A868", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedWorkshopTags), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected void AddWorldTag(string tagNameKey, string tagInternalName)
		{
			throw null;
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x0002A221 File Offset: 0x00028421
		[global::Cpp2ILInjected.Token(Token = "0x60031BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A97C", Offset = "0x132A97C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedWorkshopTags), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected void AddResourcePackTag(string tagNameKey, string tagInternalName)
		{
			throw null;
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x0002A224 File Offset: 0x00028424
		[global::Cpp2ILInjected.Token(Token = "0x60031C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x132AA64", Offset = "0x132AA64", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SupportedWorkshopTags), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected AWorkshopTagsCollection()
		{
			throw null;
		}

		// Token: 0x040031D1 RID: 12753
		[global::Cpp2ILInjected.Token(Token = "0x4003B5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly List<WorkshopTagOption> WorldTags;

		// Token: 0x040031D2 RID: 12754
		[global::Cpp2ILInjected.Token(Token = "0x4003B5D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly List<WorkshopTagOption> ResourcePackTags;
	}
}
