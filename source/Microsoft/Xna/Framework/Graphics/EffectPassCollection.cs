using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent;
using Terraria.Graphics.Shaders;
using Unity.IL2CPP.CompilerServices;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002A2 RID: 674
	[global::Cpp2ILInjected.Token(Token = "0x2000366")]
	public class EffectPassCollection : IEnumerable<EffectPass>, IEnumerable
	{
		// Token: 0x06001556 RID: 5462 RVA: 0x00025A8A File Offset: 0x00023C8A
		[global::Cpp2ILInjected.Token(Token = "0x60016B8")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA5098", Offset = "0xAA5098", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShader), Member = "get_Effect", ReturnType = typeof(ScreenShader))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteEffect), Member = "get_Effect", ReturnType = typeof(SpriteEffect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileShader), Member = "CreateNew", ReturnType = typeof(TileShader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal EffectPassCollection(EffectPass[] passes)
		{
			throw null;
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00025A8D File Offset: 0x00023C8D
		[global::Cpp2ILInjected.Token(Token = "0x60016B9")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA50C0", Offset = "0xAA50C0", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EffectTechnique), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(EffectTechnique)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EffectTechniqueCollection), Member = "Clone", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(EffectTechniqueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPass), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(EffectPass)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal EffectPassCollection Clone(Effect effect)
		{
			throw null;
		}

		// Token: 0x1700027A RID: 634
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x170002A2")]
		public EffectPass this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016BA")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA51DC", Offset = "0xAA51DC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700027B RID: 635
		[global::Cpp2ILInjected.Token(Token = "0x170002A3")]
		public EffectPass this[string name]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016BB")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA51EC", Offset = "0xAA51EC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorShaderData), Member = "GetDustEffect", ReturnType = typeof(EffectPass))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShaderData), Member = "Apply", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerTitaniumStormBuffTextureContent), Member = "GetRenderEffect", ReturnType = typeof(EffectPass))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x00025A96 File Offset: 0x00023C96
		[global::Cpp2ILInjected.Token(Token = "0x170002A4")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016BC")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA5254", Offset = "0xAA5254", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00025A99 File Offset: 0x00023C99
		[global::Cpp2ILInjected.Token(Token = "0x60016BD")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA5260", Offset = "0xAA5260", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "RenderVertexArray", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(Texture2D),
			typeof(EffectPass),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "AddSubMesh", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(Texture2D),
			typeof(EffectPass)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "RenderVertexArray2", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(Texture2D),
			typeof(EffectPass),
			typeof(int),
			typeof(int),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public EffectPassCollection.Enumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00025A9C File Offset: 0x00023C9C
		[global::Cpp2ILInjected.Token(Token = "0x60016BE")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA5284", Offset = "0xAA5284", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IEnumerator<EffectPass> System.Collections.Generic.IEnumerable<Microsoft.Xna.Framework.Graphics.EffectPass>.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00025A9F File Offset: 0x00023C9F
		[global::Cpp2ILInjected.Token(Token = "0x60016BF")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA531C", Offset = "0xAA531C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x04001F01 RID: 7937
		[global::Cpp2ILInjected.Token(Token = "0x40024E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly EffectPass[] _passes;

		// Token: 0x02000823 RID: 2083
		[global::Cpp2ILInjected.Token(Token = "0x2000367")]
		public struct Enumerator : IEnumerator<EffectPass>, IEnumerator, IDisposable
		{
			// Token: 0x06004935 RID: 18741 RVA: 0x0002EFB8 File Offset: 0x0002D1B8
			[global::Cpp2ILInjected.Token(Token = "0x60016C0")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA5274", Offset = "0xAA5274", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal Enumerator(EffectPass[] array)
			{
				throw null;
			}

			// Token: 0x06004936 RID: 18742 RVA: 0x0002EFBB File Offset: 0x0002D1BB
			[global::Cpp2ILInjected.Token(Token = "0x60016C1")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA5328", Offset = "0xAA5328", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "RenderVertexArray", MemberParameters = new object[]
			{
				typeof(Effect),
				typeof(Texture2D),
				typeof(EffectPass),
				typeof(Vector3),
				typeof(Vector3)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "AddSubMesh", MemberParameters = new object[]
			{
				typeof(Effect),
				typeof(Texture2D),
				typeof(EffectPass)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "RenderVertexArray2", MemberParameters = new object[]
			{
				typeof(Effect),
				typeof(Texture2D),
				typeof(EffectPass),
				typeof(int),
				typeof(int),
				typeof(Vector3),
				typeof(Vector3)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x17000848 RID: 2120
			// (get) Token: 0x06004937 RID: 18743 RVA: 0x0002EFBE File Offset: 0x0002D1BE
			[global::Cpp2ILInjected.Token(Token = "0x170002A5")]
			public EffectPass Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x60016C2")]
				[global::Cpp2ILInjected.Address(RVA = "0xAA5370", Offset = "0xAA5370", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000849 RID: 2121
			// (get) Token: 0x06004938 RID: 18744 RVA: 0x0002EFC1 File Offset: 0x0002D1C1
			[global::Cpp2ILInjected.Token(Token = "0x170002A6")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x60016C3")]
				[global::Cpp2ILInjected.Address(RVA = "0xAA5378", Offset = "0xAA5378", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004939 RID: 18745 RVA: 0x0002EFC4 File Offset: 0x0002D1C4
			[global::Cpp2ILInjected.Token(Token = "0x60016C4")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA53D4", Offset = "0xAA53D4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x0600493A RID: 18746 RVA: 0x0002EFC7 File Offset: 0x0002D1C7
			[global::Cpp2ILInjected.Token(Token = "0x60016C5")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA53E0", Offset = "0xAA53E0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "RenderVertexArray", MemberParameters = new object[]
			{
				typeof(Effect),
				typeof(Texture2D),
				typeof(EffectPass),
				typeof(Vector3),
				typeof(Vector3)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "AddSubMesh", MemberParameters = new object[]
			{
				typeof(Effect),
				typeof(Texture2D),
				typeof(EffectPass)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "RenderVertexArray2", MemberParameters = new object[]
			{
				typeof(Effect),
				typeof(Texture2D),
				typeof(EffectPass),
				typeof(int),
				typeof(int),
				typeof(Vector3),
				typeof(Vector3)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x04007DA2 RID: 32162
			[global::Cpp2ILInjected.Token(Token = "0x40024E6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly EffectPass[] _array;

			// Token: 0x04007DA3 RID: 32163
			[global::Cpp2ILInjected.Token(Token = "0x40024E7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private int _index;

			// Token: 0x04007DA4 RID: 32164
			[global::Cpp2ILInjected.Token(Token = "0x40024E8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private EffectPass _current;
		}
	}
}
