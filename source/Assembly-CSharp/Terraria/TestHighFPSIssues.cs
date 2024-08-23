using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameInput;

namespace Terraria
{
	// Token: 0x0200032C RID: 812
	[global::Cpp2ILInjected.Token(Token = "0x2000430")]
	public class TestHighFPSIssues
	{
		// Token: 0x060025F8 RID: 9720 RVA: 0x00028C37 File Offset: 0x00026E37
		[global::Cpp2ILInjected.Token(Token = "0x600280C")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D0E78", Offset = "0x10D0E78", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void TapUpdate(GameTime gt)
		{
			throw null;
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x00028C3A File Offset: 0x00026E3A
		[global::Cpp2ILInjected.Token(Token = "0x600280D")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D0FA0", Offset = "0x10D0FA0", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void TapUpdateEnd(GameTime gt)
		{
			throw null;
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x00028C3D File Offset: 0x00026E3D
		[global::Cpp2ILInjected.Token(Token = "0x600280E")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D1080", Offset = "0x10D1080", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void TapDraw(GameTime gt)
		{
			throw null;
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x00028C40 File Offset: 0x00026E40
		[global::Cpp2ILInjected.Token(Token = "0x600280F")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D11A8", Offset = "0x10D11A8", Length = "0x540")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "get_Down", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<double>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<double>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		public static void Update(GameTime gt)
		{
			throw null;
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x00028C43 File Offset: 0x00026E43
		[global::Cpp2ILInjected.Token(Token = "0x6002810")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D16E8", Offset = "0x10D16E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TestHighFPSIssues()
		{
			throw null;
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x00028C46 File Offset: 0x00026E46
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002811")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D16F0", Offset = "0x10D16F0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<double>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static TestHighFPSIssues()
		{
			throw null;
		}

		// Token: 0x04002CE3 RID: 11491
		[global::Cpp2ILInjected.Token(Token = "0x4003404")]
		private static List<double> _tapUpdates;

		// Token: 0x04002CE4 RID: 11492
		[global::Cpp2ILInjected.Token(Token = "0x4003405")]
		private static List<double> _tapUpdateEnds;

		// Token: 0x04002CE5 RID: 11493
		[global::Cpp2ILInjected.Token(Token = "0x4003406")]
		private static List<double> _tapDraws;

		// Token: 0x04002CE6 RID: 11494
		[global::Cpp2ILInjected.Token(Token = "0x4003407")]
		private static int conU;

		// Token: 0x04002CE7 RID: 11495
		[global::Cpp2ILInjected.Token(Token = "0x4003408")]
		private static int conUH;

		// Token: 0x04002CE8 RID: 11496
		[global::Cpp2ILInjected.Token(Token = "0x4003409")]
		private static int conD;

		// Token: 0x04002CE9 RID: 11497
		[global::Cpp2ILInjected.Token(Token = "0x400340A")]
		private static int conDH;

		// Token: 0x04002CEA RID: 11498
		[global::Cpp2ILInjected.Token(Token = "0x400340B")]
		private static int race;
	}
}
