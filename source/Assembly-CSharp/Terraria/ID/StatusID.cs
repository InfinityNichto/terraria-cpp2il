using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Reflection;

namespace Terraria.ID
{
	// Token: 0x02000404 RID: 1028
	[global::Cpp2ILInjected.Token(Token = "0x20005F3")]
	public class StatusID
	{
		// Token: 0x0600308B RID: 12427 RVA: 0x0002AAEB File Offset: 0x00028CEB
		[global::Cpp2ILInjected.Token(Token = "0x600359B")]
		[global::Cpp2ILInjected.Address(RVA = "0x13D5080", Offset = "0x13D5080", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public StatusID()
		{
			throw null;
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x0002AAEE File Offset: 0x00028CEE
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600359C")]
		[global::Cpp2ILInjected.Address(RVA = "0x13D5088", Offset = "0x13D5088", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary[]), Member = "Create", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(IdDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static StatusID()
		{
			throw null;
		}

		// Token: 0x04005C60 RID: 23648
		[global::Cpp2ILInjected.Token(Token = "0x4006FA8")]
		public const int Ok = 0;

		// Token: 0x04005C61 RID: 23649
		[global::Cpp2ILInjected.Token(Token = "0x4006FA9")]
		public const int LaterVersion = 1;

		// Token: 0x04005C62 RID: 23650
		[global::Cpp2ILInjected.Token(Token = "0x4006FAA")]
		public const int UnknownError = 2;

		// Token: 0x04005C63 RID: 23651
		[global::Cpp2ILInjected.Token(Token = "0x4006FAB")]
		public const int EmptyFile = 3;

		// Token: 0x04005C64 RID: 23652
		[global::Cpp2ILInjected.Token(Token = "0x4006FAC")]
		public const int DecryptionError = 4;

		// Token: 0x04005C65 RID: 23653
		[global::Cpp2ILInjected.Token(Token = "0x4006FAD")]
		public const int BadSectionPointer = 5;

		// Token: 0x04005C66 RID: 23654
		[global::Cpp2ILInjected.Token(Token = "0x4006FAE")]
		public const int BadFooter = 6;

		// Token: 0x04005C67 RID: 23655
		[global::Cpp2ILInjected.Token(Token = "0x4006FAF")]
		public static readonly IdDictionary Search;
	}
}
