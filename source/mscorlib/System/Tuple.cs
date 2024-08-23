﻿using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000DA RID: 218
	[global::Cpp2ILInjected.Token(Token = "0x200010C")]
	public static class Tuple
	{
		// Token: 0x06000939 RID: 2361 RVA: 0x0001600A File Offset: 0x0001420A
		[global::Cpp2ILInjected.Token(Token = "0x60009E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A1E18", Offset = "0x15A1E18", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIAchievementsMenu", Member = "AchievementDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIAchievementListItem", Member = "GetTrackerValues", ReturnType = "System.Tuple`2<Decimal, Decimal>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
		{
			throw null;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0001600D File Offset: 0x0001420D
		[global::Cpp2ILInjected.Token(Token = "0x60009E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A2164", Offset = "0x15A2164", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting", Member = "SortChest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
		{
			throw null;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00016010 File Offset: 0x00014210
		[global::Cpp2ILInjected.Token(Token = "0x60009E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C970", Offset = "0x1C4C970", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Tuple<, >), Member = "System.Collections.IStructuralEquatable.GetHashCode", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static int CombineHashCodes(int h1, int h2)
		{
			throw null;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00016013 File Offset: 0x00014213
		[global::Cpp2ILInjected.Token(Token = "0x60009E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C97C", Offset = "0x1C4C97C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Tuple<, , >), Member = "System.Collections.IStructuralEquatable.GetHashCode", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static int CombineHashCodes(int h1, int h2, int h3)
		{
			throw null;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00016016 File Offset: 0x00014216
		[global::Cpp2ILInjected.Token(Token = "0x60009E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C990", Offset = "0x1C4C990", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Tuple<, , , >), Member = "System.Collections.IStructuralEquatable.GetHashCode", MemberParameters = new object[] { typeof(global::System.Collections.IEqualityComparer) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
		{
			throw null;
		}
	}
}