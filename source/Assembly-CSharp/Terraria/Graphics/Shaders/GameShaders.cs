using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020004EC RID: 1260
	[global::Cpp2ILInjected.Token(Token = "0x2000747")]
	public class GameShaders
	{
		// Token: 0x060036EE RID: 14062 RVA: 0x0002BD0F File Offset: 0x00029F0F
		[global::Cpp2ILInjected.Token(Token = "0x6003D61")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0A5C", Offset = "0x14A0A5C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GameShaders()
		{
			throw null;
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x0002BD12 File Offset: 0x00029F12
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

		// Token: 0x0400675B RID: 26459
		[global::Cpp2ILInjected.Token(Token = "0x4007C43")]
		public static ArmorShaderDataSet Armor;

		// Token: 0x0400675C RID: 26460
		[global::Cpp2ILInjected.Token(Token = "0x4007C44")]
		public static HairShaderDataSet Hair;

		// Token: 0x0400675D RID: 26461
		[global::Cpp2ILInjected.Token(Token = "0x4007C45")]
		public static Dictionary<string, MiscShaderData> Misc;
	}
}
