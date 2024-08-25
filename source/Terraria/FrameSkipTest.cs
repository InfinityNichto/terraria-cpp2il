using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x200042F")]
	public class FrameSkipTest
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002807")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D0AF8", Offset = "0x10D0AF8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public static void Update(GameTime gameTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002808")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D0B68", Offset = "0x10D0B68", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_Seconds", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<float>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void CheckReset(GameTime gameTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002809")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D0D10", Offset = "0x10D0D10", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiTimer), Member = "Record", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiTimer), Member = "StopAndPrint", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiTimer), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void UpdateServerTest()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600280A")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D0DAC", Offset = "0x10D0DAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public FrameSkipTest()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600280B")]
		[global::Cpp2ILInjected.Address(RVA = "0x10D0DB4", Offset = "0x10D0DB4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<float>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiTimer), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static FrameSkipTest()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40033FE")]
		private static int LastRecordedSecondNumber;

		[global::Cpp2ILInjected.Token(Token = "0x40033FF")]
		private static float CallsThisSecond;

		[global::Cpp2ILInjected.Token(Token = "0x4003400")]
		private static float DeltasThisSecond;

		[global::Cpp2ILInjected.Token(Token = "0x4003401")]
		private static List<float> DeltaSamples;

		[global::Cpp2ILInjected.Token(Token = "0x4003402")]
		private const int SamplesCount = 5;

		[global::Cpp2ILInjected.Token(Token = "0x4003403")]
		private static MultiTimer serverFramerateTest;
	}
}
