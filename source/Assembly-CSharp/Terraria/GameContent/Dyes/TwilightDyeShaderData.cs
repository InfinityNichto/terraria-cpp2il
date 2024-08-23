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
	// Token: 0x02000584 RID: 1412
	[global::Cpp2ILInjected.Token(Token = "0x200081E")]
	public class TwilightDyeShaderData : ArmorShaderData
	{
		// Token: 0x06003B93 RID: 15251 RVA: 0x0002CA50 File Offset: 0x0002AC50
		[global::Cpp2ILInjected.Token(Token = "0x60042AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x79733C", Offset = "0x79733C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadArmorDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		public TwilightDyeShaderData(Ref<Effect> shader, string passName)
		{
			throw null;
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x0002CA53 File Offset: 0x0002AC53
		[global::Cpp2ILInjected.Token(Token = "0x60042AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x797344", Offset = "0x797344", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = "UseTargetPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override void Apply(Entity entity, DrawData? drawData)
		{
			throw null;
		}
	}
}
