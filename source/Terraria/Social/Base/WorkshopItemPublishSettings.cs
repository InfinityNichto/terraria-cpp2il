using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Base
{
	// Token: 0x0200039A RID: 922
	[global::Cpp2ILInjected.Token(Token = "0x2000537")]
	public class WorkshopItemPublishSettings
	{
		// Token: 0x06002DC4 RID: 11716 RVA: 0x0002A2BD File Offset: 0x000284BD
		[global::Cpp2ILInjected.Token(Token = "0x6003220")]
		[global::Cpp2ILInjected.Address(RVA = "0x132BE28", Offset = "0x132BE28", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToArray", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "TSource[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public string[] GetUsedTagsInternalNames()
		{
			throw null;
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x0002A2C0 File Offset: 0x000284C0
		[global::Cpp2ILInjected.Token(Token = "0x6003221")]
		[global::Cpp2ILInjected.Address(RVA = "0x132BF40", Offset = "0x132BF40", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public WorkshopItemPublishSettings()
		{
			throw null;
		}

		// Token: 0x040031E5 RID: 12773
		[global::Cpp2ILInjected.Token(Token = "0x4003B78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public WorkshopTagOption[] UsedTags;

		// Token: 0x040031E6 RID: 12774
		[global::Cpp2ILInjected.Token(Token = "0x4003B79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public WorkshopItemPublicSettingId Publicity;

		// Token: 0x040031E7 RID: 12775
		[global::Cpp2ILInjected.Token(Token = "0x4003B7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public string PreviewImagePath;

		// Token: 0x020008ED RID: 2285
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000538")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004C07 RID: 19463 RVA: 0x0002F74A File Offset: 0x0002D94A
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003222")]
			[global::Cpp2ILInjected.Address(RVA = "0x132BF98", Offset = "0x132BF98", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004C08 RID: 19464 RVA: 0x0002F74D File Offset: 0x0002D94D
			[global::Cpp2ILInjected.Token(Token = "0x6003223")]
			[global::Cpp2ILInjected.Address(RVA = "0x132BFF4", Offset = "0x132BFF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004C09 RID: 19465 RVA: 0x0002F750 File Offset: 0x0002D950
			[global::Cpp2ILInjected.Token(Token = "0x6003224")]
			[global::Cpp2ILInjected.Address(RVA = "0x132BFFC", Offset = "0x132BFFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal string <GetUsedTagsInternalNames>b__3_0(WorkshopTagOption x)
			{
				throw null;
			}

			// Token: 0x04008136 RID: 33078
			[global::Cpp2ILInjected.Token(Token = "0x4003B7B")]
			public static readonly WorkshopItemPublishSettings.<>c <>9;

			// Token: 0x04008137 RID: 33079
			[global::Cpp2ILInjected.Token(Token = "0x4003B7C")]
			public static Func<WorkshopTagOption, string> <>9__3_0;
		}
	}
}
