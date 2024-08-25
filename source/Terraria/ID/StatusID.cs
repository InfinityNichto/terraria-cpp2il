using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Reflection;

namespace Terraria.ID
{
	[global::Cpp2ILInjected.Token(Token = "0x20005F3")]
	public class StatusID
	{
		[global::Cpp2ILInjected.Token(Token = "0x600359B")]
		[global::Cpp2ILInjected.Address(RVA = "0x13D5080", Offset = "0x13D5080", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public StatusID()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4006FA8")]
		public const int Ok = 0;

		[global::Cpp2ILInjected.Token(Token = "0x4006FA9")]
		public const int LaterVersion = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4006FAA")]
		public const int UnknownError = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4006FAB")]
		public const int EmptyFile = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4006FAC")]
		public const int DecryptionError = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4006FAD")]
		public const int BadSectionPointer = 5;

		[global::Cpp2ILInjected.Token(Token = "0x4006FAE")]
		public const int BadFooter = 6;

		[global::Cpp2ILInjected.Token(Token = "0x4006FAF")]
		public static readonly IdDictionary Search;
	}
}
