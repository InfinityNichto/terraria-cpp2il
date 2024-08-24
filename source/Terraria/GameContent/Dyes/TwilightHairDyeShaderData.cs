using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.Initializers;

namespace Terraria.GameContent.Dyes
{
	// Token: 0x02000585 RID: 1413
	[global::Cpp2ILInjected.Token(Token = "0x200081F")]
	public class TwilightHairDyeShaderData : HairShaderData
	{
		// Token: 0x06003B95 RID: 15253 RVA: 0x0002CA56 File Offset: 0x0002AC56
		[global::Cpp2ILInjected.Token(Token = "0x60042B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x797518", Offset = "0x797518", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadHairDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		public TwilightHairDyeShaderData(Ref<Effect> shader, string passName)
		{
			throw null;
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x0002CA59 File Offset: 0x0002AC59
		[global::Cpp2ILInjected.Token(Token = "0x60042B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x797520", Offset = "0x797520", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderData), Member = "UseTargetPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(HairShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void Apply(Player player, DrawData? drawData = null)
		{
			throw null;
		}
	}
}
