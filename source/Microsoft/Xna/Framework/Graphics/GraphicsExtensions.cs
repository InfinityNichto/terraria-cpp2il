using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x200037C")]
	internal static class GraphicsExtensions
	{
		[global::Cpp2ILInjected.Token(Token = "0x60017AD")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB36A4", Offset = "0xAB36A4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int GetSyncInterval(this PresentInterval interval)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017AE")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB36B8", Offset = "0xAB36B8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool IsCompressedFormat(this SurfaceFormat format)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017AF")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB371C", Offset = "0xAB371C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture), Member = "GetPitch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static int GetSize(this SurfaceFormat surfaceFormat)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017B0")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB37AC", Offset = "0xAB37AC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void GetBlockSize(this SurfaceFormat surfaceFormat, out int width, out int height)
		{
			throw null;
		}
	}
}
