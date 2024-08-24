using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Dyes;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020004F1 RID: 1265
	[global::Cpp2ILInjected.Token(Token = "0x200074C")]
	public class ShaderData
	{
		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06003731 RID: 14129 RVA: 0x0002BDD8 File Offset: 0x00029FD8
		[global::Cpp2ILInjected.Token(Token = "0x17000782")]
		public Effect Shader
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003DA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x149FEF4", Offset = "0x149FEF4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerTitaniumStormBuffTextureContent), Member = "GetRenderEffect", ReturnType = typeof(EffectPass))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectiveArmorShaderData), Member = "Apply", MemberParameters = new object[]
			{
				typeof(Entity),
				typeof(DrawData?)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x0002BDDB File Offset: 0x00029FDB
		[global::Cpp2ILInjected.Token(Token = "0x6003DA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x149FEC8", Offset = "0x149FEC8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ShaderData(Ref<Effect> shader, string passName)
		{
			throw null;
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x0002BDDE File Offset: 0x00029FDE
		[global::Cpp2ILInjected.Token(Token = "0x6003DA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A37D0", Offset = "0x14A37D0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Apply(Entity entity, DrawData? drawData = null)
		{
			throw null;
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x0002BDE1 File Offset: 0x00029FE1
		[global::Cpp2ILInjected.Token(Token = "0x6003DA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A225C", Offset = "0x14A225C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiscShaderData), Member = "Apply", MemberParameters = new object[] { typeof(DrawData?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Apply()
		{
			throw null;
		}

		// Token: 0x0400677F RID: 26495
		[global::Cpp2ILInjected.Token(Token = "0x4007C67")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Ref<Effect> _shader;

		// Token: 0x04006780 RID: 26496
		[global::Cpp2ILInjected.Token(Token = "0x4007C68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected string _passName;

		// Token: 0x04006781 RID: 26497
		[global::Cpp2ILInjected.Token(Token = "0x4007C69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public EffectPass _effectPass;
	}
}
