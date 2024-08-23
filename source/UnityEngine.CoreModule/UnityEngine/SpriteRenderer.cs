using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D0 RID: 208
	[RequireComponent(typeof(Transform))]
	[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000E7")]
	public sealed class SpriteRenderer : Renderer
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x00002A94 File Offset: 0x00000C94
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60004EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F86C2C", Offset = "0x1F86C2C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<object>), Member = "Invoke", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void InvokeSpriteChanged()
		{
			throw null;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060004CE RID: 1230
		// (set) Token: 0x060004CF RID: 1231
		[global::Cpp2ILInjected.Token(Token = "0x17000100")]
		public extern Sprite sprite
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F86D20", Offset = "0x1F86D20", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "ScaleSpriteInPixels", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(SpriteRenderer),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "ScaleSpriteInPercent", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(SpriteRenderer),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x60004ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F86D5C", Offset = "0x1F86D5C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "CreateSpriteRenderer", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(Sprite),
				typeof(int)
			}, ReturnType = typeof(SpriteRenderer))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00002A97 File Offset: 0x00000C97
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00002A9A File Offset: 0x00000C9A
		[global::Cpp2ILInjected.Token(Token = "0x17000101")]
		public Color color
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F86DA0", Offset = "0x1F86DA0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F86E3C", Offset = "0x1F86E3C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "Create", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Transform),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004D2 RID: 1234
		[global::Cpp2ILInjected.Token(Token = "0x60004F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F86DF8", Offset = "0x1F86DF8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_color_Injected(out Color ret);

		// Token: 0x060004D3 RID: 1235
		[global::Cpp2ILInjected.Token(Token = "0x60004F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F86E90", Offset = "0x1F86E90", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_color_Injected(ref Color value);

		// Token: 0x040003BF RID: 959
		[global::Cpp2ILInjected.Token(Token = "0x40003FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private UnityEvent<SpriteRenderer> m_SpriteChangeEvent;
	}
}
