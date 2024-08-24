using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Dyes;
using Terraria.Graphics.Shaders;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200029F RID: 671
	[DebuggerDisplay("{DebugDisplayString}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000363")]
	public class EffectParameter
	{
		// Token: 0x06001538 RID: 5432 RVA: 0x00025A30 File Offset: 0x00023C30
		[global::Cpp2ILInjected.Token(Token = "0x600169A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4730", Offset = "0xAA4730", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PixelShader), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShader), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileShader), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal EffectParameter(string name)
		{
			throw null;
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00025A33 File Offset: 0x00023C33
		[global::Cpp2ILInjected.Token(Token = "0x600169B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA479C", Offset = "0xAA479C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EffectParameterCollection), Member = "Clone", ReturnType = typeof(EffectParameterCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal EffectParameter(EffectParameter cloneSource)
		{
			throw null;
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x00025A36 File Offset: 0x00023C36
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x00025A39 File Offset: 0x00023C39
		[global::Cpp2ILInjected.Token(Token = "0x1700029A")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600169C")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA4834", Offset = "0xAA4834", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600169D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA483C", Offset = "0xAA483C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00025A3C File Offset: 0x00023C3C
		[global::Cpp2ILInjected.Token(Token = "0x600169E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4844", Offset = "0xAA4844", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetValue(Matrix value)
		{
			throw null;
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00025A3F File Offset: 0x00023C3F
		[global::Cpp2ILInjected.Token(Token = "0x600169F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4848", Offset = "0xAA4848", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilePaintSystemV2), Member = "InitShader", MemberParameters = new object[] { typeof(TreePaintingSettings) }, ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void SetValue(bool value)
		{
			throw null;
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00025A42 File Offset: 0x00023C42
		[global::Cpp2ILInjected.Token(Token = "0x60016A0")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4864", Offset = "0xAA4864", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiscShaderData), Member = "Apply", MemberParameters = new object[] { typeof(DrawData?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilePaintSystemV2), Member = "InitShader", MemberParameters = new object[] { typeof(TreePaintingSettings) }, ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		public void SetValue(float value)
		{
			throw null;
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00025A45 File Offset: 0x00023C45
		[global::Cpp2ILInjected.Token(Token = "0x60016A1")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4870", Offset = "0xAA4870", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiscShaderData), Member = "Apply", MemberParameters = new object[] { typeof(DrawData?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		public void SetValue(Vector2 value)
		{
			throw null;
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00025A48 File Offset: 0x00023C48
		[global::Cpp2ILInjected.Token(Token = "0x60016A2")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA487C", Offset = "0xAA487C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiscShaderData), Member = "Apply", MemberParameters = new object[] { typeof(DrawData?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectiveArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		public void SetValue(Vector3 value)
		{
			throw null;
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00025A4B File Offset: 0x00023C4B
		[global::Cpp2ILInjected.Token(Token = "0x60016A3")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA488C", Offset = "0xAA488C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiscShaderData), Member = "Apply", MemberParameters = new object[] { typeof(DrawData?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		public void SetValue(Vector4 value)
		{
			throw null;
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00025A4E File Offset: 0x00023C4E
		[global::Cpp2ILInjected.Token(Token = "0x1700029B")]
		public Vector4 Vector
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016A4")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA489C", Offset = "0xAA489C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShader), Member = "ApplyValuesToMaterial", MemberParameters = new object[]
			{
				typeof(EffectPass),
				typeof(Material)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x00025A51 File Offset: 0x00023C51
		[global::Cpp2ILInjected.Token(Token = "0x1700029C")]
		public float Float
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016A5")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA48AC", Offset = "0xAA48AC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShader), Member = "ApplyValuesToMaterial", MemberParameters = new object[]
			{
				typeof(EffectPass),
				typeof(Material)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileShader), Member = "ApplyValuesToMaterial", MemberParameters = new object[]
			{
				typeof(EffectPass),
				typeof(Material)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x00025A54 File Offset: 0x00023C54
		[global::Cpp2ILInjected.Token(Token = "0x1700029D")]
		public bool Bool
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016A6")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA48B8", Offset = "0xAA48B8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x00025A57 File Offset: 0x00023C57
		[global::Cpp2ILInjected.Token(Token = "0x1700029E")]
		public Color Color
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016A7")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA48CC", Offset = "0xAA48CC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShader), Member = "ApplyValuesToMaterial", MemberParameters = new object[]
			{
				typeof(EffectPass),
				typeof(Material)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04001EF4 RID: 7924
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40024D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Name>k__BackingField;

		// Token: 0x04001EF5 RID: 7925
		[global::Cpp2ILInjected.Token(Token = "0x40024D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal float[] Data;
	}
}
