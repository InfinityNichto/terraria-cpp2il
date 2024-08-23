using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002A3 RID: 675
	[global::Cpp2ILInjected.Token(Token = "0x2000368")]
	public class EffectTechnique
	{
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x00025AA2 File Offset: 0x00023CA2
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x00025AA5 File Offset: 0x00023CA5
		[global::Cpp2ILInjected.Token(Token = "0x170002A7")]
		public EffectPassCollection Passes
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016C6")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA53E4", Offset = "0xAA53E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016C7")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA53EC", Offset = "0xAA53EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x00025AA8 File Offset: 0x00023CA8
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x00025AAB File Offset: 0x00023CAB
		[global::Cpp2ILInjected.Token(Token = "0x170002A8")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016C8")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA53F4", Offset = "0xAA53F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016C9")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA53FC", Offset = "0xAA53FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00025AAE File Offset: 0x00023CAE
		[global::Cpp2ILInjected.Token(Token = "0x60016CA")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA5404", Offset = "0xAA5404", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "Clone", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(EffectPassCollection))]
		internal EffectTechnique(Effect effect, EffectTechnique cloneSource)
		{
			throw null;
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00025AB1 File Offset: 0x00023CB1
		[global::Cpp2ILInjected.Token(Token = "0x60016CB")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA5444", Offset = "0xAA5444", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShader), Member = "get_Effect", ReturnType = typeof(ScreenShader))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteEffect), Member = "get_Effect", ReturnType = typeof(SpriteEffect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileShader), Member = "CreateNew", ReturnType = typeof(TileShader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal EffectTechnique(Effect effect, string name, EffectPassCollection passes)
		{
			throw null;
		}

		// Token: 0x04001F02 RID: 7938
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40024E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private EffectPassCollection <Passes>k__BackingField;

		// Token: 0x04001F03 RID: 7939
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40024EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <Name>k__BackingField;
	}
}
