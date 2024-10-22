﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Achievements;
using Terraria.Initializers;

namespace Terraria.GameContent.Achievements
{
	[global::Cpp2ILInjected.Token(Token = "0x20009AA")]
	public class CustomFlagCondition : AchievementCondition
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004937")]
		[global::Cpp2ILInjected.Address(RVA = "0x82BB98", Offset = "0x82BB98", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		private CustomFlagCondition(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004938")]
		[global::Cpp2ILInjected.Address(RVA = "0x82BBA0", Offset = "0x82BBA0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 36)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static AchievementCondition Create(string name)
		{
			throw null;
		}
	}
}
