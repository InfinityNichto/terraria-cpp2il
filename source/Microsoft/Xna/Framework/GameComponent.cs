using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework
{
	[global::Cpp2ILInjected.Token(Token = "0x2000339")]
	public class GameComponent : IGameComponent, IUpdateable, IComparable<GameComponent>
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60014CC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96904", Offset = "0xA96904", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrawableGameComponent), Member = ".ctor", MemberParameters = new object[] { typeof(Game) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GameComponent(Game game)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60014CE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA969E4", Offset = "0xA969E4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Initialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014CF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA969E8", Offset = "0xA969E8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Update(GameTime gameTime)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60014D5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA969FC", Offset = "0xA969FC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Raise(EventHandler<EventArgs> handler, EventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014D6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96ACC", Offset = "0xA96ACC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnUpdateOrderChanged(object sender, EventArgs args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014D7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96AD0", Offset = "0xA96AD0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnEnabledChanged(object sender, EventArgs args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014D8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96AD4", Offset = "0xA96AD4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014D9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96AD8", Offset = "0xA96AD8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int CompareTo(GameComponent other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40022BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Game _game;

		[global::Cpp2ILInjected.Token(Token = "0x40022BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _updateOrder;

		[global::Cpp2ILInjected.Token(Token = "0x40022BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _enabled;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40022C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private EventHandler<EventArgs> UpdateOrderChanged;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40022C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private EventHandler<EventArgs> EnabledChanged;
	}
}
