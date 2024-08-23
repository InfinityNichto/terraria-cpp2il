using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent
{
	// Token: 0x0200054B RID: 1355
	[global::Cpp2ILInjected.Token(Token = "0x20007C7")]
	public class HairstyleUnlocksHelper
	{
		// Token: 0x060039BB RID: 14779 RVA: 0x0002C501 File Offset: 0x0002A701
		[global::Cpp2ILInjected.Token(Token = "0x6004091")]
		[global::Cpp2ILInjected.Address(RVA = "0x771810", Offset = "0x771810", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawHairGrid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "RandomisePlayer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairstyleUnlocksHelper), Member = "ListWarrantsRemake", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairstyleUnlocksHelper), Member = "RebuildList", ReturnType = typeof(void))]
		public void UpdateUnlocks()
		{
			throw null;
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x0002C504 File Offset: 0x0002A704
		[global::Cpp2ILInjected.Token(Token = "0x6004092")]
		[global::Cpp2ILInjected.Address(RVA = "0x771834", Offset = "0x771834", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairstyleUnlocksHelper), Member = "UpdateUnlocks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_hairWindow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private bool ListWarrantsRemake()
		{
			throw null;
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x0002C507 File Offset: 0x0002A707
		[global::Cpp2ILInjected.Token(Token = "0x6004093")]
		[global::Cpp2ILInjected.Address(RVA = "0x771A30", Offset = "0x771A30", Length = "0xD08")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairstyleUnlocksHelper), Member = "UpdateUnlocks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void RebuildList()
		{
			throw null;
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x0002C50A File Offset: 0x0002A70A
		[global::Cpp2ILInjected.Token(Token = "0x6004094")]
		[global::Cpp2ILInjected.Address(RVA = "0x772738", Offset = "0x772738", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public HairstyleUnlocksHelper()
		{
			throw null;
		}

		// Token: 0x040068E6 RID: 26854
		[global::Cpp2ILInjected.Token(Token = "0x4007E4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<int> AvailableHairstyles;

		// Token: 0x040068E7 RID: 26855
		[global::Cpp2ILInjected.Token(Token = "0x4007E4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _defeatedMartians;

		// Token: 0x040068E8 RID: 26856
		[global::Cpp2ILInjected.Token(Token = "0x4007E4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool _defeatedMoonlord;

		// Token: 0x040068E9 RID: 26857
		[global::Cpp2ILInjected.Token(Token = "0x4007E4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
		private bool _defeatedPlantera;

		// Token: 0x040068EA RID: 26858
		[global::Cpp2ILInjected.Token(Token = "0x4007E4F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B")]
		private bool _isAtStylist;

		// Token: 0x040068EB RID: 26859
		[global::Cpp2ILInjected.Token(Token = "0x4007E50")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _isAtCharacterCreation;
	}
}
