using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Graphics;
using Terraria.Graphics.Effects;
using Terraria.UI;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x200037A")]
	public class GraphicsDevice
	{
		[global::Cpp2ILInjected.Token(Token = "0x170002E1")]
		internal GraphicsCapabilities GraphicsCapabilities
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600176C")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1298", Offset = "0xAB1298", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600176D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB12A0", Offset = "0xAB12A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x14000012")]
		public event EventHandler<EventArgs> DeviceLost
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600176E")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB12A8", Offset = "0xAB12A8", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClientInitialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
			[global::Cpp2ILInjected.Token(Token = "0x600176F")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB135C", Offset = "0xAB135C", Length = "0xB4")]
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

		[global::Cpp2ILInjected.Token(Token = "0x14000013")]
		public event EventHandler<EventArgs> DeviceReset
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001770")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1410", Offset = "0xAB1410", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClientInitialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6001771")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB14C4", Offset = "0xAB14C4", Length = "0xB4")]
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

		[global::Cpp2ILInjected.Token(Token = "0x14000014")]
		public event EventHandler<EventArgs> DeviceResetting
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001772")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1578", Offset = "0xAB1578", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClientInitialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6001773")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB162C", Offset = "0xAB162C", Length = "0xB4")]
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

		[global::Cpp2ILInjected.Token(Token = "0x14000015")]
		public event EventHandler<ResourceCreatedEventArgs> ResourceCreated
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001774")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB16E0", Offset = "0xAB16E0", Length = "0xB4")]
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
			[global::Cpp2ILInjected.Token(Token = "0x6001775")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1794", Offset = "0xAB1794", Length = "0xB4")]
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

		[global::Cpp2ILInjected.Token(Token = "0x14000016")]
		public event EventHandler<ResourceDestroyedEventArgs> ResourceDestroyed
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001776")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1848", Offset = "0xAB1848", Length = "0xB4")]
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
			[global::Cpp2ILInjected.Token(Token = "0x6001777")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB18FC", Offset = "0xAB18FC", Length = "0xB4")]
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

		[global::Cpp2ILInjected.Token(Token = "0x14000017")]
		public event EventHandler<EventArgs> Disposing
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001778")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB19B0", Offset = "0xAB19B0", Length = "0xB4")]
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
			[global::Cpp2ILInjected.Token(Token = "0x6001779")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1A64", Offset = "0xAB1A64", Length = "0xB4")]
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

		[global::Cpp2ILInjected.Token(Token = "0x14000018")]
		internal event EventHandler<PresentationEventArgs> PresentationChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600177A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1B18", Offset = "0xAB1B18", Length = "0xB4")]
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
			[global::Cpp2ILInjected.Token(Token = "0x600177B")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1BCC", Offset = "0xAB1BCC", Length = "0xB4")]
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

		[global::Cpp2ILInjected.Token(Token = "0x170002E2")]
		internal bool IsRenderTargetBound
		{
			[global::Cpp2ILInjected.Token(Token = "0x600177C")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1C80", Offset = "0xAB1C80", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E3")]
		internal DepthFormat ActiveDepthFormat
		{
			[global::Cpp2ILInjected.Token(Token = "0x600177D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1C90", Offset = "0xAB1C90", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E4")]
		public GraphicsAdapter Adapter
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600177E")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1CB8", Offset = "0xAB1CB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600177F")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB1CC0", Offset = "0xAB1CC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001780")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB1CC8", Offset = "0xAB1CC8", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsAdapter), Member = "get_DefaultAdapter", ReturnType = typeof(GraphicsAdapter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PresentationParameters), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "Setup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal GraphicsDevice()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001781")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB239C", Offset = "0xAB239C", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoSuitableGraphicsDeviceException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public GraphicsDevice(GraphicsAdapter adapter, GraphicsProfile graphicsProfile, PresentationParameters presentationParameters)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001782")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB1F28", Offset = "0xAB1F28", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Capacity", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Viewport), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "Clone", ReturnType = typeof(BlendState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "set_BlendState", MemberParameters = new object[] { typeof(BlendState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DepthStencilState), Member = "Clone", ReturnType = typeof(DepthStencilState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "set_DepthStencilState", MemberParameters = new object[] { typeof(DepthStencilState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RasterizerState), Member = "Clone", ReturnType = typeof(RasterizerState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "set_RasterizerState", MemberParameters = new object[] { typeof(RasterizerState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void Setup()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001783")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2A44", Offset = "0xAB2A44", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001784")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2A4C", Offset = "0xAB2A4C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal int GetClampedMultisampleCount(int multiSampleCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001785")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2280", Offset = "0xAB2280", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "set_BlendState", MemberParameters = new object[] { typeof(BlendState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "set_DepthStencilState", MemberParameters = new object[] { typeof(DepthStencilState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "set_RasterizerState", MemberParameters = new object[] { typeof(RasterizerState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Viewport), Member = "get_Bounds", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "set_ScissorRectangle", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void Initialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E5")]
		public RasterizerState RasterizerState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001786")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2B0C", Offset = "0xAB2B0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001787")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB28B4", Offset = "0xAB28B4", Length = "0x190")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "Setup", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIElement), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RasterizerState), Member = "BindToGraphicsDevice", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E6")]
		public Color BlendFactor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001788")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2B14", Offset = "0xAB2B14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001789")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2B1C", Offset = "0xAB2B1C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "set_BlendState", MemberParameters = new object[] { typeof(BlendState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(Color)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E7")]
		public BlendState BlendState
		{
			[global::Cpp2ILInjected.Token(Token = "0x600178A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2B9C", Offset = "0xAB2B9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600178B")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB25EC", Offset = "0xAB25EC", Length = "0x180")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "Setup", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlendState), Member = "BindToGraphicsDevice", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "set_BlendFactor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E8")]
		public DepthStencilState DepthStencilState
		{
			[global::Cpp2ILInjected.Token(Token = "0x600178C")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2BA4", Offset = "0xAB2BA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600178D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB276C", Offset = "0xAB276C", Length = "0x148")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "Setup", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderBlack", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderWalls", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DepthStencilState), Member = "BindToGraphicsDevice", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600178E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2BAC", Offset = "0xAB2BAC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void ApplyState(bool applyShaders)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600178F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2BB0", Offset = "0xAB2BB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSplash", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderTiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderTiles2", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderWater", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderBlack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderWalls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterManager), Member = "BeginCapture", MemberParameters = new object[]
		{
			typeof(RenderTarget2D),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterManager), Member = "EndCapture", MemberParameters = new object[]
		{
			typeof(RenderTarget2D),
			typeof(RenderTarget2D),
			typeof(RenderTarget2D),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		public void Clear(Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001790")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2BB4", Offset = "0xAB2BB4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear(ClearOptions options, Color color, float depth, int stencil)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001791")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2BB8", Offset = "0xAB2BB8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear(ClearOptions options, Vector4 color, float depth, int stencil)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001792")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2BBC", Offset = "0xAB2BBC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Present()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001793")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2C18", Offset = "0xAB2C18", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001794")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2C1C", Offset = "0xAB2C1C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Reset(PresentationParameters presentationParameters)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E9")]
		public DisplayMode DisplayMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001795")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB25E0", Offset = "0xAB25E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002EA")]
		public GraphicsDeviceStatus GraphicsDeviceStatus
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001796")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2C78", Offset = "0xAB2C78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002EB")]
		public PresentationParameters PresentationParameters
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001797")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2C80", Offset = "0xAB2C80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001798")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2C88", Offset = "0xAB2C88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002EC")]
		public Viewport Viewport
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001799")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2C90", Offset = "0xAB2C90", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetDisplayMode", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "Rebuild", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "ShouldRebuild", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600179A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2CB8", Offset = "0xAB2CB8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002ED")]
		public GraphicsProfile GraphicsProfile
		{
			[global::Cpp2ILInjected.Token(Token = "0x600179B")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2CCC", Offset = "0xAB2CCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002EE")]
		public Rectangle ScissorRectangle
		{
			[global::Cpp2ILInjected.Token(Token = "0x600179C")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2CD4", Offset = "0xAB2CD4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600179D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2A80", Offset = "0xAB2A80", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIElement), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(Rectangle)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002EF")]
		public int RenderTargetCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600179E")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2CE0", Offset = "0xAB2CE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600179F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2CE8", Offset = "0xAB2CE8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderTiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderTiles2", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderWater", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderBlack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RenderWalls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterManager), Member = "BeginCapture", MemberParameters = new object[]
		{
			typeof(RenderTarget2D),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterManager), Member = "EndCapture", MemberParameters = new object[]
		{
			typeof(RenderTarget2D),
			typeof(RenderTarget2D),
			typeof(RenderTarget2D),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		public void SetRenderTarget(RenderTarget2D renderTarget)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017A0")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2CEC", Offset = "0xAB2CEC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RenderTargetBinding[] GetRenderTargets()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017A1")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2D58", Offset = "0xAB2D58", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void GetRenderTargets(RenderTargetBinding[] outTargets)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F0")]
		public bool ResourcesLost
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017A2")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2D6C", Offset = "0xAB2D6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017A3")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB2D74", Offset = "0xAB2D74", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x158B208", Offset = "0x158B208", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private T[] Clone<T>(T[] srcArray, int Count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017A5")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2D80", Offset = "0xAB2D80", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "DrawGeometry", MemberParameters = new object[]
		{
			typeof(SpriteBatcher.VertexData[]),
			typeof(short[]),
			typeof(int),
			typeof(int),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "DrawGeometry", MemberParameters = new object[]
		{
			typeof(List<Vector3>),
			typeof(List<Vector2>),
			typeof(List<Vector4>),
			typeof(List<Color32>),
			typeof(List<int>),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "AddSubMesh", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(Texture2D),
			typeof(EffectPass)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "GetMaterial", MemberParameters = new object[]
		{
			typeof(EffectPass),
			typeof(Texture2D),
			typeof(Texture2D),
			typeof(Texture2D),
			typeof(Texture2D)
		}, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPass), Member = "ApplyValuesToMaterial", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = "get_UnityBindTexture", ReturnType = typeof(Texture))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Texture)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "set_renderQueue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Material GetMaterial(int offset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017A6")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2EBC", Offset = "0xAB2EBC", Length = "0xF4")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "GetInstance", MemberParameters = new object[]
		{
			typeof(SpriteBatcher.VertexData[]),
			typeof(short[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "GetMaterial", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Renderer), Member = "set_material", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "SetPosition", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DrawGeometry(SpriteBatcher.VertexData[] vertices, short[] indices, int vertexCount, int indexCount, Vector3 position, Vector3 scale)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017A7")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2FB0", Offset = "0xAB2FB0", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
		{
			typeof(SpriteBatcher.VertexData[]),
			typeof(short[]),
			typeof(int),
			typeof(int),
			typeof(Vector3),
			typeof(Vector3),
			typeof(List<Material>),
			typeof(List<SubMeshDescriptor>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private Material[] GetMaterialArray(List<Material> subMeshMaterials)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017A8")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB30D4", Offset = "0xAB30D4", Length = "0x370")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "RenderVertexArrayWithSubMeshes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "GetBatchInstance", ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "IncrementBufferOffset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "set_renderQueue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "GetMaterialArray", MemberParameters = new object[] { typeof(List<Material>) }, ReturnType = typeof(Material[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Renderer), Member = "set_materials", MemberParameters = new object[] { typeof(Material[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "Clear", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "set_subMeshCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetVertexBufferParams", MemberParameters = new object[]
		{
			typeof(int),
			typeof(VertexAttributeDescriptor[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetVertexBufferData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetIndexBufferParams", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IndexFormat)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetIndexBufferData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<SubMeshDescriptor>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetSubMesh", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SubMeshDescriptor),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "set_bounds", MemberParameters = new object[] { typeof(Bounds) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "UploadMeshData", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "SetPosition", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void DrawGeometryWithSubMeshes(SpriteBatcher.VertexData[] vertices, short[] indices, int vertexCount, int indexCount, Vector3 position, Vector3 scale, List<Material> subMeshMaterials, List<SubMeshDescriptor> subMeshPartitions)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017A9")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB3444", Offset = "0xAB3444", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "RenderVertexArray", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(Texture2D),
			typeof(EffectPass),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "GetInstance", MemberParameters = new object[]
		{
			typeof(List<Vector3>),
			typeof(List<Vector2>),
			typeof(List<Vector4>),
			typeof(List<Color32>),
			typeof(List<int>)
		}, ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "GetMaterial", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Renderer), Member = "set_material", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "SetPosition", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DrawGeometry(List<Vector3> positions, List<Vector2> uvs, List<Vector4> uv2s, List<Color32> colours, List<int> indices, Vector3 position, Vector3 scale)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017AA")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB3548", Offset = "0xAB3548", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "GetTitleSafeArea", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal static Rectangle GetDefaultTitleSafeArea(int x, int y, int width, int height)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017AB")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB35BC", Offset = "0xAB35BC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DisplayMode), Member = "get_TitleSafeArea", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Viewport), Member = "get_TitleSafeArea", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "GetDefaultTitleSafeArea", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static Rectangle GetTitleSafeArea(int x, int y, int width, int height)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60017AC")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB3638", Offset = "0xAB3638", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static GraphicsDevice()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40025E3")]
		public static GraphicsDevice Instance;

		[global::Cpp2ILInjected.Token(Token = "0x40025E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Viewport _viewport;

		[global::Cpp2ILInjected.Token(Token = "0x40025E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Color _blendFactor;

		[global::Cpp2ILInjected.Token(Token = "0x40025E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool _blendFactorDirty;

		[global::Cpp2ILInjected.Token(Token = "0x40025E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private BlendState _blendState;

		[global::Cpp2ILInjected.Token(Token = "0x40025E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private BlendState _actualBlendState;

		[global::Cpp2ILInjected.Token(Token = "0x40025E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _blendStateDirty;

		[global::Cpp2ILInjected.Token(Token = "0x40025EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private BlendState _blendStateAdditive;

		[global::Cpp2ILInjected.Token(Token = "0x40025EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private BlendState _blendStateAlphaBlend;

		[global::Cpp2ILInjected.Token(Token = "0x40025EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private BlendState _blendStateNonPremultiplied;

		[global::Cpp2ILInjected.Token(Token = "0x40025ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private BlendState _blendStateOpaque;

		[global::Cpp2ILInjected.Token(Token = "0x40025EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private DepthStencilState _depthStencilState;

		[global::Cpp2ILInjected.Token(Token = "0x40025EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private DepthStencilState _actualDepthStencilState;

		[global::Cpp2ILInjected.Token(Token = "0x40025F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private bool _depthStencilStateDirty;

		[global::Cpp2ILInjected.Token(Token = "0x40025F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private DepthStencilState _depthStencilStateDefault;

		[global::Cpp2ILInjected.Token(Token = "0x40025F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private DepthStencilState _depthStencilStateDepthRead;

		[global::Cpp2ILInjected.Token(Token = "0x40025F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private DepthStencilState _depthStencilStateNone;

		[global::Cpp2ILInjected.Token(Token = "0x40025F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private RasterizerState _rasterizerState;

		[global::Cpp2ILInjected.Token(Token = "0x40025F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private RasterizerState _actualRasterizerState;

		[global::Cpp2ILInjected.Token(Token = "0x40025F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private bool _rasterizerStateDirty;

		[global::Cpp2ILInjected.Token(Token = "0x40025F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private RasterizerState _rasterizerStateCullClockwise;

		[global::Cpp2ILInjected.Token(Token = "0x40025F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private RasterizerState _rasterizerStateCullCounterClockwise;

		[global::Cpp2ILInjected.Token(Token = "0x40025F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private RasterizerState _rasterizerStateCullNone;

		[global::Cpp2ILInjected.Token(Token = "0x40025FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private Rectangle _scissorRectangle;

		[global::Cpp2ILInjected.Token(Token = "0x40025FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private bool _scissorRectangleDirty;

		[global::Cpp2ILInjected.Token(Token = "0x40025FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private readonly RenderTargetBinding[] _currentRenderTargetBindings;

		[global::Cpp2ILInjected.Token(Token = "0x40025FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private int _currentRenderTargetCount;

		[global::Cpp2ILInjected.Token(Token = "0x40025FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private readonly RenderTargetBinding[] _tempRenderTargetBinding;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40025FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private GraphicsCapabilities <GraphicsCapabilities>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4002600")]
		private static readonly Color DiscardColor;

		[global::Cpp2ILInjected.Token(Token = "0x4002601")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		internal Dictionary<int, Effect> EffectCache;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002602")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private EventHandler<EventArgs> DeviceLost;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002603")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private EventHandler<EventArgs> DeviceReset;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002604")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private EventHandler<EventArgs> DeviceResetting;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002605")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private EventHandler<ResourceCreatedEventArgs> ResourceCreated;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002606")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		private EventHandler<ResourceDestroyedEventArgs> ResourceDestroyed;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002607")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private EventHandler<EventArgs> Disposing;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002608")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private EventHandler<PresentationEventArgs> PresentationChanged;

		[global::Cpp2ILInjected.Token(Token = "0x4002609")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		private int _maxVertexBufferSlots;

		[global::Cpp2ILInjected.Token(Token = "0x400260A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x144")]
		internal int MaxTextureSlots;

		[global::Cpp2ILInjected.Token(Token = "0x400260B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		internal int MaxVertexTextureSlots;

		[global::Cpp2ILInjected.Token(Token = "0x400260C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public Texture2D[] Textures;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400260D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private GraphicsAdapter <Adapter>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400260E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private PresentationParameters <PresentationParameters>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x400260F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private readonly GraphicsProfile _graphicsProfile;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002610")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x16C")]
		private bool <ResourcesLost>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4002611")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x16D")]
		public bool CachedImmediateDrawMaterialActive;

		[global::Cpp2ILInjected.Token(Token = "0x4002612")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private EffectPass _cachedImmediateDrawEffect;

		[global::Cpp2ILInjected.Token(Token = "0x4002613")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private int _cachedImmediateDrawEffectState;

		[global::Cpp2ILInjected.Token(Token = "0x4002614")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private Material _cachedImmediateDrawMaterial;

		[global::Cpp2ILInjected.Token(Token = "0x4002615")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		private Texture2D _cachedImmediateTexture0;

		[global::Cpp2ILInjected.Token(Token = "0x4002616")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		private Texture2D _cachedImmediateTexture1;

		[global::Cpp2ILInjected.Token(Token = "0x4002617")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		private List<Material[]> MaterialArrays;
	}
}
