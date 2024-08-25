using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x200001E")]
	public class InputControl : OneAxisInputControl
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700004D")]
		public string Handle
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000130")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986174", Offset = "0x1986174", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000131")]
			[global::Cpp2ILInjected.Address(RVA = "0x198617C", Offset = "0x198617C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700004E")]
		public InputControlType Target
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000132")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986184", Offset = "0x1986184", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000133")]
			[global::Cpp2ILInjected.Address(RVA = "0x198618C", Offset = "0x198618C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700004F")]
		public bool IsButton
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000134")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986194", Offset = "0x1986194", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000135")]
			[global::Cpp2ILInjected.Address(RVA = "0x198619C", Offset = "0x198619C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000050")]
		public bool IsAnalog
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000136")]
			[global::Cpp2ILInjected.Address(RVA = "0x19861A8", Offset = "0x19861A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000137")]
			[global::Cpp2ILInjected.Address(RVA = "0x19861B0", Offset = "0x19861B0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000138")]
		[global::Cpp2ILInjected.Address(RVA = "0x19861BC", Offset = "0x19861BC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputControl), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private InputControl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000139")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986238", Offset = "0x1986238", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputControl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(InputControlType),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDevice), Member = "AddControl", MemberParameters = new object[]
		{
			typeof(InputControlType),
			typeof(string)
		}, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "TargetIsButton", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public InputControl(string handle, InputControlType target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600013A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19862F0", Offset = "0x19862F0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(InputControlType)
		}, ReturnType = typeof(void))]
		public InputControl(string handle, InputControlType target, bool passive)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600013B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986314", Offset = "0x1986314", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "SetZeroTickOnAllControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void SetZeroTick()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000051")]
		internal bool IsOnZeroTick
		{
			[global::Cpp2ILInjected.Token(Token = "0x600013C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986320", Offset = "0x1986320", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "Update", MemberParameters = new object[]
			{
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = "Update", MemberParameters = new object[]
			{
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000052")]
		public bool IsStandard
		{
			[global::Cpp2ILInjected.Token(Token = "0x600013D")]
			[global::Cpp2ILInjected.Address(RVA = "0x197A62C", Offset = "0x197A62C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceBindingSourceListener), Member = "ListenForControl", MemberParameters = new object[]
			{
				typeof(BindingListenOptions),
				typeof(InputDevice)
			}, ReturnType = typeof(InputControlType))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "TargetIsStandard", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600013E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986334", Offset = "0x1986334", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControl), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static InputControl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000127")]
		public static readonly InputControl Null;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000128")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private string <Handle>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000129")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private InputControlType <Target>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x400012A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		public bool Passive;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400012B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7D")]
		private bool <IsButton>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400012C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7E")]
		private bool <IsAnalog>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x400012D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private ulong zeroTick;
	}
}
