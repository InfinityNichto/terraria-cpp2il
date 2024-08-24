using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Content;
using Terraria.Localization;

namespace Terraria.GameContent
{
	// Token: 0x02000573 RID: 1395
	[global::Cpp2ILInjected.Token(Token = "0x200080A")]
	public class ContentRejectionFromSize : IRejectionReason
	{
		// Token: 0x06003AC3 RID: 15043 RVA: 0x0002C7E0 File Offset: 0x0002A9E0
		[global::Cpp2ILInjected.Token(Token = "0x60041DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x784404", Offset = "0x784404", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ContentRejectionFromSize(int neededWidth, int neededHeight, int actualWidth, int actualHeight)
		{
			throw null;
		}

		// Token: 0x06003AC4 RID: 15044 RVA: 0x0002C7E3 File Offset: 0x0002A9E3
		[global::Cpp2ILInjected.Token(Token = "0x60041DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x7844E4", Offset = "0x7844E4", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType7<, , , >), Member = ".ctor", MemberParameters = new object[] { "<NeededWidth>j__TPar", "<NeededHeight>j__TPar", "<ActualWidth>j__TPar", "<ActualHeight>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public string GetReason()
		{
			throw null;
		}

		// Token: 0x04006AC5 RID: 27333
		[global::Cpp2ILInjected.Token(Token = "0x40080A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _neededWidth;

		// Token: 0x04006AC6 RID: 27334
		[global::Cpp2ILInjected.Token(Token = "0x40080A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _neededHeight;

		// Token: 0x04006AC7 RID: 27335
		[global::Cpp2ILInjected.Token(Token = "0x40080A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _actualWidth;

		// Token: 0x04006AC8 RID: 27336
		[global::Cpp2ILInjected.Token(Token = "0x40080A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _actualHeight;
	}
}
