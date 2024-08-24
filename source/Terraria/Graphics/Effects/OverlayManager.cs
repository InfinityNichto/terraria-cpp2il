using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000520 RID: 1312
	[global::Cpp2ILInjected.Token(Token = "0x2000789")]
	public class OverlayManager : EffectManager<Overlay>
	{
		// Token: 0x06003872 RID: 14450 RVA: 0x0002C13E File Offset: 0x0002A33E
		[global::Cpp2ILInjected.Token(Token = "0x6003F11")]
		[global::Cpp2ILInjected.Address(RVA = "0x740978", Offset = "0x740978", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(PlatformUser)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Overlays), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "GetNames", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public OverlayManager()
		{
			throw null;
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x0002C141 File Offset: 0x0002A341
		[global::Cpp2ILInjected.Token(Token = "0x6003F12")]
		[global::Cpp2ILInjected.Address(RVA = "0x741E8C", Offset = "0x741E8C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "AddLast", MemberParameters = new object[] { typeof(object) }, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override void OnActivate(Overlay overlay, Vector2 position)
		{
			throw null;
		}

		// Token: 0x06003874 RID: 14452 RVA: 0x0002C144 File Offset: 0x0002A344
		[global::Cpp2ILInjected.Token(Token = "0x6003F13")]
		[global::Cpp2ILInjected.Address(RVA = "0x742074", Offset = "0x742074", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedListNode<object>), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Remove", MemberParameters = new object[] { typeof(LinkedListNode<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x0002C147 File Offset: 0x0002A347
		[global::Cpp2ILInjected.Token(Token = "0x6003F14")]
		[global::Cpp2ILInjected.Address(RVA = "0x74229C", Offset = "0x74229C", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_WallsAndBlacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Transform", ReturnType = typeof(Matrix))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedListNode<object>), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void Draw(SpriteBatch spriteBatch, RenderLayers layer)
		{
			throw null;
		}

		// Token: 0x04006868 RID: 26728
		[global::Cpp2ILInjected.Token(Token = "0x4007D8E")]
		private const float OPACITY_RATE = 1f;

		// Token: 0x04006869 RID: 26729
		[global::Cpp2ILInjected.Token(Token = "0x4007D8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private LinkedList<Overlay>[] _activeOverlays;

		// Token: 0x0400686A RID: 26730
		[global::Cpp2ILInjected.Token(Token = "0x4007D90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _overlayCount;
	}
}
