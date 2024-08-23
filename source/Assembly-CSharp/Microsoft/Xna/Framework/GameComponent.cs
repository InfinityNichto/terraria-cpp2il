using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000278 RID: 632
	[global::Cpp2ILInjected.Token(Token = "0x2000339")]
	public class GameComponent : IGameComponent, IUpdateable, IComparable<GameComponent>
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600136B RID: 4971 RVA: 0x000254F6 File Offset: 0x000236F6
		// (remove) Token: 0x0600136C RID: 4972 RVA: 0x000254F9 File Offset: 0x000236F9
		[global::Cpp2ILInjected.Token(Token = "0x1400000A")]
		public event EventHandler<EventArgs> UpdateOrderChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014C8")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96644", Offset = "0xA96644", Length = "0xB0")]
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
			[global::Cpp2ILInjected.Token(Token = "0x60014C9")]
			[global::Cpp2ILInjected.Address(RVA = "0xA966F4", Offset = "0xA966F4", Length = "0xB0")]
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

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600136D RID: 4973 RVA: 0x000254FC File Offset: 0x000236FC
		// (remove) Token: 0x0600136E RID: 4974 RVA: 0x000254FF File Offset: 0x000236FF
		[global::Cpp2ILInjected.Token(Token = "0x1400000B")]
		public event EventHandler<EventArgs> EnabledChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014CA")]
			[global::Cpp2ILInjected.Address(RVA = "0xA967A4", Offset = "0xA967A4", Length = "0xB0")]
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
			[global::Cpp2ILInjected.Token(Token = "0x60014CB")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96854", Offset = "0xA96854", Length = "0xB0")]
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

		// Token: 0x0600136F RID: 4975 RVA: 0x00025502 File Offset: 0x00023702
		[global::Cpp2ILInjected.Token(Token = "0x60014CC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96904", Offset = "0xA96904", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrawableGameComponent), Member = ".ctor", MemberParameters = new object[] { typeof(Game) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GameComponent(Game game)
		{
			throw null;
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x00025505 File Offset: 0x00023705
		[global::Cpp2ILInjected.Token(Token = "0x17000215")]
		public Game Game
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014CD")]
			[global::Cpp2ILInjected.Address(RVA = "0xA969DC", Offset = "0xA969DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00025508 File Offset: 0x00023708
		[global::Cpp2ILInjected.Token(Token = "0x60014CE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA969E4", Offset = "0xA969E4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Initialize()
		{
			throw null;
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0002550B File Offset: 0x0002370B
		[global::Cpp2ILInjected.Token(Token = "0x60014CF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA969E8", Offset = "0xA969E8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x0002550E File Offset: 0x0002370E
		[global::Cpp2ILInjected.Token(Token = "0x17000216")]
		public GraphicsDevice GraphicsDevice
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014D0")]
			[global::Cpp2ILInjected.Address(RVA = "0xA969EC", Offset = "0xA969EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x00025511 File Offset: 0x00023711
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x00025514 File Offset: 0x00023714
		[global::Cpp2ILInjected.Token(Token = "0x17000217")]
		public bool Enabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014D1")]
			[global::Cpp2ILInjected.Address(RVA = "0xA969F4", Offset = "0xA969F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60014D2")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96934", Offset = "0xA96934", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x00025517 File Offset: 0x00023717
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x0002551A File Offset: 0x0002371A
		[global::Cpp2ILInjected.Token(Token = "0x17000218")]
		public int UpdateOrder
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014D3")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96A1C", Offset = "0xA96A1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60014D4")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96A24", Offset = "0xA96A24", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0002551D File Offset: 0x0002371D
		[global::Cpp2ILInjected.Token(Token = "0x60014D5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA969FC", Offset = "0xA969FC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Raise(EventHandler<EventArgs> handler, EventArgs e)
		{
			throw null;
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00025520 File Offset: 0x00023720
		[global::Cpp2ILInjected.Token(Token = "0x60014D6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96ACC", Offset = "0xA96ACC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnUpdateOrderChanged(object sender, EventArgs args)
		{
			throw null;
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x00025523 File Offset: 0x00023723
		[global::Cpp2ILInjected.Token(Token = "0x60014D7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96AD0", Offset = "0xA96AD0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnEnabledChanged(object sender, EventArgs args)
		{
			throw null;
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00025526 File Offset: 0x00023726
		[global::Cpp2ILInjected.Token(Token = "0x60014D8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96AD4", Offset = "0xA96AD4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00025529 File Offset: 0x00023729
		[global::Cpp2ILInjected.Token(Token = "0x60014D9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96AD8", Offset = "0xA96AD8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int CompareTo(GameComponent other)
		{
			throw null;
		}

		// Token: 0x04001CE3 RID: 7395
		[global::Cpp2ILInjected.Token(Token = "0x40022BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Game _game;

		// Token: 0x04001CE4 RID: 7396
		[global::Cpp2ILInjected.Token(Token = "0x40022BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _updateOrder;

		// Token: 0x04001CE5 RID: 7397
		[global::Cpp2ILInjected.Token(Token = "0x40022BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _enabled;

		// Token: 0x04001CE6 RID: 7398
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40022C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private EventHandler<EventArgs> UpdateOrderChanged;

		// Token: 0x04001CE7 RID: 7399
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40022C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private EventHandler<EventArgs> EnabledChanged;
	}
}
