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
	// Token: 0x020002AF RID: 687
	[global::Cpp2ILInjected.Token(Token = "0x200037A")]
	public class GraphicsDevice
	{
		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x00025C7C File Offset: 0x00023E7C
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x00025C7F File Offset: 0x00023E7F
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

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060015FE RID: 5630 RVA: 0x00025C82 File Offset: 0x00023E82
		// (remove) Token: 0x060015FF RID: 5631 RVA: 0x00025C85 File Offset: 0x00023E85
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

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06001600 RID: 5632 RVA: 0x00025C88 File Offset: 0x00023E88
		// (remove) Token: 0x06001601 RID: 5633 RVA: 0x00025C8B File Offset: 0x00023E8B
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

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06001602 RID: 5634 RVA: 0x00025C8E File Offset: 0x00023E8E
		// (remove) Token: 0x06001603 RID: 5635 RVA: 0x00025C91 File Offset: 0x00023E91
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

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06001604 RID: 5636 RVA: 0x00025C94 File Offset: 0x00023E94
		// (remove) Token: 0x06001605 RID: 5637 RVA: 0x00025C97 File Offset: 0x00023E97
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

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06001606 RID: 5638 RVA: 0x00025C9A File Offset: 0x00023E9A
		// (remove) Token: 0x06001607 RID: 5639 RVA: 0x00025C9D File Offset: 0x00023E9D
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

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06001608 RID: 5640 RVA: 0x00025CA0 File Offset: 0x00023EA0
		// (remove) Token: 0x06001609 RID: 5641 RVA: 0x00025CA3 File Offset: 0x00023EA3
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

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600160A RID: 5642 RVA: 0x00025CA6 File Offset: 0x00023EA6
		// (remove) Token: 0x0600160B RID: 5643 RVA: 0x00025CA9 File Offset: 0x00023EA9
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

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x00025CAC File Offset: 0x00023EAC
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

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x00025CAF File Offset: 0x00023EAF
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

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x00025CB2 File Offset: 0x00023EB2
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x00025CB5 File Offset: 0x00023EB5
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

		// Token: 0x06001610 RID: 5648 RVA: 0x00025CB8 File Offset: 0x00023EB8
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

		// Token: 0x06001611 RID: 5649 RVA: 0x00025CBB File Offset: 0x00023EBB
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

		// Token: 0x06001612 RID: 5650 RVA: 0x00025CBE File Offset: 0x00023EBE
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

		// Token: 0x06001613 RID: 5651 RVA: 0x00025CC1 File Offset: 0x00023EC1
		[global::Cpp2ILInjected.Token(Token = "0x6001783")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2A44", Offset = "0xAB2A44", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00025CC4 File Offset: 0x00023EC4
		[global::Cpp2ILInjected.Token(Token = "0x6001784")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2A4C", Offset = "0xAB2A4C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal int GetClampedMultisampleCount(int multiSampleCount)
		{
			throw null;
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00025CC7 File Offset: 0x00023EC7
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

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x00025CCA File Offset: 0x00023ECA
		// (set) Token: 0x06001617 RID: 5655 RVA: 0x00025CCD File Offset: 0x00023ECD
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

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x00025CD0 File Offset: 0x00023ED0
		// (set) Token: 0x06001619 RID: 5657 RVA: 0x00025CD3 File Offset: 0x00023ED3
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

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x00025CD6 File Offset: 0x00023ED6
		// (set) Token: 0x0600161B RID: 5659 RVA: 0x00025CD9 File Offset: 0x00023ED9
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

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x00025CDC File Offset: 0x00023EDC
		// (set) Token: 0x0600161D RID: 5661 RVA: 0x00025CDF File Offset: 0x00023EDF
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

		// Token: 0x0600161E RID: 5662 RVA: 0x00025CE2 File Offset: 0x00023EE2
		[global::Cpp2ILInjected.Token(Token = "0x600178E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2BAC", Offset = "0xAB2BAC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void ApplyState(bool applyShaders)
		{
			throw null;
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00025CE5 File Offset: 0x00023EE5
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

		// Token: 0x06001620 RID: 5664 RVA: 0x00025CE8 File Offset: 0x00023EE8
		[global::Cpp2ILInjected.Token(Token = "0x6001790")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2BB4", Offset = "0xAB2BB4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear(ClearOptions options, Color color, float depth, int stencil)
		{
			throw null;
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00025CEB File Offset: 0x00023EEB
		[global::Cpp2ILInjected.Token(Token = "0x6001791")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2BB8", Offset = "0xAB2BB8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear(ClearOptions options, Vector4 color, float depth, int stencil)
		{
			throw null;
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00025CEE File Offset: 0x00023EEE
		[global::Cpp2ILInjected.Token(Token = "0x6001792")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2BBC", Offset = "0xAB2BBC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Present()
		{
			throw null;
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00025CF1 File Offset: 0x00023EF1
		[global::Cpp2ILInjected.Token(Token = "0x6001793")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2C18", Offset = "0xAB2C18", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00025CF4 File Offset: 0x00023EF4
		[global::Cpp2ILInjected.Token(Token = "0x6001794")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB2C1C", Offset = "0xAB2C1C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Reset(PresentationParameters presentationParameters)
		{
			throw null;
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00025CF7 File Offset: 0x00023EF7
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

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00025CFA File Offset: 0x00023EFA
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

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x00025CFD File Offset: 0x00023EFD
		// (set) Token: 0x06001628 RID: 5672 RVA: 0x00025D00 File Offset: 0x00023F00
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

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x00025D03 File Offset: 0x00023F03
		// (set) Token: 0x0600162A RID: 5674 RVA: 0x00025D06 File Offset: 0x00023F06
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

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x00025D09 File Offset: 0x00023F09
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

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x00025D0C File Offset: 0x00023F0C
		// (set) Token: 0x0600162D RID: 5677 RVA: 0x00025D0F File Offset: 0x00023F0F
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

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x00025D12 File Offset: 0x00023F12
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

		// Token: 0x0600162F RID: 5679 RVA: 0x00025D15 File Offset: 0x00023F15
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

		// Token: 0x06001630 RID: 5680 RVA: 0x00025D18 File Offset: 0x00023F18
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

		// Token: 0x06001631 RID: 5681 RVA: 0x00025D1B File Offset: 0x00023F1B
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

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x00025D1E File Offset: 0x00023F1E
		// (set) Token: 0x06001633 RID: 5683 RVA: 0x00025D21 File Offset: 0x00023F21
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

		// Token: 0x06001634 RID: 5684 RVA: 0x00025D24 File Offset: 0x00023F24
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

		// Token: 0x06001635 RID: 5685 RVA: 0x00025D27 File Offset: 0x00023F27
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

		// Token: 0x06001636 RID: 5686 RVA: 0x00025D2A File Offset: 0x00023F2A
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

		// Token: 0x06001637 RID: 5687 RVA: 0x00025D2D File Offset: 0x00023F2D
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

		// Token: 0x06001638 RID: 5688 RVA: 0x00025D30 File Offset: 0x00023F30
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

		// Token: 0x06001639 RID: 5689 RVA: 0x00025D33 File Offset: 0x00023F33
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

		// Token: 0x0600163A RID: 5690 RVA: 0x00025D36 File Offset: 0x00023F36
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

		// Token: 0x0600163B RID: 5691 RVA: 0x00025D39 File Offset: 0x00023F39
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

		// Token: 0x0600163C RID: 5692 RVA: 0x00025D3C File Offset: 0x00023F3C
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

		// Token: 0x04001F9D RID: 8093
		[global::Cpp2ILInjected.Token(Token = "0x40025E3")]
		public static GraphicsDevice Instance;

		// Token: 0x04001F9E RID: 8094
		[global::Cpp2ILInjected.Token(Token = "0x40025E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Viewport _viewport;

		// Token: 0x04001F9F RID: 8095
		[global::Cpp2ILInjected.Token(Token = "0x40025E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Color _blendFactor;

		// Token: 0x04001FA0 RID: 8096
		[global::Cpp2ILInjected.Token(Token = "0x40025E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool _blendFactorDirty;

		// Token: 0x04001FA1 RID: 8097
		[global::Cpp2ILInjected.Token(Token = "0x40025E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private BlendState _blendState;

		// Token: 0x04001FA2 RID: 8098
		[global::Cpp2ILInjected.Token(Token = "0x40025E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private BlendState _actualBlendState;

		// Token: 0x04001FA3 RID: 8099
		[global::Cpp2ILInjected.Token(Token = "0x40025E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _blendStateDirty;

		// Token: 0x04001FA4 RID: 8100
		[global::Cpp2ILInjected.Token(Token = "0x40025EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private BlendState _blendStateAdditive;

		// Token: 0x04001FA5 RID: 8101
		[global::Cpp2ILInjected.Token(Token = "0x40025EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private BlendState _blendStateAlphaBlend;

		// Token: 0x04001FA6 RID: 8102
		[global::Cpp2ILInjected.Token(Token = "0x40025EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private BlendState _blendStateNonPremultiplied;

		// Token: 0x04001FA7 RID: 8103
		[global::Cpp2ILInjected.Token(Token = "0x40025ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private BlendState _blendStateOpaque;

		// Token: 0x04001FA8 RID: 8104
		[global::Cpp2ILInjected.Token(Token = "0x40025EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private DepthStencilState _depthStencilState;

		// Token: 0x04001FA9 RID: 8105
		[global::Cpp2ILInjected.Token(Token = "0x40025EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private DepthStencilState _actualDepthStencilState;

		// Token: 0x04001FAA RID: 8106
		[global::Cpp2ILInjected.Token(Token = "0x40025F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private bool _depthStencilStateDirty;

		// Token: 0x04001FAB RID: 8107
		[global::Cpp2ILInjected.Token(Token = "0x40025F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private DepthStencilState _depthStencilStateDefault;

		// Token: 0x04001FAC RID: 8108
		[global::Cpp2ILInjected.Token(Token = "0x40025F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private DepthStencilState _depthStencilStateDepthRead;

		// Token: 0x04001FAD RID: 8109
		[global::Cpp2ILInjected.Token(Token = "0x40025F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private DepthStencilState _depthStencilStateNone;

		// Token: 0x04001FAE RID: 8110
		[global::Cpp2ILInjected.Token(Token = "0x40025F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private RasterizerState _rasterizerState;

		// Token: 0x04001FAF RID: 8111
		[global::Cpp2ILInjected.Token(Token = "0x40025F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private RasterizerState _actualRasterizerState;

		// Token: 0x04001FB0 RID: 8112
		[global::Cpp2ILInjected.Token(Token = "0x40025F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private bool _rasterizerStateDirty;

		// Token: 0x04001FB1 RID: 8113
		[global::Cpp2ILInjected.Token(Token = "0x40025F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private RasterizerState _rasterizerStateCullClockwise;

		// Token: 0x04001FB2 RID: 8114
		[global::Cpp2ILInjected.Token(Token = "0x40025F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private RasterizerState _rasterizerStateCullCounterClockwise;

		// Token: 0x04001FB3 RID: 8115
		[global::Cpp2ILInjected.Token(Token = "0x40025F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private RasterizerState _rasterizerStateCullNone;

		// Token: 0x04001FB4 RID: 8116
		[global::Cpp2ILInjected.Token(Token = "0x40025FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private Rectangle _scissorRectangle;

		// Token: 0x04001FB5 RID: 8117
		[global::Cpp2ILInjected.Token(Token = "0x40025FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private bool _scissorRectangleDirty;

		// Token: 0x04001FB6 RID: 8118
		[global::Cpp2ILInjected.Token(Token = "0x40025FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private readonly RenderTargetBinding[] _currentRenderTargetBindings;

		// Token: 0x04001FB7 RID: 8119
		[global::Cpp2ILInjected.Token(Token = "0x40025FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private int _currentRenderTargetCount;

		// Token: 0x04001FB8 RID: 8120
		[global::Cpp2ILInjected.Token(Token = "0x40025FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private readonly RenderTargetBinding[] _tempRenderTargetBinding;

		// Token: 0x04001FB9 RID: 8121
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40025FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private GraphicsCapabilities <GraphicsCapabilities>k__BackingField;

		// Token: 0x04001FBA RID: 8122
		[global::Cpp2ILInjected.Token(Token = "0x4002600")]
		private static readonly Color DiscardColor;

		// Token: 0x04001FBB RID: 8123
		[global::Cpp2ILInjected.Token(Token = "0x4002601")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		internal Dictionary<int, Effect> EffectCache;

		// Token: 0x04001FBC RID: 8124
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002602")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private EventHandler<EventArgs> DeviceLost;

		// Token: 0x04001FBD RID: 8125
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002603")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private EventHandler<EventArgs> DeviceReset;

		// Token: 0x04001FBE RID: 8126
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002604")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private EventHandler<EventArgs> DeviceResetting;

		// Token: 0x04001FBF RID: 8127
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002605")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private EventHandler<ResourceCreatedEventArgs> ResourceCreated;

		// Token: 0x04001FC0 RID: 8128
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002606")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		private EventHandler<ResourceDestroyedEventArgs> ResourceDestroyed;

		// Token: 0x04001FC1 RID: 8129
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002607")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private EventHandler<EventArgs> Disposing;

		// Token: 0x04001FC2 RID: 8130
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002608")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private EventHandler<PresentationEventArgs> PresentationChanged;

		// Token: 0x04001FC3 RID: 8131
		[global::Cpp2ILInjected.Token(Token = "0x4002609")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		private int _maxVertexBufferSlots;

		// Token: 0x04001FC4 RID: 8132
		[global::Cpp2ILInjected.Token(Token = "0x400260A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x144")]
		internal int MaxTextureSlots;

		// Token: 0x04001FC5 RID: 8133
		[global::Cpp2ILInjected.Token(Token = "0x400260B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		internal int MaxVertexTextureSlots;

		// Token: 0x04001FC6 RID: 8134
		[global::Cpp2ILInjected.Token(Token = "0x400260C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public Texture2D[] Textures;

		// Token: 0x04001FC7 RID: 8135
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400260D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private GraphicsAdapter <Adapter>k__BackingField;

		// Token: 0x04001FC8 RID: 8136
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400260E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private PresentationParameters <PresentationParameters>k__BackingField;

		// Token: 0x04001FC9 RID: 8137
		[global::Cpp2ILInjected.Token(Token = "0x400260F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private readonly GraphicsProfile _graphicsProfile;

		// Token: 0x04001FCA RID: 8138
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002610")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x16C")]
		private bool <ResourcesLost>k__BackingField;

		// Token: 0x04001FCB RID: 8139
		[global::Cpp2ILInjected.Token(Token = "0x4002611")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x16D")]
		public bool CachedImmediateDrawMaterialActive;

		// Token: 0x04001FCC RID: 8140
		[global::Cpp2ILInjected.Token(Token = "0x4002612")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private EffectPass _cachedImmediateDrawEffect;

		// Token: 0x04001FCD RID: 8141
		[global::Cpp2ILInjected.Token(Token = "0x4002613")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private int _cachedImmediateDrawEffectState;

		// Token: 0x04001FCE RID: 8142
		[global::Cpp2ILInjected.Token(Token = "0x4002614")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private Material _cachedImmediateDrawMaterial;

		// Token: 0x04001FCF RID: 8143
		[global::Cpp2ILInjected.Token(Token = "0x4002615")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		private Texture2D _cachedImmediateTexture0;

		// Token: 0x04001FD0 RID: 8144
		[global::Cpp2ILInjected.Token(Token = "0x4002616")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		private Texture2D _cachedImmediateTexture1;

		// Token: 0x04001FD1 RID: 8145
		[global::Cpp2ILInjected.Token(Token = "0x4002617")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		private List<Material[]> MaterialArrays;
	}
}
