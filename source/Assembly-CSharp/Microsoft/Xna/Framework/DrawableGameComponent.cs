using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200025D RID: 605
	[global::Cpp2ILInjected.Token(Token = "0x200031E")]
	public class DrawableGameComponent : GameComponent, IDrawable
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06001131 RID: 4401 RVA: 0x00024E60 File Offset: 0x00023060
		// (remove) Token: 0x06001132 RID: 4402 RVA: 0x00024E63 File Offset: 0x00023063
		[global::Cpp2ILInjected.Token(Token = "0x14000006")]
		public event EventHandler<EventArgs> DrawOrderChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600128E")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7B814", Offset = "0xA7B814", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600128F")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7B8C4", Offset = "0xA7B8C4", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06001133 RID: 4403 RVA: 0x00024E66 File Offset: 0x00023066
		// (remove) Token: 0x06001134 RID: 4404 RVA: 0x00024E69 File Offset: 0x00023069
		[global::Cpp2ILInjected.Token(Token = "0x14000007")]
		public event EventHandler<EventArgs> VisibleChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001290")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7B974", Offset = "0xA7B974", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001291")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7BA24", Offset = "0xA7BA24", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00024E6C File Offset: 0x0002306C
		[global::Cpp2ILInjected.Token(Token = "0x6001292")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7BAD4", Offset = "0xA7BAD4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameComponent), Member = ".ctor", MemberParameters = new object[] { typeof(Game) }, ReturnType = typeof(void))]
		public DrawableGameComponent(Game game)
		{
			throw null;
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00024E6F File Offset: 0x0002306F
		[global::Cpp2ILInjected.Token(Token = "0x6001293")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7BBC8", Offset = "0xA7BBC8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Initialize()
		{
			throw null;
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00024E72 File Offset: 0x00023072
		[global::Cpp2ILInjected.Token(Token = "0x6001294")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7BBEC", Offset = "0xA7BBEC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void LoadContent()
		{
			throw null;
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00024E75 File Offset: 0x00023075
		[global::Cpp2ILInjected.Token(Token = "0x6001295")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7BBF0", Offset = "0xA7BBF0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void UnloadContent()
		{
			throw null;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x00024E78 File Offset: 0x00023078
		// (set) Token: 0x0600113A RID: 4410 RVA: 0x00024E7B File Offset: 0x0002307B
		[global::Cpp2ILInjected.Token(Token = "0x170001D5")]
		public int DrawOrder
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001296")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7BBF4", Offset = "0xA7BBF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001297")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7BBFC", Offset = "0xA7BBFC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x00024E7E File Offset: 0x0002307E
		// (set) Token: 0x0600113C RID: 4412 RVA: 0x00024E81 File Offset: 0x00023081
		[global::Cpp2ILInjected.Token(Token = "0x170001D6")]
		public bool Visible
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001298")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7BC48", Offset = "0xA7BC48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001299")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7BAF4", Offset = "0xA7BAF4", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00024E84 File Offset: 0x00023084
		[global::Cpp2ILInjected.Token(Token = "0x600129A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7BC50", Offset = "0xA7BC50", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Draw(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00024E87 File Offset: 0x00023087
		[global::Cpp2ILInjected.Token(Token = "0x600129B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7BC54", Offset = "0xA7BC54", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnVisibleChanged(object sender, EventArgs args)
		{
			throw null;
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00024E8A File Offset: 0x0002308A
		[global::Cpp2ILInjected.Token(Token = "0x600129C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7BC58", Offset = "0xA7BC58", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnDrawOrderChanged(object sender, EventArgs args)
		{
			throw null;
		}

		// Token: 0x04001C3D RID: 7229
		[global::Cpp2ILInjected.Token(Token = "0x4002217")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _isInitialized;

		// Token: 0x04001C3E RID: 7230
		[global::Cpp2ILInjected.Token(Token = "0x4002218")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		private bool _isVisible;

		// Token: 0x04001C3F RID: 7231
		[global::Cpp2ILInjected.Token(Token = "0x4002219")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int _drawOrder;

		// Token: 0x04001C40 RID: 7232
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400221A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private EventHandler<EventArgs> DrawOrderChanged;

		// Token: 0x04001C41 RID: 7233
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400221B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private EventHandler<EventArgs> VisibleChanged;
	}
}
