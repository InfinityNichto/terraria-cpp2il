using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Graphics.Shaders
{
	[global::Cpp2ILInjected.Token(Token = "0x2000747")]
	public class GameShaders
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003D61")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0A5C", Offset = "0x14A0A5C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GameShaders()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003D62")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0A64", Offset = "0x14A0A64", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderDataSet), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static GameShaders()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007C43")]
		public static ArmorShaderDataSet Armor;

		[global::Cpp2ILInjected.Token(Token = "0x4007C44")]
		public static HairShaderDataSet Hair;

		[global::Cpp2ILInjected.Token(Token = "0x4007C45")]
		public static Dictionary<string, MiscShaderData> Misc;
	}
}
