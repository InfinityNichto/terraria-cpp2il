using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Initializers;
using Terraria.Social;
using UnityEngine;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000272 RID: 626
	[global::Cpp2ILInjected.Token(Token = "0x2000333")]
	public class Game : IDisposable
	{
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x00025418 File Offset: 0x00023618
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x0002541B File Offset: 0x0002361B
		[global::Cpp2ILInjected.Token(Token = "0x170001FE")]
		public ContentManager Content
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001476")]
			[global::Cpp2ILInjected.Address(RVA = "0xA94B9C", Offset = "0xA94B9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001477")]
			[global::Cpp2ILInjected.Address(RVA = "0xA94BA4", Offset = "0xA94BA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x0002541E File Offset: 0x0002361E
		[global::Cpp2ILInjected.Token(Token = "0x170001FF")]
		public GraphicsDevice GraphicsDevice
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001478")]
			[global::Cpp2ILInjected.Address(RVA = "0xA94BAC", Offset = "0xA94BAC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 52)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x00025421 File Offset: 0x00023621
		// (set) Token: 0x0600131D RID: 4893 RVA: 0x00025424 File Offset: 0x00023624
		[global::Cpp2ILInjected.Token(Token = "0x17000200")]
		public bool IsActive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001479")]
			[global::Cpp2ILInjected.Address(RVA = "0xA94C10", Offset = "0xA94C10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600147A")]
			[global::Cpp2ILInjected.Address(RVA = "0xA94C18", Offset = "0xA94C18", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00025427 File Offset: 0x00023627
		[global::Cpp2ILInjected.Token(Token = "0x600147B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94C24", Offset = "0xA94C24", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameServiceContainer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IServiceProvider),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameComponentCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public Game()
		{
			throw null;
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0002542A File Offset: 0x0002362A
		[global::Cpp2ILInjected.Token(Token = "0x600147C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94DDC", Offset = "0xA94DDC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		protected virtual void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x0002542D File Offset: 0x0002362D
		[global::Cpp2ILInjected.Token(Token = "0x17000201")]
		public GameComponentCollection Components
		{
			[global::Cpp2ILInjected.Token(Token = "0x600147D")]
			[global::Cpp2ILInjected.Address(RVA = "0xA94DE0", Offset = "0xA94DE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00025430 File Offset: 0x00023630
		[global::Cpp2ILInjected.Token(Token = "0x600147E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94DE8", Offset = "0xA94DE8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "Awake", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "UpdateTrialMode", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void UnityAwake()
		{
			throw null;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00025433 File Offset: 0x00023633
		[global::Cpp2ILInjected.Token(Token = "0x600147F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94E38", Offset = "0xA94E38", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = "UnityStart", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "LoadTextureDBs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void initialiseCallBack(object threadContext)
		{
			throw null;
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00025436 File Offset: 0x00023636
		[global::Cpp2ILInjected.Token(Token = "0x6001480")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94FC4", Offset = "0xA94FC4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "UpdateTrialMode", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocialAPI), Member = "Initialize", MemberParameters = new object[] { typeof(SocialMode?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "add_OnEnginePreload", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "initialiseCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void UnityStart()
		{
			throw null;
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00025439 File Offset: 0x00023639
		[global::Cpp2ILInjected.Token(Token = "0x6001481")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9507C", Offset = "0xA9507C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DedServ", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void UnityServerInitialise()
		{
			throw null;
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0002543C File Offset: 0x0002363C
		[global::Cpp2ILInjected.Token(Token = "0x6001482")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95114", Offset = "0xA95114", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "EnsureLocalPlayerIsPresent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ServerLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void UnityServerShutdown()
		{
			throw null;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0002543F File Offset: 0x0002363F
		[global::Cpp2ILInjected.Token(Token = "0x6001483")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9511C", Offset = "0xA9511C", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(TimeSpan)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "ExecuteThreadTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "ServerLoopUpdateFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "ServerUpdateFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(TimeSpan)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public void UnityServerUpdate(float elapsedTime)
		{
			throw null;
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00025442 File Offset: 0x00023642
		[global::Cpp2ILInjected.Token(Token = "0x6001484")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9544C", Offset = "0xA9544C", Length = "0x610")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = "UnityUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "UpdateTrialMode", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "PendingAssetUnload", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ProcessAsyncLoad", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "ActionPendingUnloadAssets", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "UnityUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(TimeSpan)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "UpdateClientNet", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "ServerLoopUpdateFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "ServerUpdateFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(TimeSpan)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public void UnityUpdate(float elapsedTime)
		{
			throw null;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00025445 File Offset: 0x00023645
		[global::Cpp2ILInjected.Token(Token = "0x6001485")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95A5C", Offset = "0xA95A5C", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "ClearInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "ClearInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "BeginUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "FlushBatches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "FinaliseInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "EndUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public void UnityDraw()
		{
			throw null;
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00025448 File Offset: 0x00023648
		[global::Cpp2ILInjected.Token(Token = "0x6001486")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95C84", Offset = "0xA95C84", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSplash", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		protected virtual void Draw(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0002544B File Offset: 0x0002364B
		[global::Cpp2ILInjected.Token(Token = "0x6001487")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95C88", Offset = "0xA95C88", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void Initialize()
		{
			throw null;
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0002544E File Offset: 0x0002364E
		[global::Cpp2ILInjected.Token(Token = "0x6001488")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95C94", Offset = "0xA95C94", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void LoadContent()
		{
			throw null;
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00025451 File Offset: 0x00023651
		[global::Cpp2ILInjected.Token(Token = "0x6001489")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95C98", Offset = "0xA95C98", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void UnloadContent()
		{
			throw null;
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00025454 File Offset: 0x00023654
		[global::Cpp2ILInjected.Token(Token = "0x600148A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95C9C", Offset = "0xA95C9C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Exit()
		{
			throw null;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00025457 File Offset: 0x00023657
		[global::Cpp2ILInjected.Token(Token = "0x17000202")]
		public GameWindow Window
		{
			[global::Cpp2ILInjected.Token(Token = "0x600148B")]
			[global::Cpp2ILInjected.Address(RVA = "0xA95CA0", Offset = "0xA95CA0", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClientInitialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x0002545A File Offset: 0x0002365A
		[global::Cpp2ILInjected.Token(Token = "0x17000203")]
		public GameServiceContainer Services
		{
			[global::Cpp2ILInjected.Token(Token = "0x600148C")]
			[global::Cpp2ILInjected.Address(RVA = "0xA95CFC", Offset = "0xA95CFC", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadContent", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadSounds", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0002545D File Offset: 0x0002365D
		[global::Cpp2ILInjected.Token(Token = "0x600148D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95D78", Offset = "0xA95D78", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "LaunchGame", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void Run()
		{
			throw null;
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00025460 File Offset: 0x00023660
		[global::Cpp2ILInjected.Token(Token = "0x600148E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95DB0", Offset = "0xA95DB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00025463 File Offset: 0x00023663
		[global::Cpp2ILInjected.Token(Token = "0x600148F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95DB4", Offset = "0xA95DB4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Begin()
		{
			throw null;
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00025466 File Offset: 0x00023666
		[global::Cpp2ILInjected.Token(Token = "0x6001490")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95DB8", Offset = "0xA95DB8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Tick(float deltaTime)
		{
			throw null;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00025469 File Offset: 0x00023669
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001491")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95DBC", Offset = "0xA95DBC", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static Game()
		{
			throw null;
		}

		// Token: 0x04001CB6 RID: 7350
		[global::Cpp2ILInjected.Token(Token = "0x4002290")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private GameComponentCollection _components;

		// Token: 0x04001CB7 RID: 7351
		[global::Cpp2ILInjected.Token(Token = "0x4002291")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ContentManager content;

		// Token: 0x04001CB8 RID: 7352
		[global::Cpp2ILInjected.Token(Token = "0x4002292")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private GraphicsDevice graphicsDevice;

		// Token: 0x04001CB9 RID: 7353
		[global::Cpp2ILInjected.Token(Token = "0x4002293")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private long totalTicks;

		// Token: 0x04001CBA RID: 7354
		[global::Cpp2ILInjected.Token(Token = "0x4002294")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _active;

		// Token: 0x04001CBB RID: 7355
		[global::Cpp2ILInjected.Token(Token = "0x4002295")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		public bool IsMouseVisible;

		// Token: 0x04001CBC RID: 7356
		[global::Cpp2ILInjected.Token(Token = "0x4002296")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
		public bool IsFixedTimeStep;

		// Token: 0x04001CBD RID: 7357
		[global::Cpp2ILInjected.Token(Token = "0x4002297")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private DateTime _lastUpdate;

		// Token: 0x04001CBE RID: 7358
		[global::Cpp2ILInjected.Token(Token = "0x4002298")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private DateTime _firstUpdate;

		// Token: 0x04001CBF RID: 7359
		[global::Cpp2ILInjected.Token(Token = "0x4002299")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private TimeSpan _totalTime;

		// Token: 0x04001CC0 RID: 7360
		[global::Cpp2ILInjected.Token(Token = "0x400229A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool _initialised;

		// Token: 0x04001CC1 RID: 7361
		[global::Cpp2ILInjected.Token(Token = "0x400229B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x51")]
		private bool _uiHidden;

		// Token: 0x04001CC2 RID: 7362
		[global::Cpp2ILInjected.Token(Token = "0x400229C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x52")]
		private bool _serverRunning;

		// Token: 0x04001CC3 RID: 7363
		[global::Cpp2ILInjected.Token(Token = "0x400229D")]
		private static TimeSpan FrameTickTime;

		// Token: 0x04001CC4 RID: 7364
		[global::Cpp2ILInjected.Token(Token = "0x400229E")]
		private static TimeSpan FrameClampTickTime;

		// Token: 0x04001CC5 RID: 7365
		[global::Cpp2ILInjected.Token(Token = "0x400229F")]
		private static TimeSpan FrameIgnoreTime;

		// Token: 0x04001CC6 RID: 7366
		[global::Cpp2ILInjected.Token(Token = "0x40022A0")]
		private static GameTime RunGameTime;

		// Token: 0x04001CC7 RID: 7367
		[global::Cpp2ILInjected.Token(Token = "0x40022A1")]
		private static DateTime lastFrameUpdate;

		// Token: 0x04001CC8 RID: 7368
		[global::Cpp2ILInjected.Token(Token = "0x40022A2")]
		private static DateTime[] lastFrameTime;

		// Token: 0x04001CC9 RID: 7369
		[global::Cpp2ILInjected.Token(Token = "0x40022A3")]
		private static DateTime[] frameTime;

		// Token: 0x04001CCA RID: 7370
		[global::Cpp2ILInjected.Token(Token = "0x40022A4")]
		private static int frameTimeCounter;

		// Token: 0x04001CCB RID: 7371
		[global::Cpp2ILInjected.Token(Token = "0x40022A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x53")]
		private bool updateModeVariable;

		// Token: 0x04001CCC RID: 7372
		[global::Cpp2ILInjected.Token(Token = "0x40022A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private int updateCount;

		// Token: 0x04001CCD RID: 7373
		[global::Cpp2ILInjected.Token(Token = "0x40022A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private DateTime updateTimeStart;

		// Token: 0x04001CCE RID: 7374
		[global::Cpp2ILInjected.Token(Token = "0x40022A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private DateTime lastUpdateTime;

		// Token: 0x04001CCF RID: 7375
		[global::Cpp2ILInjected.Token(Token = "0x40022A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private int fpsCount;

		// Token: 0x04001CD0 RID: 7376
		[global::Cpp2ILInjected.Token(Token = "0x40022AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private int slowFrameCount;

		// Token: 0x04001CD1 RID: 7377
		[global::Cpp2ILInjected.Token(Token = "0x40022AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int oddFrameCount;

		// Token: 0x04001CD2 RID: 7378
		[global::Cpp2ILInjected.Token(Token = "0x40022AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private bool highFrameRate;
	}
}
