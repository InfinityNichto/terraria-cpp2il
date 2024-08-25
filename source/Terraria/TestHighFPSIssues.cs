using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameInput;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x2000430")]
	public class TestHighFPSIssues
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6002810")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D16E8", Offset = "0x10D16E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TestHighFPSIssues()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4003404")]
		private static List<double> _tapUpdates;

		[global::Cpp2ILInjected.Token(Token = "0x4003405")]
		private static List<double> _tapUpdateEnds;

		[global::Cpp2ILInjected.Token(Token = "0x4003406")]
		private static List<double> _tapDraws;

		[global::Cpp2ILInjected.Token(Token = "0x4003407")]
		private static int conU;

		[global::Cpp2ILInjected.Token(Token = "0x4003408")]
		private static int conUH;

		[global::Cpp2ILInjected.Token(Token = "0x4003409")]
		private static int conD;

		[global::Cpp2ILInjected.Token(Token = "0x400340A")]
		private static int conDH;

		[global::Cpp2ILInjected.Token(Token = "0x400340B")]
		private static int race;
	}
}
