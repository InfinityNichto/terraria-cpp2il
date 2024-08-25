using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	[global::Cpp2ILInjected.Token(Token = "0x200083D")]
	public class PersonalityProfile
	{
		[global::Cpp2ILInjected.Token(Token = "0x600430A")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C4E8", Offset = "0x79C4E8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabase), Member = "Register", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IShopPersonalityTrait)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public PersonalityProfile()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008135")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<IShopPersonalityTrait> ShopModifiers;
	}
}
