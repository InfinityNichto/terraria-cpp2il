using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x0200059F RID: 1439
	[global::Cpp2ILInjected.Token(Token = "0x200083D")]
	public class PersonalityProfile
	{
		// Token: 0x06003BE7 RID: 15335 RVA: 0x0002CB49 File Offset: 0x0002AD49
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

		// Token: 0x04006B38 RID: 27448
		[global::Cpp2ILInjected.Token(Token = "0x4008135")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<IShopPersonalityTrait> ShopModifiers;
	}
}
