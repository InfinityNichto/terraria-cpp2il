using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020004F4 RID: 1268
	[global::Cpp2ILInjected.Token(Token = "0x200074F")]
	public class ParticleRenderer
	{
		// Token: 0x06003738 RID: 14136 RVA: 0x0002BDE4 File Offset: 0x00029FE4
		[global::Cpp2ILInjected.Token(Token = "0x6003DAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A37D4", Offset = "0x14A37D4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIParticleLayer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ParticleRenderer()
		{
			throw null;
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x0002BDE7 File Offset: 0x00029FE7
		[global::Cpp2ILInjected.Token(Token = "0x6003DAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3858", Offset = "0x14A3858", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 46)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Add(IParticle particle)
		{
			throw null;
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x0002BDEA File Offset: 0x00029FEA
		[global::Cpp2ILInjected.Token(Token = "0x6003DAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3900", Offset = "0x14A3900", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIParticleLayer), Member = "ClearParticles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x0002BDED File Offset: 0x00029FED
		[global::Cpp2ILInjected.Token(Token = "0x6003DAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3968", Offset = "0x14A3968", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateParticleSystems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIParticleLayer), Member = "ParticleSystemUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x0002BDF0 File Offset: 0x00029FF0
		[global::Cpp2ILInjected.Token(Token = "0x6003DAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3BA4", Offset = "0x14A3BA4", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIParticleLayer), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Draw(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x04006783 RID: 26499
		[global::Cpp2ILInjected.Token(Token = "0x4007C6B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ParticleRendererSettings Settings;

		// Token: 0x04006784 RID: 26500
		[global::Cpp2ILInjected.Token(Token = "0x4007C6C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public List<IParticle> Particles;
	}
}
