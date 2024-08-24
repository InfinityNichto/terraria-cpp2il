using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Shaders;

namespace Terraria.Graphics.Effects
{
	// Token: 0x0200051B RID: 1307
	[global::Cpp2ILInjected.Token(Token = "0x2000784")]
	public class FilterManager : EffectManager<Filter>
	{
		// Token: 0x1400004D RID: 77
		// (add) Token: 0x0600385B RID: 14427 RVA: 0x0002C108 File Offset: 0x0002A308
		// (remove) Token: 0x0600385C RID: 14428 RVA: 0x0002C10B File Offset: 0x0002A30B
		[global::Cpp2ILInjected.Token(Token = "0x14000053")]
		public event Action OnPostDraw
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003EFA")]
			[global::Cpp2ILInjected.Address(RVA = "0x740C70", Offset = "0x740C70", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003EFB")]
			[global::Cpp2ILInjected.Address(RVA = "0x740D0C", Offset = "0x740D0C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x0002C10E File Offset: 0x0002A30E
		[global::Cpp2ILInjected.Token(Token = "0x6003EFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x740874", Offset = "0x740874", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(PlatformUser)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Filters), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public FilterManager()
		{
			throw null;
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x0002C111 File Offset: 0x0002A311
		[global::Cpp2ILInjected.Token(Token = "0x6003EFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x740DA8", Offset = "0x740DA8", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedListNode<object>), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "AddAfter", MemberParameters = new object[]
		{
			typeof(LinkedListNode<object>),
			typeof(object)
		}, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "AddLast", MemberParameters = new object[] { typeof(object) }, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override void OnActivate(Filter effect, Vector2 position)
		{
			throw null;
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x0002C114 File Offset: 0x0002A314
		[global::Cpp2ILInjected.Token(Token = "0x6003EFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x740F5C", Offset = "0x740F5C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "SetRenderTarget", MemberParameters = new object[] { typeof(RenderTarget2D) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "Clear", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void BeginCapture(RenderTarget2D screenTarget1, Color clearColor)
		{
			throw null;
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x0002C117 File Offset: 0x0002A317
		[global::Cpp2ILInjected.Token(Token = "0x6003EFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x741024", Offset = "0x741024", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedListNode<object>), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseGlobalOpacity", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Remove", MemberParameters = new object[] { typeof(LinkedListNode<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x0002C11A File Offset: 0x0002A31A
		[global::Cpp2ILInjected.Token(Token = "0x6003F00")]
		[global::Cpp2ILInjected.Address(RVA = "0x741218", Offset = "0x741218", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "get_Enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedListNode<object>), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "AddFilter", MemberParameters = new object[] { typeof(Filter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void UpdateFilters()
		{
			throw null;
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x0002C11D File Offset: 0x0002A31D
		[global::Cpp2ILInjected.Token(Token = "0x6003F01")]
		[global::Cpp2ILInjected.Address(RVA = "0x741330", Offset = "0x741330", Length = "0x9DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "SetRenderTarget", MemberParameters = new object[] { typeof(RenderTarget2D) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "Clear", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "get_EffectMatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "Invert", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedListNode<object>), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		public void EndCapture(RenderTarget2D finalTexture, RenderTarget2D screenTarget1, RenderTarget2D screenTarget2, Color clearColor)
		{
			throw null;
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x0002C120 File Offset: 0x0002A320
		[global::Cpp2ILInjected.Token(Token = "0x6003F02")]
		[global::Cpp2ILInjected.Address(RVA = "0x741D0C", Offset = "0x741D0C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool HasActiveFilter()
		{
			throw null;
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x0002C123 File Offset: 0x0002A323
		[global::Cpp2ILInjected.Token(Token = "0x6003F03")]
		[global::Cpp2ILInjected.Address(RVA = "0x741D54", Offset = "0x741D54", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool CanCapture()
		{
			throw null;
		}

		// Token: 0x04006857 RID: 26711
		[global::Cpp2ILInjected.Token(Token = "0x4007D7D")]
		private const float OPACITY_RATE = 1f;

		// Token: 0x04006858 RID: 26712
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007D7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Action OnPostDraw;

		// Token: 0x04006859 RID: 26713
		[global::Cpp2ILInjected.Token(Token = "0x4007D7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private LinkedList<Filter> _activeFilters;

		// Token: 0x0400685A RID: 26714
		[global::Cpp2ILInjected.Token(Token = "0x4007D80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _filterLimit;

		// Token: 0x0400685B RID: 26715
		[global::Cpp2ILInjected.Token(Token = "0x4007D81")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private EffectPriority _priorityThreshold;

		// Token: 0x0400685C RID: 26716
		[global::Cpp2ILInjected.Token(Token = "0x4007D82")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _activeFilterCount;

		// Token: 0x0400685D RID: 26717
		[global::Cpp2ILInjected.Token(Token = "0x4007D83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private bool _captureThisFrame;
	}
}
