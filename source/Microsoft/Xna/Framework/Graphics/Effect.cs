using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200029E RID: 670
	[global::Cpp2ILInjected.Token(Token = "0x2000362")]
	public class Effect : GraphicsResource
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x00025A12 File Offset: 0x00023C12
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x00025A15 File Offset: 0x00023C15
		[global::Cpp2ILInjected.Token(Token = "0x17000298")]
		public EffectParameterCollection Parameters
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001690")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA4624", Offset = "0xAA4624", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001691")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA462C", Offset = "0xAA462C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x00025A18 File Offset: 0x00023C18
		// (set) Token: 0x06001531 RID: 5425 RVA: 0x00025A1B File Offset: 0x00023C1B
		[global::Cpp2ILInjected.Token(Token = "0x17000299")]
		public EffectTechnique CurrentTechnique
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001692")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA4634", Offset = "0xAA4634", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001693")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA463C", Offset = "0xAA463C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00025A1E File Offset: 0x00023C1E
		[global::Cpp2ILInjected.Token(Token = "0x6001694")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4644", Offset = "0xAA4644", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShader), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteEffect), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteEffect), Member = "get_Effect", ReturnType = typeof(SpriteEffect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileShader), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsResource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsResource), Member = "set_GraphicsDevice", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		internal Effect(GraphicsDevice graphicsDevice)
		{
			throw null;
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00025A21 File Offset: 0x00023C21
		[global::Cpp2ILInjected.Token(Token = "0x6001695")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4674", Offset = "0xAA4674", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsResource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsResource), Member = "set_GraphicsDevice", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		protected Effect(Effect cloneSource)
		{
			throw null;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00025A24 File Offset: 0x00023C24
		[global::Cpp2ILInjected.Token(Token = "0x6001696")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA46B4", Offset = "0xAA46B4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void ApplyValuesToMaterial(EffectPass pass, Material material)
		{
			throw null;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00025A27 File Offset: 0x00023C27
		[global::Cpp2ILInjected.Token(Token = "0x6001697")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA46B0", Offset = "0xAA46B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Clone(Effect cloneSource)
		{
			throw null;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00025A2A File Offset: 0x00023C2A
		[global::Cpp2ILInjected.Token(Token = "0x6001698")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA46B8", Offset = "0xAA46B8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsResource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsResource), Member = "set_GraphicsDevice", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Effect Clone()
		{
			throw null;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00025A2D File Offset: 0x00023C2D
		[global::Cpp2ILInjected.Token(Token = "0x6001699")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA472C", Offset = "0xAA472C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected internal virtual void OnApply()
		{
			throw null;
		}

		// Token: 0x04001EF1 RID: 7921
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40024D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private EffectParameterCollection <Parameters>k__BackingField;

		// Token: 0x04001EF2 RID: 7922
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40024D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private EffectTechnique <CurrentTechnique>k__BackingField;

		// Token: 0x04001EF3 RID: 7923
		[global::Cpp2ILInjected.Token(Token = "0x40024D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly bool _isClone;
	}
}
