using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.OS.Linux;
using ReLogic.OS.OSX;

namespace Microsoft.Xna.Framework
{
	[global::Cpp2ILInjected.Token(Token = "0x2000336")]
	public abstract class GameWindow
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x1700020A")]
		public abstract bool AllowUserResizing
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A5")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x60014A6")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700020B")]
		public abstract Rectangle ClientBounds
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A7")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700020C")]
		public abstract IntPtr Handle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A8")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700020D")]
		public abstract string ScreenDeviceName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014A9")]
			get;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60014AE")]
		public abstract void BeginScreenDeviceChange(bool willBeFullScreen);

		[global::Cpp2ILInjected.Token(Token = "0x60014AF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96380", Offset = "0xA96380", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void EndScreenDeviceChange(string screenDeviceName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014B0")]
		public abstract void EndScreenDeviceChange(string screenDeviceName, int clientWidth, int clientHeight);

		[global::Cpp2ILInjected.Token(Token = "0x60014B1")]
		[global::Cpp2ILInjected.Address(RVA = "0xA963B8", Offset = "0xA963B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void OnActivated()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014B2")]
		[global::Cpp2ILInjected.Address(RVA = "0xA963BC", Offset = "0xA963BC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected void OnClientSizeChanged()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014B3")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9643C", Offset = "0xA9643C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void OnDeactivated()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014B4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96440", Offset = "0xA96440", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected void OnPaint()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014B5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96478", Offset = "0xA96478", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected void OnScreenDeviceNameChanged()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014B6")]
		protected abstract void SetTitle(string title);

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

		[global::Cpp2ILInjected.Token(Token = "0x60014B9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA96508", Offset = "0xA96508", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected GameWindow()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40022B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string title;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40022B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private EventHandler ClientSizeChanged;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40022B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private EventHandler ScreenDeviceNameChanged;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40022B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private DisplayOrientation <CurrentOrientation>k__BackingField;
	}
}
