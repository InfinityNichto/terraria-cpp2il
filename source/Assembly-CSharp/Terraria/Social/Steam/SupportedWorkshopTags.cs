using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Base;

namespace Terraria.Social.Steam
{
	// Token: 0x02000384 RID: 900
	[global::Cpp2ILInjected.Token(Token = "0x2000513")]
	public class SupportedWorkshopTags : AWorkshopTagsCollection
	{
		// Token: 0x06002D21 RID: 11553 RVA: 0x0002A182 File Offset: 0x00028382
		[global::Cpp2ILInjected.Token(Token = "0x600315A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304848", Offset = "0x1304848", Length = "0x5F4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AWorkshopTagsCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AWorkshopTagsCollection), Member = "AddWorldTag", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AWorkshopTagsCollection), Member = "AddResourcePackTag", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 48)]
		public SupportedWorkshopTags()
		{
			throw null;
		}
	}
}
