using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Dyes;
using Terraria.Graphics.Shaders;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002A0 RID: 672
	[global::Cpp2ILInjected.Token(Token = "0x2000364")]
	public class EffectParameterCollection : IEnumerable<EffectParameter>, IEnumerable
	{
		// Token: 0x06001546 RID: 5446 RVA: 0x00025A5A File Offset: 0x00023C5A
		[global::Cpp2ILInjected.Token(Token = "0x60016A8")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA48E0", Offset = "0xAA48E0", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EffectParameterCollection), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PixelShader), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShader), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileShader), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal EffectParameterCollection(EffectParameter[] parameters)
		{
			throw null;
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00025A5D File Offset: 0x00023C5D
		[global::Cpp2ILInjected.Token(Token = "0x60016A9")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA49D8", Offset = "0xAA49D8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private EffectParameterCollection(EffectParameter[] parameters, Dictionary<string, int> indexLookup)
		{
			throw null;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00025A60 File Offset: 0x00023C60
		[global::Cpp2ILInjected.Token(Token = "0x60016AA")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4A04", Offset = "0xAA4A04", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = ".ctor", MemberParameters = new object[] { typeof(EffectParameter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal EffectParameterCollection Clone()
		{
			throw null;
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x00025A63 File Offset: 0x00023C63
		[global::Cpp2ILInjected.Token(Token = "0x1700029F")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016AB")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA4B40", Offset = "0xAA4B40", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000278 RID: 632
		[global::Cpp2ILInjected.Token(Token = "0x170002A0")]
		public EffectParameter this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016AC")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA4B4C", Offset = "0xAA4B4C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000279 RID: 633
		[global::Cpp2ILInjected.Token(Token = "0x170002A1")]
		public EffectParameter this[string name]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016AD")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA4B5C", Offset = "0xAA4B5C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EffectPass), Member = "SetRegion", MemberParameters = new object[]
			{
				typeof(Vector4),
				typeof(Texture2D)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorShaderData), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Ref<Effect>),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairShaderData), Member = "Apply", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(DrawData?)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiscShaderData), Member = "Apply", MemberParameters = new object[] { typeof(DrawData?) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShaderData), Member = "Apply", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilePaintSystemV2), Member = "InitShader", MemberParameters = new object[] { typeof(TreePaintingSettings) }, ReturnType = typeof(Effect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectiveArmorShaderData), Member = "Apply", MemberParameters = new object[]
			{
				typeof(Entity),
				typeof(DrawData?)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 62)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00025A6C File Offset: 0x00023C6C
		[global::Cpp2ILInjected.Token(Token = "0x60016AE")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4BDC", Offset = "0xAA4BDC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IEnumerator<EffectParameter> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00025A6F File Offset: 0x00023C6F
		[global::Cpp2ILInjected.Token(Token = "0x60016AF")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4C74", Offset = "0xAA4C74", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00025A72 File Offset: 0x00023C72
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016B0")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4C80", Offset = "0xAA4C80", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameterCollection), Member = ".ctor", MemberParameters = new object[] { typeof(EffectParameter[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static EffectParameterCollection()
		{
			throw null;
		}

		// Token: 0x04001EF6 RID: 7926
		[global::Cpp2ILInjected.Token(Token = "0x40024DA")]
		internal static readonly EffectParameterCollection Empty;

		// Token: 0x04001EF7 RID: 7927
		[global::Cpp2ILInjected.Token(Token = "0x40024DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly EffectParameter[] _parameters;

		// Token: 0x04001EF8 RID: 7928
		[global::Cpp2ILInjected.Token(Token = "0x40024DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, int> _indexLookup;
	}
}
