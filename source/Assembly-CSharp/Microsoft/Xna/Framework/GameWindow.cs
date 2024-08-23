using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.OS.Linux;
using ReLogic.OS.OSX;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000275 RID: 629
	[global::Cpp2ILInjected.Token(Token = "0x2000336")]
	public abstract class GameWindow
	{
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x0002549F File Offset: 0x0002369F
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x000254A2 File Offset: 0x000236A2
		[global::Cpp2ILInjected.Token(Token = "0x17000209")]
		public string Title
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A3")]
			[global::Cpp2ILInjected.Address(RVA = "0xA960BC", Offset = "0xA960BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60014A4")]
			[global::Cpp2ILInjected.Address(RVA = "0xA960C4", Offset = "0xA960C4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReLogic.OS.OSX.WindowService), Member = "SetUnicodeTitle", MemberParameters = new object[]
			{
				typeof(GameWindow),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReLogic.OS.Linux.WindowService), Member = "SetUnicodeTitle", MemberParameters = new object[]
			{
				typeof(GameWindow),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06001348 RID: 4936
		// (set) Token: 0x06001349 RID: 4937
		[global::Cpp2ILInjected.Token(Token = "0x1700020A")]
		public abstract bool AllowUserResizing
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A5")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x60014A6")]
			set;
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600134A RID: 4938
		[global::Cpp2ILInjected.Token(Token = "0x1700020B")]
		public abstract Rectangle ClientBounds
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A7")]
			get;
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600134B RID: 4939
		[global::Cpp2ILInjected.Token(Token = "0x1700020C")]
		public abstract IntPtr Handle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A8")]
			get;
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600134C RID: 4940
		[global::Cpp2ILInjected.Token(Token = "0x1700020D")]
		public abstract string ScreenDeviceName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A9")]
			get;
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600134D RID: 4941 RVA: 0x000254A5 File Offset: 0x000236A5
		// (remove) Token: 0x0600134E RID: 4942 RVA: 0x000254A8 File Offset: 0x000236A8
		[global::Cpp2ILInjected.Token(Token = "0x14000008")]
		public event EventHandler ClientSizeChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014AA")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96110", Offset = "0xA96110", Length = "0x9C")]
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
			[global::Cpp2ILInjected.Token(Token = "0x60014AB")]
			[global::Cpp2ILInjected.Address(RVA = "0xA961AC", Offset = "0xA961AC", Length = "0x9C")]
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

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600134F RID: 4943 RVA: 0x000254AB File Offset: 0x000236AB
		// (remove) Token: 0x06001350 RID: 4944 RVA: 0x000254AE File Offset: 0x000236AE
		[global::Cpp2ILInjected.Token(Token = "0x14000009")]
		public event EventHandler ScreenDeviceNameChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014AC")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96248", Offset = "0xA96248", Length = "0x9C")]
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
			[global::Cpp2ILInjected.Token(Token = "0x60014AD")]
			[global::Cpp2ILInjected.Address(RVA = "0xA962E4", Offset = "0xA962E4", Length = "0x9C")]
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

		// Token: 0x06001351 RID: 4945
		[global::Cpp2ILInjected.Token(Token = "0x60014AE")]
		public abstract void BeginScreenDeviceChange(bool willBeFullScreen);

		// Token: 0x06001352 RID: 4946 RVA: 0x000254B1 File Offset: 0x000236B1
		[global::Cpp2ILInjected.Token(Token = "0x60014AF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96380", Offset = "0xA96380", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void EndScreenDeviceChange(string screenDeviceName)
		{
			throw null;
		}

		// Token: 0x06001353 RID: 4947
		[global::Cpp2ILInjected.Token(Token = "0x60014B0")]
		public abstract void EndScreenDeviceChange(string screenDeviceName, int clientWidth, int clientHeight);

		// Token: 0x06001354 RID: 4948 RVA: 0x000254B4 File Offset: 0x000236B4
		[global::Cpp2ILInjected.Token(Token = "0x60014B1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA963B8", Offset = "0xA963B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void OnActivated()
		{
			throw null;
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x000254B7 File Offset: 0x000236B7
		[global::Cpp2ILInjected.Token(Token = "0x60014B2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA963BC", Offset = "0xA963BC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected void OnClientSizeChanged()
		{
			throw null;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x000254BA File Offset: 0x000236BA
		[global::Cpp2ILInjected.Token(Token = "0x60014B3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9643C", Offset = "0xA9643C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void OnDeactivated()
		{
			throw null;
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x000254BD File Offset: 0x000236BD
		[global::Cpp2ILInjected.Token(Token = "0x60014B4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96440", Offset = "0xA96440", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected void OnPaint()
		{
			throw null;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x000254C0 File Offset: 0x000236C0
		[global::Cpp2ILInjected.Token(Token = "0x60014B5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96478", Offset = "0xA96478", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected void OnScreenDeviceNameChanged()
		{
			throw null;
		}

		// Token: 0x06001359 RID: 4953
		[global::Cpp2ILInjected.Token(Token = "0x60014B6")]
		protected abstract void SetTitle(string title);

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x000254C3 File Offset: 0x000236C3
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x000254C6 File Offset: 0x000236C6
		[global::Cpp2ILInjected.Token(Token = "0x1700020E")]
		public DisplayOrientation CurrentOrientation
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014B7")]
			[global::Cpp2ILInjected.Address(RVA = "0xA964F8", Offset = "0xA964F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014B8")]
			[global::Cpp2ILInjected.Address(RVA = "0xA96500", Offset = "0xA96500", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x000254C9 File Offset: 0x000236C9
		[global::Cpp2ILInjected.Token(Token = "0x60014B9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96508", Offset = "0xA96508", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected GameWindow()
		{
			throw null;
		}

		// Token: 0x04001CD9 RID: 7385
		[global::Cpp2ILInjected.Token(Token = "0x40022B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string title;

		// Token: 0x04001CDA RID: 7386
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40022B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private EventHandler ClientSizeChanged;

		// Token: 0x04001CDB RID: 7387
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40022B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private EventHandler ScreenDeviceNameChanged;

		// Token: 0x04001CDC RID: 7388
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40022B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private DisplayOrientation <CurrentOrientation>k__BackingField;
	}
}
